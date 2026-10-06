#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_patterns, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) }; }
    // A slice that starts or ends inside a code point fails like the C and Delphi backends (abort / Halt(3)).
    if (bytes[from as usize] & 0xC0) == 0x80 || (to + 1 < length && (bytes[(to + 1) as usize] & 0xC0) == 0x80) { std::process::exit(3); }
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
fn method2(mut v0: Rc<str>, mut v1: i32, mut v2: Rc<str>, mut v3: i32) -> bool {
    loop {
        let mut v4: i32 = (v2.clone().len() as i32);
        let mut v5: bool = v3 == v4;
        if v5 {
            return true;
        } else {
            let mut v6: i32 = v1 + v3;
            let mut v7: u8 = v0.clone().as_bytes()[v6 as usize];
            let mut v8: u8 = v2.clone().as_bytes()[v3 as usize];
            let mut v9: bool = v7 == v8;
            if v9 {
                let mut v10: i32 = v3 + 1i32;
                (v0, v1, v2, v3) = (v0.clone(), v1, v2.clone(), v10);
                continue;
            } else {
                return false;
            }
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
            let mut v7: bool = v1 < 0i32;
            let mut v8: bool = v7 || v6;
            let mut v11: bool = if v8 {
                false
            } else {
                let mut v9: i32 = 0i32;
                method2(v0.clone(), v1, v2.clone(), v9)
            };
            if v11 {
                return v1;
            } else {
                let mut v12: i32 = v1 + 1i32;
                (v0, v1, v2) = (v0.clone(), v12, v2.clone());
                continue;
            }
        }
    }
}
fn method3(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
        let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main"); } LIT.with(|lit| lit.clone()) };
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
                        let mut v14: i32 = method3(v0.clone(), v6);
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
fn method4(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
fn method5(mut v0: Rc<str>, mut v1: i32) -> i32 {
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
fn method7(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn method6(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    loop {
        let mut v2: bool = v0.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        if v2 {
            let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
                let mut v11: i32 = method7(v0.clone(), v9, v10);
                let mut v12: bool = v11 == -1i32;
                let mut v23: Rc<str> = if v12 {
                    let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
                let mut v24: bool = v23.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v24 {
                    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    return v25.clone();
                } else {
                    let mut v26: bool = v23.clone() == v0.clone();
                    if v26 {
                        let mut v27: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
fn method8(mut v0: i32, mut v1: i32) -> Rc<str> {
    loop {
        let mut v2: bool = v0 == v1;
        if v2 {
            let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            return v3.clone();
        } else {
            let mut v5: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
            let mut v6: i32 = (v5.clone().len() as i32);
            let mut v7: bool = v6 < 2i32;
            let mut v10: bool = if v7 {
                false
            } else {
                let mut v8: Rc<str> = string_slice(&v5.clone(), 0i32 as i64, 1i32 as i64);
                let mut v9: bool = v8.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--"); } LIT.with(|lit| lit.clone()) };
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
fn method9(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn method10(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
fn method11(mut v0: i32, mut v1: i32, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: i32) -> Rc<str> {
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
                let mut v11: bool = v10.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--"); } LIT.with(|lit| lit.clone()) };
                v11
            };
            if v12 {
                return v3.clone();
            } else {
                let mut v14: Rc<str> = Rc::<str>::from(std::env::args().nth(v0 as usize).unwrap_or_default());
                let mut v16: Rc<str> = Rc::<str>::from(std::path::Path::new(v2.as_ref()).join(v14.as_ref()).display().to_string());
                let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<Compile Include=\""); } LIT.with(|lit| lit.clone()) }, v16.clone()));
                let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v17.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\" />"); } LIT.with(|lit| lit.clone()) }));
                let mut v19: bool = v4 == 1i32;
                let mut v22: Rc<str> = if v19 {
                    v18.clone()
                } else {
                    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v3.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n        "); } LIT.with(|lit| lit.clone()) }));
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
fn method12(mut v0: i32, mut v1: i32, mut v2: Rc<str>, mut v3: i32) -> Rc<str> {
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
                let mut v10: bool = v9.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--"); } LIT.with(|lit| lit.clone()) };
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
                    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v2.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
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
fn method13(mut v0: US1, mut v1: US2) -> i32 {
    match &v0 {
        US1::US1_2(v2, v3) => { // Project
            let mut v2: Rc<str> = v2.clone();
            let mut v3: Rc<str> = v3.clone();
            let mut v99: i32 = match &v1 {
                US2::US2_0(v4) => { // Chosen
                    let mut v4: Rc<str> = v4.clone();
                    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("publish\n"); } LIT.with(|lit| lit.clone()) }, v2.clone()));
                    let mut v6: Rc<str> = Rc::<str>::from(format!("{}{}", v5.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v6.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--configuration"); } LIT.with(|lit| lit.clone()) }));
                    let mut v8: Rc<str> = Rc::<str>::from(format!("{}{}", v7.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v8.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Release"); } LIT.with(|lit| lit.clone()) }));
                    let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v9.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v10.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--output"); } LIT.with(|lit| lit.clone()) }));
                    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v11.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12.clone(), v3.clone()));
                    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--runtime"); } LIT.with(|lit| lit.clone()) }));
                    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16.clone(), v4.clone()));
                    let mut v18: i32 = 0i32;
                    let mut v19: i32 = -1i32;
                    let mut v20: i32 = method7(v2.clone(), v18, v19);
                    let mut v21: bool = v20 == -1i32;
                    let mut v32: Rc<str> = if v21 {
                        let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
                        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
                        v35.clone()
                    } else {
                        v32.clone()
                    };
                    let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dotnet"); } LIT.with(|lit| lit.clone()) };
                    let mut v39: i32 = { let mut command = std::process::Command::new(v38.as_ref()); command.args(v17.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir(v36.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) };
                    v39
                }
                US2::US2_1 => { // Defaults
                    let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("publish\n"); } LIT.with(|lit| lit.clone()) }, v2.clone()));
                    let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--configuration"); } LIT.with(|lit| lit.clone()) }));
                    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Release"); } LIT.with(|lit| lit.clone()) }));
                    let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--output"); } LIT.with(|lit| lit.clone()) }));
                    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v48: Rc<str> = Rc::<str>::from(format!("{}{}", v47.clone(), v3.clone()));
                    let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v48.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v50: Rc<str> = Rc::<str>::from(format!("{}{}", v49.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--runtime"); } LIT.with(|lit| lit.clone()) }));
                    let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", v50.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v52: Rc<str> = Rc::<str>::from(format!("{}{}", v51.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("linux-x64"); } LIT.with(|lit| lit.clone()) }));
                    let mut v53: i32 = 0i32;
                    let mut v54: i32 = -1i32;
                    let mut v55: i32 = method7(v2.clone(), v53, v54);
                    let mut v56: bool = v55 == -1i32;
                    let mut v67: Rc<str> = if v56 {
                        let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
                        let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
                        v70.clone()
                    } else {
                        v67.clone()
                    };
                    let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dotnet"); } LIT.with(|lit| lit.clone()) };
                    let mut v74: i32 = { let mut command = std::process::Command::new(v73.as_ref()); command.args(v52.as_ref().split(char::from(10)).filter(|arg| arg.is_empty() == false)); let status = command.current_dir(v71.as_ref()).status(); status.map(|status| status.code().unwrap_or(1)).unwrap_or(1) };
                    let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v51.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("win-x64"); } LIT.with(|lit| lit.clone()) }));
                    let mut v76: i32 = 0i32;
                    let mut v77: i32 = -1i32;
                    let mut v78: i32 = method7(v2.clone(), v76, v77);
                    let mut v79: bool = v78 == -1i32;
                    let mut v90: Rc<str> = if v79 {
                        let mut v80: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
                        let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
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
            let mut v101: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("CI"); } LIT.with(|lit| lit.clone()) };
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
                let mut v111: i32 = method7(v108.clone(), v109, v110);
                let mut v112: bool = v111 == -1i32;
                let mut v123: Rc<str> = if v112 {
                    let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
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
                let mut v125: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("bin"); } LIT.with(|lit| lit.clone()) };
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
                let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("obj"); } LIT.with(|lit| lit.clone()) };
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
        let mut v5: bool = v4.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--self-test"); } LIT.with(|lit| lit.clone()) };
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
            let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) };
            let mut v12: i32 = 0i32;
            let mut v13: i32 = method0(v11.clone(), v12);
            let mut v14: bool = v13 == -1i32;
            let mut v25: Rc<str> = if v14 {
                v11.clone()
            } else {
                let mut v15: i32 = method4(v11.clone(), v13);
                let mut v16: i32 = v13 - 1i32;
                let mut v17: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v15 as i64, v16 as i64);
                let mut v18: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v13 as i64, 24i32 as i64);
                let mut v19: i32 = v15 - 1i32;
                let mut v20: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, 0i32 as i64, v19 as i64);
                let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v20.clone(), v17.clone()));
                let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[<EntryPoint>]\n"); } LIT.with(|lit| lit.clone()) }));
                let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v22.clone(), v17.clone()));
                let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23.clone(), v18.clone()));
                v24.clone()
            };
            let mut v26: i32 = (v25.clone().len() as i32);
            let mut v27: i32 = method5(v25.clone(), v26);
            let mut v28: i32 = v27 - 1i32;
            let mut v29: Rc<str> = string_slice(&v25.clone(), 0i32 as i64, v28 as i64);
            let mut v30: i32 = (v29.clone().len() as i32);
            let mut v31: bool = v30 < 3i32;
            let mut v44: Rc<str> = if v31 {
                v25.clone()
            } else {
                let mut v32: i32 = v30 - 3i32;
                let mut v33: bool = v32 < 0i32;
                let mut v36: bool = if v33 {
                    true
                } else {
                    let mut v34: i32 = v32 + 3i32;
                    let mut v35: bool = v34 > v30;
                    v35
                };
                let mut v40: bool = if v36 {
                    false
                } else {
                    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n()"); } LIT.with(|lit| lit.clone()) };
                    let mut v38: i32 = 0i32;
                    method2(v29.clone(), v32, v37.clone(), v38)
                };
                if v40 {
                    let mut v41: i32 = v30 - 4i32;
                    let mut v42: Rc<str> = string_slice(&v29.clone(), 0i32 as i64, v41 as i64);
                    v42.clone()
                } else {
                    v25.clone()
                }
            };
            let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) };
            let mut v46: i32 = 0i32;
            let mut v47: i32 = method0(v45.clone(), v46);
            let mut v48: bool = v47 == -1i32;
            let mut v59: Rc<str> = if v48 {
                v45.clone()
            } else {
                let mut v49: i32 = method4(v45.clone(), v47);
                let mut v50: i32 = v47 - 1i32;
                let mut v51: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v49 as i64, v50 as i64);
                let mut v52: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v47 as i64, 34i32 as i64);
                let mut v53: i32 = v49 - 1i32;
                let mut v54: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let x = 1\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, 0i32 as i64, v53 as i64);
                let mut v55: Rc<str> = Rc::<str>::from(format!("{}{}", v54.clone(), v51.clone()));
                let mut v56: Rc<str> = Rc::<str>::from(format!("{}{}", v55.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[<EntryPoint>]\n"); } LIT.with(|lit| lit.clone()) }));
                let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v56.clone(), v51.clone()));
                let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57.clone(), v52.clone()));
                v58.clone()
            };
            let mut v60: i32 = (v59.clone().len() as i32);
            let mut v61: i32 = method5(v59.clone(), v60);
            let mut v62: i32 = v61 - 1i32;
            let mut v63: Rc<str> = string_slice(&v59.clone(), 0i32 as i64, v62 as i64);
            let mut v64: i32 = (v63.clone().len() as i32);
            let mut v65: bool = v64 < 3i32;
            let mut v78: Rc<str> = if v65 {
                v59.clone()
            } else {
                let mut v66: i32 = v64 - 3i32;
                let mut v67: bool = v66 < 0i32;
                let mut v70: bool = if v67 {
                    true
                } else {
                    let mut v68: i32 = v66 + 3i32;
                    let mut v69: bool = v68 > v64;
                    v69
                };
                let mut v74: bool = if v70 {
                    false
                } else {
                    let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n()"); } LIT.with(|lit| lit.clone()) };
                    let mut v72: i32 = 0i32;
                    method2(v63.clone(), v66, v71.clone(), v72)
                };
                if v74 {
                    let mut v75: i32 = v64 - 4i32;
                    let mut v76: Rc<str> = string_slice(&v63.clone(), 0i32 as i64, v75 as i64);
                    v76.clone()
                } else {
                    v59.clone()
                }
            };
            let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) };
            let mut v80: i32 = 0i32;
            let mut v81: i32 = method0(v79.clone(), v80);
            let mut v82: bool = v81 == -1i32;
            let mut v93: Rc<str> = if v82 {
                v79.clone()
            } else {
                let mut v83: i32 = method4(v79.clone(), v81);
                let mut v84: i32 = v81 - 1i32;
                let mut v85: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v83 as i64, v84 as i64);
                let mut v86: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v81 as i64, 59i32 as i64);
                let mut v87: i32 = v83 - 1i32;
                let mut v88: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        let main = StringBuilder()\n    let main args = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, 0i32 as i64, v87 as i64);
                let mut v89: Rc<str> = Rc::<str>::from(format!("{}{}", v88.clone(), v85.clone()));
                let mut v90: Rc<str> = Rc::<str>::from(format!("{}{}", v89.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[<EntryPoint>]\n"); } LIT.with(|lit| lit.clone()) }));
                let mut v91: Rc<str> = Rc::<str>::from(format!("{}{}", v90.clone(), v85.clone()));
                let mut v92: Rc<str> = Rc::<str>::from(format!("{}{}", v91.clone(), v86.clone()));
                v92.clone()
            };
            let mut v94: i32 = (v93.clone().len() as i32);
            let mut v95: i32 = method5(v93.clone(), v94);
            let mut v96: i32 = v95 - 1i32;
            let mut v97: Rc<str> = string_slice(&v93.clone(), 0i32 as i64, v96 as i64);
            let mut v98: i32 = (v97.clone().len() as i32);
            let mut v99: bool = v98 < 3i32;
            let mut v112: Rc<str> = if v99 {
                v93.clone()
            } else {
                let mut v100: i32 = v98 - 3i32;
                let mut v101: bool = v100 < 0i32;
                let mut v104: bool = if v101 {
                    true
                } else {
                    let mut v102: i32 = v100 + 3i32;
                    let mut v103: bool = v102 > v98;
                    v103
                };
                let mut v108: bool = if v104 {
                    false
                } else {
                    let mut v105: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n()"); } LIT.with(|lit| lit.clone()) };
                    let mut v106: i32 = 0i32;
                    method2(v97.clone(), v100, v105.clone(), v106)
                };
                if v108 {
                    let mut v109: i32 = v98 - 4i32;
                    let mut v110: Rc<str> = string_slice(&v97.clone(), 0i32 as i64, v109 as i64);
                    v110.clone()
                } else {
                    v93.clone()
                }
            };
            let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main = StringBuilder()\n()\n"); } LIT.with(|lit| lit.clone()) };
            let mut v114: i32 = 0i32;
            let mut v115: i32 = method0(v113.clone(), v114);
            let mut v116: bool = v115 == -1i32;
            let mut v127: Rc<str> = if v116 {
                v113.clone()
            } else {
                let mut v117: i32 = method4(v113.clone(), v115);
                let mut v118: i32 = v115 - 1i32;
                let mut v119: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main = StringBuilder()\n()\n"); } LIT.with(|lit| lit.clone()) }, v117 as i64, v118 as i64);
                let mut v120: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main = StringBuilder()\n()\n"); } LIT.with(|lit| lit.clone()) }, v115 as i64, 29i32 as i64);
                let mut v121: i32 = v117 - 1i32;
                let mut v122: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main = StringBuilder()\n()\n"); } LIT.with(|lit| lit.clone()) }, 0i32 as i64, v121 as i64);
                let mut v123: Rc<str> = Rc::<str>::from(format!("{}{}", v122.clone(), v119.clone()));
                let mut v124: Rc<str> = Rc::<str>::from(format!("{}{}", v123.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[<EntryPoint>]\n"); } LIT.with(|lit| lit.clone()) }));
                let mut v125: Rc<str> = Rc::<str>::from(format!("{}{}", v124.clone(), v119.clone()));
                let mut v126: Rc<str> = Rc::<str>::from(format!("{}{}", v125.clone(), v120.clone()));
                v126.clone()
            };
            let mut v128: i32 = (v127.clone().len() as i32);
            let mut v129: i32 = method5(v127.clone(), v128);
            let mut v130: i32 = v129 - 1i32;
            let mut v131: Rc<str> = string_slice(&v127.clone(), 0i32 as i64, v130 as i64);
            let mut v132: i32 = (v131.clone().len() as i32);
            let mut v133: bool = v132 < 3i32;
            let mut v146: Rc<str> = if v133 {
                v127.clone()
            } else {
                let mut v134: i32 = v132 - 3i32;
                let mut v135: bool = v134 < 0i32;
                let mut v138: bool = if v135 {
                    true
                } else {
                    let mut v136: i32 = v134 + 3i32;
                    let mut v137: bool = v136 > v132;
                    v137
                };
                let mut v142: bool = if v138 {
                    false
                } else {
                    let mut v139: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n()"); } LIT.with(|lit| lit.clone()) };
                    let mut v140: i32 = 0i32;
                    method2(v131.clone(), v134, v139.clone(), v140)
                };
                if v142 {
                    let mut v143: i32 = v132 - 4i32;
                    let mut v144: Rc<str> = string_slice(&v131.clone(), 0i32 as i64, v143 as i64);
                    v144.clone()
                } else {
                    v127.clone()
                }
            };
            let mut v147: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main() = 0\n()\n"); } LIT.with(|lit| lit.clone()) };
            let mut v148: i32 = 0i32;
            let mut v149: i32 = method0(v147.clone(), v148);
            let mut v150: bool = v149 == -1i32;
            let mut v161: Rc<str> = if v150 {
                v147.clone()
            } else {
                let mut v151: i32 = method4(v147.clone(), v149);
                let mut v152: i32 = v149 - 1i32;
                let mut v153: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main() = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v151 as i64, v152 as i64);
                let mut v154: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main() = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, v149 as i64, 17i32 as i64);
                let mut v155: i32 = v151 - 1i32;
                let mut v156: Rc<str> = string_slice(&{ thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main() = 0\n()\n"); } LIT.with(|lit| lit.clone()) }, 0i32 as i64, v155 as i64);
                let mut v157: Rc<str> = Rc::<str>::from(format!("{}{}", v156.clone(), v153.clone()));
                let mut v158: Rc<str> = Rc::<str>::from(format!("{}{}", v157.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[<EntryPoint>]\n"); } LIT.with(|lit| lit.clone()) }));
                let mut v159: Rc<str> = Rc::<str>::from(format!("{}{}", v158.clone(), v153.clone()));
                let mut v160: Rc<str> = Rc::<str>::from(format!("{}{}", v159.clone(), v154.clone()));
                v160.clone()
            };
            let mut v162: i32 = (v161.clone().len() as i32);
            let mut v163: i32 = method5(v161.clone(), v162);
            let mut v164: i32 = v163 - 1i32;
            let mut v165: Rc<str> = string_slice(&v161.clone(), 0i32 as i64, v164 as i64);
            let mut v166: i32 = (v165.clone().len() as i32);
            let mut v167: bool = v166 < 3i32;
            let mut v180: Rc<str> = if v167 {
                v161.clone()
            } else {
                let mut v168: i32 = v166 - 3i32;
                let mut v169: bool = v168 < 0i32;
                let mut v172: bool = if v169 {
                    true
                } else {
                    let mut v170: i32 = v168 + 3i32;
                    let mut v171: bool = v170 > v166;
                    v171
                };
                let mut v176: bool = if v172 {
                    false
                } else {
                    let mut v173: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n()"); } LIT.with(|lit| lit.clone()) };
                    let mut v174: i32 = 0i32;
                    method2(v165.clone(), v168, v173.clone(), v174)
                };
                if v176 {
                    let mut v177: i32 = v166 - 4i32;
                    let mut v178: Rc<str> = string_slice(&v165.clone(), 0i32 as i64, v177 as i64);
                    v178.clone()
                } else {
                    v161.clone()
                }
            };
            let mut v181: bool = v44.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("    [<EntryPoint>]\n    let main args = 0"); } LIT.with(|lit| lit.clone()) };
            if v181 {
                let mut v182: bool = v78.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let x = 1\n    [<EntryPoint>]\n    let main args = 0"); } LIT.with(|lit| lit.clone()) };
                if v182 {
                    let mut v183: bool = v112.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("        let main = StringBuilder()\n    [<EntryPoint>]\n    let main args = 0"); } LIT.with(|lit| lit.clone()) };
                    if v183 {
                        let mut v184: bool = v146.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("let main = StringBuilder()"); } LIT.with(|lit| lit.clone()) };
                        if v184 {
                            let mut v185: bool = v180.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[<EntryPoint>]\nlet main() = 0"); } LIT.with(|lit| lit.clone()) };
                            if v185 {
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
            let mut v192: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("spiral"); } LIT.with(|lit| lit.clone()) };
            let mut v193: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("workspace"); } LIT.with(|lit| lit.clone()) };
            let mut v194: Rc<str> = Rc::<str>::from(std::path::Path::new(v192.as_ref()).join(v193.as_ref()).display().to_string());
            let mut v196: Rc<str> = Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default());
            let mut v197: Rc<str> = method6(v196.clone(), v194.clone());
            let mut v198: bool = v197.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v202: Rc<str> = if v198 {
                let mut v200: Rc<str> = Rc::<str>::from(std::env::current_exe().ok().and_then(|path| path.parent().map(|dir| dir.to_path_buf())).map(|path| path.display().to_string()).unwrap_or_default());
                method6(v200.clone(), v194.clone())
            } else {
                v197.clone()
            };
            let mut v203: bool = v202.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v206: Rc<str> = if v203 {
                let mut v204: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/workspaces"); } LIT.with(|lit| lit.clone()) };
                method6(v204.clone(), v194.clone())
            } else {
                v202.clone()
            };
            let mut v207: bool = v206.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v239: Rc<str> = if v207 {
                let mut v208: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v208.clone()
            } else {
                let mut v209: i32 = 0i32;
                let mut v210: i32 = -1i32;
                let mut v211: i32 = method7(v206.clone(), v209, v210);
                let mut v212: i32 = (v206.clone().len() as i32);
                let mut v213: bool = v211 == -1i32;
                let mut v220: Rc<str> = if v213 {
                    v206.clone()
                } else {
                    let mut v214: i32 = v211 + 1i32;
                    let mut v215: bool = v214 == v212;
                    if v215 {
                        let mut v216: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v216.clone()
                    } else {
                        let mut v217: i32 = v212 - 1i32;
                        let mut v218: Rc<str> = string_slice(&v206.clone(), v214 as i64, v217 as i64);
                        v218.clone()
                    }
                };
                let mut v221: bool = v220.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("deps"); } LIT.with(|lit| lit.clone()) };
                if v221 {
                    let mut v222: i32 = 0i32;
                    let mut v223: i32 = -1i32;
                    let mut v224: i32 = method7(v206.clone(), v222, v223);
                    let mut v225: bool = v224 == -1i32;
                    let mut v236: Rc<str> = if v225 {
                        let mut v226: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v226.clone()
                    } else {
                        let mut v227: i32 = v224 - 1i32;
                        let mut v228: Rc<str> = string_slice(&v206.clone(), 0i32 as i64, v227 as i64);
                        let mut v229: i32 = (v228.clone().len() as i32);
                        let mut v230: bool = v229 == 2i32;
                        let mut v233: bool = if v230 {
                            let mut v231: u8 = v228.clone().as_bytes()[1i32 as usize];
                            let mut v232: bool = v231 == b':';
                            v232
                        } else {
                            false
                        };
                        if v233 {
                            let mut v234: Rc<str> = string_slice(&v206.clone(), 0i32 as i64, v224 as i64);
                            v234.clone()
                        } else {
                            v228.clone()
                        }
                    };
                    method6(v236.clone(), v194.clone())
                } else {
                    v206.clone()
                }
            };
            let mut v240: bool = v239.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v245: Rc<str> = if v240 {
                let mut v241: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v241.clone()
            } else {
                let mut v243: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("polyglot"); } LIT.with(|lit| lit.clone()) };
                let mut v244: Rc<str> = Rc::<str>::from(std::path::Path::new(v239.as_ref()).join(v243.as_ref()).display().to_string());
                v244.clone()
            };
            let mut v246: bool = v245.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v267: Rc<str> = if v246 {
                let mut v248: Rc<str> = Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default());
                let mut v249: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".paket/Paket.Restore.targets"); } LIT.with(|lit| lit.clone()) };
                let mut v250: Rc<str> = method6(v248.clone(), v249.clone());
                let mut v251: bool = v250.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v251 {
                    let mut v252: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
                    v252.clone()
                } else {
                    v250.clone()
                }
            } else {
                let mut v255: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".paket/Paket.Restore.targets"); } LIT.with(|lit| lit.clone()) };
                let mut v256: Rc<str> = Rc::<str>::from(std::path::Path::new(v245.as_ref()).join(v255.as_ref()).display().to_string());
                let mut v258: i32 = i32::from(std::path::Path::new(v256.as_ref()).exists());
                let mut v259: bool = v258 == 1i32;
                if v259 {
                    v245.clone()
                } else {
                    let mut v261: Rc<str> = Rc::<str>::from(std::env::current_dir().map(|path| path.display().to_string()).unwrap_or_default());
                    let mut v262: Rc<str> = method6(v261.clone(), v255.clone());
                    let mut v263: bool = v262.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v263 {
                        let mut v264: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
                        v264.clone()
                    } else {
                        v262.clone()
                    }
                }
            };
            let mut v268: i32 = 1i32;
            let mut v270: i32 = std::env::args().count() as i32;
            let mut v271: Rc<str> = method8(v268, v270);
            let mut v273: Rc<str> = Rc::<str>::from(std::path::absolute(v271.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from(v271.as_ref())).display().to_string());
            let mut v274: i32 = 0i32;
            let mut v275: i32 = -1i32;
            let mut v276: i32 = method7(v273.clone(), v274, v275);
            let mut v277: i32 = (v273.clone().len() as i32);
            let mut v278: bool = v276 == -1i32;
            let mut v285: Rc<str> = if v278 {
                v273.clone()
            } else {
                let mut v279: i32 = v276 + 1i32;
                let mut v280: bool = v279 == v277;
                if v280 {
                    let mut v281: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v281.clone()
                } else {
                    let mut v282: i32 = v277 - 1i32;
                    let mut v283: Rc<str> = string_slice(&v273.clone(), v279 as i64, v282 as i64);
                    v283.clone()
                }
            };
            let mut v286: i32 = 0i32;
            let mut v287: i32 = -1i32;
            let mut v288: i32 = method9(v285.clone(), v286, v287);
            let mut v289: bool = v288 <= 0i32;
            let mut v292: Rc<str> = if v289 {
                v285.clone()
            } else {
                let mut v290: i32 = v288 - 1i32;
                let mut v291: Rc<str> = string_slice(&v285.clone(), 0i32 as i64, v290 as i64);
                v291.clone()
            };
            let mut v294: Rc<str> = { let path = std::path::absolute(v271.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from(v271.as_ref())); Rc::<str>::from(std::fs::read_to_string(path).unwrap_or_default()) };
            let mut v295: i32 = 0i32;
            let mut v296: i32 = method0(v294.clone(), v295);
            let mut v297: bool = v296 == -1i32;
            let mut v310: Rc<str> = if v297 {
                v294.clone()
            } else {
                let mut v298: i32 = method4(v294.clone(), v296);
                let mut v299: i32 = v296 - 1i32;
                let mut v300: Rc<str> = string_slice(&v294.clone(), v298 as i64, v299 as i64);
                let mut v301: i32 = (v294.clone().len() as i32);
                let mut v302: i32 = v301 - 1i32;
                let mut v303: Rc<str> = string_slice(&v294.clone(), v296 as i64, v302 as i64);
                let mut v304: i32 = v298 - 1i32;
                let mut v305: Rc<str> = string_slice(&v294.clone(), 0i32 as i64, v304 as i64);
                let mut v306: Rc<str> = Rc::<str>::from(format!("{}{}", v305.clone(), v300.clone()));
                let mut v307: Rc<str> = Rc::<str>::from(format!("{}{}", v306.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[<EntryPoint>]\n"); } LIT.with(|lit| lit.clone()) }));
                let mut v308: Rc<str> = Rc::<str>::from(format!("{}{}", v307.clone(), v300.clone()));
                let mut v309: Rc<str> = Rc::<str>::from(format!("{}{}", v308.clone(), v303.clone()));
                v309.clone()
            };
            let mut v311: i32 = (v310.clone().len() as i32);
            let mut v312: i32 = method5(v310.clone(), v311);
            let mut v313: i32 = v312 - 1i32;
            let mut v314: Rc<str> = string_slice(&v310.clone(), 0i32 as i64, v313 as i64);
            let mut v315: i32 = (v314.clone().len() as i32);
            let mut v316: bool = v315 < 3i32;
            let mut v329: Rc<str> = if v316 {
                v310.clone()
            } else {
                let mut v317: i32 = v315 - 3i32;
                let mut v318: bool = v317 < 0i32;
                let mut v321: bool = if v318 {
                    true
                } else {
                    let mut v319: i32 = v317 + 3i32;
                    let mut v320: bool = v319 > v315;
                    v320
                };
                let mut v325: bool = if v321 {
                    false
                } else {
                    let mut v322: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n()"); } LIT.with(|lit| lit.clone()) };
                    let mut v323: i32 = 0i32;
                    method2(v314.clone(), v317, v322.clone(), v323)
                };
                if v325 {
                    let mut v326: i32 = v315 - 4i32;
                    let mut v327: Rc<str> = string_slice(&v314.clone(), 0i32 as i64, v326 as i64);
                    v327.clone()
                } else {
                    v310.clone()
                }
            };
            let mut v331: Rc<str> = Rc::<str>::from(std::path::absolute(v271.as_ref()).unwrap_or_else(|_| std::path::PathBuf::from(v271.as_ref())).display().to_string());
            let mut v332: i32 = 0i32;
            let mut v333: i32 = -1i32;
            let mut v334: i32 = method7(v331.clone(), v332, v333);
            let mut v335: bool = v334 == -1i32;
            let mut v346: Rc<str> = if v335 {
                let mut v336: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v336.clone()
            } else {
                let mut v337: i32 = v334 - 1i32;
                let mut v338: Rc<str> = string_slice(&v331.clone(), 0i32 as i64, v337 as i64);
                let mut v339: i32 = (v338.clone().len() as i32);
                let mut v340: bool = v339 == 2i32;
                let mut v343: bool = if v340 {
                    let mut v341: u8 = v338.clone().as_bytes()[1i32 as usize];
                    let mut v342: bool = v341 == b':';
                    v342
                } else {
                    false
                };
                if v343 {
                    let mut v344: Rc<str> = string_slice(&v331.clone(), 0i32 as i64, v334 as i64);
                    v344.clone()
                } else {
                    v338.clone()
                }
            };
            let mut v348: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist"); } LIT.with(|lit| lit.clone()) };
            let mut v349: Rc<str> = Rc::<str>::from(std::path::Path::new(v346.as_ref()).join(v348.as_ref()).display().to_string());
            let mut v351: i32 = std::env::args().count() as i32;
            let mut v352: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--modules"); } LIT.with(|lit| lit.clone()) };
            let mut v353: i32 = 1i32;
            let mut v354: i32 = method10(v352.clone(), v353, v351);
            let mut v355: bool = v354 == -1i32;
            let mut v361: Rc<str> = if v355 {
                let mut v356: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v356.clone()
            } else {
                let mut v357: i32 = v354 + 1i32;
                let mut v358: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v359: i32 = 1i32;
                method11(v357, v351, v267.clone(), v358.clone(), v359)
            };
            let mut v363: i32 = std::env::args().count() as i32;
            let mut v364: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--packages"); } LIT.with(|lit| lit.clone()) };
            let mut v365: i32 = 1i32;
            let mut v366: i32 = method10(v364.clone(), v365, v363);
            let mut v367: bool = v366 == -1i32;
            let mut v373: Rc<str> = if v367 {
                let mut v368: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v368.clone()
            } else {
                let mut v369: i32 = v366 + 1i32;
                let mut v370: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v371: i32 = 1i32;
                method12(v369, v363, v370.clone(), v371)
            };
            let mut v374: i32 = (v373.clone().len() as i32);
            let mut v375: bool = v374 == 0i32;
            let mut v378: Rc<str> = if v375 {
                let mut v376: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("FSharp.Core"); } LIT.with(|lit| lit.clone()) };
                v376.clone()
            } else {
                let mut v377: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("FSharp.Core\n"); } LIT.with(|lit| lit.clone()) }, v373.clone()));
                v377.clone()
            };
            let mut v380: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("target"); } LIT.with(|lit| lit.clone()) };
            let mut v381: Rc<str> = Rc::<str>::from(std::path::Path::new(v267.as_ref()).join(v380.as_ref()).display().to_string());
            let mut v383: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Builder"); } LIT.with(|lit| lit.clone()) };
            let mut v384: Rc<str> = Rc::<str>::from(std::path::Path::new(v381.as_ref()).join(v383.as_ref()).display().to_string());
            let mut v386: Rc<str> = Rc::<str>::from(std::path::Path::new(v384.as_ref()).join(v292.as_ref()).display().to_string());
            let mut v387: Rc<str> = Rc::<str>::from(format!("{}{}", v292.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".fs"); } LIT.with(|lit| lit.clone()) }));
            let mut v389: Rc<str> = Rc::<str>::from(std::path::Path::new(v386.as_ref()).join(v387.as_ref()).display().to_string());
            let mut v390: Rc<str> = Rc::<str>::from(format!("{}{}", v292.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".fsproj"); } LIT.with(|lit| lit.clone()) }));
            let mut v392: Rc<str> = Rc::<str>::from(std::path::Path::new(v386.as_ref()).join(v390.as_ref()).display().to_string());
            let mut v394: i32 = { let path = std::path::Path::new(v389.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some(v329.as_ref())) };
            let mut v395: bool = v394 == 1i32;
            let mut v420: i32 = if v395 {
                0i32
            } else {
                let mut v396: i32 = 0i32;
                let mut v397: i32 = -1i32;
                let mut v398: i32 = method7(v389.clone(), v396, v397);
                let mut v399: bool = v398 == -1i32;
                let mut v410: Rc<str> = if v399 {
                    let mut v400: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v400.clone()
                } else {
                    let mut v401: i32 = v398 - 1i32;
                    let mut v402: Rc<str> = string_slice(&v389.clone(), 0i32 as i64, v401 as i64);
                    let mut v403: i32 = (v402.clone().len() as i32);
                    let mut v404: bool = v403 == 2i32;
                    let mut v407: bool = if v404 {
                        let mut v405: u8 = v402.clone().as_bytes()[1i32 as usize];
                        let mut v406: bool = v405 == b':';
                        v406
                    } else {
                        false
                    };
                    if v407 {
                        let mut v408: Rc<str> = string_slice(&v389.clone(), 0i32 as i64, v398 as i64);
                        v408.clone()
                    } else {
                        v402.clone()
                    }
                };
                let mut v411: i32 = (v410.clone().len() as i32);
                let mut v412: bool = v411 == 0i32;
                let mut v415: i32 = if v412 {
                    0i32
                } else {
                    let mut v414: i32 = i32::from(std::fs::create_dir_all(v410.as_ref()).is_err());
                    v414
                };
                let mut v416: bool = v415 == 0i32;
                if v416 {
                    let mut v418: i32 = i32::from(std::fs::write(v389.as_ref(), v329.as_ref().as_bytes()).is_err());
                    v418
                } else {
                    v415
                }
            };
            let mut v421: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<Project Sdk=\"Microsoft.NET.Sdk\">\n    <PropertyGroup>\n        <TargetFramework>net9.0</TargetFramework>\n        <LangVersion>preview</LangVersion>\n        <RollForward>Major</RollForward>\n        <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n        <ServerGarbageCollection>true</ServerGarbageCollection>\n        <ConcurrentGarbageCollection>true</ConcurrentGarbageCollection>\n        <PublishAot>false</PublishAot>\n        <PublishTrimmed>false</PublishTrimmed>\n        <PublishSingleFile>true</PublishSingleFile>\n        <SelfContained>true</SelfContained>\n        <Version>0.0.1-alpha.1</Version>\n        <OutputType>Exe</OutputType>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('FreeBSD'))\">\n        <DefineConstants>_FREEBSD</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Linux'))\">\n        <DefineConstants>_LINUX</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('OSX'))\">\n        <DefineConstants>_OSX</DefineConstants>\n    </PropertyGroup>\n\n    <PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform('Windows'))\">\n        <DefineConstants>_WINDOWS</DefineConstants>\n    </PropertyGroup>\n\n    <ItemGroup>\n        "); } LIT.with(|lit| lit.clone()) }, v361.clone()));
            let mut v422: Rc<str> = Rc::<str>::from(format!("{}{}", v421.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n        <Compile Include=\""); } LIT.with(|lit| lit.clone()) }));
            let mut v423: Rc<str> = Rc::<str>::from(format!("{}{}", v422.clone(), v389.clone()));
            let mut v424: Rc<str> = Rc::<str>::from(format!("{}{}", v423.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\" />\n    </ItemGroup>\n    <ItemGroup>\n        <FrameworkReference Include=\"Microsoft.AspNetCore.App\" />\n    </ItemGroup>\n    <Import Project=\""); } LIT.with(|lit| lit.clone()) }));
            let mut v425: Rc<str> = Rc::<str>::from(format!("{}{}", v424.clone(), v267.clone()));
            let mut v426: Rc<str> = Rc::<str>::from(format!("{}{}", v425.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/.paket/Paket.Restore.targets\" />\n</Project>\n"); } LIT.with(|lit| lit.clone()) }));
            let mut v428: i32 = { let path = std::path::Path::new(v392.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some(v426.as_ref())) };
            let mut v429: bool = v428 == 1i32;
            let mut v454: i32 = if v429 {
                0i32
            } else {
                let mut v430: i32 = 0i32;
                let mut v431: i32 = -1i32;
                let mut v432: i32 = method7(v392.clone(), v430, v431);
                let mut v433: bool = v432 == -1i32;
                let mut v444: Rc<str> = if v433 {
                    let mut v434: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v434.clone()
                } else {
                    let mut v435: i32 = v432 - 1i32;
                    let mut v436: Rc<str> = string_slice(&v392.clone(), 0i32 as i64, v435 as i64);
                    let mut v437: i32 = (v436.clone().len() as i32);
                    let mut v438: bool = v437 == 2i32;
                    let mut v441: bool = if v438 {
                        let mut v439: u8 = v436.clone().as_bytes()[1i32 as usize];
                        let mut v440: bool = v439 == b':';
                        v440
                    } else {
                        false
                    };
                    if v441 {
                        let mut v442: Rc<str> = string_slice(&v392.clone(), 0i32 as i64, v432 as i64);
                        v442.clone()
                    } else {
                        v436.clone()
                    }
                };
                let mut v445: i32 = (v444.clone().len() as i32);
                let mut v446: bool = v445 == 0i32;
                let mut v449: i32 = if v446 {
                    0i32
                } else {
                    let mut v448: i32 = i32::from(std::fs::create_dir_all(v444.as_ref()).is_err());
                    v448
                };
                let mut v450: bool = v449 == 0i32;
                if v450 {
                    let mut v452: i32 = i32::from(std::fs::write(v392.as_ref(), v426.as_ref().as_bytes()).is_err());
                    v452
                } else {
                    v449
                }
            };
            let mut v456: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("paket.references"); } LIT.with(|lit| lit.clone()) };
            let mut v457: Rc<str> = Rc::<str>::from(std::path::Path::new(v386.as_ref()).join(v456.as_ref()).display().to_string());
            let mut v459: i32 = { let path = std::path::Path::new(v457.as_ref()); i32::from(path.is_file() && std::fs::read_to_string(path).ok().as_deref() == Some(v378.as_ref())) };
            let mut v460: bool = v459 == 1i32;
            let mut v485: i32 = if v460 {
                0i32
            } else {
                let mut v461: i32 = 0i32;
                let mut v462: i32 = -1i32;
                let mut v463: i32 = method7(v457.clone(), v461, v462);
                let mut v464: bool = v463 == -1i32;
                let mut v475: Rc<str> = if v464 {
                    let mut v465: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v465.clone()
                } else {
                    let mut v466: i32 = v463 - 1i32;
                    let mut v467: Rc<str> = string_slice(&v457.clone(), 0i32 as i64, v466 as i64);
                    let mut v468: i32 = (v467.clone().len() as i32);
                    let mut v469: bool = v468 == 2i32;
                    let mut v472: bool = if v469 {
                        let mut v470: u8 = v467.clone().as_bytes()[1i32 as usize];
                        let mut v471: bool = v470 == b':';
                        v471
                    } else {
                        false
                    };
                    if v472 {
                        let mut v473: Rc<str> = string_slice(&v457.clone(), 0i32 as i64, v463 as i64);
                        v473.clone()
                    } else {
                        v467.clone()
                    }
                };
                let mut v476: i32 = (v475.clone().len() as i32);
                let mut v477: bool = v476 == 0i32;
                let mut v480: i32 = if v477 {
                    0i32
                } else {
                    let mut v479: i32 = i32::from(std::fs::create_dir_all(v475.as_ref()).is_err());
                    v479
                };
                let mut v481: bool = v480 == 0i32;
                if v481 {
                    let mut v483: i32 = i32::from(std::fs::write(v457.as_ref(), v378.as_ref().as_bytes()).is_err());
                    v483
                } else {
                    v480
                }
            };
            let mut v486: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--persist-only"); } LIT.with(|lit| lit.clone()) };
            let mut v487: i32 = 1i32;
            let mut v489: i32 = std::env::args().count() as i32;
            let mut v490: i32 = method10(v486.clone(), v487, v489);
            let mut v491: bool = v490 == -1i32;
            let mut v492: i32 = if v491 {
                0i32
            } else {
                1i32
            };
            let mut v493: bool = v492 == 1i32;
            if v493 {
                0i32
            } else {
                let mut v494: US1 = US1::US1_2(v392.clone(), v349.clone());
                let mut v496: i32 = std::env::args().count() as i32;
                let mut v497: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--runtime"); } LIT.with(|lit| lit.clone()) };
                let mut v498: i32 = 1i32;
                let mut v499: i32 = method10(v497.clone(), v498, v496);
                let mut v500: bool = v499 == -1i32;
                let mut v517: Rc<str> = if v500 {
                    let mut v501: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v501.clone()
                } else {
                    let mut v502: i32 = v499 + 1i32;
                    let mut v503: bool = v502 == v496;
                    if v503 {
                        let mut v504: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v504.clone()
                    } else {
                        let mut v506: Rc<str> = Rc::<str>::from(std::env::args().nth(v502 as usize).unwrap_or_default());
                        let mut v507: i32 = (v506.clone().len() as i32);
                        let mut v508: bool = v507 < 2i32;
                        let mut v511: bool = if v508 {
                            false
                        } else {
                            let mut v509: Rc<str> = string_slice(&v506.clone(), 0i32 as i64, 1i32 as i64);
                            let mut v510: bool = v509.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--"); } LIT.with(|lit| lit.clone()) };
                            v510
                        };
                        if v511 {
                            let mut v512: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v512.clone()
                        } else {
                            let mut v514: Rc<str> = Rc::<str>::from(std::env::args().nth(v502 as usize).unwrap_or_default());
                            v514.clone()
                        }
                    }
                };
                let mut v518: i32 = (v517.clone().len() as i32);
                let mut v519: bool = v518 == 0i32;
                let mut v522: US2 = if v519 {
                    US2::US2_1
                } else {
                    US2::US2_0(v517.clone())
                };
                method13(v494.clone(), v522.clone())
            }
        }
        _ => unreachable!(),
    }
}
#[cfg(not(target_arch = "wasm32"))]
fn main() {
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 101 });
}
#[cfg(target_arch = "wasm32")]
fn main() {
    spiral_main();
}
