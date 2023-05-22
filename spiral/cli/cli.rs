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
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::substring2;
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
    pub fn method9(v0_1: &str) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method10(v0_1: string) -> string {
        v0_1
    }
    pub fn method11() -> string {
        string("$1=$2")
    }
    pub fn method12() -> string {
        string("[$1]")
    }
    pub fn method13() -> string {
        string("\"")
    }
    pub fn method14() -> string {
        string(" ")
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
        let v27: string = string("r#\"> app ()\"#");
        let v30: Array<std::string::String> = new_array(&[Cli::method9(r#"> app ()"#)]);
        let v32: &Array<std::string::String> = &v30;
        let v35 = core::ops::Deref::deref(v32);
        let v37: std::string::String = format!("{:?}", v35).clone();
        let v40: string = toString(format!("{}", &v37));
        let v42: string = string("r#\"\"([^\"]+)\", \"([^\"]+)\"\"#");
        let v43: &str = r#""([^"]+)", "([^"]+)""#;
        let v45: regex::RegexBuilder = regex::RegexBuilder::new(&v43);
        let v47: &regex::Regex = &v45.build().unwrap();
        let v48: string = Cli::method10(v40);
        let v50: &str = v48.as_str();
        let v51: string = Cli::method11();
        let v53: &str = v51.as_str();
        let v56: std::string::String = Cli::method1(v47.replace_all(&v50, v53).to_string());
        let v58: string = fable_library_rust::String_::fromString(v56);
        let v60: string = string("r#\"\\[\"(.*?)\"\\]\"#");
        let v61: &str = r#"\["(.*?)"\]"#;
        let v62: regex::RegexBuilder = regex::RegexBuilder::new(&v61);
        let v63: &regex::Regex = &v62.build().unwrap();
        let v64: string = Cli::method10(v58);
        let v66: &str = v64.as_str();
        let v67: string = Cli::method12();
        let v69: &str = v67.as_str();
        let v71: std::string::String = Cli::method1(v63.replace_all(&v66, v69).to_string());
        let v73: string = fable_library_rust::String_::fromString(v71);
        let v75: string = string("r#\"\\\\\"\"#");
        let v76: &str = r#"\\""#;
        let v77: regex::RegexBuilder = regex::RegexBuilder::new(&v76);
        let v78: &regex::Regex = &v77.build().unwrap();
        let v79: string = Cli::method10(v73);
        let v81: &str = v79.as_str();
        let v82: string = Cli::method13();
        let v84: &str = v82.as_str();
        let v86: std::string::String = Cli::method1(v78.replace_all(&v81, v84).to_string());
        let v88: string = fable_library_rust::String_::fromString(v86);
        let v90: string = string("r#\", \"#");
        let v91: &str = r#", "#;
        let v92: regex::RegexBuilder = regex::RegexBuilder::new(&v91);
        let v93: &regex::Regex = &v92.build().unwrap();
        let v94: string = Cli::method10(v88);
        let v96: &str = v94.as_str();
        let v97: string = Cli::method14();
        let v99: &str = v97.as_str();
        let v101: std::string::String = Cli::method1(v93.replace_all(&v96, v99).to_string());
        let v104: std::string::String = Cli::method3(fable_library_rust::String_::fromString(v101));
        let v106: &Array<std::string::String> = &v1;
        let v109 = core::ops::Deref::deref(v106);
        let v111: std::string::String = format!("{:?}", v109).clone();
        let v113: string = toString(format!("{}", &v111));
        let v114: string = string("r#\"\"([^\"]+)\", \"([^\"]+)\"\"#");
        let v115: &str = r#""([^"]+)", "([^"]+)""#;
        let v116: regex::RegexBuilder = regex::RegexBuilder::new(&v115);
        let v117: &regex::Regex = &v116.build().unwrap();
        let v118: string = Cli::method10(v113);
        let v120: &str = v118.as_str();
        let v121: string = Cli::method11();
        let v123: &str = v121.as_str();
        let v125: std::string::String = Cli::method1(v117.replace_all(&v120, v123).to_string());
        let v127: string = fable_library_rust::String_::fromString(v125);
        let v128: string = string("r#\"\\[\"(.*?)\"\\]\"#");
        let v129: &str = r#"\["(.*?)"\]"#;
        let v130: regex::RegexBuilder = regex::RegexBuilder::new(&v129);
        let v131: &regex::Regex = &v130.build().unwrap();
        let v132: string = Cli::method10(v127);
        let v134: &str = v132.as_str();
        let v135: string = Cli::method12();
        let v137: &str = v135.as_str();
        let v139: std::string::String = Cli::method1(v131.replace_all(&v134, v137).to_string());
        let v141: string = fable_library_rust::String_::fromString(v139);
        let v142: string = string("r#\"\\\\\"\"#");
        let v143: &str = r#"\\""#;
        let v144: regex::RegexBuilder = regex::RegexBuilder::new(&v143);
        let v145: &regex::Regex = &v144.build().unwrap();
        let v146: string = Cli::method10(v141);
        let v148: &str = v146.as_str();
        let v149: string = Cli::method13();
        let v151: &str = v149.as_str();
        let v153: std::string::String = Cli::method1(v145.replace_all(&v148, v151).to_string());
        let v155: string = fable_library_rust::String_::fromString(v153);
        let v156: string = string("r#\", \"#");
        let v157: &str = r#", "#;
        let v158: regex::RegexBuilder = regex::RegexBuilder::new(&v157);
        let v159: &regex::Regex = &v158.build().unwrap();
        let v160: string = Cli::method10(v155);
        let v162: &str = v160.as_str();
        let v163: string = Cli::method14();
        let v165: &str = v163.as_str();
        let v167: std::string::String = Cli::method1(v159.replace_all(&v162, v165).to_string());
        let v170: std::string::String = Cli::method3(fable_library_rust::String_::fromString(v167));
        let v172: string = toString(format!("{}", &v25));
        let v173: string = string("r#\"\"([^\"]+)\", \"([^\"]+)\"\"#");
        let v174: &str = r#""([^"]+)", "([^"]+)""#;
        let v175: regex::RegexBuilder = regex::RegexBuilder::new(&v174);
        let v176: &regex::Regex = &v175.build().unwrap();
        let v177: string = Cli::method10(v172);
        let v179: &str = v177.as_str();
        let v180: string = Cli::method11();
        let v182: &str = v180.as_str();
        let v184: std::string::String = Cli::method1(v176.replace_all(&v179, v182).to_string());
        let v186: string = fable_library_rust::String_::fromString(v184);
        let v187: string = string("r#\"\\[\"(.*?)\"\\]\"#");
        let v188: &str = r#"\["(.*?)"\]"#;
        let v189: regex::RegexBuilder = regex::RegexBuilder::new(&v188);
        let v190: &regex::Regex = &v189.build().unwrap();
        let v191: string = Cli::method10(v186);
        let v193: &str = v191.as_str();
        let v194: string = Cli::method12();
        let v196: &str = v194.as_str();
        let v198: std::string::String = Cli::method1(v190.replace_all(&v193, v196).to_string());
        let v200: string = fable_library_rust::String_::fromString(v198);
        let v201: string = string("r#\"\\\\\"\"#");
        let v202: &str = r#"\\""#;
        let v203: regex::RegexBuilder = regex::RegexBuilder::new(&v202);
        let v204: &regex::Regex = &v203.build().unwrap();
        let v205: string = Cli::method10(v200);
        let v207: &str = v205.as_str();
        let v208: string = Cli::method13();
        let v210: &str = v208.as_str();
        let v212: std::string::String = Cli::method1(v204.replace_all(&v207, v210).to_string());
        let v214: string = fable_library_rust::String_::fromString(v212);
        let v215: string = string("r#\", \"#");
        let v216: &str = r#", "#;
        let v217: regex::RegexBuilder = regex::RegexBuilder::new(&v216);
        let v218: &regex::Regex = &v217.build().unwrap();
        let v219: string = Cli::method10(v214);
        let v221: &str = v219.as_str();
        let v222: string = Cli::method14();
        let v224: &str = v222.as_str();
        let v226: std::string::String = Cli::method1(v218.replace_all(&v221, v224).to_string());
        let v229: std::string::String = Cli::method3(fable_library_rust::String_::fromString(v226));
        let v231: string = substring2(string("387958"), 0_i32, 2_i32);
        let v233: u8 = u8::from_str_radix(&v231, 16).unwrap();
        let v234: string = substring2(string("387958"), 2_i32, 4_i32);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = substring2(string("387958"), 4_i32, 6_i32);
        let v237: u8 = u8::from_str_radix(&v236, 16).unwrap();
        let v239: colored::ColoredString =
            colored::Colorize::truecolor(&*v170.to_string(), v233, v235, v237);
        let v240: std::string::String = format!("{}", &v239);
        let v242: string = substring2(string("385779"), 0_i32, 2_i32);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: string = substring2(string("385779"), 2_i32, 4_i32);
        let v245: u8 = u8::from_str_radix(&v244, 16).unwrap();
        let v246: string = substring2(string("385779"), 4_i32, 6_i32);
        let v247: u8 = u8::from_str_radix(&v246, 16).unwrap();
        let v248: colored::ColoredString =
            colored::Colorize::truecolor(&*v229.to_string(), v243, v245, v247);
        let v250: string = sprintf!("{} {} {}", &v104, &v240, format!("{}", &v248));
        println!("{0}", v250,);
        ()
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> i32 {
        let v1: string = string("r#\"cli2\"#");
        let v2: &str = r#"cli2"#;
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
