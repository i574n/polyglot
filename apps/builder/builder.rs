#![allow(unused_mut, unused_variables, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_patterns, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return Rc::<str>::from(""); }
    match std::str::from_utf8(&bytes[from as usize..(to + 1) as usize]) { Ok(slice) => Rc::<str>::from(slice), Err(_) => std::process::abort() }
}
#[derive(Clone)]
enum US0 {
    US0_0,
    US0_1,
}
impl US0 {
    fn tag(&self) -> i32 {
        match self {
            US0::US0_0 => 0,
            US0::US0_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US1 {
    US1_2(Rc<str>, Rc<str>),
}
impl US1 {
    fn tag(&self) -> i32 {
        match self {
            US1::US1_2(..) => 2,
        }
    }
}
#[derive(Clone)]
enum US2 {
    US2_0(Rc<str>),
    US2_1,
}
impl US2 {
    fn tag(&self) -> i32 {
        match self {
            US2::US2_0(..) => 0,
            US2::US2_1 => 1,
        }
    }
}
fn method0(mut v0: Rc<str>, mut v1: i32, mut v2: Rc<str>) -> i32 {
    loop {
        let mut v3: i32 = (v0.clone().len() as i32);
        let mut v4: i32 = (v2.clone().len() as i32);
        let mut v5: i32 = v1 + v4;
        let mut v6: bool = v5 > v3;
        if v6 {
            return -1i32;
        } else {
            let mut v7: i32 = v5 - 1i32;
            let mut v8: Rc<str> = string_slice(&v0.clone(), v1 as i64, v7 as i64);
            let mut v9: bool = v8.clone() == v2.clone();
            if v9 {
                return v1;
            } else {
                let mut v10: i32 = v1 + 1i32;
                (v0, v1, v2) = (v0.clone(), v10, v2.clone());
                continue;
            }
        }
    }
}
fn method1(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 == 0i32;
        if v2 {
            return 0i32;
        } else {
            let mut v3: i32 = v1 - 1i32;
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v5: bool = v4 == b'\n';
            if v5 {
                return v1;
            } else {
                (v0, v1) = (v0.clone(), v3);
                continue;
            }
        }
    }
}
fn method2(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 == 0i32;
        if v2 {
            return 0i32;
        } else {
            let mut v3: i32 = v1 - 1i32;
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v5: bool = v4 == b' ';
            if v5 {
                (v0, v1) = (v0.clone(), v3);
                continue;
            } else {
                let mut v7: bool = v4 == b'\t';
                if v7 {
                    (v0, v1) = (v0.clone(), v3);
                    continue;
                } else {
                    let mut v9: bool = v4 == b'\r';
                    if v9 {
                        (v0, v1) = (v0.clone(), v3);
                        continue;
                    } else {
                        let mut v11: bool = v4 == b'\n';
                        if v11 {
                            (v0, v1) = (v0.clone(), v3);
                            continue;
                        } else {
                            return v1;
                        }
                    }
                }
            }
        }
    }
}
fn method4(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: i32 = (v0.clone().len() as i32);
        let mut v4: bool = v1 == v3;
        if v4 {
            return v2;
        } else {
            let mut v5: u8 = v0.clone().as_bytes()[v1 as usize];
            let mut v6: bool = v5 == b'/';
            let mut v9: i32 = if v6 {
                v1
            } else {
                let mut v7: bool = v5 == b'\\';
                if v7 {
                    v1
                } else {
                    v2
                }
            };
            let mut v10: i32 = v1 + 1i32;
            (v0, v1, v2) = (v0.clone(), v10, v9);
            continue;
        }
    }
}
fn method3(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    loop {
        let mut v2: bool = v0.clone() == Rc::<str>::from("");
        if v2 {
            let mut v3: Rc<str> = Rc::<str>::from("");
            return v3.clone();
        } else {
            let mut v4: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v5: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v0.clone(), v1.clone()) v4 ;
            let mut v6: Rc<str> = "i32::from(std::path::Path::new($0.as_ref()).exists())";
            let mut v7: i32 = Fable.Core.RustInterop.emitRustExpr v5 v6 ;
            let mut v8: bool = v7 == 1i32;
            if v8 {
                return v0.clone();
            } else {
                let mut v9: i32 = 0i32;
                let mut v10: i32 = -1i32;
                let mut v11: i32 = method4(v0.clone(), v9, v10);
                let mut v12: bool = v11 == -1i32;
                let mut v23: Rc<str> = if v12 {
                    let mut v13: Rc<str> = Rc::<str>::from("");
                    v13.clone()
                } else {
                    let mut v14: i32 = v11 - 1i32;
                    let mut v15: Rc<str> = string_slice(&v0.clone(), 0i32 as i64, v14 as i64);
                    let mut v16: i32 = (v15.clone().len() as i32);
                    let mut v17: bool = v16 == 2i32;
                    let mut v20: bool = if v17 {
                        let mut v18: u8 = v15.clone().as_bytes()[1i32 as usize];
                        let mut v19: bool = v18 == b':';
                        v19
                    } else {
                        false
                    };
                    if v20 {
                        let mut v21: Rc<str> = string_slice(&v0.clone(), 0i32 as i64, v11 as i64);
                        v21.clone()
                    } else {
                        v15.clone()
                    }
                };
                let mut v24: bool = v23.clone() == Rc::<str>::from("");
                if v24 {
                    let mut v25: Rc<str> = Rc::<str>::from("");
                    return v25.clone();
                } else {
                    let mut v26: bool = v23.clone() == v0.clone();
                    if v26 {
                        let mut v27: Rc<str> = Rc::<str>::from("");
                        return v27.clone();
                    } else {
                        (v0, v1) = (v23.clone(), v1.clone());
                        continue;
                    }
                }
            }
        }
    }
}
fn method5(mut v0: i32, mut v1: i32) -> Rc<str> {
    loop {
        let mut v2: bool = v0 == v1;
        if v2 {
            let mut v3: Rc<str> = Rc::<str>::from("");
            return v3.clone();
        } else {
            let mut v4: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
            let mut v5: Rc<str> = Fable.Core.RustInterop.emitRustExpr v0 v4 ;
            let mut v6: i32 = (v5.clone().len() as i32);
            let mut v7: bool = v6 < 2i32;
            let mut v10: bool = if v7 {
                false
            } else {
                let mut v8: Rc<str> = string_slice(&v5.clone(), 0i32 as i64, 1i32 as i64);
                let mut v9: bool = v8.clone() == Rc::<str>::from("--");
                v9
            };
            if v10 {
                let mut v11: i32 = v0 + 1i32;
                (v0, v1) = (v11, v1);
                continue;
            } else {
                let mut v13: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
                let mut v14: Rc<str> = Fable.Core.RustInterop.emitRustExpr v0 v13 ;
                return v14.clone();
            }
        }
    }
}
fn method6(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: i32 = (v0.clone().len() as i32);
        let mut v4: bool = v1 == v3;
        if v4 {
            return v2;
        } else {
            let mut v5: u8 = v0.clone().as_bytes()[v1 as usize];
            let mut v6: bool = v5 == b'.';
            let mut v7: i32 = if v6 {
                v1
            } else {
                v2
            };
            let mut v8: i32 = v1 + 1i32;
            (v0, v1, v2) = (v0.clone(), v8, v7);
            continue;
        }
    }
}
fn method7(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v1 == v2;
        if v3 {
            return -1i32;
        } else {
            let mut v4: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
            let mut v5: Rc<str> = Fable.Core.RustInterop.emitRustExpr v1 v4 ;
            let mut v6: bool = v5.clone() == v0.clone();
            if v6 {
                return v1;
            } else {
                let mut v7: i32 = v1 + 1i32;
                (v0, v1, v2) = (v0.clone(), v7, v2);
                continue;
            }
        }
    }
}
fn method8(mut v0: i32, mut v1: i32, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: i32) -> Rc<str> {
    loop {
        let mut v5: bool = v0 == v1;
        if v5 {
            return v3.clone();
        } else {
            let mut v6: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
            let mut v7: Rc<str> = Fable.Core.RustInterop.emitRustExpr v0 v6 ;
            let mut v8: i32 = (v7.clone().len() as i32);
            let mut v9: bool = v8 < 2i32;
            let mut v12: bool = if v9 {
                false
            } else {
                let mut v10: Rc<str> = string_slice(&v7.clone(), 0i32 as i64, 1i32 as i64);
                let mut v11: bool = v10.clone() == Rc::<str>::from("--");
                v11
            };
            if v12 {
                return v3.clone();
            } else {
                let mut v13: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
                let mut v14: Rc<str> = Fable.Core.RustInterop.emitRustExpr v0 v13 ;
                let mut v15: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
                let mut v16: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v2.clone(), v14.clone()) v15 ;
                let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from("<Compile Include=\""), v16.clone()));
                let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17.clone(), Rc::<str>::from("\" />")));
                let mut v19: bool = v4 == 1i32;
                let mut v22: Rc<str> = if v19 {
                    v18.clone()
                } else {
                    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v3.clone(), Rc::<str>::from("\n        ")));
                    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20.clone(), v18.clone()));
                    v21.clone()
                };
                let mut v23: i32 = v0 + 1i32;
                let mut v24: i32 = 0i32;
                (v0, v1, v2, v3, v4) = (v23, v1, v2.clone(), v22.clone(), v24);
                continue;
            }
        }
    }
}
fn method9(mut v0: i32, mut v1: i32, mut v2: Rc<str>, mut v3: i32) -> Rc<str> {
    loop {
        let mut v4: bool = v0 == v1;
        if v4 {
            return v2.clone();
        } else {
            let mut v5: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
            let mut v6: Rc<str> = Fable.Core.RustInterop.emitRustExpr v0 v5 ;
            let mut v7: i32 = (v6.clone().len() as i32);
            let mut v8: bool = v7 < 2i32;
            let mut v11: bool = if v8 {
                false
            } else {
                let mut v9: Rc<str> = string_slice(&v6.clone(), 0i32 as i64, 1i32 as i64);
                let mut v10: bool = v9.clone() == Rc::<str>::from("--");
                v10
            };
            if v11 {
                return v2.clone();
            } else {
                let mut v12: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
                let mut v13: Rc<str> = Fable.Core.RustInterop.emitRustExpr v0 v12 ;
                let mut v14: bool = v3 == 1i32;
                let mut v17: Rc<str> = if v14 {
                    v13.clone()
                } else {
                    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v2.clone(), Rc::<str>::from("\n")));
                    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15.clone(), v13.clone()));
                    v16.clone()
                };
                let mut v18: i32 = v0 + 1i32;
                let mut v19: i32 = 0i32;
                (v0, v1, v2, v3) = (v18, v1, v17.clone(), v19);
                continue;
            }
        }
    }
}
fn method10(mut v0: US1, mut v1: US2) -> i32 {
    match &v0 {
        US1::US1_0(v2, v3) => { // Project
            let mut v2: Rc<str> = v2.clone();
            let mut v3: Rc<str> = v3.clone();
            let mut v99: i32 = match &v1 {
                US2::US2_0(v4) => { // Chosen
                    let mut v4: Rc<str> = v4.clone();
                    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from("publish\n"), v2.clone()));
                    let mut v6: Rc<str> = Rc::<str>::from(format!("{}{}", v5.clone(), Rc::<str>::from("\n")));
                    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v6.clone(), Rc::<str>::from("--configuration")));
                    let mut v8: Rc<str> = Rc::<str>::from(format!("{}{}", v7.clone(), Rc::<str>::from("\n")));
                    let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v8.clone(), Rc::<str>::from("Release")));
                    let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v9.clone(), Rc::<str>::from("\n")));
                    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v10.clone(), Rc::<str>::from("--output")));
                    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v11.clone(), Rc::<str>::from("\n")));
                    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12.clone(), v3.clone()));
                    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13.clone(), Rc::<str>::from("\n")));
                    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14.clone(), Rc::<str>::from("--runtime")));
                    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15.clone(), Rc::<str>::from("\n")));
                    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16.clone(), v4.clone()));
                    let mut v18: i32 = 0i32;
                    let mut v19: i32 = -1i32;
                    let mut v20: i32 = method4(v2.clone(), v18, v19);
                    let mut v21: bool = v20 == -1i32;
                    let mut v32: Rc<str> = if v21 {
                        let mut v22: Rc<str> = Rc::<str>::from("");
                        v22.clone()
                    } else {
                        let mut v23: i32 = v20 - 1i32;
                        let mut v24: Rc<str> = string_slice(&v2.clone(), 0i32 as i64, v23 as i64);
                        let mut v25: i32 = (v24.clone().len() as i32);
                        let mut v26: bool = v25 == 2i32;
                        let mut v29: bool = if v26 {
                            let mut v27: u8 = v24.clone().as_bytes()[1i32 as usize];
                            let mut v28: bool = v27 == b':';
                            v28
                        } else {
                            false
                        };
                        if v29 {
                            let mut v30: Rc<str> = string_slice(&v2.clone(), 0i32 as i64, v20 as i64);
                            v30.clone()
                        } else {
                            v24.clone()
                        }
                    };
                    let mut v33: i32 = (v32.clone().len() as i32);
                    let mut v34: bool = v33 == 0i32;
                    let mut v36: Rc<str> = if v34 {
                        let mut v35: Rc<str> = Rc::<str>::from(".");
                        v35.clone()
                    } else {
                        v32.clone()
                    };
                    let mut v37: Rc<str> = "{ let mut command = std::process::Command::new($0.as_ref()); command.args($2.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir($1.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) }";
                    let mut v38: Rc<str> = Rc::<str>::from("dotnet");
                    let mut v39: i32 = Fable.Core.RustInterop.emitRustExpr (v38.clone(), v36.clone(), v17.clone()) v37 ;
                    v39
                }
                US2::US2_1 => { // Defaults
                    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from("publish\n"), v2.clone()));
                    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40.clone(), Rc::<str>::from("\n")));
                    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41.clone(), Rc::<str>::from("--configuration")));
                    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42.clone(), Rc::<str>::from("\n")));
                    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43.clone(), Rc::<str>::from("Release")));
                    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44.clone(), Rc::<str>::from("\n")));
                    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45.clone(), Rc::<str>::from("--output")));
                    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46.clone(), Rc::<str>::from("\n")));
                    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v47.clone(), v3.clone()));
                    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v48.clone(), Rc::<str>::from("\n")));
                    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v49.clone(), Rc::<str>::from("--runtime")));
                    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50.clone(), Rc::<str>::from("\n")));
                    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51.clone(), Rc::<str>::from("linux-x64")));
                    let mut v53: i32 = 0i32;
                    let mut v54: i32 = -1i32;
                    let mut v55: i32 = method4(v2.clone(), v53, v54);
                    let mut v56: bool = v55 == -1i32;
                    let mut v67: Rc<str> = if v56 {
                        let mut v57: Rc<str> = Rc::<str>::from("");
                        v57.clone()
                    } else {
                        let mut v58: i32 = v55 - 1i32;
                        let mut v59: Rc<str> = string_slice(&v2.clone(), 0i32 as i64, v58 as i64);
                        let mut v60: i32 = (v59.clone().len() as i32);
                        let mut v61: bool = v60 == 2i32;
                        let mut v64: bool = if v61 {
                            let mut v62: u8 = v59.clone().as_bytes()[1i32 as usize];
                            let mut v63: bool = v62 == b':';
                            v63
                        } else {
                            false
                        };
                        if v64 {
                            let mut v65: Rc<str> = string_slice(&v2.clone(), 0i32 as i64, v55 as i64);
                            v65.clone()
                        } else {
                            v59.clone()
                        }
                    };
                    let mut v68: i32 = (v67.clone().len() as i32);
                    let mut v69: bool = v68 == 0i32;
                    let mut v71: Rc<str> = if v69 {
                        let mut v70: Rc<str> = Rc::<str>::from(".");
                        v70.clone()
                    } else {
                        v67.clone()
                    };
                    let mut v72: Rc<str> = "{ let mut command = std::process::Command::new($0.as_ref()); command.args($2.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir($1.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) }";
                    let mut v73: Rc<str> = Rc::<str>::from("dotnet");
                    let mut v74: i32 = Fable.Core.RustInterop.emitRustExpr (v73.clone(), v71.clone(), v52.clone()) v72 ;
                    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v51.clone(), Rc::<str>::from("win-x64")));
                    let mut v76: i32 = 0i32;
                    let mut v77: i32 = -1i32;
                    let mut v78: i32 = method4(v2.clone(), v76, v77);
                    let mut v79: bool = v78 == -1i32;
                    let mut v90: Rc<str> = if v79 {
                        let mut v80: Rc<str> = Rc::<str>::from("");
                        v80.clone()
                    } else {
                        let mut v81: i32 = v78 - 1i32;
                        let mut v82: Rc<str> = string_slice(&v2.clone(), 0i32 as i64, v81 as i64);
                        let mut v83: i32 = (v82.clone().len() as i32);
                        let mut v84: bool = v83 == 2i32;
                        let mut v87: bool = if v84 {
                            let mut v85: u8 = v82.clone().as_bytes()[1i32 as usize];
                            let mut v86: bool = v85 == b':';
                            v86
                        } else {
                            false
                        };
                        if v87 {
                            let mut v88: Rc<str> = string_slice(&v2.clone(), 0i32 as i64, v78 as i64);
                            v88.clone()
                        } else {
                            v82.clone()
                        }
                    };
                    let mut v91: i32 = (v90.clone().len() as i32);
                    let mut v92: bool = v91 == 0i32;
                    let mut v94: Rc<str> = if v92 {
                        let mut v93: Rc<str> = Rc::<str>::from(".");
                        v93.clone()
                    } else {
                        v90.clone()
                    };
                    let mut v95: Rc<str> = "{ let mut command = std::process::Command::new($0.as_ref()); command.args($2.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir($1.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) }";
                    let mut v96: i32 = Fable.Core.RustInterop.emitRustExpr (v73.clone(), v94.clone(), v75.clone()) v95 ;
                    let mut v97: i32 = v74 + v96;
                    v97
                }
                _ => unreachable!(),
            };
            let mut v100: Rc<str> = "Rc::<str>::from(std::env::var($0.as_ref()).unwrap_or_default())";
            let mut v101: Rc<str> = Rc::<str>::from("CI");
            let mut v102: Rc<str> = Fable.Core.RustInterop.emitRustExpr v101 v100 ;
            let mut v103: i32 = (v102.clone().len() as i32);
            let mut v104: bool = v103 == 0i32;
            let mut v105: i32 = if v104 {
                0i32
            } else {
                1i32
            };
            let mut v106: bool = v105 == 1i32;
            if v106 {
                let mut v107: Rc<str> = "Rc::<str>::from(std::path::absolute($0.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from($0.as_ref())).display().to_string())";
                let mut v108: Rc<str> = Fable.Core.RustInterop.emitRustExpr v2 v107 ;
                let mut v109: i32 = 0i32;
                let mut v110: i32 = -1i32;
                let mut v111: i32 = method4(v108.clone(), v109, v110);
                let mut v112: bool = v111 == -1i32;
                let mut v123: Rc<str> = if v112 {
                    let mut v113: Rc<str> = Rc::<str>::from("");
                    v113.clone()
                } else {
                    let mut v114: i32 = v111 - 1i32;
                    let mut v115: Rc<str> = string_slice(&v108.clone(), 0i32 as i64, v114 as i64);
                    let mut v116: i32 = (v115.clone().len() as i32);
                    let mut v117: bool = v116 == 2i32;
                    let mut v120: bool = if v117 {
                        let mut v118: u8 = v115.clone().as_bytes()[1i32 as usize];
                        let mut v119: bool = v118 == b':';
                        v119
                    } else {
                        false
                    };
                    if v120 {
                        let mut v121: Rc<str> = string_slice(&v108.clone(), 0i32 as i64, v111 as i64);
                        v121.clone()
                    } else {
                        v115.clone()
                    }
                };
                let mut v124: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
                let mut v125: Rc<str> = Rc::<str>::from("bin");
                let mut v126: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v123.clone(), v125.clone()) v124 ;
                let mut v127: Rc<str> = "i32::from(std::path::Path::new($0.as_ref()).is_dir())";
                let mut v128: i32 = Fable.Core.RustInterop.emitRustExpr v126 v127 ;
                let mut v129: bool = v128 == 1i32;
                let mut v134: i32 = if v129 {
                    let mut v130: Rc<str> = "i32::from(std::fs::remove_dir_all($0.as_ref()).is_err())";
                    let mut v131: i32 = Fable.Core.RustInterop.emitRustExpr v126 v130 ;
                    v131
                } else {
                    let mut v132: Rc<str> = "i32::from(std::fs::remove_file($0.as_ref()).is_err())";
                    let mut v133: i32 = Fable.Core.RustInterop.emitRustExpr v126 v132 ;
                    v133
                };
                let mut v135: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
                let mut v136: Rc<str> = Rc::<str>::from("obj");
                let mut v137: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v123.clone(), v136.clone()) v135 ;
                let mut v138: Rc<str> = "i32::from(std::path::Path::new($0.as_ref()).is_dir())";
                let mut v139: i32 = Fable.Core.RustInterop.emitRustExpr v137 v138 ;
                let mut v140: bool = v139 == 1i32;
                let mut v145: i32 = if v140 {
                    let mut v141: Rc<str> = "i32::from(std::fs::remove_dir_all($0.as_ref()).is_err())";
                    let mut v142: i32 = Fable.Core.RustInterop.emitRustExpr v137 v141 ;
                    v142
                } else {
                    let mut v143: Rc<str> = "i32::from(std::fs::remove_file($0.as_ref()).is_err())";
                    let mut v144: i32 = Fable.Core.RustInterop.emitRustExpr v137 v143 ;
                    v144
                };
                v99
            } else {
                v99
            }
        }
        _ => unreachable!(),
    }
}
fn spiral_main() -> i32 {
    let mut v0: Rc<str> = "std::env::args().count() as i32";
    let mut v1: i32 = Fable.Core.RustInterop.emitRustExpr () v0 ;
    let mut v2: bool = v1 == 2i32;
    let mut v10: US0 = if v2 {
        let mut v3: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
        let mut v4: Rc<str> = Fable.Core.RustInterop.emitRustExpr 1i32 v3 ;
        let mut v5: bool = v4.clone() == Rc::<str>::from("--self-test");
        if v5 {
            US0::US0_0
        } else {
            US0::US0_1
        }
    } else {
        US0::US0_1
    };
    match &v10 {
        US0::US0_0 => { // Check
            let mut v11: Rc<str> = Rc::<str>::from("    let main args = 0\n()\n");
            let mut v12: i32 = 0i32;
            let mut v13: Rc<str> = Rc::<str>::from("let main");
            let mut v14: i32 = method0(v11.clone(), v12, v13.clone());
            let mut v15: bool = v14 == -1i32;
            let mut v26: Rc<str> = if v15 {
                v11.clone()
            } else {
                let mut v16: i32 = method1(v11.clone(), v14);
                let mut v17: i32 = v14 - 1i32;
                let mut v18: Rc<str> = string_slice(&Rc::<str>::from("    let main args = 0\n()\n"), v16 as i64, v17 as i64);
                let mut v19: Rc<str> = string_slice(&Rc::<str>::from("    let main args = 0\n()\n"), v14 as i64, 24i32 as i64);
                let mut v20: i32 = v16 - 1i32;
                let mut v21: Rc<str> = string_slice(&Rc::<str>::from("    let main args = 0\n()\n"), 0i32 as i64, v20 as i64);
                let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21.clone(), v18.clone()));
                let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23.clone(), v18.clone()));
                let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", v24.clone(), v19.clone()));
                v25.clone()
            };
            let mut v27: i32 = (v26.clone().len() as i32);
            let mut v28: i32 = method2(v26.clone(), v27);
            let mut v29: i32 = v28 - 1i32;
            let mut v30: Rc<str> = string_slice(&v26.clone(), 0i32 as i64, v29 as i64);
            let mut v31: i32 = (v30.clone().len() as i32);
            let mut v32: bool = v31 < 3i32;
            let mut v40: Rc<str> = if v32 {
                v26.clone()
            } else {
                let mut v33: i32 = v31 - 3i32;
                let mut v34: i32 = v31 - 1i32;
                let mut v35: Rc<str> = string_slice(&v30.clone(), v33 as i64, v34 as i64);
                let mut v36: bool = v35.clone() == Rc::<str>::from("\n()");
                if v36 {
                    let mut v37: i32 = v31 - 4i32;
                    let mut v38: Rc<str> = string_slice(&v30.clone(), 0i32 as i64, v37 as i64);
                    v38.clone()
                } else {
                    v26.clone()
                }
            };
            let mut v41: Rc<str> = Rc::<str>::from("let x = 1\n    let main args = 0\n()\n");
            let mut v42: i32 = 0i32;
            let mut v43: i32 = method0(v41.clone(), v42, v13.clone());
            let mut v44: bool = v43 == -1i32;
            let mut v55: Rc<str> = if v44 {
                v41.clone()
            } else {
                let mut v45: i32 = method1(v41.clone(), v43);
                let mut v46: i32 = v43 - 1i32;
                let mut v47: Rc<str> = string_slice(&Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"), v45 as i64, v46 as i64);
                let mut v48: Rc<str> = string_slice(&Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"), v43 as i64, 34i32 as i64);
                let mut v49: i32 = v45 - 1i32;
                let mut v50: Rc<str> = string_slice(&Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"), 0i32 as i64, v49 as i64);
                let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50.clone(), v47.clone()));
                let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v52.clone(), v47.clone()));
                let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v53.clone(), v48.clone()));
                v54.clone()
            };
            let mut v56: i32 = (v55.clone().len() as i32);
            let mut v57: i32 = method2(v55.clone(), v56);
            let mut v58: i32 = v57 - 1i32;
            let mut v59: Rc<str> = string_slice(&v55.clone(), 0i32 as i64, v58 as i64);
            let mut v60: i32 = (v59.clone().len() as i32);
            let mut v61: bool = v60 < 3i32;
            let mut v69: Rc<str> = if v61 {
                v55.clone()
            } else {
                let mut v62: i32 = v60 - 3i32;
                let mut v63: i32 = v60 - 1i32;
                let mut v64: Rc<str> = string_slice(&v59.clone(), v62 as i64, v63 as i64);
                let mut v65: bool = v64.clone() == Rc::<str>::from("\n()");
                if v65 {
                    let mut v66: i32 = v60 - 4i32;
                    let mut v67: Rc<str> = string_slice(&v59.clone(), 0i32 as i64, v66 as i64);
                    v67.clone()
                } else {
                    v55.clone()
                }
            };
            let mut v70: bool = v40.clone() == Rc::<str>::from("    [<EntryPoint>]\n    let main args = 0");
            if v70 {
                let mut v71: bool = v69.clone() == Rc::<str>::from("let x = 1\n    [<EntryPoint>]\n    let main args = 0");
                if v71 {
                    0i32
                } else {
                    1i32
                }
            } else {
                1i32
            }
        }
        US0::US0_1 => { // Ship
            let mut v74: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v75: Rc<str> = Rc::<str>::from("spiral");
            let mut v76: Rc<str> = Rc::<str>::from("workspace");
            let mut v77: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v75.clone(), v76.clone()) v74 ;
            let mut v78: Rc<str> = "Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default())";
            let mut v79: Rc<str> = Fable.Core.RustInterop.emitRustExpr () v78 ;
            let mut v80: Rc<str> = method3(v79.clone(), v77.clone());
            let mut v81: bool = v80.clone() == Rc::<str>::from("");
            let mut v85: Rc<str> = if v81 {
                let mut v82: Rc<str> = "Rc::<str>::from(std::env::current_exe().ok().and_then(|path| path.parent().map(|dir| dir.to_path_buf())).map(|path| path.display().to_string()).unwrap_or_default())";
                let mut v83: Rc<str> = Fable.Core.RustInterop.emitRustExpr () v82 ;
                method3(v83.clone(), v77.clone())
            } else {
                v80.clone()
            };
            let mut v86: bool = v85.clone() == Rc::<str>::from("");
            let mut v89: Rc<str> = if v86 {
                let mut v87: Rc<str> = Rc::<str>::from("/workspaces");
                method3(v87.clone(), v77.clone())
            } else {
                v85.clone()
            };
            let mut v90: bool = v89.clone() == Rc::<str>::from("");
            let mut v122: Rc<str> = if v90 {
                let mut v91: Rc<str> = Rc::<str>::from("");
                v91.clone()
            } else {
                let mut v92: i32 = 0i32;
                let mut v93: i32 = -1i32;
                let mut v94: i32 = method4(v89.clone(), v92, v93);
                let mut v95: i32 = (v89.clone().len() as i32);
                let mut v96: bool = v94 == -1i32;
                let mut v103: Rc<str> = if v96 {
                    v89.clone()
                } else {
                    let mut v97: i32 = v94 + 1i32;
                    let mut v98: bool = v97 == v95;
                    if v98 {
                        let mut v99: Rc<str> = Rc::<str>::from("");
                        v99.clone()
                    } else {
                        let mut v100: i32 = v95 - 1i32;
                        let mut v101: Rc<str> = string_slice(&v89.clone(), v97 as i64, v100 as i64);
                        v101.clone()
                    }
                };
                let mut v104: bool = v103.clone() == Rc::<str>::from("deps");
                if v104 {
                    let mut v105: i32 = 0i32;
                    let mut v106: i32 = -1i32;
                    let mut v107: i32 = method4(v89.clone(), v105, v106);
                    let mut v108: bool = v107 == -1i32;
                    let mut v119: Rc<str> = if v108 {
                        let mut v109: Rc<str> = Rc::<str>::from("");
                        v109.clone()
                    } else {
                        let mut v110: i32 = v107 - 1i32;
                        let mut v111: Rc<str> = string_slice(&v89.clone(), 0i32 as i64, v110 as i64);
                        let mut v112: i32 = (v111.clone().len() as i32);
                        let mut v113: bool = v112 == 2i32;
                        let mut v116: bool = if v113 {
                            let mut v114: u8 = v111.clone().as_bytes()[1i32 as usize];
                            let mut v115: bool = v114 == b':';
                            v115
                        } else {
                            false
                        };
                        if v116 {
                            let mut v117: Rc<str> = string_slice(&v89.clone(), 0i32 as i64, v107 as i64);
                            v117.clone()
                        } else {
                            v111.clone()
                        }
                    };
                    method3(v119.clone(), v77.clone())
                } else {
                    v89.clone()
                }
            };
            let mut v123: bool = v122.clone() == Rc::<str>::from("");
            let mut v128: Rc<str> = if v123 {
                let mut v124: Rc<str> = Rc::<str>::from("");
                v124.clone()
            } else {
                let mut v125: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
                let mut v126: Rc<str> = Rc::<str>::from("polyglot");
                let mut v127: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v122.clone(), v126.clone()) v125 ;
                v127.clone()
            };
            let mut v129: bool = v128.clone() == Rc::<str>::from("");
            let mut v150: Rc<str> = if v129 {
                let mut v130: Rc<str> = "Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default())";
                let mut v131: Rc<str> = Fable.Core.RustInterop.emitRustExpr () v130 ;
                let mut v132: Rc<str> = Rc::<str>::from(".paket/Paket.Restore.targets");
                let mut v133: Rc<str> = method3(v131.clone(), v132.clone());
                let mut v134: bool = v133.clone() == Rc::<str>::from("");
                if v134 {
                    let mut v135: Rc<str> = Rc::<str>::from(".");
                    v135.clone()
                } else {
                    v133.clone()
                }
            } else {
                let mut v137: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
                let mut v138: Rc<str> = Rc::<str>::from(".paket/Paket.Restore.targets");
                let mut v139: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v128.clone(), v138.clone()) v137 ;
                let mut v140: Rc<str> = "i32::from(std::path::Path::new($0.as_ref()).exists())";
                let mut v141: i32 = Fable.Core.RustInterop.emitRustExpr v139 v140 ;
                let mut v142: bool = v141 == 1i32;
                if v142 {
                    v128.clone()
                } else {
                    let mut v143: Rc<str> = "Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default())";
                    let mut v144: Rc<str> = Fable.Core.RustInterop.emitRustExpr () v143 ;
                    let mut v145: Rc<str> = method3(v144.clone(), v138.clone());
                    let mut v146: bool = v145.clone() == Rc::<str>::from("");
                    if v146 {
                        let mut v147: Rc<str> = Rc::<str>::from(".");
                        v147.clone()
                    } else {
                        v145.clone()
                    }
                }
            };
            let mut v151: i32 = 1i32;
            let mut v152: Rc<str> = "std::env::args().count() as i32";
            let mut v153: i32 = Fable.Core.RustInterop.emitRustExpr () v152 ;
            let mut v154: Rc<str> = method5(v151, v153);
            let mut v155: Rc<str> = "Rc::<str>::from(std::path::absolute($0.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from($0.as_ref())).display().to_string())";
            let mut v156: Rc<str> = Fable.Core.RustInterop.emitRustExpr v154 v155 ;
            let mut v157: i32 = 0i32;
            let mut v158: i32 = -1i32;
            let mut v159: i32 = method4(v156.clone(), v157, v158);
            let mut v160: i32 = (v156.clone().len() as i32);
            let mut v161: bool = v159 == -1i32;
            let mut v168: Rc<str> = if v161 {
                v156.clone()
            } else {
                let mut v162: i32 = v159 + 1i32;
                let mut v163: bool = v162 == v160;
                if v163 {
                    let mut v164: Rc<str> = Rc::<str>::from("");
                    v164.clone()
                } else {
                    let mut v165: i32 = v160 - 1i32;
                    let mut v166: Rc<str> = string_slice(&v156.clone(), v162 as i64, v165 as i64);
                    v166.clone()
                }
            };
            let mut v169: i32 = 0i32;
            let mut v170: i32 = -1i32;
            let mut v171: i32 = method6(v168.clone(), v169, v170);
            let mut v172: bool = v171 <= 0i32;
            let mut v175: Rc<str> = if v172 {
                v168.clone()
            } else {
                let mut v173: i32 = v171 - 1i32;
                let mut v174: Rc<str> = string_slice(&v168.clone(), 0i32 as i64, v173 as i64);
                v174.clone()
            };
            let mut v176: Rc<str> = "{ let path = std::path::absolute($0.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from($0.as_ref())); Rc::<str>::from(std::fs::read_to_string(path).unwrap_or_default()) }";
            let mut v177: Rc<str> = Fable.Core.RustInterop.emitRustExpr v154 v176 ;
            let mut v178: i32 = 0i32;
            let mut v179: Rc<str> = Rc::<str>::from("let main");
            let mut v180: i32 = method0(v177.clone(), v178, v179.clone());
            let mut v181: bool = v180 == -1i32;
            let mut v194: Rc<str> = if v181 {
                v177.clone()
            } else {
                let mut v182: i32 = method1(v177.clone(), v180);
                let mut v183: i32 = v180 - 1i32;
                let mut v184: Rc<str> = string_slice(&v177.clone(), v182 as i64, v183 as i64);
                let mut v185: i32 = (v177.clone().len() as i32);
                let mut v186: i32 = v185 - 1i32;
                let mut v187: Rc<str> = string_slice(&v177.clone(), v180 as i64, v186 as i64);
                let mut v188: i32 = v182 - 1i32;
                let mut v189: Rc<str> = string_slice(&v177.clone(), 0i32 as i64, v188 as i64);
                let mut v190: Rc<str> = Rc::<str>::from(format!("{}{}", v189.clone(), v184.clone()));
                let mut v191: Rc<str> = Rc::<str>::from(format!("{}{}", v190.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v192: Rc<str> = Rc::<str>::from(format!("{}{}", v191.clone(), v184.clone()));
                let mut v193: Rc<str> = Rc::<str>::from(format!("{}{}", v192.clone(), v187.clone()));
                v193.clone()
            };
            let mut v195: i32 = (v194.clone().len() as i32);
            let mut v196: i32 = method2(v194.clone(), v195);
            let mut v197: i32 = v196 - 1i32;
            let mut v198: Rc<str> = string_slice(&v194.clone(), 0i32 as i64, v197 as i64);
            let mut v199: i32 = (v198.clone().len() as i32);
            let mut v200: bool = v199 < 3i32;
            let mut v208: Rc<str> = if v200 {
                v194.clone()
            } else {
                let mut v201: i32 = v199 - 3i32;
                let mut v202: i32 = v199 - 1i32;
                let mut v203: Rc<str> = string_slice(&v198.clone(), v201 as i64, v202 as i64);
                let mut v204: bool = v203.clone() == Rc::<str>::from("\n()");
                if v204 {
                    let mut v205: i32 = v199 - 4i32;
                    let mut v206: Rc<str> = string_slice(&v198.clone(), 0i32 as i64, v205 as i64);
                    v206.clone()
                } else {
                    v194.clone()
                }
            };
            let mut v209: Rc<str> = "Rc::<str>::from(std::path::absolute($0.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from($0.as_ref())).display().to_string())";
            let mut v210: Rc<str> = Fable.Core.RustInterop.emitRustExpr v154 v209 ;
            let mut v211: i32 = 0i32;
            let mut v212: i32 = -1i32;
            let mut v213: i32 = method4(v210.clone(), v211, v212);
            let mut v214: bool = v213 == -1i32;
            let mut v225: Rc<str> = if v214 {
                let mut v215: Rc<str> = Rc::<str>::from("");
                v215.clone()
            } else {
                let mut v216: i32 = v213 - 1i32;
                let mut v217: Rc<str> = string_slice(&v210.clone(), 0i32 as i64, v216 as i64);
                let mut v218: i32 = (v217.clone().len() as i32);
                let mut v219: bool = v218 == 2i32;
                let mut v222: bool = if v219 {
                    let mut v220: u8 = v217.clone().as_bytes()[1i32 as usize];
                    let mut v221: bool = v220 == b':';
                    v221
                } else {
                    false
                };
                if v222 {
                    let mut v223: Rc<str> = string_slice(&v210.clone(), 0i32 as i64, v213 as i64);
                    v223.clone()
                } else {
                    v217.clone()
                }
            };
            let mut v226: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v227: Rc<str> = Rc::<str>::from("dist");
            let mut v228: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v225.clone(), v227.clone()) v226 ;
            let mut v229: Rc<str> = "std::env::args().count() as i32";
            let mut v230: i32 = Fable.Core.RustInterop.emitRustExpr () v229 ;
            let mut v231: Rc<str> = Rc::<str>::from("--modules");
            let mut v232: i32 = 1i32;
            let mut v233: i32 = method7(v231.clone(), v232, v230);
            let mut v234: bool = v233 == -1i32;
            let mut v240: Rc<str> = if v234 {
                let mut v235: Rc<str> = Rc::<str>::from("");
                v235.clone()
            } else {
                let mut v236: i32 = v233 + 1i32;
                let mut v237: Rc<str> = Rc::<str>::from("");
                let mut v238: i32 = 1i32;
                method8(v236, v230, v150.clone(), v237.clone(), v238)
            };
            let mut v241: Rc<str> = "std::env::args().count() as i32";
            let mut v242: i32 = Fable.Core.RustInterop.emitRustExpr () v241 ;
            let mut v243: Rc<str> = Rc::<str>::from("--packages");
            let mut v244: i32 = 1i32;
            let mut v245: i32 = method7(v243.clone(), v244, v242);
            let mut v246: bool = v245 == -1i32;
            let mut v252: Rc<str> = if v246 {
                let mut v247: Rc<str> = Rc::<str>::from("");
                v247.clone()
            } else {
                let mut v248: i32 = v245 + 1i32;
                let mut v249: Rc<str> = Rc::<str>::from("");
                let mut v250: i32 = 1i32;
                method9(v248, v242, v249.clone(), v250)
            };
            let mut v253: i32 = (v252.clone().len() as i32);
            let mut v254: bool = v253 == 0i32;
            let mut v257: Rc<str> = if v254 {
                let mut v255: Rc<str> = Rc::<str>::from("FSharp.Core");
                v255.clone()
            } else {
                let mut v256: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from("FSharp.Core\n"), v252.clone()));
                v256.clone()
            };
            let mut v258: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v259: Rc<str> = Rc::<str>::from("target");
            let mut v260: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v150.clone(), v259.clone()) v258 ;
            let mut v261: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v262: Rc<str> = Rc::<str>::from("Builder");
            let mut v263: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v260.clone(), v262.clone()) v261 ;
            let mut v264: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v265: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v263.clone(), v175.clone()) v264 ;
            let mut v266: Rc<str> = Rc::<str>::from(format!("{}{}", v175.clone(), Rc::<str>::from(".fs")));
            let mut v267: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v268: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v265.clone(), v266.clone()) v267 ;
            let mut v269: Rc<str> = Rc::<str>::from(format!("{}{}", v175.clone(), Rc::<str>::from(".fsproj")));
            let mut v270: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v271: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v265.clone(), v269.clone()) v270 ;
            let mut v272: Rc<str> = "{ let path = std::path::Path::new($0.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some($1.as_ref())) }";
            let mut v273: i32 = Fable.Core.RustInterop.emitRustExpr (v268.clone(), v208.clone()) v272 ;
            let mut v274: bool = v273 == 1i32;
            let mut v299: i32 = if v274 {
                0i32
            } else {
                let mut v275: i32 = 0i32;
                let mut v276: i32 = -1i32;
                let mut v277: i32 = method4(v268.clone(), v275, v276);
                let mut v278: bool = v277 == -1i32;
                let mut v289: Rc<str> = if v278 {
                    let mut v279: Rc<str> = Rc::<str>::from("");
                    v279.clone()
                } else {
                    let mut v280: i32 = v277 - 1i32;
                    let mut v281: Rc<str> = string_slice(&v268.clone(), 0i32 as i64, v280 as i64);
                    let mut v282: i32 = (v281.clone().len() as i32);
                    let mut v283: bool = v282 == 2i32;
                    let mut v286: bool = if v283 {
                        let mut v284: u8 = v281.clone().as_bytes()[1i32 as usize];
                        let mut v285: bool = v284 == b':';
                        v285
                    } else {
                        false
                    };
                    if v286 {
                        let mut v287: Rc<str> = string_slice(&v268.clone(), 0i32 as i64, v277 as i64);
                        v287.clone()
                    } else {
                        v281.clone()
                    }
                };
                let mut v290: i32 = (v289.clone().len() as i32);
                let mut v291: bool = v290 == 0i32;
                let mut v294: i32 = if v291 {
                    0i32
                } else {
                    let mut v292: Rc<str> = "i32::from(std::fs::create_dir_all($0.as_ref()).is_err())";
                    let mut v293: i32 = Fable.Core.RustInterop.emitRustExpr v289 v292 ;
                    v293
                };
                let mut v295: bool = v294 == 0i32;
                if v295 {
                    let mut v296: Rc<str> = "i32::from(std::fs::write($0.as_ref(), $1.as_ref().as_bytes()).is_err())";
                    let mut v297: i32 = Fable.Core.RustInterop.emitRustExpr (v268.clone(), v208.clone()) v296 ;
                    v297
                } else {
                    v294
                }
            };
            let mut v300: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from("<Project Sdk=\"Microsoft.NET.Sdk\">\n    <PropertyGroup>\n        <TargetFramework>net9.0</TargetFramework>\n        <LangVersion>preview</LangVersion>\n        <RollForward>Major</RollForward>\n        <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n        <ServerGarbageCollection>true</ServerGarbageCollection>\n        <ConcurrentGarbageCollection>true</ConcurrentGarbageCollection>\n        <PublishAot>false</PublishAot>\n        <PublishTrimmed>false</PublishTrimmed>\n        <PublishSingleFile>true</PublishSingleFile>\n        <SelfContained>true</SelfContained>\n        <Version>0.0.1-alpha.1</Version>\n        <OutputType>Exe</OutputType>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">\n        <DefineConstants>_FREEBSD</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">\n        <DefineConstants>_LINUX</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">\n        <DefineConstants>_OSX</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">\n        <DefineConstants>_WINDOWS</DefineConstants>\n    </PropertyGroup>\n\n    <ItemGroup>\n        "), v240.clone()));
            let mut v301: Rc<str> = Rc::<str>::from(format!("{}{}", v300.clone(), Rc::<str>::from("\n        <Compile Include=\"")));
            let mut v302: Rc<str> = Rc::<str>::from(format!("{}{}", v301.clone(), v268.clone()));
            let mut v303: Rc<str> = Rc::<str>::from(format!("{}{}", v302.clone(), Rc::<str>::from("\" />\n    </ItemGroup>\n    <ItemGroup>\n        <FrameworkReference Include=\"Microsoft.AspNetCore.App\" />\n    </ItemGroup>\n    <Import Project=\"")));
            let mut v304: Rc<str> = Rc::<str>::from(format!("{}{}", v303.clone(), v150.clone()));
            let mut v305: Rc<str> = Rc::<str>::from(format!("{}{}", v304.clone(), Rc::<str>::from("/.paket/Paket.Restore.targets\" />\n</Project>\n")));
            let mut v306: Rc<str> = "{ let path = std::path::Path::new($0.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some($1.as_ref())) }";
            let mut v307: i32 = Fable.Core.RustInterop.emitRustExpr (v271.clone(), v305.clone()) v306 ;
            let mut v308: bool = v307 == 1i32;
            let mut v333: i32 = if v308 {
                0i32
            } else {
                let mut v309: i32 = 0i32;
                let mut v310: i32 = -1i32;
                let mut v311: i32 = method4(v271.clone(), v309, v310);
                let mut v312: bool = v311 == -1i32;
                let mut v323: Rc<str> = if v312 {
                    let mut v313: Rc<str> = Rc::<str>::from("");
                    v313.clone()
                } else {
                    let mut v314: i32 = v311 - 1i32;
                    let mut v315: Rc<str> = string_slice(&v271.clone(), 0i32 as i64, v314 as i64);
                    let mut v316: i32 = (v315.clone().len() as i32);
                    let mut v317: bool = v316 == 2i32;
                    let mut v320: bool = if v317 {
                        let mut v318: u8 = v315.clone().as_bytes()[1i32 as usize];
                        let mut v319: bool = v318 == b':';
                        v319
                    } else {
                        false
                    };
                    if v320 {
                        let mut v321: Rc<str> = string_slice(&v271.clone(), 0i32 as i64, v311 as i64);
                        v321.clone()
                    } else {
                        v315.clone()
                    }
                };
                let mut v324: i32 = (v323.clone().len() as i32);
                let mut v325: bool = v324 == 0i32;
                let mut v328: i32 = if v325 {
                    0i32
                } else {
                    let mut v326: Rc<str> = "i32::from(std::fs::create_dir_all($0.as_ref()).is_err())";
                    let mut v327: i32 = Fable.Core.RustInterop.emitRustExpr v323 v326 ;
                    v327
                };
                let mut v329: bool = v328 == 0i32;
                if v329 {
                    let mut v330: Rc<str> = "i32::from(std::fs::write($0.as_ref(), $1.as_ref().as_bytes()).is_err())";
                    let mut v331: i32 = Fable.Core.RustInterop.emitRustExpr (v271.clone(), v305.clone()) v330 ;
                    v331
                } else {
                    v328
                }
            };
            let mut v334: Rc<str> = "Rc::<str>::from(std::path::Path::new($0.as_ref()).join($1.as_ref()).display().to_string())";
            let mut v335: Rc<str> = Rc::<str>::from("paket.references");
            let mut v336: Rc<str> = Fable.Core.RustInterop.emitRustExpr (v265.clone(), v335.clone()) v334 ;
            let mut v337: Rc<str> = "{ let path = std::path::Path::new($0.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some($1.as_ref())) }";
            let mut v338: i32 = Fable.Core.RustInterop.emitRustExpr (v336.clone(), v257.clone()) v337 ;
            let mut v339: bool = v338 == 1i32;
            let mut v364: i32 = if v339 {
                0i32
            } else {
                let mut v340: i32 = 0i32;
                let mut v341: i32 = -1i32;
                let mut v342: i32 = method4(v336.clone(), v340, v341);
                let mut v343: bool = v342 == -1i32;
                let mut v354: Rc<str> = if v343 {
                    let mut v344: Rc<str> = Rc::<str>::from("");
                    v344.clone()
                } else {
                    let mut v345: i32 = v342 - 1i32;
                    let mut v346: Rc<str> = string_slice(&v336.clone(), 0i32 as i64, v345 as i64);
                    let mut v347: i32 = (v346.clone().len() as i32);
                    let mut v348: bool = v347 == 2i32;
                    let mut v351: bool = if v348 {
                        let mut v349: u8 = v346.clone().as_bytes()[1i32 as usize];
                        let mut v350: bool = v349 == b':';
                        v350
                    } else {
                        false
                    };
                    if v351 {
                        let mut v352: Rc<str> = string_slice(&v336.clone(), 0i32 as i64, v342 as i64);
                        v352.clone()
                    } else {
                        v346.clone()
                    }
                };
                let mut v355: i32 = (v354.clone().len() as i32);
                let mut v356: bool = v355 == 0i32;
                let mut v359: i32 = if v356 {
                    0i32
                } else {
                    let mut v357: Rc<str> = "i32::from(std::fs::create_dir_all($0.as_ref()).is_err())";
                    let mut v358: i32 = Fable.Core.RustInterop.emitRustExpr v354 v357 ;
                    v358
                };
                let mut v360: bool = v359 == 0i32;
                if v360 {
                    let mut v361: Rc<str> = "i32::from(std::fs::write($0.as_ref(), $1.as_ref().as_bytes()).is_err())";
                    let mut v362: i32 = Fable.Core.RustInterop.emitRustExpr (v336.clone(), v257.clone()) v361 ;
                    v362
                } else {
                    v359
                }
            };
            let mut v365: Rc<str> = Rc::<str>::from("--persist-only");
            let mut v366: i32 = 1i32;
            let mut v367: Rc<str> = "std::env::args().count() as i32";
            let mut v368: i32 = Fable.Core.RustInterop.emitRustExpr () v367 ;
            let mut v369: i32 = method7(v365.clone(), v366, v368);
            let mut v370: bool = v369 == -1i32;
            let mut v371: i32 = if v370 {
                0i32
            } else {
                1i32
            };
            let mut v372: bool = v371 == 1i32;
            if v372 {
                0i32
            } else {
                let mut v373: US1 = US1::US1_0(v271.clone(), v228.clone());
                let mut v374: Rc<str> = "std::env::args().count() as i32";
                let mut v375: i32 = Fable.Core.RustInterop.emitRustExpr () v374 ;
                let mut v376: Rc<str> = Rc::<str>::from("--runtime");
                let mut v377: i32 = 1i32;
                let mut v378: i32 = method7(v376.clone(), v377, v375);
                let mut v379: bool = v378 == -1i32;
                let mut v396: Rc<str> = if v379 {
                    let mut v380: Rc<str> = Rc::<str>::from("");
                    v380.clone()
                } else {
                    let mut v381: i32 = v378 + 1i32;
                    let mut v382: bool = v381 == v375;
                    if v382 {
                        let mut v383: Rc<str> = Rc::<str>::from("");
                        v383.clone()
                    } else {
                        let mut v384: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
                        let mut v385: Rc<str> = Fable.Core.RustInterop.emitRustExpr v381 v384 ;
                        let mut v386: i32 = (v385.clone().len() as i32);
                        let mut v387: bool = v386 < 2i32;
                        let mut v390: bool = if v387 {
                            false
                        } else {
                            let mut v388: Rc<str> = string_slice(&v385.clone(), 0i32 as i64, 1i32 as i64);
                            let mut v389: bool = v388.clone() == Rc::<str>::from("--");
                            v389
                        };
                        if v390 {
                            let mut v391: Rc<str> = Rc::<str>::from("");
                            v391.clone()
                        } else {
                            let mut v392: Rc<str> = "Rc::<str>::from(std::env::args().nth($0 as usize).unwrap_or_default())";
                            let mut v393: Rc<str> = Fable.Core.RustInterop.emitRustExpr v381 v392 ;
                            v393.clone()
                        }
                    }
                };
                let mut v397: i32 = (v396.clone().len() as i32);
                let mut v398: bool = v397 == 0i32;
                let mut v401: US2 = if v398 {
                    US2::US2_1
                } else {
                    US2::US2_0(v396.clone())
                };
                method10(v373.clone(), v401.clone())
            }
        }
        _ => unreachable!(),
    }
}
fn main() {
    std::process::exit(spiral_main());
}
