use plotters::prelude::*;

fn draw_line_plot(
    (caption, x_axis, y_axis): (&str, (&str, Vec<f32>), (&str, Vec<(&str, Vec<f32>)>)),
    path: String,
) -> Result<(), Box<dyn std::error::Error>> {
    let root = SVGBackend::new(&path, (640, 480)).into_drawing_area();
    let _ = root.fill(&RGBColor(20, 20, 20));

    let (x_desc, x_axis) = x_axis;
    let (y_desc, y_axis) = y_axis;

    let (min_y, max_y) = y_axis
        .iter()
        .map(|(_, y)| y)
        .flatten()
        .fold((std::f32::MAX, std::f32::MIN), |(min, max), y| {
            (min.min(*y), max.max(*y))
        });

    let y_axis: Vec<(&str, Vec<(f32, f32)>)> = y_axis
        .into_iter()
        .map(|(label, y)| {
            (
                label,
                y.into_iter()
                    .enumerate()
                    .map(|(idx, y)| (x_axis[idx], y))
                    .collect(),
            )
        })
        .collect();

    let mut cc = ChartBuilder::on(&root)
        .margin(5)
        .caption(caption, &WHITE)
        .set_all_label_area_size(50)
        .build_cartesian_2d(x_axis[0]..*x_axis.last().unwrap(), min_y..max_y)?;

    cc.configure_mesh()
        .x_labels(20)
        .y_labels(10)
        .max_light_lines(4)
        .x_label_formatter(&|v| format!("{:.1}", v))
        .y_label_formatter(&|v| format!("{:.1}", v))
        .x_desc(x_desc)
        .y_desc(y_desc)
        .label_style(&WHITE)
        .bold_line_style(RGBColor(90, 90, 90))
        .light_line_style(RGBColor(50, 50, 50))
        .axis_style(&WHITE)
        .draw()?;

    let colors = vec![&RED, &BLUE, &YELLOW, &GREEN];

    for (idx, (label, y)) in y_axis.iter().enumerate() {
        let color = colors[idx % colors.len()];
        cc.draw_series(LineSeries::new(y.clone(), color))?
            .label(*label)
            .legend(move |(x, y)| PathElement::new(vec![(x, y), (x + 20, y)], color));
    }

    cc.configure_series_labels()
        .border_style(&WHITE)
        .label_font(&WHITE)
        .draw()?;

    root.present()?;

    Ok(())
}

fn main() -> Result<(), Box<dyn std::error::Error>> {
    let tmp_spiral_path = std::env::temp_dir().join("!dotnet-interactive-spiral");
    let line_plots_data_path = tmp_spiral_path.join("line-plots-data");
    let line_plots_svg_path = tmp_spiral_path.join("line-plots-svg");

    std::fs::create_dir_all(&line_plots_data_path)?;
    std::fs::create_dir_all(&line_plots_svg_path)?;

    let missing_svg = std::fs::read_dir(&line_plots_data_path)?
        .filter_map(|file| {
            let file = file.ok()?;
            let path = file.path();
            let hash_hex = path.file_stem()?.to_str()?;
            let svg_path = line_plots_svg_path.join(format!("{}.svg", hash_hex));
            if !svg_path.exists() {
                Some((std::fs::read_to_string(path).ok()?, svg_path))
            } else {
                None
            }
        })
        .collect::<Vec<_>>();

    for (json, svg_path) in missing_svg {
        println!("Creating {}", svg_path.display());

        let (caption, x_axis, y_axis): (&str, (&str, Vec<f32>), (&str, Vec<(&str, Vec<f32>)>)) =
            serde_json::from_str(&json)?;
        draw_line_plot((caption, x_axis, y_axis), svg_path.display().to_string())?;
    }

    Ok(())
}
