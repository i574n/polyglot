#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_patterns, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return Rc::<str>::from(""); }
    let slice = &bytes[from as usize..(to + 1) as usize];
    match std::str::from_utf8(slice) { Ok(text) => Rc::<str>::from(text), Err(error) => Rc::<str>::from(std::str::from_utf8(&slice[..error.valid_up_to()]).unwrap_or("")) }
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
fn method1(mut v0: Rc<str>, mut v1: i32, mut v2: Rc<str>) -> i32 {
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
fn method2(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: i32 = (v0.clone().len() as i32);
        let mut v3: i32 = v2 - 1i32;
        let mut v4: bool = v1 > v3;
        if v4 {
            return v1;
        } else {
            let mut v5: u8 = v0.clone().as_bytes()[v1 as usize];
            let mut v6: bool = v5 == b' ';
            if v6 {
                let mut v7: i32 = v1 + 1i32;
                (v0, v1) = (v0.clone(), v7);
                continue;
            } else {
                let mut v9: bool = v5 == b'\t';
                if v9 {
                    let mut v10: i32 = v1 + 1i32;
                    (v0, v1) = (v0.clone(), v10);
                    continue;
                } else {
                    return v1;
                }
            }
        }
    }
}
fn method0(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: Rc<str> = Rc::<str>::from("let main");
        let mut v3: i32 = method1(v0.clone(), v1, v2.clone());
        let mut v4: bool = v3 == -1i32;
        if v4 {
            return -1i32;
        } else {
            let mut v5: i32 = (v0.clone().len() as i32);
            let mut v6: i32 = v3 + 8i32;
            let mut v7: i32 = v5 - 1i32;
            let mut v8: bool = v6 > v7;
            let mut v22: bool = if v8 {
                false
            } else {
                let mut v9: u8 = v0.clone().as_bytes()[v6 as usize];
                let mut v10: bool = v9 == b'(';
                if v10 {
                    true
                } else {
                    let mut v11: bool = v9 == b' ';
                    let mut v13: bool = if v11 {
                        true
                    } else {
                        let mut v12: bool = v9 == b'\t';
                        v12
                    };
                    if v13 {
                        let mut v14: i32 = method2(v0.clone(), v6);
                        let mut v15: bool = v14 > v7;
                        if v15 {
                            false
                        } else {
                            let mut v16: u8 = v0.clone().as_bytes()[v14 as usize];
                            let mut v17: bool = v16 == b'=';
                            let mut v18: bool = v17 == false;
                            v18
                        }
                    } else {
                        false
                    }
                }
            };
            if v22 {
                return v3;
            } else {
                (v0, v1) = (v0.clone(), v6);
                continue;
            }
        }
    }
}
fn method3(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
fn method4(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
fn method6(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn method5(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    loop {
        let mut v2: bool = v0.clone() == Rc::<str>::from("");
        if v2 {
            let mut v3: Rc<str> = Rc::<str>::from("");
            return v3.clone();
        } else {
            let mut v5: Rc<str> = Rc::<str>::from(std::path::Path::new(v0.as_ref()).join(v1.as_ref()).display().to_string());
            let mut v7: i32 = i32::from(std::path::Path::new(v5.as_ref()).exists());
            let mut v8: bool = v7 == 1i32;
            if v8 {
                return v0.clone();
            } else {
                let mut v9: i32 = 0i32;
                let mut v10: i32 = -1i32;
                let mut v11: i32 = method6(v0.clone(), v9, v10);
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
fn method7(mut v0: i32, mut v1: i32) -> Rc<str> {
    loop {
        let mut v2: bool = v0 == v1;
        if v2 {
            let mut v3: Rc<str> = Rc::<str>::from("");
            return v3.clone();
        } else {
            let mut v5: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
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
                let mut v14: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
                return v14.clone();
            }
        }
    }
}
fn method8(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn method9(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v1 == v2;
        if v3 {
            return -1i32;
        } else {
            let mut v5: Rc<str> = Rc::<str>::from(std::env::args().nth(v1 as usize).unwrap_or_default());
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
fn method10(mut v0: i32, mut v1: i32, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: i32) -> Rc<str> {
    loop {
        let mut v5: bool = v0 == v1;
        if v5 {
            return v3.clone();
        } else {
            let mut v7: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
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
                let mut v14: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
                let mut v16: Rc<str> = Rc::<str>::from(std::path::Path::new(v2.as_ref()).join(v14.as_ref()).display().to_string());
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
fn method11(mut v0: i32, mut v1: i32, mut v2: Rc<str>, mut v3: i32) -> Rc<str> {
    loop {
        let mut v4: bool = v0 == v1;
        if v4 {
            return v2.clone();
        } else {
            let mut v6: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
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
                let mut v13: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
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
fn method12(mut v0: US1, mut v1: US2) -> i32 {
    match &v0 {
        US1::US1_2(v2, v3) => { // Project
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
                    let mut v20: i32 = method6(v2.clone(), v18, v19);
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
                    let mut v38: Rc<str> = Rc::<str>::from("dotnet");
                    let mut v39: i32 = { let mut command = std::process::Command::new(v38.as_ref()); command.args(v17.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir(v36.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) };
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
                    let mut v55: i32 = method6(v2.clone(), v53, v54);
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
                    let mut v73: Rc<str> = Rc::<str>::from("dotnet");
                    let mut v74: i32 = { let mut command = std::process::Command::new(v73.as_ref()); command.args(v52.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir(v71.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) };
                    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v51.clone(), Rc::<str>::from("win-x64")));
                    let mut v76: i32 = 0i32;
                    let mut v77: i32 = -1i32;
                    let mut v78: i32 = method6(v2.clone(), v76, v77);
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
                    let mut v96: i32 = { let mut command = std::process::Command::new(v73.as_ref()); command.args(v75.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir(v94.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) };
                    let mut v97: i32 = v74 + v96;
                    v97
                }
                _ => unreachable!(),
            };
            let mut v101: Rc<str> = Rc::<str>::from("CI");
            let mut v102: Rc<str> = Rc::<str>::from(std::env::var(v101.as_ref()).unwrap_or_default());
            let mut v103: i32 = (v102.clone().len() as i32);
            let mut v104: bool = v103 == 0i32;
            let mut v105: i32 = if v104 {
                0i32
            } else {
                1i32
            };
            let mut v106: bool = v105 == 1i32;
            if v106 {
                let mut v108: Rc<str> = Rc::<str>::from(std::path::absolute(v2.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from(v2.as_ref())).display().to_string());
                let mut v109: i32 = 0i32;
                let mut v110: i32 = -1i32;
                let mut v111: i32 = method6(v108.clone(), v109, v110);
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
                let mut v125: Rc<str> = Rc::<str>::from("bin");
                let mut v126: Rc<str> = Rc::<str>::from(std::path::Path::new(v123.as_ref()).join(v125.as_ref()).display().to_string());
                let mut v128: i32 = i32::from(std::path::Path::new(v126.as_ref()).is_dir());
                let mut v129: bool = v128 == 1i32;
                let mut v134: i32 = if v129 {
                    let mut v131: i32 = i32::from(std::fs::remove_dir_all(v126.as_ref()).is_err());
                    v131
                } else {
                    let mut v133: i32 = i32::from(std::fs::remove_file(v126.as_ref()).is_err());
                    v133
                };
                let mut v136: Rc<str> = Rc::<str>::from("obj");
                let mut v137: Rc<str> = Rc::<str>::from(std::path::Path::new(v123.as_ref()).join(v136.as_ref()).display().to_string());
                let mut v139: i32 = i32::from(std::path::Path::new(v137.as_ref()).is_dir());
                let mut v140: bool = v139 == 1i32;
                let mut v145: i32 = if v140 {
                    let mut v142: i32 = i32::from(std::fs::remove_dir_all(v137.as_ref()).is_err());
                    v142
                } else {
                    let mut v144: i32 = i32::from(std::fs::remove_file(v137.as_ref()).is_err());
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
    let mut v1: i32 = std::env::args().count() as i32;
    let mut v2: bool = v1 == 2i32;
    let mut v10: US0 = if v2 {
        let mut v4: Rc<str> = Rc::<str>::from(std::env::args().nth(1i32 as usize).unwrap_or_default());
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
            let mut v13: i32 = method0(v11.clone(), v12);
            let mut v14: bool = v13 == -1i32;
            let mut v25: Rc<str> = if v14 {
                v11.clone()
            } else {
                let mut v15: i32 = method3(v11.clone(), v13);
                let mut v16: i32 = v13 - 1i32;
                let mut v17: Rc<str> = string_slice(&Rc::<str>::from("    let main args = 0\n()\n"), v15 as i64, v16 as i64);
                let mut v18: Rc<str> = string_slice(&Rc::<str>::from("    let main args = 0\n()\n"), v13 as i64, 24i32 as i64);
                let mut v19: i32 = v15 - 1i32;
                let mut v20: Rc<str> = string_slice(&Rc::<str>::from("    let main args = 0\n()\n"), 0i32 as i64, v19 as i64);
                let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20.clone(), v17.clone()));
                let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22.clone(), v17.clone()));
                let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23.clone(), v18.clone()));
                v24.clone()
            };
            let mut v26: i32 = (v25.clone().len() as i32);
            let mut v27: i32 = method4(v25.clone(), v26);
            let mut v28: i32 = v27 - 1i32;
            let mut v29: Rc<str> = string_slice(&v25.clone(), 0i32 as i64, v28 as i64);
            let mut v30: i32 = (v29.clone().len() as i32);
            let mut v31: bool = v30 < 3i32;
            let mut v39: Rc<str> = if v31 {
                v25.clone()
            } else {
                let mut v32: i32 = v30 - 3i32;
                let mut v33: i32 = v30 - 1i32;
                let mut v34: Rc<str> = string_slice(&v29.clone(), v32 as i64, v33 as i64);
                let mut v35: bool = v34.clone() == Rc::<str>::from("\n()");
                if v35 {
                    let mut v36: i32 = v30 - 4i32;
                    let mut v37: Rc<str> = string_slice(&v29.clone(), 0i32 as i64, v36 as i64);
                    v37.clone()
                } else {
                    v25.clone()
                }
            };
            let mut v40: Rc<str> = Rc::<str>::from("let x = 1\n    let main args = 0\n()\n");
            let mut v41: i32 = 0i32;
            let mut v42: i32 = method0(v40.clone(), v41);
            let mut v43: bool = v42 == -1i32;
            let mut v54: Rc<str> = if v43 {
                v40.clone()
            } else {
                let mut v44: i32 = method3(v40.clone(), v42);
                let mut v45: i32 = v42 - 1i32;
                let mut v46: Rc<str> = string_slice(&Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"), v44 as i64, v45 as i64);
                let mut v47: Rc<str> = string_slice(&Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"), v42 as i64, 34i32 as i64);
                let mut v48: i32 = v44 - 1i32;
                let mut v49: Rc<str> = string_slice(&Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"), 0i32 as i64, v48 as i64);
                let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v49.clone(), v46.clone()));
                let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51.clone(), v46.clone()));
                let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v52.clone(), v47.clone()));
                v53.clone()
            };
            let mut v55: i32 = (v54.clone().len() as i32);
            let mut v56: i32 = method4(v54.clone(), v55);
            let mut v57: i32 = v56 - 1i32;
            let mut v58: Rc<str> = string_slice(&v54.clone(), 0i32 as i64, v57 as i64);
            let mut v59: i32 = (v58.clone().len() as i32);
            let mut v60: bool = v59 < 3i32;
            let mut v68: Rc<str> = if v60 {
                v54.clone()
            } else {
                let mut v61: i32 = v59 - 3i32;
                let mut v62: i32 = v59 - 1i32;
                let mut v63: Rc<str> = string_slice(&v58.clone(), v61 as i64, v62 as i64);
                let mut v64: bool = v63.clone() == Rc::<str>::from("\n()");
                if v64 {
                    let mut v65: i32 = v59 - 4i32;
                    let mut v66: Rc<str> = string_slice(&v58.clone(), 0i32 as i64, v65 as i64);
                    v66.clone()
                } else {
                    v54.clone()
                }
            };
            let mut v69: Rc<str> = Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n");
            let mut v70: i32 = 0i32;
            let mut v71: i32 = method0(v69.clone(), v70);
            let mut v72: bool = v71 == -1i32;
            let mut v83: Rc<str> = if v72 {
                v69.clone()
            } else {
                let mut v73: i32 = method3(v69.clone(), v71);
                let mut v74: i32 = v71 - 1i32;
                let mut v75: Rc<str> = string_slice(&Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n"), v73 as i64, v74 as i64);
                let mut v76: Rc<str> = string_slice(&Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n"), v71 as i64, 59i32 as i64);
                let mut v77: i32 = v73 - 1i32;
                let mut v78: Rc<str> = string_slice(&Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n"), 0i32 as i64, v77 as i64);
                let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", v78.clone(), v75.clone()));
                let mut v80: Rc<str> = Rc::<str>::from(format!("{}{}", v79.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v81: Rc<str> = Rc::<str>::from(format!("{}{}", v80.clone(), v75.clone()));
                let mut v82: Rc<str> = Rc::<str>::from(format!("{}{}", v81.clone(), v76.clone()));
                v82.clone()
            };
            let mut v84: i32 = (v83.clone().len() as i32);
            let mut v85: i32 = method4(v83.clone(), v84);
            let mut v86: i32 = v85 - 1i32;
            let mut v87: Rc<str> = string_slice(&v83.clone(), 0i32 as i64, v86 as i64);
            let mut v88: i32 = (v87.clone().len() as i32);
            let mut v89: bool = v88 < 3i32;
            let mut v97: Rc<str> = if v89 {
                v83.clone()
            } else {
                let mut v90: i32 = v88 - 3i32;
                let mut v91: i32 = v88 - 1i32;
                let mut v92: Rc<str> = string_slice(&v87.clone(), v90 as i64, v91 as i64);
                let mut v93: bool = v92.clone() == Rc::<str>::from("\n()");
                if v93 {
                    let mut v94: i32 = v88 - 4i32;
                    let mut v95: Rc<str> = string_slice(&v87.clone(), 0i32 as i64, v94 as i64);
                    v95.clone()
                } else {
                    v83.clone()
                }
            };
            let mut v98: Rc<str> = Rc::<str>::from("let main = StringBuilder()\n()\n");
            let mut v99: i32 = 0i32;
            let mut v100: i32 = method0(v98.clone(), v99);
            let mut v101: bool = v100 == -1i32;
            let mut v112: Rc<str> = if v101 {
                v98.clone()
            } else {
                let mut v102: i32 = method3(v98.clone(), v100);
                let mut v103: i32 = v100 - 1i32;
                let mut v104: Rc<str> = string_slice(&Rc::<str>::from("let main = StringBuilder()\n()\n"), v102 as i64, v103 as i64);
                let mut v105: Rc<str> = string_slice(&Rc::<str>::from("let main = StringBuilder()\n()\n"), v100 as i64, 29i32 as i64);
                let mut v106: i32 = v102 - 1i32;
                let mut v107: Rc<str> = string_slice(&Rc::<str>::from("let main = StringBuilder()\n()\n"), 0i32 as i64, v106 as i64);
                let mut v108: Rc<str> = Rc::<str>::from(format!("{}{}", v107.clone(), v104.clone()));
                let mut v109: Rc<str> = Rc::<str>::from(format!("{}{}", v108.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v110: Rc<str> = Rc::<str>::from(format!("{}{}", v109.clone(), v104.clone()));
                let mut v111: Rc<str> = Rc::<str>::from(format!("{}{}", v110.clone(), v105.clone()));
                v111.clone()
            };
            let mut v113: i32 = (v112.clone().len() as i32);
            let mut v114: i32 = method4(v112.clone(), v113);
            let mut v115: i32 = v114 - 1i32;
            let mut v116: Rc<str> = string_slice(&v112.clone(), 0i32 as i64, v115 as i64);
            let mut v117: i32 = (v116.clone().len() as i32);
            let mut v118: bool = v117 < 3i32;
            let mut v126: Rc<str> = if v118 {
                v112.clone()
            } else {
                let mut v119: i32 = v117 - 3i32;
                let mut v120: i32 = v117 - 1i32;
                let mut v121: Rc<str> = string_slice(&v116.clone(), v119 as i64, v120 as i64);
                let mut v122: bool = v121.clone() == Rc::<str>::from("\n()");
                if v122 {
                    let mut v123: i32 = v117 - 4i32;
                    let mut v124: Rc<str> = string_slice(&v116.clone(), 0i32 as i64, v123 as i64);
                    v124.clone()
                } else {
                    v112.clone()
                }
            };
            let mut v127: Rc<str> = Rc::<str>::from("let main() = 0\n()\n");
            let mut v128: i32 = 0i32;
            let mut v129: i32 = method0(v127.clone(), v128);
            let mut v130: bool = v129 == -1i32;
            let mut v141: Rc<str> = if v130 {
                v127.clone()
            } else {
                let mut v131: i32 = method3(v127.clone(), v129);
                let mut v132: i32 = v129 - 1i32;
                let mut v133: Rc<str> = string_slice(&Rc::<str>::from("let main() = 0\n()\n"), v131 as i64, v132 as i64);
                let mut v134: Rc<str> = string_slice(&Rc::<str>::from("let main() = 0\n()\n"), v129 as i64, 17i32 as i64);
                let mut v135: i32 = v131 - 1i32;
                let mut v136: Rc<str> = string_slice(&Rc::<str>::from("let main() = 0\n()\n"), 0i32 as i64, v135 as i64);
                let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v136.clone(), v133.clone()));
                let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v139: Rc<str> = Rc::<str>::from(format!("{}{}", v138.clone(), v133.clone()));
                let mut v140: Rc<str> = Rc::<str>::from(format!("{}{}", v139.clone(), v134.clone()));
                v140.clone()
            };
            let mut v142: i32 = (v141.clone().len() as i32);
            let mut v143: i32 = method4(v141.clone(), v142);
            let mut v144: i32 = v143 - 1i32;
            let mut v145: Rc<str> = string_slice(&v141.clone(), 0i32 as i64, v144 as i64);
            let mut v146: i32 = (v145.clone().len() as i32);
            let mut v147: bool = v146 < 3i32;
            let mut v155: Rc<str> = if v147 {
                v141.clone()
            } else {
                let mut v148: i32 = v146 - 3i32;
                let mut v149: i32 = v146 - 1i32;
                let mut v150: Rc<str> = string_slice(&v145.clone(), v148 as i64, v149 as i64);
                let mut v151: bool = v150.clone() == Rc::<str>::from("\n()");
                if v151 {
                    let mut v152: i32 = v146 - 4i32;
                    let mut v153: Rc<str> = string_slice(&v145.clone(), 0i32 as i64, v152 as i64);
                    v153.clone()
                } else {
                    v141.clone()
                }
            };
            let mut v156: bool = v39.clone() == Rc::<str>::from("    [<EntryPoint>]\n    let main args = 0");
            if v156 {
                let mut v157: bool = v68.clone() == Rc::<str>::from("let x = 1\n    [<EntryPoint>]\n    let main args = 0");
                if v157 {
                    let mut v158: bool = v97.clone() == Rc::<str>::from("        let main = StringBuilder()\n    [<EntryPoint>]\n    let main args = 0");
                    if v158 {
                        let mut v159: bool = v126.clone() == Rc::<str>::from("let main = StringBuilder()");
                        if v159 {
                            let mut v160: bool = v155.clone() == Rc::<str>::from("[<EntryPoint>]\nlet main() = 0");
                            if v160 {
                                0i32
                            } else {
                                5i32
                            }
                        } else {
                            4i32
                        }
                    } else {
                        3i32
                    }
                } else {
                    2i32
                }
            } else {
                1i32
            }
        }
        US0::US0_1 => { // Ship
            let mut v167: Rc<str> = Rc::<str>::from("spiral");
            let mut v168: Rc<str> = Rc::<str>::from("workspace");
            let mut v169: Rc<str> = Rc::<str>::from(std::path::Path::new(v167.as_ref()).join(v168.as_ref()).display().to_string());
            let mut v171: Rc<str> = Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default());
            let mut v172: Rc<str> = method5(v171.clone(), v169.clone());
            let mut v173: bool = v172.clone() == Rc::<str>::from("");
            let mut v177: Rc<str> = if v173 {
                let mut v175: Rc<str> = Rc::<str>::from(std::env::current_exe().ok().and_then(|path| path.parent().map(|dir| dir.to_path_buf())).map(|path| path.display().to_string()).unwrap_or_default());
                method5(v175.clone(), v169.clone())
            } else {
                v172.clone()
            };
            let mut v178: bool = v177.clone() == Rc::<str>::from("");
            let mut v181: Rc<str> = if v178 {
                let mut v179: Rc<str> = Rc::<str>::from("/workspaces");
                method5(v179.clone(), v169.clone())
            } else {
                v177.clone()
            };
            let mut v182: bool = v181.clone() == Rc::<str>::from("");
            let mut v214: Rc<str> = if v182 {
                let mut v183: Rc<str> = Rc::<str>::from("");
                v183.clone()
            } else {
                let mut v184: i32 = 0i32;
                let mut v185: i32 = -1i32;
                let mut v186: i32 = method6(v181.clone(), v184, v185);
                let mut v187: i32 = (v181.clone().len() as i32);
                let mut v188: bool = v186 == -1i32;
                let mut v195: Rc<str> = if v188 {
                    v181.clone()
                } else {
                    let mut v189: i32 = v186 + 1i32;
                    let mut v190: bool = v189 == v187;
                    if v190 {
                        let mut v191: Rc<str> = Rc::<str>::from("");
                        v191.clone()
                    } else {
                        let mut v192: i32 = v187 - 1i32;
                        let mut v193: Rc<str> = string_slice(&v181.clone(), v189 as i64, v192 as i64);
                        v193.clone()
                    }
                };
                let mut v196: bool = v195.clone() == Rc::<str>::from("deps");
                if v196 {
                    let mut v197: i32 = 0i32;
                    let mut v198: i32 = -1i32;
                    let mut v199: i32 = method6(v181.clone(), v197, v198);
                    let mut v200: bool = v199 == -1i32;
                    let mut v211: Rc<str> = if v200 {
                        let mut v201: Rc<str> = Rc::<str>::from("");
                        v201.clone()
                    } else {
                        let mut v202: i32 = v199 - 1i32;
                        let mut v203: Rc<str> = string_slice(&v181.clone(), 0i32 as i64, v202 as i64);
                        let mut v204: i32 = (v203.clone().len() as i32);
                        let mut v205: bool = v204 == 2i32;
                        let mut v208: bool = if v205 {
                            let mut v206: u8 = v203.clone().as_bytes()[1i32 as usize];
                            let mut v207: bool = v206 == b':';
                            v207
                        } else {
                            false
                        };
                        if v208 {
                            let mut v209: Rc<str> = string_slice(&v181.clone(), 0i32 as i64, v199 as i64);
                            v209.clone()
                        } else {
                            v203.clone()
                        }
                    };
                    method5(v211.clone(), v169.clone())
                } else {
                    v181.clone()
                }
            };
            let mut v215: bool = v214.clone() == Rc::<str>::from("");
            let mut v220: Rc<str> = if v215 {
                let mut v216: Rc<str> = Rc::<str>::from("");
                v216.clone()
            } else {
                let mut v218: Rc<str> = Rc::<str>::from("polyglot");
                let mut v219: Rc<str> = Rc::<str>::from(std::path::Path::new(v214.as_ref()).join(v218.as_ref()).display().to_string());
                v219.clone()
            };
            let mut v221: bool = v220.clone() == Rc::<str>::from("");
            let mut v242: Rc<str> = if v221 {
                let mut v223: Rc<str> = Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default());
                let mut v224: Rc<str> = Rc::<str>::from(".paket/Paket.Restore.targets");
                let mut v225: Rc<str> = method5(v223.clone(), v224.clone());
                let mut v226: bool = v225.clone() == Rc::<str>::from("");
                if v226 {
                    let mut v227: Rc<str> = Rc::<str>::from(".");
                    v227.clone()
                } else {
                    v225.clone()
                }
            } else {
                let mut v230: Rc<str> = Rc::<str>::from(".paket/Paket.Restore.targets");
                let mut v231: Rc<str> = Rc::<str>::from(std::path::Path::new(v220.as_ref()).join(v230.as_ref()).display().to_string());
                let mut v233: i32 = i32::from(std::path::Path::new(v231.as_ref()).exists());
                let mut v234: bool = v233 == 1i32;
                if v234 {
                    v220.clone()
                } else {
                    let mut v236: Rc<str> = Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default());
                    let mut v237: Rc<str> = method5(v236.clone(), v230.clone());
                    let mut v238: bool = v237.clone() == Rc::<str>::from("");
                    if v238 {
                        let mut v239: Rc<str> = Rc::<str>::from(".");
                        v239.clone()
                    } else {
                        v237.clone()
                    }
                }
            };
            let mut v243: i32 = 1i32;
            let mut v245: i32 = std::env::args().count() as i32;
            let mut v246: Rc<str> = method7(v243, v245);
            let mut v248: Rc<str> = Rc::<str>::from(std::path::absolute(v246.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from(v246.as_ref())).display().to_string());
            let mut v249: i32 = 0i32;
            let mut v250: i32 = -1i32;
            let mut v251: i32 = method6(v248.clone(), v249, v250);
            let mut v252: i32 = (v248.clone().len() as i32);
            let mut v253: bool = v251 == -1i32;
            let mut v260: Rc<str> = if v253 {
                v248.clone()
            } else {
                let mut v254: i32 = v251 + 1i32;
                let mut v255: bool = v254 == v252;
                if v255 {
                    let mut v256: Rc<str> = Rc::<str>::from("");
                    v256.clone()
                } else {
                    let mut v257: i32 = v252 - 1i32;
                    let mut v258: Rc<str> = string_slice(&v248.clone(), v254 as i64, v257 as i64);
                    v258.clone()
                }
            };
            let mut v261: i32 = 0i32;
            let mut v262: i32 = -1i32;
            let mut v263: i32 = method8(v260.clone(), v261, v262);
            let mut v264: bool = v263 <= 0i32;
            let mut v267: Rc<str> = if v264 {
                v260.clone()
            } else {
                let mut v265: i32 = v263 - 1i32;
                let mut v266: Rc<str> = string_slice(&v260.clone(), 0i32 as i64, v265 as i64);
                v266.clone()
            };
            let mut v269: Rc<str> = { let path = std::path::absolute(v246.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from(v246.as_ref())); Rc::<str>::from(std::fs::read_to_string(path).unwrap_or_default()) };
            let mut v270: i32 = 0i32;
            let mut v271: i32 = method0(v269.clone(), v270);
            let mut v272: bool = v271 == -1i32;
            let mut v285: Rc<str> = if v272 {
                v269.clone()
            } else {
                let mut v273: i32 = method3(v269.clone(), v271);
                let mut v274: i32 = v271 - 1i32;
                let mut v275: Rc<str> = string_slice(&v269.clone(), v273 as i64, v274 as i64);
                let mut v276: i32 = (v269.clone().len() as i32);
                let mut v277: i32 = v276 - 1i32;
                let mut v278: Rc<str> = string_slice(&v269.clone(), v271 as i64, v277 as i64);
                let mut v279: i32 = v273 - 1i32;
                let mut v280: Rc<str> = string_slice(&v269.clone(), 0i32 as i64, v279 as i64);
                let mut v281: Rc<str> = Rc::<str>::from(format!("{}{}", v280.clone(), v275.clone()));
                let mut v282: Rc<str> = Rc::<str>::from(format!("{}{}", v281.clone(), Rc::<str>::from("[<EntryPoint>]\n")));
                let mut v283: Rc<str> = Rc::<str>::from(format!("{}{}", v282.clone(), v275.clone()));
                let mut v284: Rc<str> = Rc::<str>::from(format!("{}{}", v283.clone(), v278.clone()));
                v284.clone()
            };
            let mut v286: i32 = (v285.clone().len() as i32);
            let mut v287: i32 = method4(v285.clone(), v286);
            let mut v288: i32 = v287 - 1i32;
            let mut v289: Rc<str> = string_slice(&v285.clone(), 0i32 as i64, v288 as i64);
            let mut v290: i32 = (v289.clone().len() as i32);
            let mut v291: bool = v290 < 3i32;
            let mut v299: Rc<str> = if v291 {
                v285.clone()
            } else {
                let mut v292: i32 = v290 - 3i32;
                let mut v293: i32 = v290 - 1i32;
                let mut v294: Rc<str> = string_slice(&v289.clone(), v292 as i64, v293 as i64);
                let mut v295: bool = v294.clone() == Rc::<str>::from("\n()");
                if v295 {
                    let mut v296: i32 = v290 - 4i32;
                    let mut v297: Rc<str> = string_slice(&v289.clone(), 0i32 as i64, v296 as i64);
                    v297.clone()
                } else {
                    v285.clone()
                }
            };
            let mut v301: Rc<str> = Rc::<str>::from(std::path::absolute(v246.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from(v246.as_ref())).display().to_string());
            let mut v302: i32 = 0i32;
            let mut v303: i32 = -1i32;
            let mut v304: i32 = method6(v301.clone(), v302, v303);
            let mut v305: bool = v304 == -1i32;
            let mut v316: Rc<str> = if v305 {
                let mut v306: Rc<str> = Rc::<str>::from("");
                v306.clone()
            } else {
                let mut v307: i32 = v304 - 1i32;
                let mut v308: Rc<str> = string_slice(&v301.clone(), 0i32 as i64, v307 as i64);
                let mut v309: i32 = (v308.clone().len() as i32);
                let mut v310: bool = v309 == 2i32;
                let mut v313: bool = if v310 {
                    let mut v311: u8 = v308.clone().as_bytes()[1i32 as usize];
                    let mut v312: bool = v311 == b':';
                    v312
                } else {
                    false
                };
                if v313 {
                    let mut v314: Rc<str> = string_slice(&v301.clone(), 0i32 as i64, v304 as i64);
                    v314.clone()
                } else {
                    v308.clone()
                }
            };
            let mut v318: Rc<str> = Rc::<str>::from("dist");
            let mut v319: Rc<str> = Rc::<str>::from(std::path::Path::new(v316.as_ref()).join(v318.as_ref()).display().to_string());
            let mut v321: i32 = std::env::args().count() as i32;
            let mut v322: Rc<str> = Rc::<str>::from("--modules");
            let mut v323: i32 = 1i32;
            let mut v324: i32 = method9(v322.clone(), v323, v321);
            let mut v325: bool = v324 == -1i32;
            let mut v331: Rc<str> = if v325 {
                let mut v326: Rc<str> = Rc::<str>::from("");
                v326.clone()
            } else {
                let mut v327: i32 = v324 + 1i32;
                let mut v328: Rc<str> = Rc::<str>::from("");
                let mut v329: i32 = 1i32;
                method10(v327, v321, v242.clone(), v328.clone(), v329)
            };
            let mut v333: i32 = std::env::args().count() as i32;
            let mut v334: Rc<str> = Rc::<str>::from("--packages");
            let mut v335: i32 = 1i32;
            let mut v336: i32 = method9(v334.clone(), v335, v333);
            let mut v337: bool = v336 == -1i32;
            let mut v343: Rc<str> = if v337 {
                let mut v338: Rc<str> = Rc::<str>::from("");
                v338.clone()
            } else {
                let mut v339: i32 = v336 + 1i32;
                let mut v340: Rc<str> = Rc::<str>::from("");
                let mut v341: i32 = 1i32;
                method11(v339, v333, v340.clone(), v341)
            };
            let mut v344: i32 = (v343.clone().len() as i32);
            let mut v345: bool = v344 == 0i32;
            let mut v348: Rc<str> = if v345 {
                let mut v346: Rc<str> = Rc::<str>::from("FSharp.Core");
                v346.clone()
            } else {
                let mut v347: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from("FSharp.Core\n"), v343.clone()));
                v347.clone()
            };
            let mut v350: Rc<str> = Rc::<str>::from("target");
            let mut v351: Rc<str> = Rc::<str>::from(std::path::Path::new(v242.as_ref()).join(v350.as_ref()).display().to_string());
            let mut v353: Rc<str> = Rc::<str>::from("Builder");
            let mut v354: Rc<str> = Rc::<str>::from(std::path::Path::new(v351.as_ref()).join(v353.as_ref()).display().to_string());
            let mut v356: Rc<str> = Rc::<str>::from(std::path::Path::new(v354.as_ref()).join(v267.as_ref()).display().to_string());
            let mut v357: Rc<str> = Rc::<str>::from(format!("{}{}", v267.clone(), Rc::<str>::from(".fs")));
            let mut v359: Rc<str> = Rc::<str>::from(std::path::Path::new(v356.as_ref()).join(v357.as_ref()).display().to_string());
            let mut v360: Rc<str> = Rc::<str>::from(format!("{}{}", v267.clone(), Rc::<str>::from(".fsproj")));
            let mut v362: Rc<str> = Rc::<str>::from(std::path::Path::new(v356.as_ref()).join(v360.as_ref()).display().to_string());
            let mut v364: i32 = { let path = std::path::Path::new(v359.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some(v299.as_ref())) };
            let mut v365: bool = v364 == 1i32;
            let mut v390: i32 = if v365 {
                0i32
            } else {
                let mut v366: i32 = 0i32;
                let mut v367: i32 = -1i32;
                let mut v368: i32 = method6(v359.clone(), v366, v367);
                let mut v369: bool = v368 == -1i32;
                let mut v380: Rc<str> = if v369 {
                    let mut v370: Rc<str> = Rc::<str>::from("");
                    v370.clone()
                } else {
                    let mut v371: i32 = v368 - 1i32;
                    let mut v372: Rc<str> = string_slice(&v359.clone(), 0i32 as i64, v371 as i64);
                    let mut v373: i32 = (v372.clone().len() as i32);
                    let mut v374: bool = v373 == 2i32;
                    let mut v377: bool = if v374 {
                        let mut v375: u8 = v372.clone().as_bytes()[1i32 as usize];
                        let mut v376: bool = v375 == b':';
                        v376
                    } else {
                        false
                    };
                    if v377 {
                        let mut v378: Rc<str> = string_slice(&v359.clone(), 0i32 as i64, v368 as i64);
                        v378.clone()
                    } else {
                        v372.clone()
                    }
                };
                let mut v381: i32 = (v380.clone().len() as i32);
                let mut v382: bool = v381 == 0i32;
                let mut v385: i32 = if v382 {
                    0i32
                } else {
                    let mut v384: i32 = i32::from(std::fs::create_dir_all(v380.as_ref()).is_err());
                    v384
                };
                let mut v386: bool = v385 == 0i32;
                if v386 {
                    let mut v388: i32 = i32::from(std::fs::write(v359.as_ref(), v299.as_ref().as_bytes()).is_err());
                    v388
                } else {
                    v385
                }
            };
            let mut v391: Rc<str> = Rc::<str>::from(format!("{}{}", Rc::<str>::from("<Project Sdk=\"Microsoft.NET.Sdk\">\n    <PropertyGroup>\n        <TargetFramework>net9.0</TargetFramework>\n        <LangVersion>preview</LangVersion>\n        <RollForward>Major</RollForward>\n        <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n        <ServerGarbageCollection>true</ServerGarbageCollection>\n        <ConcurrentGarbageCollection>true</ConcurrentGarbageCollection>\n        <PublishAot>false</PublishAot>\n        <PublishTrimmed>false</PublishTrimmed>\n        <PublishSingleFile>true</PublishSingleFile>\n        <SelfContained>true</SelfContained>\n        <Version>0.0.1-alpha.1</Version>\n        <OutputType>Exe</OutputType>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">\n        <DefineConstants>_FREEBSD</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">\n        <DefineConstants>_LINUX</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">\n        <DefineConstants>_OSX</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">\n        <DefineConstants>_WINDOWS</DefineConstants>\n    </PropertyGroup>\n\n    <ItemGroup>\n        "), v331.clone()));
            let mut v392: Rc<str> = Rc::<str>::from(format!("{}{}", v391.clone(), Rc::<str>::from("\n        <Compile Include=\"")));
            let mut v393: Rc<str> = Rc::<str>::from(format!("{}{}", v392.clone(), v359.clone()));
            let mut v394: Rc<str> = Rc::<str>::from(format!("{}{}", v393.clone(), Rc::<str>::from("\" />\n    </ItemGroup>\n    <ItemGroup>\n        <FrameworkReference Include=\"Microsoft.AspNetCore.App\" />\n    </ItemGroup>\n    <Import Project=\"")));
            let mut v395: Rc<str> = Rc::<str>::from(format!("{}{}", v394.clone(), v242.clone()));
            let mut v396: Rc<str> = Rc::<str>::from(format!("{}{}", v395.clone(), Rc::<str>::from("/.paket/Paket.Restore.targets\" />\n</Project>\n")));
            let mut v398: i32 = { let path = std::path::Path::new(v362.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some(v396.as_ref())) };
            let mut v399: bool = v398 == 1i32;
            let mut v424: i32 = if v399 {
                0i32
            } else {
                let mut v400: i32 = 0i32;
                let mut v401: i32 = -1i32;
                let mut v402: i32 = method6(v362.clone(), v400, v401);
                let mut v403: bool = v402 == -1i32;
                let mut v414: Rc<str> = if v403 {
                    let mut v404: Rc<str> = Rc::<str>::from("");
                    v404.clone()
                } else {
                    let mut v405: i32 = v402 - 1i32;
                    let mut v406: Rc<str> = string_slice(&v362.clone(), 0i32 as i64, v405 as i64);
                    let mut v407: i32 = (v406.clone().len() as i32);
                    let mut v408: bool = v407 == 2i32;
                    let mut v411: bool = if v408 {
                        let mut v409: u8 = v406.clone().as_bytes()[1i32 as usize];
                        let mut v410: bool = v409 == b':';
                        v410
                    } else {
                        false
                    };
                    if v411 {
                        let mut v412: Rc<str> = string_slice(&v362.clone(), 0i32 as i64, v402 as i64);
                        v412.clone()
                    } else {
                        v406.clone()
                    }
                };
                let mut v415: i32 = (v414.clone().len() as i32);
                let mut v416: bool = v415 == 0i32;
                let mut v419: i32 = if v416 {
                    0i32
                } else {
                    let mut v418: i32 = i32::from(std::fs::create_dir_all(v414.as_ref()).is_err());
                    v418
                };
                let mut v420: bool = v419 == 0i32;
                if v420 {
                    let mut v422: i32 = i32::from(std::fs::write(v362.as_ref(), v396.as_ref().as_bytes()).is_err());
                    v422
                } else {
                    v419
                }
            };
            let mut v426: Rc<str> = Rc::<str>::from("paket.references");
            let mut v427: Rc<str> = Rc::<str>::from(std::path::Path::new(v356.as_ref()).join(v426.as_ref()).display().to_string());
            let mut v429: i32 = { let path = std::path::Path::new(v427.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some(v348.as_ref())) };
            let mut v430: bool = v429 == 1i32;
            let mut v455: i32 = if v430 {
                0i32
            } else {
                let mut v431: i32 = 0i32;
                let mut v432: i32 = -1i32;
                let mut v433: i32 = method6(v427.clone(), v431, v432);
                let mut v434: bool = v433 == -1i32;
                let mut v445: Rc<str> = if v434 {
                    let mut v435: Rc<str> = Rc::<str>::from("");
                    v435.clone()
                } else {
                    let mut v436: i32 = v433 - 1i32;
                    let mut v437: Rc<str> = string_slice(&v427.clone(), 0i32 as i64, v436 as i64);
                    let mut v438: i32 = (v437.clone().len() as i32);
                    let mut v439: bool = v438 == 2i32;
                    let mut v442: bool = if v439 {
                        let mut v440: u8 = v437.clone().as_bytes()[1i32 as usize];
                        let mut v441: bool = v440 == b':';
                        v441
                    } else {
                        false
                    };
                    if v442 {
                        let mut v443: Rc<str> = string_slice(&v427.clone(), 0i32 as i64, v433 as i64);
                        v443.clone()
                    } else {
                        v437.clone()
                    }
                };
                let mut v446: i32 = (v445.clone().len() as i32);
                let mut v447: bool = v446 == 0i32;
                let mut v450: i32 = if v447 {
                    0i32
                } else {
                    let mut v449: i32 = i32::from(std::fs::create_dir_all(v445.as_ref()).is_err());
                    v449
                };
                let mut v451: bool = v450 == 0i32;
                if v451 {
                    let mut v453: i32 = i32::from(std::fs::write(v427.as_ref(), v348.as_ref().as_bytes()).is_err());
                    v453
                } else {
                    v450
                }
            };
            let mut v456: Rc<str> = Rc::<str>::from("--persist-only");
            let mut v457: i32 = 1i32;
            let mut v459: i32 = std::env::args().count() as i32;
            let mut v460: i32 = method9(v456.clone(), v457, v459);
            let mut v461: bool = v460 == -1i32;
            let mut v462: i32 = if v461 {
                0i32
            } else {
                1i32
            };
            let mut v463: bool = v462 == 1i32;
            if v463 {
                0i32
            } else {
                let mut v464: US1 = US1::US1_2(v362.clone(), v319.clone());
                let mut v466: i32 = std::env::args().count() as i32;
                let mut v467: Rc<str> = Rc::<str>::from("--runtime");
                let mut v468: i32 = 1i32;
                let mut v469: i32 = method9(v467.clone(), v468, v466);
                let mut v470: bool = v469 == -1i32;
                let mut v487: Rc<str> = if v470 {
                    let mut v471: Rc<str> = Rc::<str>::from("");
                    v471.clone()
                } else {
                    let mut v472: i32 = v469 + 1i32;
                    let mut v473: bool = v472 == v466;
                    if v473 {
                        let mut v474: Rc<str> = Rc::<str>::from("");
                        v474.clone()
                    } else {
                        let mut v476: Rc<str> = Rc::<str>::from(std::env::args().nth(v472 as usize).unwrap_or_default());
                        let mut v477: i32 = (v476.clone().len() as i32);
                        let mut v478: bool = v477 < 2i32;
                        let mut v481: bool = if v478 {
                            false
                        } else {
                            let mut v479: Rc<str> = string_slice(&v476.clone(), 0i32 as i64, 1i32 as i64);
                            let mut v480: bool = v479.clone() == Rc::<str>::from("--");
                            v480
                        };
                        if v481 {
                            let mut v482: Rc<str> = Rc::<str>::from("");
                            v482.clone()
                        } else {
                            let mut v484: Rc<str> = Rc::<str>::from(std::env::args().nth(v472 as usize).unwrap_or_default());
                            v484.clone()
                        }
                    }
                };
                let mut v488: i32 = (v487.clone().len() as i32);
                let mut v489: bool = v488 == 0i32;
                let mut v492: US2 = if v489 {
                    US2::US2_1
                } else {
                    US2::US2_0(v487.clone())
                };
                method12(v464.clone(), v492.clone())
            }
        }
        _ => unreachable!(),
    }
}
fn main() {
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(main.join().unwrap());
}
