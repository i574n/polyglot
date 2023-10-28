#![allow(dead_code)]
#![allow(non_snake_case)]
#![allow(non_camel_case_types)]
#![allow(non_upper_case_globals)]
#![allow(unused_parens)]
#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(unused_attributes)]
pub mod Proxy {
    use super::*;
    use fable_library_rust::Native_::array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Array;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::stringFrom;
    use fable_library_rust::String_::toString;
    pub fn method0() -> (string, string, string, bool) {
        let v0_1: string = string("");
        (v0_1.clone(), v0_1.clone(), v0_1, true)
    }
    pub fn method1(v0_1: string) -> std::string::String {
        (&v0_1).to_string().clone()
    }
    pub fn method2(
        v0_1: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,
    ) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method4(v0_1: i32, v1: string) -> string {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1: MutCell<string> = MutCell::new(v1.clone());
        '_method4: loop {
            break '_method4 (if length(v1.get()) < v0_1.get() {
                let v0_1_temp: i32 = v0_1.get();
                let v1_temp: string = stringFrom(format!("0{0}", &v1.get()));
                v0_1.set(v0_1_temp);
                v1.set(v1_temp);
                continue '_method4;
            } else {
                v1.get()
            });
        }
    }
    pub fn method5(v0_1: u8) -> std::string::String {
        format!("{:?}", &v0_1).clone()
    }
    pub fn method6(v0_1: Array<std::string::String>) -> std::string::String {
        let v2 = core::ops::Deref::deref(&v0_1);
        let v4 = &***&v2;
        let v5 = &***&v4;
        format!("{:?}", &v5).clone()
    }
    pub fn method7(v0_1: string) -> string {
        v0_1
    }
    pub fn method8() -> string {
        string("$1=$2")
    }
    pub fn method9() -> string {
        string("[$1]")
    }
    pub fn method10() -> string {
        string("\"")
    }
    pub fn method11() -> string {
        string(" ")
    }
    pub fn method12() -> string {
        string("006666")
    }
    pub fn method13() -> string {
        string("385779")
    }
    pub fn method3(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Proxy::method4(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Proxy::method6(array(&[
            Proxy::method1(string("timestamp")),
            Proxy::method1(v9),
            Proxy::method1(string("run_id")),
            Proxy::method5(v11),
            Proxy::method1(string("log_level")),
            Proxy::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Proxy::method1(string("> parseUrls ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Proxy::method7(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Proxy::method8();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Proxy::method7(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Proxy::method9();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Proxy::method7(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Proxy::method10();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Proxy::method7(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Proxy::method11();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String = Proxy::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Proxy::method7(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Proxy::method8();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Proxy::method7(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Proxy::method9();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Proxy::method7(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Proxy::method10();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Proxy::method7(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Proxy::method11();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String = Proxy::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Proxy::method7(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Proxy::method8();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Proxy::method7(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Proxy::method9();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Proxy::method7(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Proxy::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Proxy::method7(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Proxy::method11();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String = Proxy::method1(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Proxy::method12();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Proxy::method12();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Proxy::method12();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Proxy::method13();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Proxy::method13();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Proxy::method13();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245))
        );
        ()
    }
    pub fn closure1(
        unitVar: (),
        v0_1: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,
    ) {
        let patternInput: (string, string, string, bool) = Proxy::method0();
        let v6: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        Proxy::method3(
            (&v6).timestamp(),
            array(&[Proxy::method1(string("uri")), Proxy::method2(v0_1)]),
        )
    }
    pub fn method15() -> string {
        string("666666")
    }
    pub fn method14(v0_1: i64, v1: Array<std::string::String>) {
        let v3: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v9: string = Proxy::method4(6i32, toString(&((&v3).timestamp() - v0_1)));
        let v11: u8 = rand::random::<u8>();
        let v23: std::string::String = Proxy::method6(array(&[
            Proxy::method1(string("timestamp")),
            Proxy::method1(v9),
            Proxy::method1(string("run_id")),
            Proxy::method5(v11),
            Proxy::method1(string("log_level")),
            Proxy::method1(string("Debug")),
        ]));
        let v26: Array<std::string::String> = array(&[Proxy::method1(string("> init ()"))]);
        let v28 = core::ops::Deref::deref(&v26);
        let v30 = &***&v28;
        let v31 = &***&v30;
        let v34: std::string::String = format!("{:?}", &v31).clone();
        let v37: string = toString(&format!("{}", &v34));
        let v40: &str = r#""([^"]+)", "([^"]+)""#;
        let v42: regex::RegexBuilder = regex::RegexBuilder::new(&v40);
        let v44: &regex::Regex = &v42.build().unwrap();
        let v45: string = Proxy::method7(v37);
        let v47: &str = &v45.as_str();
        let v48: string = Proxy::method8();
        let v49: &str = &v48.as_str();
        let v51: std::string::String = v44.replace_all(&v47, v49).to_string();
        let v54: string = fable_library_rust::String_::fromStr(&v51);
        let v57: &str = r#"\["(.*?)"\]"#;
        let v58: regex::RegexBuilder = regex::RegexBuilder::new(&v57);
        let v59: &regex::Regex = &v58.build().unwrap();
        let v60: string = Proxy::method7(v54);
        let v61: &str = &v60.as_str();
        let v62: string = Proxy::method9();
        let v63: &str = &v62.as_str();
        let v64: std::string::String = v59.replace_all(&v61, v63).to_string();
        let v66: string = fable_library_rust::String_::fromStr(&v64);
        let v69: &str = r#"\\""#;
        let v70: regex::RegexBuilder = regex::RegexBuilder::new(&v69);
        let v71: &regex::Regex = &v70.build().unwrap();
        let v72: string = Proxy::method7(v66);
        let v73: &str = &v72.as_str();
        let v74: string = Proxy::method10();
        let v75: &str = &v74.as_str();
        let v76: std::string::String = v71.replace_all(&v73, v75).to_string();
        let v78: string = fable_library_rust::String_::fromStr(&v76);
        let v81: &str = r#", "#;
        let v82: regex::RegexBuilder = regex::RegexBuilder::new(&v81);
        let v83: &regex::Regex = &v82.build().unwrap();
        let v84: string = Proxy::method7(v78);
        let v85: &str = &v84.as_str();
        let v86: string = Proxy::method11();
        let v87: &str = &v86.as_str();
        let v88: std::string::String = v83.replace_all(&v85, v87).to_string();
        let v91: std::string::String = Proxy::method1(fable_library_rust::String_::fromStr(&v88));
        let v92 = core::ops::Deref::deref(&v1);
        let v93 = &***&v92;
        let v94 = &***&v93;
        let v96: std::string::String = format!("{:?}", &v94).clone();
        let v98: string = toString(&format!("{}", &v96));
        let v100: &str = r#""([^"]+)", "([^"]+)""#;
        let v101: regex::RegexBuilder = regex::RegexBuilder::new(&v100);
        let v102: &regex::Regex = &v101.build().unwrap();
        let v103: string = Proxy::method7(v98);
        let v104: &str = &v103.as_str();
        let v105: string = Proxy::method8();
        let v106: &str = &v105.as_str();
        let v107: std::string::String = v102.replace_all(&v104, v106).to_string();
        let v109: string = fable_library_rust::String_::fromStr(&v107);
        let v111: &str = r#"\["(.*?)"\]"#;
        let v112: regex::RegexBuilder = regex::RegexBuilder::new(&v111);
        let v113: &regex::Regex = &v112.build().unwrap();
        let v114: string = Proxy::method7(v109);
        let v115: &str = &v114.as_str();
        let v116: string = Proxy::method9();
        let v117: &str = &v116.as_str();
        let v118: std::string::String = v113.replace_all(&v115, v117).to_string();
        let v120: string = fable_library_rust::String_::fromStr(&v118);
        let v122: &str = r#"\\""#;
        let v123: regex::RegexBuilder = regex::RegexBuilder::new(&v122);
        let v124: &regex::Regex = &v123.build().unwrap();
        let v125: string = Proxy::method7(v120);
        let v126: &str = &v125.as_str();
        let v127: string = Proxy::method10();
        let v128: &str = &v127.as_str();
        let v129: std::string::String = v124.replace_all(&v126, v128).to_string();
        let v131: string = fable_library_rust::String_::fromStr(&v129);
        let v133: &str = r#", "#;
        let v134: regex::RegexBuilder = regex::RegexBuilder::new(&v133);
        let v135: &regex::Regex = &v134.build().unwrap();
        let v136: string = Proxy::method7(v131);
        let v137: &str = &v136.as_str();
        let v138: string = Proxy::method11();
        let v139: &str = &v138.as_str();
        let v140: std::string::String = v135.replace_all(&v137, v139).to_string();
        let v143: std::string::String = Proxy::method1(fable_library_rust::String_::fromStr(&v140));
        let v145: string = toString(&format!("{}", &v23));
        let v147: &str = r#""([^"]+)", "([^"]+)""#;
        let v148: regex::RegexBuilder = regex::RegexBuilder::new(&v147);
        let v149: &regex::Regex = &v148.build().unwrap();
        let v150: string = Proxy::method7(v145);
        let v151: &str = &v150.as_str();
        let v152: string = Proxy::method8();
        let v153: &str = &v152.as_str();
        let v154: std::string::String = v149.replace_all(&v151, v153).to_string();
        let v156: string = fable_library_rust::String_::fromStr(&v154);
        let v158: &str = r#"\["(.*?)"\]"#;
        let v159: regex::RegexBuilder = regex::RegexBuilder::new(&v158);
        let v160: &regex::Regex = &v159.build().unwrap();
        let v161: string = Proxy::method7(v156);
        let v162: &str = &v161.as_str();
        let v163: string = Proxy::method9();
        let v164: &str = &v163.as_str();
        let v165: std::string::String = v160.replace_all(&v162, v164).to_string();
        let v167: string = fable_library_rust::String_::fromStr(&v165);
        let v169: &str = r#"\\""#;
        let v170: regex::RegexBuilder = regex::RegexBuilder::new(&v169);
        let v171: &regex::Regex = &v170.build().unwrap();
        let v172: string = Proxy::method7(v167);
        let v173: &str = &v172.as_str();
        let v174: string = Proxy::method10();
        let v175: &str = &v174.as_str();
        let v176: std::string::String = v171.replace_all(&v173, v175).to_string();
        let v178: string = fable_library_rust::String_::fromStr(&v176);
        let v180: &str = r#", "#;
        let v181: regex::RegexBuilder = regex::RegexBuilder::new(&v180);
        let v182: &regex::Regex = &v181.build().unwrap();
        let v183: string = Proxy::method7(v178);
        let v184: &str = &v183.as_str();
        let v185: string = Proxy::method11();
        let v186: &str = &v185.as_str();
        let v187: std::string::String = v182.replace_all(&v184, v186).to_string();
        let v190: std::string::String = Proxy::method1(fable_library_rust::String_::fromStr(&v187));
        let v191: string = Proxy::method15();
        let v192: &str = &v191.as_str();
        let v196: &str = &v192[0i32 as usize..2i32 as usize];
        let v198: string = fable_library_rust::String_::fromStr(&v196);
        let v200: u8 = u8::from_str_radix(&v198, 16).unwrap();
        let v201: string = Proxy::method15();
        let v202: &str = &v201.as_str();
        let v205: &str = &v202[2i32 as usize..4i32 as usize];
        let v207: string = fable_library_rust::String_::fromStr(&v205);
        let v208: u8 = u8::from_str_radix(&v207, 16).unwrap();
        let v209: string = Proxy::method15();
        let v210: &str = &v209.as_str();
        let v213: &str = &v210[4i32 as usize..6i32 as usize];
        let v215: string = fable_library_rust::String_::fromStr(&v213);
        let v216: u8 = u8::from_str_radix(&v215, 16).unwrap();
        let v218: colored::ColoredString =
            colored::Colorize::truecolor(&*v143.to_string(), v200, v208, v216);
        let v219: std::string::String = format!("{}", &v218);
        let v220: string = Proxy::method13();
        let v221: &str = &v220.as_str();
        let v224: &str = &v221[0i32 as usize..2i32 as usize];
        let v226: string = fable_library_rust::String_::fromStr(&v224);
        let v227: u8 = u8::from_str_radix(&v226, 16).unwrap();
        let v228: string = Proxy::method13();
        let v229: &str = &v228.as_str();
        let v232: &str = &v229[2i32 as usize..4i32 as usize];
        let v234: string = fable_library_rust::String_::fromStr(&v232);
        let v235: u8 = u8::from_str_radix(&v234, 16).unwrap();
        let v236: string = Proxy::method13();
        let v237: &str = &v236.as_str();
        let v240: &str = &v237[4i32 as usize..6i32 as usize];
        let v242: string = fable_library_rust::String_::fromStr(&v240);
        let v243: u8 = u8::from_str_radix(&v242, 16).unwrap();
        let v244: colored::ColoredString =
            colored::Colorize::truecolor(&*v190.to_string(), v227, v235, v243);
        let v245: std::string::String = format!("{}", &v244);
        println!(
            "{0}",
            stringFrom(format!("{0} {1} {2}", &v91, &v219, &v245))
        );
        ()
    }
        let patternInput: (string, string, string, bool) = Proxy::method0();
        let v5: chrono::DateTime<chrono::Utc> = chrono::Utc::now();
        let v7: i64 = (&v5).timestamp();
        fn v17(v: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>) {
            Proxy::closure1((), v);
        }
        #[rocket::get("/<uri..>")]
        pub async fn proxy(
            uri: rocket::http::uri::Segments<'_, rocket::http::uri::fmt::Path>,
            client: &rocket::State<reqwest::Client>,
        ) -> Result<rocket::response::content::RawHtml<String>, rocket::http::Status> {
            v17(uri.clone());
            let uri = uri.collect::<Vec<_>>();
            let uri = uri.join("/");
            let uri = uri.replace(":/", "://");
            let (host_url, url) = uri.split_once('|').unwrap_or(("", &uri));
            let (host_protocol, host_host) = host_url
                .split_once("://")
                .unwrap_or(("https", "www.github.com"));
            let (protocol, suffix) = url.split_once("://").unwrap_or((host_protocol, url));
            let (host, path) = match (url.split_once("://"), suffix.split_once("/")) {
                (Some(_), None) if suffix != "" => (suffix, ""),
                _ => (host_host, suffix),
            };
            let new_url = match path {
                "" => format!("{protocol}://{host}"),
                _ => format!("{protocol}://{host}/{path}"),
            };
            println!("uri={uri}; new_url={new_url}; host={host}; path={path}; suffix={suffix}; host_url={host_url}; url={url}; host_host={host_host}; host_protocol={host_protocol}; protocol={protocol}");
            let res = client
                .get(new_url)
                .send()
                .await
                .map_err(|_| rocket::http::Status::NotFound);
            match res {
                Ok(res) => {
                    let content = res.text();
                    let content = content.await;
                    let content = content.map_err(|_| rocket::http::Status::InternalServerError);
                    let content = content.unwrap();
                    Ok(rocket::response::content::RawHtml(content))
                }
                Err(status) => Err(status),
            }
        }
        ();
        #[rocket::get("/file/<file..>")]
        pub async fn file(
            file: std::path::PathBuf,
            client: &rocket::State<reqwest::Client>,
        ) -> std::option::Option<rocket::fs::NamedFile> {
            rocket::fs::NamedFile::open(std::path::Path::new("./").join(file))
                .await
                .ok()
        }
        ();
        ();
        Proxy::method14(
            v7,
            array(&[
                Proxy::method1(string("app end")),
                Proxy::method1(string("???")),
            ]),
        );
        0i32
    }
    pub fn v0() -> Func0<i32> {
        static v0: MutCell<Option<Func0<i32>>> = MutCell::new(None);
        v0.get_or_init(move || Func0::new(move || Proxy::closure0((), ())))
    }
    on_startup!(());
}
#[path = "../rust/Types.rs"]
mod module_33165bf2;
pub use module_33165bf2::*;

#[rocket::launch]
fn rocket() -> _ {
    rocket::build()
        .manage(reqwest::Client::new())
        .mount("/", rocket::routes![Proxy::proxy, Proxy::file])
}
fn main(){}
