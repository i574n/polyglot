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
        Cli::method23(
            v0_1,
            array(&[
                Cli::method5(string("line len")),
                Cli::method22((&v2).len().try_into().unwrap()),
            ]),
        );
        {
            let v10: Vec<u8> = v2.to_owned();
            let v12: std::string::String = std::string::String::from_utf8(v10).unwrap();
            let v13: Lrc<Cli::UH0> = v1.l0.get().clone();
            v1.l0
                .set(Lrc::new(Cli::UH0::UH0_0(v12.clone(), v13.clone())));
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
    pub fn method35() -> string {
        string("e36a62")
    }
    pub fn method34(v0_1: i64, v1: Array<std::string::String>) {
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
        let v214: string = Cli::method35();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method35();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method35();
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
    pub fn method37() -> string {
        string("fcfb1b")
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
        string("98d5ef")
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
    pub fn method40(v0_1: std::time::SystemTime) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method42() -> string {
        string("387957")
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
        let v214: string = Cli::method42();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method42();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method42();
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
    pub fn method43(v0_1: i32, v1: Lrc<Cli::Mut1>) -> bool {
        v1.l0.get() < v0_1
    }
    pub fn method45() -> string {
        string("387958")
    }
    pub fn method44(v0_1: i64, v1: Array<std::string::String>) {
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
        let v214: string = Cli::method45();
        let v216: &str = v214.as_str();
        let v220: &str = &v216[0i32 as usize..2i32 as usize];
        let v222: string = fable_library_rust::String_::fromStr(&v220);
        let v224: u8 = u8::from_str_radix(&v222, 16).unwrap();
        let v225: string = Cli::method45();
        let v227: &str = v225.as_str();
        let v230: &str = &v227[2i32 as usize..4i32 as usize];
        let v232: string = fable_library_rust::String_::fromStr(&v230);
        let v233: u8 = u8::from_str_radix(&v232, 16).unwrap();
        let v234: string = Cli::method45();
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
                                Cli::method7(
                                    v109,
                                    array(&[
                                        Cli::method5(string("text len")),
                                        Cli::method22((&v164).len().try_into().unwrap()),
                                    ]),
                                );
                                {
                                    let v172: Result<(), std::io::Error> =
                                        std::fs::write(v103, v164.as_str());
                                    *((&v172).as_ref()).unwrap();
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
                let v177: string = Cli::method30();
                let v179: &str = v177.as_str();
                let v181: Option<&std::string::String> = v80.get_one::<String>(v179);
                fn v182(v_1: &std::string::String) -> std::string::String {
                    Cli::closure3((), v_1)
                }
                let v184: Option<std::string::String> = v181.map(v182);
                let v188: std::string::String = (&string("get_clap_one: spi-path")).to_string();
                let v190: std::string::String = v184.unwrap_or(v188);
                let v192: std::path::PathBuf = std::path::PathBuf::from(&v190);
                let v194: Result<std::path::PathBuf, std::io::Error> = (&v192).canonicalize();
                let v196: std::path::PathBuf = (&v194).as_ref().unwrap().to_path_buf();
                let v197: string = Cli::method31();
                let v199: &str = v197.as_str();
                let v201: Option<&std::string::String> = v80.get_one::<String>(v199);
                fn v202(v_2: &std::string::String) -> std::path::PathBuf {
                    Cli::closure4((), v_2)
                }
                let v204: Option<std::path::PathBuf> = v201.map(v202);
                let patternInput_4: (string, string, string, bool) = Cli::method0();
                let v209: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                let v210: i64 = (&v209).timestamp();
                let v212: std::string::String = Cli::method5(string("pwd"));
                let v214: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                let v215: std::path::PathBuf = (&v214).as_ref().unwrap().to_path_buf();
                let v216: Result<std::path::PathBuf, std::io::Error> = (&v215).canonicalize();
                let v217: std::path::PathBuf = (&v216).as_ref().unwrap().to_path_buf();
                let v221: string = string("spi_path");
                Cli::method32(
                    v210,
                    array(&[
                        v212,
                        Cli::method5(fable_library_rust::String_::fromStr(&format!(
                            "{}",
                            &v217.display()
                        ))),
                        Cli::method5(v221.clone()),
                        Cli::method5(fable_library_rust::String_::fromStr(&format!(
                            "{}",
                            &v196.display()
                        ))),
                        Cli::method5(string("new_fsx_path")),
                        Cli::method20(format!("{:?}", &v204)),
                    ]),
                );
                {
                    let v232: Option<&std::path::Path> = (&v196).parent();
                    let v234: &std::path::Path = &v232.unwrap();
                    let v235: std::path::PathBuf = std::path::PathBuf::from(&v234);
                    Cli::method32(
                        v210,
                        array(&[
                            Cli::method5(string("src_path")),
                            Cli::method5(fable_library_rust::String_::fromStr(&format!(
                                "{}",
                                &v235.display()
                            ))),
                        ]),
                    );
                    {
                        let v242: &std::path::Ancestors = &v235.ancestors();
                        let v245: _ = v242.take(10i32 as usize);
                        fn v246(v_3: &std::path::Path) -> std::path::PathBuf {
                            Cli::closure5((), v_3)
                        }
                        let v249: _ = v245.into_iter().map((&v246).clone());
                        fn v250(v_4: &std::path::PathBuf) -> bool {
                            Cli::closure6((), v_4)
                        }
                        let v253: Option<std::path::PathBuf> =
                            v249.into_iter().find((&v250).clone());
                        let v254: std::path::PathBuf = (&v253).as_ref().unwrap().to_path_buf();
                        let v255: string = string("spiproj_path");
                        Cli::method32(
                            v210,
                            array(&[
                                Cli::method5(v255.clone()),
                                Cli::method5(fable_library_rust::String_::fromStr(&format!(
                                    "{}",
                                    &v254.display()
                                ))),
                            ]),
                        );
                        {
                            let v261: Option<&str> = (&v196).to_str();
                            let v262: &str = &v261.unwrap();
                            let v265: string = string(".spi");
                            let v268: &str =
                                &v262.replace(&*(&string(".spir")).clone(), &(&v265).clone());
                            let v272: &str =
                                &v268.replace(&*(&v265).clone(), &(&string(".fsx")).clone());
                            let v273: std::path::PathBuf = std::path::PathBuf::from(&v272);
                            let v274: Result<std::path::PathBuf, std::io::Error> =
                                (&v273).canonicalize();
                            let v275: std::path::PathBuf = (&v274).as_ref().unwrap().to_path_buf();
                            let v276: string = string("fsx_path");
                            Cli::method32(
                                v210,
                                array(&[
                                    Cli::method5(v276.clone()),
                                    Cli::method5(fable_library_rust::String_::fromStr(&format!(
                                        "{}",
                                        &v275.display()
                                    ))),
                                ]),
                            );
                            {
                                let v281: string = string("");
                                let v283: Result<(), std::io::Error> =
                                    std::fs::write(v275.clone(), v281.clone().as_str());
                                *((&v283).as_ref()).unwrap();
                                Cli::method32(
                                    v210,
                                    array(&[Cli::method5(string("> fs_write fsx_path \"\"; ok"))]),
                                );
                                {
                                    let v289: Result<std::string::String, std::io::Error> =
                                        std::fs::read_to_string(&v254);
                                    let v291: std::string::String =
                                        (&v289).as_ref().unwrap().to_string();
                                    let patternInput_5: (string, string, string, bool) =
                                        Cli::method0();
                                    let v296: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
                                    let v297: i64 = (&v296).timestamp();
                                    Cli::method34(
                                        v297,
                                        array(&[
                                            Cli::method5(v255),
                                            Cli::method5(fable_library_rust::String_::fromStr(
                                                &format!("{}", &v254.display()),
                                            )),
                                            Cli::method5(string("spiproj_text len")),
                                            Cli::method22((&v291).len().try_into().unwrap()),
                                        ]),
                                    );
                                    {
                                        let v307: string = string("{");
                                        let v310: string = string("\"uri\": $0,");
                                        let v314: string = string("}");
                                        let v317: string = string("serde_json::json!(");
                                        let v319: string = string(").to_string()");
                                        let v320: string = append(
                                            append(
                                                v317.clone(),
                                                append(
                                                    append(
                                                        append(
                                                            append(
                                                                append(
                                                                    v307.clone(),
                                                                    string(
                                                                        "\"ProjectFileOpen\": {",
                                                                    ),
                                                                ),
                                                                v310.clone(),
                                                            ),
                                                            string("\"spiprojText\": $1"),
                                                        ),
                                                        v314.clone(),
                                                    ),
                                                    v314.clone(),
                                                ),
                                            ),
                                            v319.clone(),
                                        );
                                        let v321: std::string::String =
                                            serde_json::json!({"ProjectFileOpen": {"uri": v254,"spiprojText": v291}}).to_string();
                                        Cli::method34(
                                            v297,
                                            array(&[
                                                Cli::method5(string("json len=")),
                                                Cli::method22((&v321).len().try_into().unwrap()),
                                            ]),
                                        );
                                        {
                                            let patternInput_6: (string, string, string, bool) =
                                                Cli::method0();
                                            let v331: chrono::DateTime<chrono::Utc> =
                                                chrono::Utc::now();
                                            let v332: i64 = (&v331).timestamp();
                                            let v333: string = string("host");
                                            let v335: string = string("localhost");
                                            let v337: string = string("port");
                                            let v341: string = string("msg len");
                                            Cli::method36(
                                                v332,
                                                array(&[
                                                    Cli::method5(v333.clone()),
                                                    Cli::method5(v335.clone()),
                                                    Cli::method5(v337.clone()),
                                                    Cli::method22(13805i32),
                                                    Cli::method5(v341.clone()),
                                                    Cli::method22(
                                                        (&v321).len().try_into().unwrap(),
                                                    ),
                                                ]),
                                            );
                                            {
                                                let v347 = zmq::Context::new();
                                                let v349 = v347.socket(zmq::REQ).unwrap();
                                                let v350: string = stringFrom(format!(
                                                    "tcp://{0}:{1}",
                                                    &v335, &13805i32
                                                ));
                                                v349.connect(&v350.clone()).unwrap();
                                                v349.send(v321.as_str(), 0).unwrap();
                                                {
                                                    let v354: std::string::String =
                                                        v349.recv_string(0).unwrap().unwrap();
                                                    v349.disconnect(&v350).unwrap();
                                                    {
                                                        let v356: string = string("result len");
                                                        Cli::method36(
                                                            v332,
                                                            array(&[
                                                                Cli::method5(v356.clone()),
                                                                Cli::method22(
                                                                    (&v354)
                                                                        .len()
                                                                        .try_into()
                                                                        .unwrap(),
                                                                ),
                                                            ]),
                                                        );
                                                        Cli::method32(
                                                            v210,
                                                            array(&[Cli::method5(string(
                                                                "> spiproj_open; ok",
                                                            ))]),
                                                        );
                                                        {
                                                            let patternInput_7: (
                                                                string,
                                                                string,
                                                                string,
                                                                bool,
                                                            ) = Cli::method0();
                                                            let v368: chrono::DateTime<
                                                                chrono::Utc,
                                                            > = chrono::Utc::now();
                                                            let v369: i64 = (&v368).timestamp();
                                                            let v375: string = string("Fsharp");
                                                            Cli::method38(v369,
                                                                          array(&[Cli::method5(v221),
                                                                                  Cli::method5(fable_library_rust::String_::fromStr(&format!("{}", &v196.display()))),
                                                                                  Cli::method5(string("backend")),
                                                                                  Cli::method5(v375.clone())]));
                                                            {
                                                                let v378: std::string::String =
                                                                    (&v375).to_string();
                                                                let v387:
                                                                        string =
                                                                    append(append(v317,
                                                                                  append(append(append(append(append(v307,
                                                                                                                     string("\"BuildFile\": {")),
                                                                                                              v310),
                                                                                                       string("\"backend\": $1")),
                                                                                                v314.clone()),
                                                                                         v314)),
                                                                           v319);
                                                                let v388:
                                                                        std::string::String =
                                                                    serde_json::json!({"BuildFile": {"uri": v196,"backend": v378}}).to_string();
                                                                Cli::method38(
                                                                    v369,
                                                                    array(&[
                                                                        Cli::method5(string(
                                                                            "json len",
                                                                        )),
                                                                        Cli::method22(
                                                                            (&v388)
                                                                                .len()
                                                                                .try_into()
                                                                                .unwrap(),
                                                                        ),
                                                                    ]),
                                                                );
                                                                {
                                                                    let patternInput_8: (
                                                                        string,
                                                                        string,
                                                                        string,
                                                                        bool,
                                                                    ) = Cli::method0();
                                                                    let v398: chrono::DateTime<
                                                                        chrono::Utc,
                                                                    > = chrono::Utc::now();
                                                                    let v399: i64 =
                                                                        (&v398).timestamp();
                                                                    Cli::method36(
                                                                        v399,
                                                                        array(&[
                                                                            Cli::method5(v333),
                                                                            Cli::method5(
                                                                                v335.clone(),
                                                                            ),
                                                                            Cli::method5(v337),
                                                                            Cli::method22(13805i32),
                                                                            Cli::method5(v341),
                                                                            Cli::method22(
                                                                                (&v388)
                                                                                    .len()
                                                                                    .try_into()
                                                                                    .unwrap(),
                                                                            ),
                                                                        ]),
                                                                    );
                                                                    {
                                                                        let v409 =
                                                                            zmq::Context::new();
                                                                        let v410 = v409
                                                                            .socket(zmq::REQ)
                                                                            .unwrap();
                                                                        let v411: string =
                                                                            stringFrom(format!(
                                                                                "tcp://{0}:{1}",
                                                                                &v335, &13805i32
                                                                            ));
                                                                        v410.connect(&v411.clone())
                                                                            .unwrap();
                                                                        v410.send(v388.as_str(), 0)
                                                                            .unwrap();
                                                                        {
                                                                            let v413:
                                                                                    std::string::String =
                                                                                v410.recv_string(0).unwrap().unwrap();
                                                                            v410.disconnect(&v411)
                                                                                .unwrap();
                                                                            Cli::method36(v399,
                                                                                          array(&[Cli::method5(v356),
                                                                                                  Cli::method22((&v413).len().try_into().unwrap())]));
                                                                            Cli::method32(v210,
                                                                                          array(&[Cli::method5(string("> spi_build_file; ok"))]));
                                                                            {
                                                                                let patternInput_9:
                                                                                        (string,
                                                                                         string,
                                                                                         string,
                                                                                         bool) =
                                                                                    Cli::method0();
                                                                                let v425:
                                                                                        chrono::DateTime<chrono::Utc> =
                                                                                    chrono::Utc::now();
                                                                                let v426: i64 =
                                                                                    (&v425)
                                                                                        .timestamp(
                                                                                        );
                                                                                let v428:
                                                                                        std::time::SystemTime =
                                                                                    std::fs::metadata(&v275).unwrap().modified().unwrap();
                                                                                Cli::method41(v426,
                                                                                              array(&[Cli::method5(v276),
                                                                                                      Cli::method5(fable_library_rust::String_::fromStr(&format!("{}", &v275.display()))),
                                                                                                      Cli::method5(string("start")),
                                                                                                      Cli::method40(v428.clone())]));
                                                                                {
                                                                                    let v436:
                                                                                            Array<i32> =
                                                                                        toArray(rangeNumeric(0i32,
                                                                                                             1i32,
                                                                                                             50i32).clone());
                                                                                    let v437: i32 =
                                                                                        v436.len()
                                                                                            as i32;
                                                                                    let v439:
                                                                                            Lrc<Cli::Mut1> =
                                                                                        Lrc::new(Cli::Mut1{l0:
                                                                                                               MutCell::new(0i32),
                                                                                                           l1:
                                                                                                               MutCell::new(Cli::US0::US0_0),});
                                                                                    while Cli::method43(v437,
                                                                                                        v439.clone())
                                                                                          {
                                                                                        let v441:
                                                                                                i32 =
                                                                                            v439.l0.get();
                                                                                        let v442:
                                                                                                Cli::US0 =
                                                                                            v439.l1.get().clone();
                                                                                        let v443:
                                                                                                i32 =
                                                                                            v436[v441].clone();
                                                                                        let v465:
                                                                                                Cli::US0 =
                                                                                            match &v442
                                                                                                {
                                                                                                Cli::US0::US0_1(v442_1_0)
                                                                                                =>
                                                                                                Cli::US0::US0_1(v442_1_0.clone()),
                                                                                                _
                                                                                                =>
                                                                                                {
                                                                                                    let v446:
                                                                                                            std::time::SystemTime =
                                                                                                        std::fs::metadata(&v275).unwrap().modified().unwrap();
                                                                                                    Cli::method41(v426,
                                                                                                                  array(&[Cli::method5(string("i")),
                                                                                                                          Cli::method22(v443),
                                                                                                                          Cli::method5(string("last_modified")),
                                                                                                                          Cli::method40(v446.clone())]));
                                                                                                    if v446 > v428
                                                                                                       {
                                                                                                        let v456:
                                                                                                                Result<std::string::String,
                                                                                                                       std::io::Error> =
                                                                                                            std::fs::read_to_string(&v275);
                                                                                                        let v457:
                                                                                                                std::string::String =
                                                                                                            (&v456).as_ref().unwrap().to_string();
                                                                                                        Cli::US0::US0_1(fable_library_rust::String_::fromStr(&v457))
                                                                                                    } else {
                                                                                                        std::thread::sleep(std::time::Duration::from_millis(*&25u64));
                                                                                                        Cli::US0::US0_0
                                                                                                    }
                                                                                                }
                                                                                            };
                                                                                        let v466:
                                                                                                i32 =
                                                                                            v441
                                                                                                +
                                                                                                1i32;
                                                                                        v439.l0.set(v466);
                                                                                        v439.l1.set(v465.clone());
                                                                                        ()
                                                                                    }
                                                                                    {
                                                                                        let v467:
                                                                                                Cli::US0 =
                                                                                            v439.l1.get().clone();
                                                                                        let v470:
                                                                                                string =
                                                                                            match &v467
                                                                                                {
                                                                                                Cli::US0::US0_1(v467_1_0)
                                                                                                =>
                                                                                                v467_1_0.clone(),
                                                                                                _
                                                                                                =>
                                                                                                v281,
                                                                                            };
                                                                                        Cli::method32(v210,
                                                                                                      array(&[Cli::method5(string("new_fsx len")),
                                                                                                              Cli::method22((&v470).len().try_into().unwrap())]));
                                                                                        {
                                                                                            let v477:
                                                                                                    std::path::PathBuf =
                                                                                                v204.unwrap_or(v275);
                                                                                            let v478:
                                                                                                    Result<(),
                                                                                                           std::io::Error> =
                                                                                                std::fs::write(v477, v470.clone().as_str());
                                                                                            *((&v478).as_ref()).unwrap();
                                                                                            Cli::method32(v210,
                                                                                                          array(&[Cli::method5(string("> fs_write new_fsx_path; ok"))]));
                                                                                            Cli::method44(v7,
                                                                                                          array(&[Cli::method5(string("fsx.len")),
                                                                                                                  Cli::method22(length(v470))]))
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
        Cli::method44(
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
