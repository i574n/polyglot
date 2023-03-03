#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Cli {
    use super::*;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Range_::rangeNumeric;
    use fable_library_rust::Seq_::toArray;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Debug, Hash)]
    pub enum UH0 {
        UH0_0(std::string::String, Lrc<Cli::UH0>),
        UH0_1,
    }
    #[derive(Clone, Debug, Hash)]
    pub struct Mut0 {
        pub l0: MutCell<Lrc<Cli::UH0>>,
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum UH1 {
        UH1_0(string, Lrc<Cli::UH1>),
        UH1_1,
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 {
        US0_0,
        US0_1(string),
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub struct Mut1 {
        pub l0: MutCell<i32>,
        pub l1: MutCell<Cli::US0>,
    }
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1(v0_1: clap::parser::ArgMatches) -> clap::parser::ArgMatches {
        v0_1
    }
    pub fn method2() -> string {
        string("rs-path")
    }
    pub fn method3(v0_1: &std::string::String) -> &std::string::String {
        v0_1
    }
    pub fn method4(v0_1: std::string::String) -> std::string::String {
        v0_1
    }
    pub fn closure1(unitVar: (), v0_1: &std::string::String) -> std::string::String {
        let v1: &std::string::String = Cli::method3(v0_1);
        let v3: std::string::String = v1.to_string();
        let v7: std::string::String = (&string("--rs-path=")).to_string();
        let v9: std::string::String = (&string("")).to_string();
        let v10: std::string::String = Cli::method4(v3);
        v10.replace(&v7, &v9)
    }
    pub fn method5(v0_1: string) -> std::string::String {
        (&v0_1).to_string().clone()
    }
    pub fn method6(v0_1: std::path::PathBuf) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method8(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method8: loop {
            break '_method8 (if length(v1.get()) < v0_1.get() {
                let v0_1_temp: i32 = v0_1.get();
                let v1_temp: string = stringFrom(format!("0{0}", &v1.get()));
                v0_1.set(v0_1_temp);
                v1.set(v1_temp);
                continue '_method8;
            } else {
                v1.get()
            });
        }
    }
    pub fn method9(v0_1: u8) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method10(v0_1: Array<std::string::String>) -> std::string::String {
        let v2 = core::ops::Deref::deref(&v0_1);
        let v4 = &***&v2;
        let v5 = &***&v4;
        format!("{:?}", &v5).clone()
    }
    pub fn method11(v0_1: string) -> string {
        v0_1
    }
    pub fn method12() -> string {
        string("$1=$2")
    }
    pub fn method13() -> string {
        string("[$1]")
    }
    pub fn method14() -> string {
        string("\"")
    }
    pub fn method15() -> string {
        string(" ")
    }
    pub fn method16() -> string {
        string("666666")
    }
    pub fn method17() -> string {
        string("385779")
    }
    pub fn method7(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Cli::method5(string("> post_fsx_rs_build ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method16();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method16();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method16();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method19() -> string {
        string("881749")
    }
    pub fn method18(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> read_lines ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method19();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method19();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method19();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method20(v0_1: std::string::String) -> std::string::String {
        (&v0_1).clone()
    }
    pub fn method22(v0_1: i32) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method23(v0_1: i64, v1: Array<std::string::String>) {
        ();
    }
    pub fn closure2(v0_1: i64, v1: Lrc<Cli::Mut0>, v2: Vec<u8>) -> Result<bool, std::io::Error> {
        let v4: std::string::String = Cli::method5(string("line len"));
        let v6 = v2.len();
        Cli::method23(v0_1, array(&[v4, Cli::method22(v6.try_into().unwrap())]));
        {
            let v12: Vec<u8> = v2.to_owned();
            let v14: std::string::String = std::string::String::from_utf8(v12).unwrap();
            let v15: Lrc<Cli::UH0> = v1.l0.get().clone();
            v1.l0
                .set(Lrc::new(Cli::UH0::UH0_0(v14.clone(), v15.clone())));
            Ok(true)
        }
    }
    pub fn method21(v0_1: i64, v1: Lrc<Cli::Mut0>) -> Func1<Vec<u8>, Result<bool, std::io::Error>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1 = v1.clone();
            move |v: Vec<u8>| Cli::closure2(v0_1, v1.clone(), v.clone())
        })
    }
    pub fn method24(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH0>) -> Lrc<Cli::UH0> {
        let v0_1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH0>> = MutCell::new(v1.clone());
        '_method24: loop {
            break '_method24 (match v0_1.get().as_ref() {
                Cli::UH0::UH0_1 => v1.get(),
                Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                    let v0_1_temp: Lrc<Cli::UH0> = v0_1_0_1.clone();
                    let v1_temp: Lrc<Cli::UH0> =
                        Lrc::new(Cli::UH0::UH0_0(v0_1_0_0.clone(), v1.get()));
                    v0_1.set(v0_1_temp);
                    v1.set(v1_temp);
                    continue '_method24;
                }
            });
        }
    }
    pub fn method25(v0_1: Lrc<Cli::UH0>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        match v0_1.as_ref() {
            Cli::UH0::UH0_1 => v1.clone(),
            Cli::UH0::UH0_0(v0_1_0_0, v0_1_0_1) => {
                let v4: Lrc<Cli::UH1> = Cli::method25(v0_1_0_1.clone(), v1);
                Lrc::new(Cli::UH1::UH1_0(
                    fable_library_rust::String_::fromStr(v0_1_0_0),
                    v4,
                ))
            }
        }
    }
    pub fn method26(v0_1: Lrc<Cli::UH1>, v1: i32) -> i32 {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method26: loop {
            break '_method26 (match v0_1.get().as_ref() {
                Cli::UH1::UH1_1 => v1.get(),
                Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                    let v1_temp: i32 = v1.get() + 1i32;
                    v0_1.set(v0_1_temp);
                    v1.set(v1_temp);
                    continue '_method26;
                }
            });
        }
    }
    pub fn method27(
        v0_1: i64,
        v1: Lrc<Cli::UH1>,
        v2: i32,
        v3: Lrc<Cli::UH1>,
    ) -> (i32, Lrc<Cli::UH1>) {
        let v0_1: MutCell<i64> = MutCell::new(v0_1);
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        let v2: MutCell<i32> = MutCell::new(v2);
        let v3: MutCell<Lrc<Cli::UH1>> = MutCell::new(v3.clone());
        '_method27: loop {
            break '_method27 (match v1.get().as_ref() {
                Cli::UH1::UH1_1 => (v2.get(), v3.get()),
                Cli::UH1::UH1_0(v1_0_0, v1_0_1) => {
                    let v4: string = v1_0_0.clone();
                    let patternInput: (i32, Lrc<Cli::UH1>) =
                        if if ((&v4).clone()).contains(&*(&string("/node_modules/")).clone()) {
                            ((&v4).clone()).contains(&*(&string(".cs")).clone())
                        } else {
                            false
                        } {
                            Cli::method7(
                                v0_1.get(),
                                array(&[
                                    Cli::method5(string("found line. removing.")),
                                    Cli::method5(string(" line")),
                                    Cli::method5(v4.clone()),
                                ]),
                            );
                            (1i32, v3.get())
                        } else {
                            if 0i32 == v2.get() {
                                (0i32, Lrc::new(Cli::UH1::UH1_0(v4, v3.get())))
                            } else {
                                if 2i32 == v2.get() {
                                    (0i32, v3.get())
                                } else {
                                    (v2.get() + 1i32, v3.get())
                                }
                            }
                        };
                    {
                        let v0_1_temp: i64 = v0_1.get();
                        let v1_temp: Lrc<Cli::UH1> = v1_0_1.clone();
                        let v2_temp: i32 = patternInput.0.clone();
                        let v3_temp: Lrc<Cli::UH1> = patternInput.1.clone();
                        v0_1.set(v0_1_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        v3.set(v3_temp);
                        continue '_method27;
                    }
                }
            });
        }
    }
    pub fn method28(v0_1: Lrc<Cli::UH1>, v1: Lrc<Cli::UH1>) -> Lrc<Cli::UH1> {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v1.clone());
        '_method28: loop {
            break '_method28 (match v0_1.get().as_ref() {
                Cli::UH1::UH1_1 => v1.get(),
                Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                    let v1_temp: Lrc<Cli::UH1> =
                        Lrc::new(Cli::UH1::UH1_0(v0_1_0_0.clone(), v1.get()));
                    v0_1.set(v0_1_temp);
                    v1.set(v1_temp);
                    continue '_method28;
                }
            });
        }
    }
    pub fn method29(v0_1: Lrc<Cli::UH1>, v1: string) -> string {
        let v0_1: MutCell<Lrc<Cli::UH1>> = MutCell::new(v0_1.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method29: loop {
            break '_method29 (match v0_1.get().as_ref() {
                Cli::UH1::UH1_1 => v1.get(),
                Cli::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v0_1_temp: Lrc<Cli::UH1> = v0_1_0_1.clone();
                    let v1_temp: string = append(v1.get(), v0_1_0_0.clone());
                    v0_1.set(v0_1_temp);
                    v1.set(v1_temp);
                    continue '_method29;
                }
            });
        }
    }
    pub fn method30() -> string {
        string("spi-path")
    }
    pub fn closure3(unitVar: (), v0_1: &std::string::String) -> std::string::String {
        let v1: &std::string::String = Cli::method3(v0_1);
        let v3: std::string::String = v1.to_string();
        let v7: std::string::String = (&string("--spi-path=")).to_string();
        let v9: std::string::String = (&string("")).to_string();
        let v10: std::string::String = Cli::method4(v3);
        v10.replace(&v7, &v9)
    }
    pub fn method31() -> string {
        string("fsx-path")
    }
    pub fn closure4(unitVar: (), v0_1: &std::string::String) -> std::path::PathBuf {
        std::path::PathBuf::from(&v0_1)
    }
    pub fn method33() -> string {
        string("de884c")
    }
    pub fn method32(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> spi_to_fsx ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method33();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method33();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method33();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn closure5(unitVar: (), v0_1: &std::path::Path) -> std::path::PathBuf {
        v0_1.join(string("package.spiproj").as_str())
    }
    pub fn closure6(unitVar: (), v0_1: &std::path::PathBuf) -> bool {
        std::path::Path::exists(&v0_1)
    }
    pub fn method34(v0_1: u16) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method35(v0_1: u16) -> u16 {
        v0_1
    }
    pub fn method37() -> string {
        string("e36a62")
    }
    pub fn method36(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> ping ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method37();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method37();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method37();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method39() -> string {
        string("fcfb1b")
    }
    pub fn method38(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> zmq_request ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method39();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method39();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method39();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method40(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> spi_open ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method37();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method37();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method37();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method41(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> spiproj_open ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method37();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method37();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method37();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method43() -> string {
        string("98d5ef")
    }
    pub fn method42(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> spi_build_file ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method43();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method43();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method43();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method44(v0_1: std::time::SystemTime) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method46() -> string {
        string("387957")
    }
    pub fn method45(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> =
            array(&[Cli::method5(string("> wait_file_change ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method46();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method46();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method46();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn method47(v0_1: i32, v1: Lrc<Cli::Mut1>) -> bool {
        v1.l0.get() < v0_1
    }
    pub fn method49() -> string {
        string("387958")
    }
    pub fn method48(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method8(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Cli::method10(array(&[
            Cli::method5(string("timestamp")),
            Cli::method5(v9),
            Cli::method5(string("run_id")),
            Cli::method9(v11),
            Cli::method5(string("log_level")),
            Cli::method5(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Cli::method5(string("> app ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Cli::method11(v37);
        let v47: &str = v45.as_str();
        let v48: string = Cli::method12();
        let v50: &str = v48.as_str();
        let v52: std::string::String = v44.replace_all(&v47, v50).to_string();
        let v55: string = fable_library_rust::String_::fromStr(&v52);
        let v58: &str = r#"\["(.*?)"\]"#;
        let v59: regex::RegexBuilder = regex::RegexBuilder::new(&v58);
        let v60: &regex::Regex = &v59.build().unwrap();
        let v61: string = Cli::method11(v55);
        let v63: &str = v61.as_str();
        let v64: string = Cli::method13();
        let v66: &str = v64.as_str();
        let v67: std::string::String = v60.replace_all(&v63, v66).to_string();
        let v69: string = fable_library_rust::String_::fromStr(&v67);
        let v72: &str = r#"\\""#;
        let v73: regex::RegexBuilder = regex::RegexBuilder::new(&v72);
        let v74: &regex::Regex = &v73.build().unwrap();
        let v75: string = Cli::method11(v69);
        let v77: &str = v75.as_str();
        let v78: string = Cli::method14();
        let v80: &str = v78.as_str();
        let v81: std::string::String = v74.replace_all(&v77, v80).to_string();
        let v83: string = fable_library_rust::String_::fromStr(&v81);
        let v86: &str = r#", "#;
        let v87: regex::RegexBuilder = regex::RegexBuilder::new(&v86);
        let v88: &regex::Regex = &v87.build().unwrap();
        let v89: string = Cli::method11(v83);
        let v91: &str = v89.as_str();
        let v92: string = Cli::method15();
        let v94: &str = v92.as_str();
        let v95: std::string::String = v88.replace_all(&v91, v94).to_string();
        let v98: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v95));
        let v99 = core::ops::Deref::deref(&v1);
        let v100 = &***&v99;
        let v101 = &***&v100;
        let v103: std::string::String = format!("{:?}", &v101).clone();
        let v105: string = toString(&format!("{}", &v103));
        let v107: &str = r#""([^"]+)", "([^"]+)""#;
        let v108: regex::RegexBuilder = regex::RegexBuilder::new(&v107);
        let v109: &regex::Regex = &v108.build().unwrap();
        let v110: string = Cli::method11(v105);
        let v112: &str = v110.as_str();
        let v113: string = Cli::method12();
        let v115: &str = v113.as_str();
        let v116: std::string::String = v109.replace_all(&v112, v115).to_string();
        let v118: string = fable_library_rust::String_::fromStr(&v116);
        let v120: &str = r#"\["(.*?)"\]"#;
        let v121: regex::RegexBuilder = regex::RegexBuilder::new(&v120);
        let v122: &regex::Regex = &v121.build().unwrap();
        let v123: string = Cli::method11(v118);
        let v125: &str = v123.as_str();
        let v126: string = Cli::method13();
        let v128: &str = v126.as_str();
        let v129: std::string::String = v122.replace_all(&v125, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#"\\""#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Cli::method11(v131);
        let v138: &str = v136.as_str();
        let v139: string = Cli::method14();
        let v141: &str = v139.as_str();
        let v142: std::string::String = v135.replace_all(&v138, v141).to_string();
        let v144: string = fable_library_rust::String_::fromStr(&v142);
        let v146: &str = r#", "#;
        let v147: regex::RegexBuilder = regex::RegexBuilder::new(&v146);
        let v148: &regex::Regex = &v147.build().unwrap();
        let v149: string = Cli::method11(v144);
        let v151: &str = v149.as_str();
        let v152: string = Cli::method15();
        let v154: &str = v152.as_str();
        let v155: std::string::String = v148.replace_all(&v151, v154).to_string();
        let v158: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v155));
        let v160: string = toString(&format!("{}", &v23));
        let v162: &str = r#""([^"]+)", "([^"]+)""#;
        let v163: regex::RegexBuilder = regex::RegexBuilder::new(&v162);
        let v164: &regex::Regex = &v163.build().unwrap();
        let v165: string = Cli::method11(v160);
        let v167: &str = v165.as_str();
        let v168: string = Cli::method12();
        let v170: &str = v168.as_str();
        let v171: std::string::String = v164.replace_all(&v167, v170).to_string();
        let v173: string = fable_library_rust::String_::fromStr(&v171);
        let v175: &str = r#"\["(.*?)"\]"#;
        let v176: regex::RegexBuilder = regex::RegexBuilder::new(&v175);
        let v177: &regex::Regex = &v176.build().unwrap();
        let v178: string = Cli::method11(v173);
        let v180: &str = v178.as_str();
        let v181: string = Cli::method13();
        let v183: &str = v181.as_str();
        let v184: std::string::String = v177.replace_all(&v180, v183).to_string();
        let v186: string = fable_library_rust::String_::fromStr(&v184);
        let v188: &str = r#"\\""#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method11(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method14();
        let v196: &str = v194.as_str();
        let v197: std::string::String = v190.replace_all(&v193, v196).to_string();
        let v199: string = fable_library_rust::String_::fromStr(&v197);
        let v201: &str = r#", "#;
        let v202: regex::RegexBuilder = regex::RegexBuilder::new(&v201);
        let v203: &regex::Regex = &v202.build().unwrap();
        let v204: string = Cli::method11(v199);
        let v206: &str = v204.as_str();
        let v207: string = Cli::method15();
        let v209: &str = v207.as_str();
        let v210: std::string::String = v203.replace_all(&v206, v209).to_string();
        let v213: std::string::String = Cli::method5(fable_library_rust::String_::fromStr(&v210));
        let v214: string = Cli::method49();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method49();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method49();
        let v236: &str = v234.as_str();
        let v239: &str = &v236[4i32 as usize..6i32 as usize];
        let v241: string = fable_library_rust::String_::fromStr(&v239);
        let v242: u8 = u8::from_str_radix(&v241, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v158.to_string(), v224, v233, v242);
        let v245: std::string::String = format!("{}", &v244);
        let v246: string = Cli::method17();
        let v248: &str = v246.as_str();
        let v251: &str = &v248[0i32 as usize..2i32 as usize];
        let v253: string = fable_library_rust::String_::fromStr(&v251);
        let v254: u8 = u8::from_str_radix(&v253, 16).unwrap();
        let v255: string = Cli::method17();
        let v257: &str = v255.as_str();
        let v260: &str = &v257[2i32 as usize..4i32 as usize];
        let v262: string = fable_library_rust::String_::fromStr(&v260);
        let v263: u8 = u8::from_str_radix(&v262, 16).unwrap();
        let v264: string = Cli::method17();
        let v266: &str = v264.as_str();
        let v269: &str = &v266[4i32 as usize..6i32 as usize];
        let v271: string = fable_library_rust::String_::fromStr(&v269);
        let v272: u8 = u8::from_str_radix(&v271, 16).unwrap();
        let v273: colored::ColoredString =
            colored::Colorize::truecolor(&*v213.to_string(), v254, v263, v272);
        let v274: std::string::String = format!("{}", &v273);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v98, &v245, &v274))
        );
        ()
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let patternInput: (string, string, string, bool) = Cli::method0();
        let v5: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v7: i64 = (&v5).timestamp();
        let v10: &str = r#"app1"#;
        let v12: string = string(".version(env!(\"CARGO_PKG_VERSION\"))");
        let v14: string = string(".propagate_version(true)");
        let v16: string = string(".subcommand_required(false)");
        let v18: string = string(".about(\"command about\")");
        let v20: string = string(".arg_required_else_help(true)");
        let v21: string = append(
            append(
                append(
                    append(
                        append(string("clap::Command::new(v10)"), v12.clone()),
                        v14.clone(),
                    ),
                    v16.clone(),
                ),
                v18.clone(),
            ),
            v20.clone(),
        );
        let v22: clap::builder::Command = clap::Command::new(v10)
            .version(env!("CARGO_PKG_VERSION"))
            .propagate_version(true)
            .subcommand_required(false)
            .about("command about")
            .arg_required_else_help(true);
        let v25: &str = r#"PostFsxRsBuild"#;
        let v31: string = append(
            append(
                append(
                    append(
                        append(string("clap::Command::new(v25)"), v12.clone()),
                        v14.clone(),
                    ),
                    v16.clone(),
                ),
                v18.clone(),
            ),
            v20.clone(),
        );
        let v32: clap::builder::Command = clap::Command::new(v25)
            .version(env!("CARGO_PKG_VERSION"))
            .propagate_version(true)
            .subcommand_required(false)
            .about("command about")
            .arg_required_else_help(true);
        let v35: &str = r#"rs-path"#;
        let v37: clap::builder::Arg = clap::Arg::new(v35);
        let v39: clap::builder::Command = v32.arg(v37);
        let v41: clap::builder::Command = v22.subcommand(v39);
        let v44: &str = r#"SpiFsxBuild"#;
        let v50: string = append(
            append(
                append(
                    append(append(string("clap::Command::new(v44)"), v12), v14),
                    v16,
                ),
                v18,
            ),
            v20,
        );
        let v51: clap::builder::Command = clap::Command::new(v44)
            .version(env!("CARGO_PKG_VERSION"))
            .propagate_version(true)
            .subcommand_required(false)
            .about("command about")
            .arg_required_else_help(true);
        let v54: &str = r#"spi-path"#;
        let v56: clap::builder::Arg = clap::Arg::new(v54);
        let v58: clap::builder::Command = v51.arg(v56);
        let v61: &str = r#"fsx-path"#;
        let v63: clap::builder::Arg = clap::Arg::new(v61);
        let v65: clap::builder::Command = v58.arg(v63);
        let v67: clap::builder::Command = v41.subcommand(v65);
        let v70: clap::parser::ArgMatches = Cli::method1(v67.get_matches());
        let v72: std::sync::Arc<clap::parser::ArgMatches> = std::sync::Arc::new(v70);
        let v74: Option<(&str, std::sync::Arc<clap::parser::ArgMatches>)> = v72
            .subcommand()
            .map(|(name, matches)| (name, std::sync::Arc::new(matches.clone())));
        let v76: &(&str, std::sync::Arc<clap::parser::ArgMatches>) = v74.as_ref().unwrap();
        let v78: &str = v76.0;
        let v80: std::sync::Arc<clap::parser::ArgMatches> = std::sync::Arc::clone(&v76.1);
        let v82: string = fable_library_rust::String_::fromStr(&v78);
        if string("PostFsxRsBuild") == v82.clone() {
            let v84: string = Cli::method2();
            let v86: &str = v84.as_str();
            let v88: Option<&std::string::String> = v80.get_one::<String>(v86);
            fn v89(v: &std::string::String) -> std::string::String {
                Cli::closure1((), v)
            }
            let v91: Option<std::string::String> = v88.map(v89);
            let v95: std::string::String = (&string("get_clap_one: rs-path")).to_string();
            let v97: std::string::String = v91.unwrap_or(v95);
            let v99: std::path::PathBuf = std::path::PathBuf::from(&v97);
            let v101: Result<std::path::PathBuf, std::io::Error> = (&v99).canonicalize();
            let v103: std::path::PathBuf = (&v101).as_ref().unwrap().to_path_buf();
            let patternInput_1: (string, string, string, bool) = Cli::method0();
            let v108: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v109: i64 = (&v108).timestamp();
            Cli::method7(
                v109,
                array(&[Cli::method5(string("rs_path")), Cli::method6(v103.clone())]),
            );
            {
                let patternInput_2: (string, string, string, bool) = Cli::method0();
                let v118: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v119: i64 = (&v118).timestamp();
                let v120: Result<std::path::PathBuf, std::io::Error> = (&v103).canonicalize();
                let v121: std::path::PathBuf = (&v120).as_ref().unwrap().to_path_buf();
                Cli::method18(
                    v119,
                    array(&[
                        Cli::method5(string("path_clean")),
                        Cli::method5(fable_library_rust::String_::fromStr(&format!(
                            "{}",
                            &v121.display()
                        ))),
                    ]),
                );
                {
                    let v129: Result<std::fs::File, std::io::Error> = std::fs::File::open(&v121);
                    let v131: &std::fs::File = &v129.unwrap();
                    let v133: std::cell::RefCell<linereader::LineReader<&std::fs::File>> =
                        std::cell::RefCell::new(linereader::LineReader::new(&v131));
                    Cli::method18(
                        v119,
                        array(&[
                            Cli::method5(string("reader")),
                            Cli::method20(format!("{:?}", &v133)),
                        ]),
                    );
                    {
                        let v141: Lrc<Cli::Mut0> = Lrc::new(Cli::Mut0 {
                            l0: MutCell::new(Lrc::new(Cli::UH0::UH0_1)),
                        });
                        let v142 = Cli::method21(v119, v141.clone());
                        let v144: Result<(), std::io::Error> =
                            (v133).borrow_mut().for_each(move |x| v142(x.to_vec()));
                        *((&v144).as_ref()).unwrap();
                        {
                            let v150: Lrc<Cli::UH1> = Cli::method25(
                                Cli::method24(v141.l0.get().clone(), Lrc::new(Cli::UH0::UH0_1)),
                                Lrc::new(Cli::UH1::UH1_1),
                            );
                            Cli::method18(
                                v119,
                                array(&[
                                    Cli::method5(string("lines len")),
                                    Cli::method22(Cli::method26(v150.clone(), 0i32)),
                                ]),
                            );
                            {
                                let v164: string = Cli::method29(
                                    Cli::method28(
                                        (Cli::method27(
                                            v109,
                                            v150,
                                            0i32,
                                            Lrc::new(Cli::UH1::UH1_1),
                                        ))
                                        .1
                                        .clone(),
                                        Lrc::new(Cli::UH1::UH1_1),
                                    ),
                                    string(""),
                                );
                                let v166: std::string::String = Cli::method5(string("text_len"));
                                let v168 = v164.len();
                                Cli::method7(
                                    v109,
                                    array(&[v166, Cli::method22(v168.try_into().unwrap())]),
                                );
                                {
                                    let v174: Result<(), std::io::Error> =
                                        std::fs::write(v103, v164.as_str());
                                    *((&v174).as_ref()).unwrap();
                                    Cli::method7(
                                        v109,
                                        array(&[Cli::method5(string(
                                            "> fs_write rs_path_clean text; ok",
                                        ))]),
                                    )
                                }
                            }
                        }
                    }
                }
            }
        } else {
            if string("SpiFsxBuild") == v82 {
                let v179: string = Cli::method30();
                let v181: &str = v179.as_str();
                let v183: Option<&std::string::String> = v80.get_one::<String>(v181);
                fn v184(v_1: &std::string::String) -> std::string::String {
                    Cli::closure3((), v_1)
                }
                let v186: Option<std::string::String> = v183.map(v184);
                let v190: std::string::String = (&string("get_clap_one: spi-path")).to_string();
                let v192: std::string::String = v186.unwrap_or(v190);
                let v194: std::path::PathBuf = std::path::PathBuf::from(&v192);
                let v196: Result<std::path::PathBuf, std::io::Error> = (&v194).canonicalize();
                let v198: std::path::PathBuf = (&v196).as_ref().unwrap().to_path_buf();
                let v199: string = Cli::method31();
                let v201: &str = v199.as_str();
                let v203: Option<&std::string::String> = v80.get_one::<String>(v201);
                fn v204(v_2: &std::string::String) -> std::path::PathBuf {
                    Cli::closure4((), v_2)
                }
                let v206: Option<std::path::PathBuf> = v203.map(v204);
                let patternInput_4: (string, string, string, bool) = Cli::method0();
                let v211: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v212: i64 = (&v211).timestamp();
                let v214: std::string::String = Cli::method5(string("pwd"));
                let v216: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                let v217: std::path::PathBuf = (&v216).as_ref().unwrap().to_path_buf();
                let v218: Result<std::path::PathBuf, std::io::Error> = (&v217).canonicalize();
                let v219: std::path::PathBuf = (&v218).as_ref().unwrap().to_path_buf();
                let v223: string = string("spi_path");
                Cli::method32(
                    v212,
                    array(&[
                        v214,
                        Cli::method5(fable_library_rust::String_::fromStr(&format!(
                            "{}",
                            &v219.display()
                        ))),
                        Cli::method5(v223.clone()),
                        Cli::method5(fable_library_rust::String_::fromStr(&format!(
                            "{}",
                            &v198.display()
                        ))),
                        Cli::method5(string("new_fsx_path")),
                        Cli::method20(format!("{:?}", &v206)),
                    ]),
                );
                {
                    let v234: Option<&std::path::Path> = (&v198).parent();
                    let v236: &std::path::Path = &v234.unwrap();
                    let v237: std::path::PathBuf = std::path::PathBuf::from(&v236);
                    Cli::method32(
                        v212,
                        array(&[
                            Cli::method5(string("src_path")),
                            Cli::method5(fable_library_rust::String_::fromStr(&format!(
                                "{}",
                                &v237.display()
                            ))),
                        ]),
                    );
                    {
                        let v244: &std::path::Ancestors = &v237.ancestors();
                        let v247: _ = v244.take(10i32 as usize);
                        fn v248(v_3: &std::path::Path) -> std::path::PathBuf {
                            Cli::closure5((), v_3)
                        }
                        let v251: _ = v247.into_iter().map((&v248).clone());
                        fn v252(v_4: &std::path::PathBuf) -> bool {
                            Cli::closure6((), v_4)
                        }
                        let v255: Option<std::path::PathBuf> =
                            v251.into_iter().find((&v252).clone());
                        let v256: std::path::PathBuf = (&v255).as_ref().unwrap().to_path_buf();
                        let v257: string = string("spiproj_path");
                        Cli::method32(
                            v212,
                            array(&[
                                Cli::method5(v257.clone()),
                                Cli::method5(fable_library_rust::String_::fromStr(&format!(
                                    "{}",
                                    &v256.display()
                                ))),
                            ]),
                        );
                        {
                            let v263: Option<&str> = (&v198).to_str();
                            let v264: &str = &v263.unwrap();
                            let v267: string = string(".spi");
                            let v270: &str =
                                &v264.replace(&*(&string(".spir")).clone(), &(&v267).clone());
                            let v274: &str =
                                &v270.replace(&*(&v267).clone(), &(&string(".fsx")).clone());
                            let v275: std::path::PathBuf = std::path::PathBuf::from(&v274);
                            let v276: Result<std::path::PathBuf, std::io::Error> =
                                (&v275).canonicalize();
                            let v277: std::path::PathBuf = (&v276).as_ref().unwrap().to_path_buf();
                            let v278: string = string("fsx_path");
                            Cli::method32(
                                v212,
                                array(&[
                                    Cli::method5(v278.clone()),
                                    Cli::method5(fable_library_rust::String_::fromStr(&format!(
                                        "{}",
                                        &v277.display()
                                    ))),
                                ]),
                            );
                            {
                                let v283: string = string("");
                                let v285: Result<(), std::io::Error> =
                                    std::fs::write(v277.clone(), v283.clone().as_str());
                                *((&v285).as_ref()).unwrap();
                                Cli::method32(
                                    v212,
                                    array(&[Cli::method5(string("> fs_write fsx_path \"\"; ok"))]),
                                );
                                {
                                    let v291: u16 = 13805.try_into().unwrap();
                                    let v292: string = string("port");
                                    Cli::method32(
                                        v212,
                                        array(&[
                                            Cli::method5(v292.clone()),
                                            Cli::method34(v291.clone()),
                                        ]),
                                    );
                                    {
                                        let v298: &str = r#"../The-Spiral-Language/The Spiral Language 2/bin/Release/net7.0/Spiral.dll"#;
                                        let v301: &str = r#"dotnet"#;
                                        let v303 = std::process::Command::new(v301);
                                        let mut v303 = v303;
                                        {
                                            let v306 = v303.arg(v298);
                                            let v309: string =
                                                append(string("port="), toString(&v291));
                                            let v310: std::string::String = (&v309).to_string();
                                            let v312 = v306.arg(v310);
                                            let v314 = v312.stdout(std::process::Stdio::inherit());
                                            let v316 = v314.stderr(std::process::Stdio::inherit());
                                            let v318: Result<std::process::Child, std::io::Error> =
                                                v316.spawn();
                                            let v320: std::process::Child = v318.unwrap();
                                            Cli::method32(
                                                v212,
                                                array(&[
                                                    Cli::method5(string("process")),
                                                    Cli::method20(format!("{:?}", &v320)),
                                                ]),
                                            );
                                            {
                                                let v326: u16 = Cli::method35(v291.clone());
                                                let v328: std::net::SocketAddr =
                                                    std::net::SocketAddr::from((
                                                        [0, 0, 0, 0],
                                                        v326,
                                                    ));
                                                let v353 =
                                                    tokio::runtime::Builder::new_current_thread();
                                                let mut v353 = v353;
                                                {
                                                    let v356 = v353.enable_all();
                                                    let v358 = v356.build();
                                                    let v360 = v358.unwrap();
                                                    let v364: string =
                                                        string("v360.block_on(async move {     loop {         let result = std::net::TcpStream::connect(&v328);         println!(\"connect_timeout: {:?}\", result);         if result.is_ok() {             tokio::time::sleep(std::time::Duration::from_secs(1)).await;             break;         } else {             tokio::time::sleep(std::time::Duration::from_millis(60)).await;         }     } })");
                                                    v360.block_on(async move {     loop {         let result = std::net::TcpStream::connect(&v328);         println!("connect_timeout: {:?}", result);         if result.is_ok() {             tokio::time::sleep(std::time::Duration::from_secs(1)).await;             break;         } else {             tokio::time::sleep(std::time::Duration::from_millis(60)).await;         }     } });
                                                    {
                                                        let patternInput_5: (
                                                            string,
                                                            string,
                                                            string,
                                                            bool,
                                                        ) = Cli::method0();
                                                        let v369: chrono::DateTime<chrono::Utc> =
                                                            chrono::Utc::now();
                                                        let v370: i64 = (&v369).timestamp();
                                                        let v372: string = string("{");
                                                        let v374: string = string("}");
                                                        let v376: string =
                                                            string("serde_json::json!(");
                                                        let v378: string = string(").to_string()");
                                                        let v379: string = append(
                                                            append(
                                                                v376.clone(),
                                                                append(
                                                                    append(
                                                                        v372.clone(),
                                                                        string("\"Ping\": true"),
                                                                    ),
                                                                    v374.clone(),
                                                                ),
                                                            ),
                                                            v378.clone(),
                                                        );
                                                        let v380: std::string::String =
                                                            serde_json::json!({"Ping": true})
                                                                .to_string();
                                                        let v381: string = string("json_len");
                                                        let v382: std::string::String =
                                                            Cli::method5(v381.clone());
                                                        let v384 = v380.len();
                                                        Cli::method36(
                                                            v370,
                                                            array(&[
                                                                v382,
                                                                Cli::method22(
                                                                    v384.try_into().unwrap(),
                                                                ),
                                                            ]),
                                                        );
                                                        {
                                                            let patternInput_6: (
                                                                string,
                                                                string,
                                                                string,
                                                                bool,
                                                            ) = Cli::method0();
                                                            let v393: chrono::DateTime<
                                                                chrono::Utc,
                                                            > = chrono::Utc::now();
                                                            let v394: i64 = (&v393).timestamp();
                                                            let v395: string = string("host");
                                                            let v396: std::string::String =
                                                                Cli::method5(v395.clone());
                                                            let v397: string = string("127.0.0.1");
                                                            let v398: std::string::String =
                                                                Cli::method5(v397.clone());
                                                            let v399: std::string::String =
                                                                Cli::method5(v292.clone());
                                                            let v400: std::string::String =
                                                                Cli::method34(v291.clone());
                                                            let v401: string = string("msg_len");
                                                            let v402: std::string::String =
                                                                Cli::method5(v401.clone());
                                                            let v404 = v380.len();
                                                            Cli::method38(
                                                                v394,
                                                                array(&[
                                                                    v396,
                                                                    v398,
                                                                    v399,
                                                                    v400,
                                                                    v402,
                                                                    Cli::method22(
                                                                        v404.try_into().unwrap(),
                                                                    ),
                                                                ]),
                                                            );
                                                            {
                                                                let v410 = zmq::Context::new();
                                                                let v412 =
                                                                    v410.socket(zmq::REQ).unwrap();
                                                                let v413: string =
                                                                    stringFrom(format!(
                                                                        "tcp://{0}:{1}",
                                                                        &v397, &v291
                                                                    ));
                                                                v412.connect(&v413.clone())
                                                                    .unwrap();
                                                                v412.send(v380.as_str(), 0)
                                                                    .unwrap();
                                                                {
                                                                    let v417: std::string::String =
                                                                        v412.recv_string(0)
                                                                            .unwrap()
                                                                            .unwrap();
                                                                    v412.disconnect(&v413).unwrap();
                                                                    {
                                                                        let v419: string =
                                                                            string("result_len");
                                                                        let v420:
                                                                                std::string::String =
                                                                            Cli::method5(v419.clone());
                                                                        let v422 = v417.len();
                                                                        Cli::method38(
                                                                            v394,
                                                                            array(&[
                                                                                v420,
                                                                                Cli::method22(
                                                                                    v422.try_into()
                                                                                        .unwrap(),
                                                                                ),
                                                                            ]),
                                                                        );
                                                                        {
                                                                            let v427: string =
                                                                                string(
                                                                                    "> ping; ok",
                                                                                );
                                                                            Cli::method32(
                                                                                v212,
                                                                                array(&[
                                                                                    Cli::method5(
                                                                                        v427.clone(
                                                                                        ),
                                                                                    ),
                                                                                ]),
                                                                            );
                                                                            {
                                                                                let v431:
                                                                                        Result<std::string::String,
                                                                                               std::io::Error> =
                                                                                    std::fs::read_to_string(&v198);
                                                                                let v433:
                                                                                        std::string::String =
                                                                                    (&v431).as_ref().unwrap().to_string();
                                                                                let patternInput_7:
                                                                                        (string,
                                                                                         string,
                                                                                         string,
                                                                                         bool) =
                                                                                    Cli::method0();
                                                                                let v438:
                                                                                        chrono::DateTime<chrono::Utc> =
                                                                                    chrono::Utc::now();
                                                                                let v439: i64 =
                                                                                    (&v438)
                                                                                        .timestamp(
                                                                                        );
                                                                                let v440:
                                                                                        std::string::String =
                                                                                    Cli::method5(v223.clone());
                                                                                let v442:
                                                                                        std::string::String =
                                                                                    Cli::method5(fable_library_rust::String_::fromStr(&format!("{}", &v198.display())));
                                                                                let v444:
                                                                                        std::string::String =
                                                                                    Cli::method5(string("spi_text_len"));
                                                                                let v446 =
                                                                                    v433.len();
                                                                                Cli::method40(v439,
                                                                                              array(&[v440,
                                                                                                      v442,
                                                                                                      v444,
                                                                                                      Cli::method22(v446.try_into().unwrap())]));
                                                                                {
                                                                                    let v460:
                                                                                            string =
                                                                                        append(append(v376.clone(),
                                                                                                      append(append(append(append(append(v372.clone(),
                                                                                                                                         string("\"FileOpen\": {")),
                                                                                                                                  string("\"spiText\": v433,")),
                                                                                                                           string("\"uri\": \"file://\".to_owned() + v198.to_str().unwrap()")),
                                                                                                                    v374.clone()),
                                                                                                             v374.clone())),
                                                                                               v378.clone());
                                                                                    let v461:
                                                                                            std::string::String =
                                                                                        serde_json::json!({"FileOpen": {"spiText": v433,"uri": "file://".to_owned() + v198.to_str().unwrap()}}).to_string();
                                                                                    let v462:
                                                                                            std::string::String =
                                                                                        Cli::method5(v381.clone());
                                                                                    let v464 =
                                                                                        v461.len();
                                                                                    Cli::method40(v439,
                                                                                                  array(&[v462,
                                                                                                          Cli::method22(v464.try_into().unwrap())]));
                                                                                    {
                                                                                        let patternInput_8:
                                                                                                (string,
                                                                                                 string,
                                                                                                 string,
                                                                                                 bool) =
                                                                                            Cli::method0();
                                                                                        let v473:
                                                                                                chrono::DateTime<chrono::Utc> =
                                                                                            chrono::Utc::now();
                                                                                        let v474:
                                                                                                i64 =
                                                                                            (&v473).timestamp();
                                                                                        let v475:
                                                                                                std::string::String =
                                                                                            Cli::method5(v395.clone());
                                                                                        let v476:
                                                                                                std::string::String =
                                                                                            Cli::method5(v397.clone());
                                                                                        let v477:
                                                                                                std::string::String =
                                                                                            Cli::method5(v292.clone());
                                                                                        let v478:
                                                                                                std::string::String =
                                                                                            Cli::method34(v291.clone());
                                                                                        let v479:
                                                                                                std::string::String =
                                                                                            Cli::method5(v401.clone());
                                                                                        let v481 =
                                                                                            v461.len();
                                                                                        Cli::method38(v474,
                                                                                                      array(&[v475,
                                                                                                              v476,
                                                                                                              v477,
                                                                                                              v478,
                                                                                                              v479,
                                                                                                              Cli::method22(v481.try_into().unwrap())]));
                                                                                        {
                                                                                            let v486 =
                                                                                                zmq::Context::new();
                                                                                            let v487 =
                                                                                                v486.socket(zmq::REQ).unwrap();
                                                                                            let v488:
                                                                                                    string =
                                                                                                stringFrom(format!("tcp://{0}:{1}",
                                                                                                                   &v397,
                                                                                                                   &v291));
                                                                                            v487.connect(&v488.clone()).unwrap();
                                                                                            v487.send(v461.as_str(), 0).unwrap();
                                                                                            {
                                                                                                let v490:
                                                                                                        std::string::String =
                                                                                                    v487.recv_string(0).unwrap().unwrap();
                                                                                                v487.disconnect(&v488).unwrap();
                                                                                                {
                                                                                                    let v491:
                                                                                                            std::string::String =
                                                                                                        Cli::method5(v419.clone());
                                                                                                    let v493 =
                                                                                                        v490.len();
                                                                                                    Cli::method38(v474,
                                                                                                                  array(&[v491,
                                                                                                                          Cli::method22(v493.try_into().unwrap())]));
                                                                                                    Cli::method32(v212,
                                                                                                                  array(&[Cli::method5(string("> spi_open; ok"))]));
                                                                                                    {
                                                                                                        let patternInput_9:
                                                                                                                (string,
                                                                                                                 string,
                                                                                                                 string,
                                                                                                                 bool) =
                                                                                                            Cli::method0();
                                                                                                        let v505:
                                                                                                                chrono::DateTime<chrono::Utc> =
                                                                                                            chrono::Utc::now();
                                                                                                        let v506:
                                                                                                                i64 =
                                                                                                            (&v505).timestamp();
                                                                                                        let v511:
                                                                                                                string =
                                                                                                            append(append(v376.clone(),
                                                                                                                          append(append(v372.clone(),
                                                                                                                                        string("\"Ping\": true")),
                                                                                                                                 v374.clone())),
                                                                                                                   v378.clone());
                                                                                                        let v512:
                                                                                                                std::string::String =
                                                                                                            serde_json::json!({"Ping": true}).to_string();
                                                                                                        let v513:
                                                                                                                std::string::String =
                                                                                                            Cli::method5(v381.clone());
                                                                                                        let v515 =
                                                                                                            v512.len();
                                                                                                        Cli::method36(v506,
                                                                                                                      array(&[v513,
                                                                                                                              Cli::method22(v515.try_into().unwrap())]));
                                                                                                        {
                                                                                                            let patternInput_10:
                                                                                                                    (string,
                                                                                                                     string,
                                                                                                                     string,
                                                                                                                     bool) =
                                                                                                                Cli::method0();
                                                                                                            let v524:
                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                chrono::Utc::now();
                                                                                                            let v525:
                                                                                                                    i64 =
                                                                                                                (&v524).timestamp();
                                                                                                            let v526:
                                                                                                                    std::string::String =
                                                                                                                Cli::method5(v395.clone());
                                                                                                            let v527:
                                                                                                                    std::string::String =
                                                                                                                Cli::method5(v397.clone());
                                                                                                            let v528:
                                                                                                                    std::string::String =
                                                                                                                Cli::method5(v292.clone());
                                                                                                            let v529:
                                                                                                                    std::string::String =
                                                                                                                Cli::method34(v291.clone());
                                                                                                            let v530:
                                                                                                                    std::string::String =
                                                                                                                Cli::method5(v401.clone());
                                                                                                            let v532 =
                                                                                                                v512.len();
                                                                                                            Cli::method38(v525,
                                                                                                                          array(&[v526,
                                                                                                                                  v527,
                                                                                                                                  v528,
                                                                                                                                  v529,
                                                                                                                                  v530,
                                                                                                                                  Cli::method22(v532.try_into().unwrap())]));
                                                                                                            {
                                                                                                                let v537 =
                                                                                                                    zmq::Context::new();
                                                                                                                let v538 =
                                                                                                                    v537.socket(zmq::REQ).unwrap();
                                                                                                                let v539:
                                                                                                                        string =
                                                                                                                    stringFrom(format!("tcp://{0}:{1}",
                                                                                                                                       &v397,
                                                                                                                                       &v291));
                                                                                                                v538.connect(&v539.clone()).unwrap();
                                                                                                                v538.send(v512.as_str(), 0).unwrap();
                                                                                                                {
                                                                                                                    let v541:
                                                                                                                            std::string::String =
                                                                                                                        v538.recv_string(0).unwrap().unwrap();
                                                                                                                    v538.disconnect(&v539).unwrap();
                                                                                                                    {
                                                                                                                        let v542:
                                                                                                                                std::string::String =
                                                                                                                            Cli::method5(v419.clone());
                                                                                                                        let v544 =
                                                                                                                            v541.len();
                                                                                                                        Cli::method38(v525,
                                                                                                                                      array(&[v542,
                                                                                                                                              Cli::method22(v544.try_into().unwrap())]));
                                                                                                                        Cli::method32(v212,
                                                                                                                                      array(&[Cli::method5(v427.clone())]));
                                                                                                                        {
                                                                                                                            let v553:
                                                                                                                                    &str =
                                                                                                                                r#"../The-Spiral-Language/VS Code Plugin/core/package.spiproj"#;
                                                                                                                            let v554:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(&v553);
                                                                                                                            let v555:
                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                           std::io::Error> =
                                                                                                                                (&v554).canonicalize();
                                                                                                                            let v556:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                (&v555).as_ref().unwrap().to_path_buf();
                                                                                                                            let v557:
                                                                                                                                    Result<std::string::String,
                                                                                                                                           std::io::Error> =
                                                                                                                                std::fs::read_to_string(&v556);
                                                                                                                            let v558:
                                                                                                                                    std::string::String =
                                                                                                                                (&v557).as_ref().unwrap().to_string();
                                                                                                                            let patternInput_11:
                                                                                                                                    (string,
                                                                                                                                     string,
                                                                                                                                     string,
                                                                                                                                     bool) =
                                                                                                                                Cli::method0();
                                                                                                                            let v563:
                                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                                chrono::Utc::now();
                                                                                                                            let v564:
                                                                                                                                    i64 =
                                                                                                                                (&v563).timestamp();
                                                                                                                            let v565:
                                                                                                                                    std::string::String =
                                                                                                                                Cli::method5(v257.clone());
                                                                                                                            let v567:
                                                                                                                                    std::string::String =
                                                                                                                                Cli::method5(fable_library_rust::String_::fromStr(&format!("{}", &v556.display())));
                                                                                                                            let v568:
                                                                                                                                    string =
                                                                                                                                string("spiproj_text_len");
                                                                                                                            let v569:
                                                                                                                                    std::string::String =
                                                                                                                                Cli::method5(v568.clone());
                                                                                                                            let v571 =
                                                                                                                                v558.len();
                                                                                                                            Cli::method41(v564,
                                                                                                                                          array(&[v565,
                                                                                                                                                  v567,
                                                                                                                                                  v569,
                                                                                                                                                  Cli::method22(v571.try_into().unwrap())]));
                                                                                                                            {
                                                                                                                                let v576:
                                                                                                                                        string =
                                                                                                                                    string("\"ProjectFileOpen\": {");
                                                                                                                                let v585:
                                                                                                                                        string =
                                                                                                                                    append(append(v376.clone(),
                                                                                                                                                  append(append(append(append(append(v372.clone(),
                                                                                                                                                                                     v576.clone()),
                                                                                                                                                                              string("\"spiprojText\": v558,")),
                                                                                                                                                                       string("\"uri\": \"file://\".to_owned() + v556.to_str().unwrap()")),
                                                                                                                                                                v374.clone()),
                                                                                                                                                         v374.clone())),
                                                                                                                                           v378.clone());
                                                                                                                                let v586:
                                                                                                                                        std::string::String =
                                                                                                                                    serde_json::json!({"ProjectFileOpen": {"spiprojText": v558,"uri": "file://".to_owned() + v556.to_str().unwrap()}}).to_string();
                                                                                                                                let v587:
                                                                                                                                        std::string::String =
                                                                                                                                    Cli::method5(v381.clone());
                                                                                                                                let v589 =
                                                                                                                                    v586.len();
                                                                                                                                Cli::method41(v564,
                                                                                                                                              array(&[v587,
                                                                                                                                                      Cli::method22(v589.try_into().unwrap())]));
                                                                                                                                {
                                                                                                                                    let patternInput_12:
                                                                                                                                            (string,
                                                                                                                                             string,
                                                                                                                                             string,
                                                                                                                                             bool) =
                                                                                                                                        Cli::method0();
                                                                                                                                    let v598:
                                                                                                                                            chrono::DateTime<chrono::Utc> =
                                                                                                                                        chrono::Utc::now();
                                                                                                                                    let v599:
                                                                                                                                            i64 =
                                                                                                                                        (&v598).timestamp();
                                                                                                                                    let v600:
                                                                                                                                            std::string::String =
                                                                                                                                        Cli::method5(v395.clone());
                                                                                                                                    let v601:
                                                                                                                                            std::string::String =
                                                                                                                                        Cli::method5(v397.clone());
                                                                                                                                    let v602:
                                                                                                                                            std::string::String =
                                                                                                                                        Cli::method5(v292.clone());
                                                                                                                                    let v603:
                                                                                                                                            std::string::String =
                                                                                                                                        Cli::method34(v291.clone());
                                                                                                                                    let v604:
                                                                                                                                            std::string::String =
                                                                                                                                        Cli::method5(v401.clone());
                                                                                                                                    let v606 =
                                                                                                                                        v586.len();
                                                                                                                                    Cli::method38(v599,
                                                                                                                                                  array(&[v600,
                                                                                                                                                          v601,
                                                                                                                                                          v602,
                                                                                                                                                          v603,
                                                                                                                                                          v604,
                                                                                                                                                          Cli::method22(v606.try_into().unwrap())]));
                                                                                                                                    {
                                                                                                                                        let v611 =
                                                                                                                                            zmq::Context::new();
                                                                                                                                        let v612 =
                                                                                                                                            v611.socket(zmq::REQ).unwrap();
                                                                                                                                        let v613:
                                                                                                                                                string =
                                                                                                                                            stringFrom(format!("tcp://{0}:{1}",
                                                                                                                                                               &v397,
                                                                                                                                                               &v291));
                                                                                                                                        v612.connect(&v613.clone()).unwrap();
                                                                                                                                        v612.send(v586.as_str(), 0).unwrap();
                                                                                                                                        {
                                                                                                                                            let v615:
                                                                                                                                                    std::string::String =
                                                                                                                                                v612.recv_string(0).unwrap().unwrap();
                                                                                                                                            v612.disconnect(&v613).unwrap();
                                                                                                                                            {
                                                                                                                                                let v616:
                                                                                                                                                        std::string::String =
                                                                                                                                                    Cli::method5(v419.clone());
                                                                                                                                                let v618 =
                                                                                                                                                    v615.len();
                                                                                                                                                Cli::method38(v599,
                                                                                                                                                              array(&[v616,
                                                                                                                                                                      Cli::method22(v618.try_into().unwrap())]));
                                                                                                                                                Cli::method32(v212,
                                                                                                                                                              array(&[Cli::method5(string("> spiproj_open base_spiproj_path; ok"))]));
                                                                                                                                                {
                                                                                                                                                    let v626:
                                                                                                                                                            Result<std::string::String,
                                                                                                                                                                   std::io::Error> =
                                                                                                                                                        std::fs::read_to_string(&v256);
                                                                                                                                                    let v627:
                                                                                                                                                            std::string::String =
                                                                                                                                                        (&v626).as_ref().unwrap().to_string();
                                                                                                                                                    let patternInput_13:
                                                                                                                                                            (string,
                                                                                                                                                             string,
                                                                                                                                                             string,
                                                                                                                                                             bool) =
                                                                                                                                                        Cli::method0();
                                                                                                                                                    let v632:
                                                                                                                                                            chrono::DateTime<chrono::Utc> =
                                                                                                                                                        chrono::Utc::now();
                                                                                                                                                    let v633:
                                                                                                                                                            i64 =
                                                                                                                                                        (&v632).timestamp();
                                                                                                                                                    let v634:
                                                                                                                                                            std::string::String =
                                                                                                                                                        Cli::method5(v257);
                                                                                                                                                    let v636:
                                                                                                                                                            std::string::String =
                                                                                                                                                        Cli::method5(fable_library_rust::String_::fromStr(&format!("{}", &v256.display())));
                                                                                                                                                    let v637:
                                                                                                                                                            std::string::String =
                                                                                                                                                        Cli::method5(v568);
                                                                                                                                                    let v639 =
                                                                                                                                                        v627.len();
                                                                                                                                                    Cli::method41(v633,
                                                                                                                                                                  array(&[v634,
                                                                                                                                                                          v636,
                                                                                                                                                                          v637,
                                                                                                                                                                          Cli::method22(v639.try_into().unwrap())]));
                                                                                                                                                    {
                                                                                                                                                        let v652:
                                                                                                                                                                string =
                                                                                                                                                            append(append(v376.clone(),
                                                                                                                                                                          append(append(append(append(append(v372.clone(),
                                                                                                                                                                                                             v576),
                                                                                                                                                                                                      string("\"spiprojText\": v627,")),
                                                                                                                                                                                               string("\"uri\": \"file://\".to_owned() + v256.to_str().unwrap()")),
                                                                                                                                                                                        v374.clone()),
                                                                                                                                                                                 v374.clone())),
                                                                                                                                                                   v378.clone());
                                                                                                                                                        let v653:
                                                                                                                                                                std::string::String =
                                                                                                                                                            serde_json::json!({"ProjectFileOpen": {"spiprojText": v627,"uri": "file://".to_owned() + v256.to_str().unwrap()}}).to_string();
                                                                                                                                                        let v654:
                                                                                                                                                                std::string::String =
                                                                                                                                                            Cli::method5(v381.clone());
                                                                                                                                                        let v656 =
                                                                                                                                                            v653.len();
                                                                                                                                                        Cli::method41(v633,
                                                                                                                                                                      array(&[v654,
                                                                                                                                                                              Cli::method22(v656.try_into().unwrap())]));
                                                                                                                                                        {
                                                                                                                                                            let patternInput_14:
                                                                                                                                                                    (string,
                                                                                                                                                                     string,
                                                                                                                                                                     string,
                                                                                                                                                                     bool) =
                                                                                                                                                                Cli::method0();
                                                                                                                                                            let v665:
                                                                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                                                                chrono::Utc::now();
                                                                                                                                                            let v666:
                                                                                                                                                                    i64 =
                                                                                                                                                                (&v665).timestamp();
                                                                                                                                                            let v667:
                                                                                                                                                                    std::string::String =
                                                                                                                                                                Cli::method5(v395.clone());
                                                                                                                                                            let v668:
                                                                                                                                                                    std::string::String =
                                                                                                                                                                Cli::method5(v397.clone());
                                                                                                                                                            let v669:
                                                                                                                                                                    std::string::String =
                                                                                                                                                                Cli::method5(v292.clone());
                                                                                                                                                            let v670:
                                                                                                                                                                    std::string::String =
                                                                                                                                                                Cli::method34(v291.clone());
                                                                                                                                                            let v671:
                                                                                                                                                                    std::string::String =
                                                                                                                                                                Cli::method5(v401.clone());
                                                                                                                                                            let v673 =
                                                                                                                                                                v653.len();
                                                                                                                                                            Cli::method38(v666,
                                                                                                                                                                          array(&[v667,
                                                                                                                                                                                  v668,
                                                                                                                                                                                  v669,
                                                                                                                                                                                  v670,
                                                                                                                                                                                  v671,
                                                                                                                                                                                  Cli::method22(v673.try_into().unwrap())]));
                                                                                                                                                            {
                                                                                                                                                                let v678 =
                                                                                                                                                                    zmq::Context::new();
                                                                                                                                                                let v679 =
                                                                                                                                                                    v678.socket(zmq::REQ).unwrap();
                                                                                                                                                                let v680:
                                                                                                                                                                        string =
                                                                                                                                                                    stringFrom(format!("tcp://{0}:{1}",
                                                                                                                                                                                       &v397,
                                                                                                                                                                                       &v291));
                                                                                                                                                                v679.connect(&v680.clone()).unwrap();
                                                                                                                                                                v679.send(v653.as_str(), 0).unwrap();
                                                                                                                                                                {
                                                                                                                                                                    let v682:
                                                                                                                                                                            std::string::String =
                                                                                                                                                                        v679.recv_string(0).unwrap().unwrap();
                                                                                                                                                                    v679.disconnect(&v680).unwrap();
                                                                                                                                                                    {
                                                                                                                                                                        let v683:
                                                                                                                                                                                std::string::String =
                                                                                                                                                                            Cli::method5(v419.clone());
                                                                                                                                                                        let v685 =
                                                                                                                                                                            v682.len();
                                                                                                                                                                        Cli::method38(v666,
                                                                                                                                                                                      array(&[v683,
                                                                                                                                                                                              Cli::method22(v685.try_into().unwrap())]));
                                                                                                                                                                        Cli::method32(v212,
                                                                                                                                                                                      array(&[Cli::method5(string("> spiproj_open spiproj_path; ok"))]));
                                                                                                                                                                        {
                                                                                                                                                                            let patternInput_15:
                                                                                                                                                                                    (string,
                                                                                                                                                                                     string,
                                                                                                                                                                                     string,
                                                                                                                                                                                     bool) =
                                                                                                                                                                                Cli::method0();
                                                                                                                                                                            let v697:
                                                                                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                chrono::Utc::now();
                                                                                                                                                                            let v698:
                                                                                                                                                                                    i64 =
                                                                                                                                                                                (&v697).timestamp();
                                                                                                                                                                            let v703:
                                                                                                                                                                                    string =
                                                                                                                                                                                append(append(v376.clone(),
                                                                                                                                                                                              append(append(v372.clone(),
                                                                                                                                                                                                            string("\"Ping\": true")),
                                                                                                                                                                                                     v374.clone())),
                                                                                                                                                                                       v378.clone());
                                                                                                                                                                            let v704:
                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                serde_json::json!({"Ping": true}).to_string();
                                                                                                                                                                            let v705:
                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                Cli::method5(v381.clone());
                                                                                                                                                                            let v707 =
                                                                                                                                                                                v704.len();
                                                                                                                                                                            Cli::method36(v698,
                                                                                                                                                                                          array(&[v705,
                                                                                                                                                                                                  Cli::method22(v707.try_into().unwrap())]));
                                                                                                                                                                            {
                                                                                                                                                                                let patternInput_16:
                                                                                                                                                                                        (string,
                                                                                                                                                                                         string,
                                                                                                                                                                                         string,
                                                                                                                                                                                         bool) =
                                                                                                                                                                                    Cli::method0();
                                                                                                                                                                                let v716:
                                                                                                                                                                                        chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                    chrono::Utc::now();
                                                                                                                                                                                let v717:
                                                                                                                                                                                        i64 =
                                                                                                                                                                                    (&v716).timestamp();
                                                                                                                                                                                let v718:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    Cli::method5(v395.clone());
                                                                                                                                                                                let v719:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    Cli::method5(v397.clone());
                                                                                                                                                                                let v720:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    Cli::method5(v292.clone());
                                                                                                                                                                                let v721:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    Cli::method34(v291.clone());
                                                                                                                                                                                let v722:
                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                    Cli::method5(v401.clone());
                                                                                                                                                                                let v724 =
                                                                                                                                                                                    v704.len();
                                                                                                                                                                                Cli::method38(v717,
                                                                                                                                                                                              array(&[v718,
                                                                                                                                                                                                      v719,
                                                                                                                                                                                                      v720,
                                                                                                                                                                                                      v721,
                                                                                                                                                                                                      v722,
                                                                                                                                                                                                      Cli::method22(v724.try_into().unwrap())]));
                                                                                                                                                                                {
                                                                                                                                                                                    let v729 =
                                                                                                                                                                                        zmq::Context::new();
                                                                                                                                                                                    let v730 =
                                                                                                                                                                                        v729.socket(zmq::REQ).unwrap();
                                                                                                                                                                                    let v731:
                                                                                                                                                                                            string =
                                                                                                                                                                                        stringFrom(format!("tcp://{0}:{1}",
                                                                                                                                                                                                           &v397,
                                                                                                                                                                                                           &v291));
                                                                                                                                                                                    v730.connect(&v731.clone()).unwrap();
                                                                                                                                                                                    v730.send(v704.as_str(), 0).unwrap();
                                                                                                                                                                                    {
                                                                                                                                                                                        let v733:
                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                            v730.recv_string(0).unwrap().unwrap();
                                                                                                                                                                                        v730.disconnect(&v731).unwrap();
                                                                                                                                                                                        {
                                                                                                                                                                                            let v734:
                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                Cli::method5(v419.clone());
                                                                                                                                                                                            let v736 =
                                                                                                                                                                                                v733.len();
                                                                                                                                                                                            Cli::method38(v717,
                                                                                                                                                                                                          array(&[v734,
                                                                                                                                                                                                                  Cli::method22(v736.try_into().unwrap())]));
                                                                                                                                                                                            Cli::method32(v212,
                                                                                                                                                                                                          array(&[Cli::method5(v427.clone())]));
                                                                                                                                                                                            {
                                                                                                                                                                                                let patternInput_17:
                                                                                                                                                                                                        (string,
                                                                                                                                                                                                         string,
                                                                                                                                                                                                         string,
                                                                                                                                                                                                         bool) =
                                                                                                                                                                                                    Cli::method0();
                                                                                                                                                                                                let v747:
                                                                                                                                                                                                        chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                                    chrono::Utc::now();
                                                                                                                                                                                                let v748:
                                                                                                                                                                                                        i64 =
                                                                                                                                                                                                    (&v747).timestamp();
                                                                                                                                                                                                let v754:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    string("Fsharp");
                                                                                                                                                                                                Cli::method42(v748,
                                                                                                                                                                                                              array(&[Cli::method5(v223),
                                                                                                                                                                                                                      Cli::method5(fable_library_rust::String_::fromStr(&format!("{}", &v198.display()))),
                                                                                                                                                                                                                      Cli::method5(string("backend")),
                                                                                                                                                                                                                      Cli::method5(v754.clone())]));
                                                                                                                                                                                                {
                                                                                                                                                                                                    let v757:
                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                        (&v754).to_string();
                                                                                                                                                                                                    let v767:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        append(append(v376.clone(),
                                                                                                                                                                                                                      append(append(append(append(append(v372.clone(),
                                                                                                                                                                                                                                                         string("\"BuildFile\": {")),
                                                                                                                                                                                                                                                  string("\"uri\": \"file://\".to_owned() + v198.to_str().unwrap(),")),
                                                                                                                                                                                                                                           string("\"backend\": v757")),
                                                                                                                                                                                                                                    v374.clone()),
                                                                                                                                                                                                                             v374.clone())),
                                                                                                                                                                                                               v378.clone());
                                                                                                                                                                                                    let v768:
                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                        serde_json::json!({"BuildFile": {"uri": "file://".to_owned() + v198.to_str().unwrap(),"backend": v757}}).to_string();
                                                                                                                                                                                                    let v769:
                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                        Cli::method5(v381.clone());
                                                                                                                                                                                                    let v771 =
                                                                                                                                                                                                        v768.len();
                                                                                                                                                                                                    Cli::method42(v748,
                                                                                                                                                                                                                  array(&[v769,
                                                                                                                                                                                                                          Cli::method22(v771.try_into().unwrap())]));
                                                                                                                                                                                                    {
                                                                                                                                                                                                        let patternInput_18:
                                                                                                                                                                                                                (string,
                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                 bool) =
                                                                                                                                                                                                            Cli::method0();
                                                                                                                                                                                                        let v780:
                                                                                                                                                                                                                chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                                            chrono::Utc::now();
                                                                                                                                                                                                        let v781:
                                                                                                                                                                                                                i64 =
                                                                                                                                                                                                            (&v780).timestamp();
                                                                                                                                                                                                        let v782:
                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                            Cli::method5(v395.clone());
                                                                                                                                                                                                        let v783:
                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                            Cli::method5(v397.clone());
                                                                                                                                                                                                        let v784:
                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                            Cli::method5(v292.clone());
                                                                                                                                                                                                        let v785:
                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                            Cli::method34(v291.clone());
                                                                                                                                                                                                        let v786:
                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                            Cli::method5(v401.clone());
                                                                                                                                                                                                        let v788 =
                                                                                                                                                                                                            v768.len();
                                                                                                                                                                                                        Cli::method38(v781,
                                                                                                                                                                                                                      array(&[v782,
                                                                                                                                                                                                                              v783,
                                                                                                                                                                                                                              v784,
                                                                                                                                                                                                                              v785,
                                                                                                                                                                                                                              v786,
                                                                                                                                                                                                                              Cli::method22(v788.try_into().unwrap())]));
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v793 =
                                                                                                                                                                                                                zmq::Context::new();
                                                                                                                                                                                                            let v794 =
                                                                                                                                                                                                                v793.socket(zmq::REQ).unwrap();
                                                                                                                                                                                                            let v795:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                stringFrom(format!("tcp://{0}:{1}",
                                                                                                                                                                                                                                   &v397,
                                                                                                                                                                                                                                   &v291));
                                                                                                                                                                                                            v794.connect(&v795.clone()).unwrap();
                                                                                                                                                                                                            v794.send(v768.as_str(), 0).unwrap();
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v797:
                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                    v794.recv_string(0).unwrap().unwrap();
                                                                                                                                                                                                                v794.disconnect(&v795).unwrap();
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    let v798:
                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                        Cli::method5(v419.clone());
                                                                                                                                                                                                                    let v800 =
                                                                                                                                                                                                                        v797.len();
                                                                                                                                                                                                                    Cli::method38(v781,
                                                                                                                                                                                                                                  array(&[v798,
                                                                                                                                                                                                                                          Cli::method22(v800.try_into().unwrap())]));
                                                                                                                                                                                                                    Cli::method32(v212,
                                                                                                                                                                                                                                  array(&[Cli::method5(string("> spi_build_file; ok"))]));
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        let patternInput_19:
                                                                                                                                                                                                                                (string,
                                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                                 bool) =
                                                                                                                                                                                                                            Cli::method0();
                                                                                                                                                                                                                        let v812:
                                                                                                                                                                                                                                chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                                                            chrono::Utc::now();
                                                                                                                                                                                                                        let v813:
                                                                                                                                                                                                                                i64 =
                                                                                                                                                                                                                            (&v812).timestamp();
                                                                                                                                                                                                                        let v818:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            append(append(v376.clone(),
                                                                                                                                                                                                                                          append(append(v372.clone(),
                                                                                                                                                                                                                                                        string("\"Ping\": true")),
                                                                                                                                                                                                                                                 v374.clone())),
                                                                                                                                                                                                                                   v378.clone());
                                                                                                                                                                                                                        let v819:
                                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                                            serde_json::json!({"Ping": true}).to_string();
                                                                                                                                                                                                                        let v820:
                                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                                            Cli::method5(v381.clone());
                                                                                                                                                                                                                        let v822 =
                                                                                                                                                                                                                            v819.len();
                                                                                                                                                                                                                        Cli::method36(v813,
                                                                                                                                                                                                                                      array(&[v820,
                                                                                                                                                                                                                                              Cli::method22(v822.try_into().unwrap())]));
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            let patternInput_20:
                                                                                                                                                                                                                                    (string,
                                                                                                                                                                                                                                     string,
                                                                                                                                                                                                                                     string,
                                                                                                                                                                                                                                     bool) =
                                                                                                                                                                                                                                Cli::method0();
                                                                                                                                                                                                                            let v831:
                                                                                                                                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                                                                chrono::Utc::now();
                                                                                                                                                                                                                            let v832:
                                                                                                                                                                                                                                    i64 =
                                                                                                                                                                                                                                (&v831).timestamp();
                                                                                                                                                                                                                            let v833:
                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                Cli::method5(v395.clone());
                                                                                                                                                                                                                            let v834:
                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                Cli::method5(v397.clone());
                                                                                                                                                                                                                            let v835:
                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                Cli::method5(v292.clone());
                                                                                                                                                                                                                            let v836:
                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                Cli::method34(v291.clone());
                                                                                                                                                                                                                            let v837:
                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                Cli::method5(v401.clone());
                                                                                                                                                                                                                            let v839 =
                                                                                                                                                                                                                                v819.len();
                                                                                                                                                                                                                            Cli::method38(v832,
                                                                                                                                                                                                                                          array(&[v833,
                                                                                                                                                                                                                                                  v834,
                                                                                                                                                                                                                                                  v835,
                                                                                                                                                                                                                                                  v836,
                                                                                                                                                                                                                                                  v837,
                                                                                                                                                                                                                                                  Cli::method22(v839.try_into().unwrap())]));
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v844 =
                                                                                                                                                                                                                                    zmq::Context::new();
                                                                                                                                                                                                                                let v845 =
                                                                                                                                                                                                                                    v844.socket(zmq::REQ).unwrap();
                                                                                                                                                                                                                                let v846:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    stringFrom(format!("tcp://{0}:{1}",
                                                                                                                                                                                                                                                       &v397,
                                                                                                                                                                                                                                                       &v291));
                                                                                                                                                                                                                                v845.connect(&v846.clone()).unwrap();
                                                                                                                                                                                                                                v845.send(v819.as_str(), 0).unwrap();
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v848:
                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                        v845.recv_string(0).unwrap().unwrap();
                                                                                                                                                                                                                                    v845.disconnect(&v846).unwrap();
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        let v849:
                                                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                                                            Cli::method5(v419.clone());
                                                                                                                                                                                                                                        let v851 =
                                                                                                                                                                                                                                            v848.len();
                                                                                                                                                                                                                                        Cli::method38(v832,
                                                                                                                                                                                                                                                      array(&[v849,
                                                                                                                                                                                                                                                              Cli::method22(v851.try_into().unwrap())]));
                                                                                                                                                                                                                                        Cli::method32(v212,
                                                                                                                                                                                                                                                      array(&[Cli::method5(v427.clone())]));
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            let patternInput_21:
                                                                                                                                                                                                                                                    (string,
                                                                                                                                                                                                                                                     string,
                                                                                                                                                                                                                                                     string,
                                                                                                                                                                                                                                                     bool) =
                                                                                                                                                                                                                                                Cli::method0();
                                                                                                                                                                                                                                            let v862:
                                                                                                                                                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                                                                                chrono::Utc::now();
                                                                                                                                                                                                                                            let v863:
                                                                                                                                                                                                                                                    i64 =
                                                                                                                                                                                                                                                (&v862).timestamp();
                                                                                                                                                                                                                                            let v865:
                                                                                                                                                                                                                                                    std::time::SystemTime =
                                                                                                                                                                                                                                                std::fs::metadata(&v277).unwrap().modified().unwrap();
                                                                                                                                                                                                                                            Cli::method45(v863,
                                                                                                                                                                                                                                                          array(&[Cli::method5(v278),
                                                                                                                                                                                                                                                                  Cli::method5(fable_library_rust::String_::fromStr(&format!("{}", &v277.display()))),
                                                                                                                                                                                                                                                                  Cli::method5(string("start")),
                                                                                                                                                                                                                                                                  Cli::method44(v865.clone())]));
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                let v873:
                                                                                                                                                                                                                                                        Array<i32> =
                                                                                                                                                                                                                                                    toArray(rangeNumeric(0i32,
                                                                                                                                                                                                                                                                         1i32,
                                                                                                                                                                                                                                                                         20i32).clone());
                                                                                                                                                                                                                                                let v874:
                                                                                                                                                                                                                                                        i32 =
                                                                                                                                                                                                                                                    v873.len()
                                                                                                                                                                                                                                                        as
                                                                                                                                                                                                                                                        i32;
                                                                                                                                                                                                                                                let v876:
                                                                                                                                                                                                                                                        Lrc<Cli::Mut1> =
                                                                                                                                                                                                                                                    Lrc::new(Cli::Mut1{l0:
                                                                                                                                                                                                                                                                           MutCell::new(0i32),
                                                                                                                                                                                                                                                                       l1:
                                                                                                                                                                                                                                                                           MutCell::new(Cli::US0::US0_0),});
                                                                                                                                                                                                                                                while Cli::method47(v874,
                                                                                                                                                                                                                                                                    v876.clone())
                                                                                                                                                                                                                                                      {
                                                                                                                                                                                                                                                    let v878:
                                                                                                                                                                                                                                                            i32 =
                                                                                                                                                                                                                                                        v876.l0.get();
                                                                                                                                                                                                                                                    let v879:
                                                                                                                                                                                                                                                            Cli::US0 =
                                                                                                                                                                                                                                                        v876.l1.get().clone();
                                                                                                                                                                                                                                                    let v880:
                                                                                                                                                                                                                                                            i32 =
                                                                                                                                                                                                                                                        v873[v878].clone();
                                                                                                                                                                                                                                                    let v902:
                                                                                                                                                                                                                                                            Cli::US0 =
                                                                                                                                                                                                                                                        match &v879
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                            Cli::US0::US0_1(v879_1_0)
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            Cli::US0::US0_1(v879_1_0.clone()),
                                                                                                                                                                                                                                                            _
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                let v883:
                                                                                                                                                                                                                                                                        std::time::SystemTime =
                                                                                                                                                                                                                                                                    std::fs::metadata(&v277).unwrap().modified().unwrap();
                                                                                                                                                                                                                                                                Cli::method45(v863,
                                                                                                                                                                                                                                                                              array(&[Cli::method5(string("i")),
                                                                                                                                                                                                                                                                                      Cli::method22(v880),
                                                                                                                                                                                                                                                                                      Cli::method5(string("last_modified")),
                                                                                                                                                                                                                                                                                      Cli::method44(v883.clone())]));
                                                                                                                                                                                                                                                                if v883 > v865
                                                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                                                    let v893:
                                                                                                                                                                                                                                                                            Result<std::string::String,
                                                                                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                                                                                        std::fs::read_to_string(&v277);
                                                                                                                                                                                                                                                                    let v894:
                                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                                        (&v893).as_ref().unwrap().to_string();
                                                                                                                                                                                                                                                                    Cli::US0::US0_1(fable_library_rust::String_::fromStr(&v894))
                                                                                                                                                                                                                                                                } else {
                                                                                                                                                                                                                                                                    std::thread::sleep(std::time::Duration::from_millis(*&60u64));
                                                                                                                                                                                                                                                                    Cli::US0::US0_0
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        };
                                                                                                                                                                                                                                                    let v903:
                                                                                                                                                                                                                                                            i32 =
                                                                                                                                                                                                                                                        v878
                                                                                                                                                                                                                                                            +
                                                                                                                                                                                                                                                            1i32;
                                                                                                                                                                                                                                                    v876.l0.set(v903);
                                                                                                                                                                                                                                                    v876.l1.set(v902.clone());
                                                                                                                                                                                                                                                    ()
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v904:
                                                                                                                                                                                                                                                            Cli::US0 =
                                                                                                                                                                                                                                                        v876.l1.get().clone();
                                                                                                                                                                                                                                                    let v907:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        match &v904
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                            Cli::US0::US0_1(v904_1_0)
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            v904_1_0.clone(),
                                                                                                                                                                                                                                                            _
                                                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                                                            v283,
                                                                                                                                                                                                                                                        };
                                                                                                                                                                                                                                                    let v909:
                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                        Cli::method5(string("new_fsx_len"));
                                                                                                                                                                                                                                                    let v911 =
                                                                                                                                                                                                                                                        v907.len();
                                                                                                                                                                                                                                                    Cli::method32(v212,
                                                                                                                                                                                                                                                                  array(&[v909,
                                                                                                                                                                                                                                                                          Cli::method22(v911.try_into().unwrap())]));
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let patternInput_22:
                                                                                                                                                                                                                                                                (string,
                                                                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                                                                 string,
                                                                                                                                                                                                                                                                 bool) =
                                                                                                                                                                                                                                                            Cli::method0();
                                                                                                                                                                                                                                                        let v920:
                                                                                                                                                                                                                                                                chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                                                                                            chrono::Utc::now();
                                                                                                                                                                                                                                                        let v921:
                                                                                                                                                                                                                                                                i64 =
                                                                                                                                                                                                                                                            (&v920).timestamp();
                                                                                                                                                                                                                                                        let v926:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            append(append(v376,
                                                                                                                                                                                                                                                                          append(append(v372,
                                                                                                                                                                                                                                                                                        string("\"Ping\": true")),
                                                                                                                                                                                                                                                                                 v374)),
                                                                                                                                                                                                                                                                   v378);
                                                                                                                                                                                                                                                        let v927:
                                                                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                                                                            serde_json::json!({"Ping": true}).to_string();
                                                                                                                                                                                                                                                        let v928:
                                                                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                                                                            Cli::method5(v381);
                                                                                                                                                                                                                                                        let v930 =
                                                                                                                                                                                                                                                            v927.len();
                                                                                                                                                                                                                                                        Cli::method36(v921,
                                                                                                                                                                                                                                                                      array(&[v928,
                                                                                                                                                                                                                                                                              Cli::method22(v930.try_into().unwrap())]));
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            let patternInput_23:
                                                                                                                                                                                                                                                                    (string,
                                                                                                                                                                                                                                                                     string,
                                                                                                                                                                                                                                                                     string,
                                                                                                                                                                                                                                                                     bool) =
                                                                                                                                                                                                                                                                Cli::method0();
                                                                                                                                                                                                                                                            let v939:
                                                                                                                                                                                                                                                                    chrono::DateTime<chrono::Utc> =
                                                                                                                                                                                                                                                                chrono::Utc::now();
                                                                                                                                                                                                                                                            let v940:
                                                                                                                                                                                                                                                                    i64 =
                                                                                                                                                                                                                                                                (&v939).timestamp();
                                                                                                                                                                                                                                                            let v941:
                                                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                                                Cli::method5(v395);
                                                                                                                                                                                                                                                            let v942:
                                                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                                                Cli::method5(v397.clone());
                                                                                                                                                                                                                                                            let v943:
                                                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                                                Cli::method5(v292);
                                                                                                                                                                                                                                                            let v944:
                                                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                                                Cli::method34(v291.clone());
                                                                                                                                                                                                                                                            let v945:
                                                                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                                                                Cli::method5(v401);
                                                                                                                                                                                                                                                            let v947 =
                                                                                                                                                                                                                                                                v927.len();
                                                                                                                                                                                                                                                            Cli::method38(v940,
                                                                                                                                                                                                                                                                          array(&[v941,
                                                                                                                                                                                                                                                                                  v942,
                                                                                                                                                                                                                                                                                  v943,
                                                                                                                                                                                                                                                                                  v944,
                                                                                                                                                                                                                                                                                  v945,
                                                                                                                                                                                                                                                                                  Cli::method22(v947.try_into().unwrap())]));
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                let v952 =
                                                                                                                                                                                                                                                                    zmq::Context::new();
                                                                                                                                                                                                                                                                let v953 =
                                                                                                                                                                                                                                                                    v952.socket(zmq::REQ).unwrap();
                                                                                                                                                                                                                                                                let v954:
                                                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                                                    stringFrom(format!("tcp://{0}:{1}",
                                                                                                                                                                                                                                                                                       &v397,
                                                                                                                                                                                                                                                                                       &v291));
                                                                                                                                                                                                                                                                v953.connect(&v954.clone()).unwrap();
                                                                                                                                                                                                                                                                v953.send(v927.as_str(), 0).unwrap();
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    let v956:
                                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                                        v953.recv_string(0).unwrap().unwrap();
                                                                                                                                                                                                                                                                    v953.disconnect(&v954).unwrap();
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        let v957:
                                                                                                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                                                                                                            Cli::method5(v419);
                                                                                                                                                                                                                                                                        let v959 =
                                                                                                                                                                                                                                                                            v956.len();
                                                                                                                                                                                                                                                                        Cli::method38(v940,
                                                                                                                                                                                                                                                                                      array(&[v957,
                                                                                                                                                                                                                                                                                              Cli::method22(v959.try_into().unwrap())]));
                                                                                                                                                                                                                                                                        Cli::method32(v212,
                                                                                                                                                                                                                                                                                      array(&[Cli::method5(v427)]));
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            let v967 =
                                                                                                                                                                                                                                                                                v320.wait_with_output().unwrap();
                                                                                                                                                                                                                                                                            Cli::method32(v212,
                                                                                                                                                                                                                                                                                          array(&[Cli::method5(string("output")),
                                                                                                                                                                                                                                                                                                  Cli::method20(format!("{:?}", v967))]));
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                let v974:
                                                                                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                                                                                    v206.unwrap_or(v277);
                                                                                                                                                                                                                                                                                let v975:
                                                                                                                                                                                                                                                                                        Result<(),
                                                                                                                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                                                                                                                    std::fs::write(v974, v907.clone().as_str());
                                                                                                                                                                                                                                                                                *((&v975).as_ref()).unwrap();
                                                                                                                                                                                                                                                                                Cli::method32(v212,
                                                                                                                                                                                                                                                                                              array(&[Cli::method5(string("> fs_write new_fsx_path; ok"))]));
                                                                                                                                                                                                                                                                                Cli::method48(v7,
                                                                                                                                                                                                                                                                                              array(&[Cli::method5(string("fsx.len")),
                                                                                                                                                                                                                                                                                                      Cli::method22(length(v907))]))
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Cli::method48(
            v7,
            array(&[Cli::method5(string("cli end")), Cli::method5(string("???"))]),
        );
        0i32
    }
    pub fn v0() -> Func0<i32> {
        static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        v0.get_or_init(move || Func0::new(move || Cli::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_f02d1879;
pub use module_f02d1879::*;
