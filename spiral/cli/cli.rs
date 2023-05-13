#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
pub mod Cli {
    use super::*;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Array::new_array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toString;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
    }
    impl core::fmt::Display for Cli::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method0(v0_1: Option<std::string::String>) -> Option<std::string::String> {
        v0_1
    }
    pub fn method1(v0_1: std::string::String) -> std::string::String {
        v0_1
    }
    pub fn closure1(unitVar: (), v0_1: std::string::String) -> string {
        let v1: std::string::String = Cli::method1(v0_1);
        fable_library_rust::String_::fromString(v1)
    }
    pub fn method2() -> (string, string, string, bool) {
        let v1 = &string("");
        (string(""), string(""), string(""), true)
    }
    pub fn method3(v0_1: string) -> std::string::String {
        String::from(core::ops::Deref::deref(&v0_1)).clone()
    }
    pub fn method5(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method5: loop {
            break '_method5 (if length(v1.get()) < v0_1.get() {
                let v0_1_temp: i32 = v0_1.get();
                let v1_temp: string = sprintf!("0{}", &v1.get());
                v0_1.set(v0_1_temp);
                v1.set(v1_temp);
                continue '_method5;
            } else {
                v1.get()
            });
        }
    }
    pub fn method6(v0_1: u8) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method7(v0_1: std::string::String) -> std::string::String {
        (&v0_1).clone()
    }
    pub fn method8(v0_1: Array<std::string::String>) -> std::string::String {
        let v2: &Array<std::string::String> = &v0_1;
        let v5 = core::ops::Deref::deref(v2);
        format!("{:?}", v5).clone()
    }
    pub fn method9(v0_1: string) -> string {
        v0_1
    }
    pub fn method10() -> string {
        string("$1=$2")
    }
    pub fn method11() -> string {
        string("[$1]")
    }
    pub fn method12() -> string {
        string("\"")
    }
    pub fn method13() -> string {
        string(" ")
    }
    pub fn method14() -> string {
        string("387958")
    }
    pub fn method15() -> string {
        string("385779")
    }
    pub fn method4(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Cli::method5(6_i32, toString((&v3).timestamp() - v0_1));
        let v11: u8 = rand::random::<u8>();
        let v25: std::string::String = Cli::method8(new_array(&[
            Cli::method3(string("timestamp")),
            Cli::method3(v9),
            Cli::method3(string("run_id")),
            Cli::method6(v11),
            Cli::method3(string("log_level")),
            Cli::method7(format!("{:?}", &Cli::US0::US0_0)),
        ]));
        let v28: Array<std::string::String> = new_array(&[Cli::method3(string("> app ()"))]);
        let v30: &Array<std::string::String> = &v28;
        let v33 = core::ops::Deref::deref(v30);
        let v35: std::string::String = format!("{:?}", v33).clone();
        let v38: string = toString(format!("{}", &v35));
        let v40: string = string("r#\"\"([^\"]+)\", \"([^\"]+)\"\"#");
        let v41: &str = r#""([^"]+)", "([^"]+)""#;
        let v43: regex::RegexBuilder = regex::RegexBuilder::new(&v41);
        let v45: &regex::Regex = &v43.build().unwrap();
        let v46: string = Cli::method9(v38);
        let v48: &str = v46.as_str();
        let v49: string = Cli::method10();
        let v51: &str = v49.as_str();
        let v54: std::string::String = Cli::method1(v45.replace_all(&v48, v51).to_string());
        let v56: string = fable_library_rust::String_::fromString(v54);
        let v58: string = string("r#\"\\[\"(.*?)\"\\]\"#");
        let v59: &str = r#"\["(.*?)"\]"#;
        let v60: regex::RegexBuilder = regex::RegexBuilder::new(&v59);
        let v61: &regex::Regex = &v60.build().unwrap();
        let v62: string = Cli::method9(v56);
        let v64: &str = v62.as_str();
        let v65: string = Cli::method11();
        let v67: &str = v65.as_str();
        let v69: std::string::String = Cli::method1(v61.replace_all(&v64, v67).to_string());
        let v71: string = fable_library_rust::String_::fromString(v69);
        let v73: string = string("r#\"\\\\\"\"#");
        let v74: &str = r#"\\""#;
        let v75: regex::RegexBuilder = regex::RegexBuilder::new(&v74);
        let v76: &regex::Regex = &v75.build().unwrap();
        let v77: string = Cli::method9(v71);
        let v79: &str = v77.as_str();
        let v80: string = Cli::method12();
        let v82: &str = v80.as_str();
        let v84: std::string::String = Cli::method1(v76.replace_all(&v79, v82).to_string());
        let v86: string = fable_library_rust::String_::fromString(v84);
        let v88: string = string("r#\", \"#");
        let v89: &str = r#", "#;
        let v90: regex::RegexBuilder = regex::RegexBuilder::new(&v89);
        let v91: &regex::Regex = &v90.build().unwrap();
        let v92: string = Cli::method9(v86);
        let v94: &str = v92.as_str();
        let v95: string = Cli::method13();
        let v97: &str = v95.as_str();
        let v99: std::string::String = Cli::method1(v91.replace_all(&v94, v97).to_string());
        let v102: std::string::String = Cli::method3(fable_library_rust::String_::fromString(v99));
        let v104: &Array<std::string::String> = &v1;
        let v107 = core::ops::Deref::deref(v104);
        let v109: std::string::String = format!("{:?}", v107).clone();
        let v111: string = toString(format!("{}", &v109));
        let v112: string = string("r#\"\"([^\"]+)\", \"([^\"]+)\"\"#");
        let v113: &str = r#""([^"]+)", "([^"]+)""#;
        let v114: regex::RegexBuilder = regex::RegexBuilder::new(&v113);
        let v115: &regex::Regex = &v114.build().unwrap();
        let v116: string = Cli::method9(v111);
        let v118: &str = v116.as_str();
        let v119: string = Cli::method10();
        let v121: &str = v119.as_str();
        let v123: std::string::String = Cli::method1(v115.replace_all(&v118, v121).to_string());
        let v125: string = fable_library_rust::String_::fromString(v123);
        let v126: string = string("r#\"\\[\"(.*?)\"\\]\"#");
        let v127: &str = r#"\["(.*?)"\]"#;
        let v128: regex::RegexBuilder = regex::RegexBuilder::new(&v127);
        let v129: &regex::Regex = &v128.build().unwrap();
        let v130: string = Cli::method9(v125);
        let v132: &str = v130.as_str();
        let v133: string = Cli::method11();
        let v135: &str = v133.as_str();
        let v137: std::string::String = Cli::method1(v129.replace_all(&v132, v135).to_string());
        let v139: string = fable_library_rust::String_::fromString(v137);
        let v140: string = string("r#\"\\\\\"\"#");
        let v141: &str = r#"\\""#;
        let v142: regex::RegexBuilder = regex::RegexBuilder::new(&v141);
        let v143: &regex::Regex = &v142.build().unwrap();
        let v144: string = Cli::method9(v139);
        let v146: &str = v144.as_str();
        let v147: string = Cli::method12();
        let v149: &str = v147.as_str();
        let v151: std::string::String = Cli::method1(v143.replace_all(&v146, v149).to_string());
        let v153: string = fable_library_rust::String_::fromString(v151);
        let v154: string = string("r#\", \"#");
        let v155: &str = r#", "#;
        let v156: regex::RegexBuilder = regex::RegexBuilder::new(&v155);
        let v157: &regex::Regex = &v156.build().unwrap();
        let v158: string = Cli::method9(v153);
        let v160: &str = v158.as_str();
        let v161: string = Cli::method13();
        let v163: &str = v161.as_str();
        let v165: std::string::String = Cli::method1(v157.replace_all(&v160, v163).to_string());
        let v168: std::string::String = Cli::method3(fable_library_rust::String_::fromString(v165));
        let v170: string = toString(format!("{}", &v25));
        let v171: string = string("r#\"\"([^\"]+)\", \"([^\"]+)\"\"#");
        let v172: &str = r#""([^"]+)", "([^"]+)""#;
        let v173: regex::RegexBuilder = regex::RegexBuilder::new(&v172);
        let v174: &regex::Regex = &v173.build().unwrap();
        let v175: string = Cli::method9(v170);
        let v177: &str = v175.as_str();
        let v178: string = Cli::method10();
        let v180: &str = v178.as_str();
        let v182: std::string::String = Cli::method1(v174.replace_all(&v177, v180).to_string());
        let v184: string = fable_library_rust::String_::fromString(v182);
        let v185: string = string("r#\"\\[\"(.*?)\"\\]\"#");
        let v186: &str = r#"\["(.*?)"\]"#;
        let v187: regex::RegexBuilder = regex::RegexBuilder::new(&v186);
        let v188: &regex::Regex = &v187.build().unwrap();
        let v189: string = Cli::method9(v184);
        let v191: &str = v189.as_str();
        let v192: string = Cli::method11();
        let v194: &str = v192.as_str();
        let v196: std::string::String = Cli::method1(v188.replace_all(&v191, v194).to_string());
        let v198: string = fable_library_rust::String_::fromString(v196);
        let v199: string = string("r#\"\\\\\"\"#");
        let v200: &str = r#"\\""#;
        let v201: regex::RegexBuilder = regex::RegexBuilder::new(&v200);
        let v202: &regex::Regex = &v201.build().unwrap();
        let v203: string = Cli::method9(v198);
        let v205: &str = v203.as_str();
        let v206: string = Cli::method12();
        let v208: &str = v206.as_str();
        let v210: std::string::String = Cli::method1(v202.replace_all(&v205, v208).to_string());
        let v212: string = fable_library_rust::String_::fromString(v210);
        let v213: string = string("r#\", \"#");
        let v214: &str = r#", "#;
        let v215: regex::RegexBuilder = regex::RegexBuilder::new(&v214);
        let v216: &regex::Regex = &v215.build().unwrap();
        let v217: string = Cli::method9(v212);
        let v219: &str = v217.as_str();
        let v220: string = Cli::method13();
        let v222: &str = v220.as_str();
        let v224: std::string::String = Cli::method1(v216.replace_all(&v219, v222).to_string());
        let v227: std::string::String = Cli::method3(fable_library_rust::String_::fromString(v224));
        let v228: string = Cli::method14();
        let v230: &str = v228.as_str();
        let v231: usize = 0_i32 as usize;
        let v232: usize = 2_i32 as usize;
        let v234: &str = &v230[v231..v232];
        let v236: string = fable_library_rust::String_::string(v234);
        let v238: u8 = u8::from_str_radix(&v236, 16).unwrap();
        let v239: string = Cli::method14();
        let v241: &str = v239.as_str();
        let v242: usize = 2_i32 as usize;
        let v243: usize = 4_i32 as usize;
        let v244: &str = &v241[v242..v243];
        let v246: string = fable_library_rust::String_::string(v244);
        let v247: u8 = u8::from_str_radix(&v246, 16).unwrap();
        let v248: string = Cli::method14();
        let v250: &str = v248.as_str();
        let v251: usize = 4_i32 as usize;
        let v252: usize = 6_i32 as usize;
        let v253: &str = &v250[v251..v252];
        let v255: string = fable_library_rust::String_::string(v253);
        let v256: u8 = u8::from_str_radix(&v255, 16).unwrap();
        let v258: colored::ColoredString =
            colored::Colorize::truecolor(&*v168.to_string(), v238, v247, v256);
        let v259: std::string::String = format!("{}", &v258);
        let v260: string = Cli::method15();
        let v262: &str = v260.as_str();
        let v263: usize = 0_i32 as usize;
        let v264: usize = 2_i32 as usize;
        let v265: &str = &v262[v263..v264];
        let v267: string = fable_library_rust::String_::string(v265);
        let v268: u8 = u8::from_str_radix(&v267, 16).unwrap();
        let v269: string = Cli::method15();
        let v271: &str = v269.as_str();
        let v272: usize = 2_i32 as usize;
        let v273: usize = 4_i32 as usize;
        let v274: &str = &v271[v272..v273];
        let v276: string = fable_library_rust::String_::string(v274);
        let v277: u8 = u8::from_str_radix(&v276, 16).unwrap();
        let v278: string = Cli::method15();
        let v280: &str = v278.as_str();
        let v281: usize = 4_i32 as usize;
        let v282: usize = 6_i32 as usize;
        let v283: &str = &v280[v281..v282];
        let v285: string = fable_library_rust::String_::string(v283);
        let v286: u8 = u8::from_str_radix(&v285, 16).unwrap();
        let v287: colored::ColoredString =
            colored::Colorize::truecolor(&*v227.to_string(), v268, v277, v286);
        let v289: string = sprintf!("{} {} {}", &v102, &v259, format!("{}", &v287));
        println!("{0}", v289,);
        ()
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let v1: string = string("r#\"test1\"#");
        let v2: &str = r#"test1"#;
        let v6: Option<std::string::String> =
            Cli::method0(Some(String::from(core::ops::Deref::deref(&v2))));
        let v9: Option<string> = v6.map(&*Func1::new(move |v: std::string::String| {
            Cli::closure1((), v.clone())
        }));
        let v11: std::string::String = format!("{:?}", &v9);
        println!("{0}", &v11,);
        {
            let patternInput: (string, string, string, bool) = Cli::method2();
            let v17: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
            let v19: i64 = (&v17).timestamp();
            let v21: string = string("r#\"app1\"#");
            let v22: &str = r#"app1"#;
            let v33: string =
                string("clap::Command::new(v22).version(env!(\"CARGO_PKG_VERSION\")).propagate_version(true).subcommand_required(false).about(\"command about\").arg_required_else_help(true)");
            let v34: clap::builder::Command = clap::Command::new(v22)
                .version(env!("CARGO_PKG_VERSION"))
                .propagate_version(true)
                .subcommand_required(false)
                .about("command about")
                .arg_required_else_help(true);
            let v36: string = string("r#\"PostFsxRsBuild\"#");
            let v37: &str = r#"PostFsxRsBuild"#;
            let v43: string =
                string("clap::Command::new(v37).version(env!(\"CARGO_PKG_VERSION\")).propagate_version(true).subcommand_required(false).about(\"command about\").arg_required_else_help(true)");
            let v44: clap::builder::Command = clap::Command::new(v37)
                .version(env!("CARGO_PKG_VERSION"))
                .propagate_version(true)
                .subcommand_required(false)
                .about("command about")
                .arg_required_else_help(true);
            let v46: string = string("r#\"rs-path\"#");
            let v47: &str = r#"rs-path"#;
            let v49: clap::builder::Arg = clap::Arg::new(v47);
            let v51: clap::builder::Command = v44.arg(v49);
            let v53: clap::builder::Command = v34.subcommand(v51);
            let v55: string = string("r#\"SpiFsxBuild\"#");
            let v56: &str = r#"SpiFsxBuild"#;
            let v62: string =
                string("clap::Command::new(v56).version(env!(\"CARGO_PKG_VERSION\")).propagate_version(true).subcommand_required(false).about(\"command about\").arg_required_else_help(true)");
            let v63: clap::builder::Command = clap::Command::new(v56)
                .version(env!("CARGO_PKG_VERSION"))
                .propagate_version(true)
                .subcommand_required(false)
                .about("command about")
                .arg_required_else_help(true);
            let v65: string = string("r#\"spi-path\"#");
            let v66: &str = r#"spi-path"#;
            let v68: clap::builder::Arg = clap::Arg::new(v66);
            let v70: clap::builder::Command = v63.arg(v68);
            let v72: string = string("r#\"fsx-path\"#");
            let v73: &str = r#"fsx-path"#;
            let v75: clap::builder::Arg = clap::Arg::new(v73);
            let v77: clap::builder::Command = v70.arg(v75);
            let v79: clap::builder::Command = v53.subcommand(v77);
            let v81: clap::parser::ArgMatches = v79.get_matches();
            let v83: std::sync::Arc<clap::parser::ArgMatches> = std::sync::Arc::new(v81);
            let v85: Option<(&str, std::sync::Arc<clap::parser::ArgMatches>)> = v83
                .subcommand()
                .map(|(name, matches)| (name, std::sync::Arc::new(matches.clone())));
            let patternInput_1: (&str, std::sync::Arc<clap::parser::ArgMatches>) = v85.unwrap();
            let v89 = &(patternInput_1.0.clone(), patternInput_1.1.clone());
            let v91: &str = v89.0;
            let v93: std::sync::Arc<clap::parser::ArgMatches> = std::sync::Arc::clone(&v89.1);
            Cli::method4(
                v19,
                new_array(&[Cli::method3(string("cli end")), Cli::method3(string("???"))]),
            );
            0_i32
        }
    }
    pub fn v0() -> Func0<i32> {
        static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        v0.get_or_init(|| Func0::new(move || Cli::closure0((), ())))
    }
    on_startup!((),);
}
#[path = "../rust/Types.rs"]
mod module_cd193dc2;
pub use module_cd193dc2::*;
