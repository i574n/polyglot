#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
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
enum UH0 {
    UH0_0,
    UH0_1(i32, Rc<str>, Rc<UH0>),
}
impl UH0 {
    fn tag(&self) -> i32 {
        match self {
            UH0::UH0_0 => 0,
            UH0::UH0_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum UH1 {
    UH1_0,
    UH1_1(Rc<str>, Rc<str>, i64, Rc<UH1>),
    UH1_2(Rc<str>, Rc<str>, Rc<UH1>, Rc<UH1>),
}
impl UH1 {
    fn tag(&self) -> i32 {
        match self {
            UH1::UH1_0 => 0,
            UH1::UH1_1(..) => 1,
            UH1::UH1_2(..) => 2,
        }
    }
}
fn method0(mut v0: i64) -> Rc<str> {
    let mut v1: i64 = v0.wrapping_rem(10i64);
    let mut v2: bool = v1 == 0i64;
    let mut v32: Rc<str> = if v2 {
        let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
        v3.clone()
    } else {
        let mut v4: bool = v1 == 1i64;
        if v4 {
            let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("1"); } LIT.with(|lit| lit.clone()) };
            v5.clone()
        } else {
            let mut v6: bool = v1 == 2i64;
            if v6 {
                let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("2"); } LIT.with(|lit| lit.clone()) };
                v7.clone()
            } else {
                let mut v8: bool = v1 == 3i64;
                if v8 {
                    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("3"); } LIT.with(|lit| lit.clone()) };
                    v9.clone()
                } else {
                    let mut v10: bool = v1 == 4i64;
                    if v10 {
                        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("4"); } LIT.with(|lit| lit.clone()) };
                        v11.clone()
                    } else {
                        let mut v12: bool = v1 == 5i64;
                        if v12 {
                            let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("5"); } LIT.with(|lit| lit.clone()) };
                            v13.clone()
                        } else {
                            let mut v14: bool = v1 == 6i64;
                            if v14 {
                                let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("6"); } LIT.with(|lit| lit.clone()) };
                                v15.clone()
                            } else {
                                let mut v16: bool = v1 == 7i64;
                                if v16 {
                                    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("7"); } LIT.with(|lit| lit.clone()) };
                                    v17.clone()
                                } else {
                                    let mut v18: bool = v1 == 8i64;
                                    if v18 {
                                        let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("8"); } LIT.with(|lit| lit.clone()) };
                                        v19.clone()
                                    } else {
                                        let mut v20: bool = v1 == 9i64;
                                        if v20 {
                                            let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("9"); } LIT.with(|lit| lit.clone()) };
                                            v21.clone()
                                        } else {
                                            let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
                                            v22.clone()
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    };
    let mut v33: i64 = v0.wrapping_div(10i64);
    let mut v34: bool = v33 == 0i64;
    if v34 {
        v32.clone()
    } else {
        let mut v35: Rc<str> = method0(v33);
        let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35.clone(), v32.clone()));
        v36.clone()
    }
}
fn method2(mut v0: Rc<str>, mut v1: i64) -> Rc<str> {
    let mut v2: bool = v1 <= 0i64;
    if v2 {
        let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v3.clone()
    } else {
        let mut v4: i64 = v1.wrapping_sub(1i64);
        let mut v5: Rc<str> = method2(v0.clone(), v4);
        let mut v6: Rc<str> = Rc::<str>::from(format!("{}{}", v0.clone(), v5.clone()));
        v6.clone()
    }
}
fn method3(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
            let mut v10: i32 = v1.wrapping_add(1i32);
            (v0, v1, v2) = (v0.clone(), v10, v9);
            continue;
        }
    }
}
fn method1(mut v0: Rc<str>, mut v1: i64) -> i32 {
    loop {
        let mut v2: bool = v1 < 0i64;
        if v2 {
            return 0i32;
        } else {
            let mut v4: i32 = i32::from(std::fs::create_dir_all(v0.as_ref()).is_err());
            let mut v5: bool = v1 == 0i64;
            let mut v35: Rc<str> = if v5 {
                let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
                v6.clone()
            } else {
                let mut v7: bool = v1 == 1i64;
                if v7 {
                    let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("1"); } LIT.with(|lit| lit.clone()) };
                    v8.clone()
                } else {
                    let mut v9: bool = v1 == 2i64;
                    if v9 {
                        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("2"); } LIT.with(|lit| lit.clone()) };
                        v10.clone()
                    } else {
                        let mut v11: bool = v1 == 3i64;
                        if v11 {
                            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("3"); } LIT.with(|lit| lit.clone()) };
                            v12.clone()
                        } else {
                            let mut v13: bool = v1 == 4i64;
                            if v13 {
                                let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("4"); } LIT.with(|lit| lit.clone()) };
                                v14.clone()
                            } else {
                                let mut v15: bool = v1 == 5i64;
                                if v15 {
                                    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("5"); } LIT.with(|lit| lit.clone()) };
                                    v16.clone()
                                } else {
                                    let mut v17: bool = v1 == 6i64;
                                    if v17 {
                                        let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("6"); } LIT.with(|lit| lit.clone()) };
                                        v18.clone()
                                    } else {
                                        let mut v19: bool = v1 == 7i64;
                                        if v19 {
                                            let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("7"); } LIT.with(|lit| lit.clone()) };
                                            v20.clone()
                                        } else {
                                            let mut v21: bool = v1 == 8i64;
                                            if v21 {
                                                let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("8"); } LIT.with(|lit| lit.clone()) };
                                                v22.clone()
                                            } else {
                                                let mut v23: bool = v1 == 9i64;
                                                if v23 {
                                                    let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("9"); } LIT.with(|lit| lit.clone()) };
                                                    v24.clone()
                                                } else {
                                                    let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) };
                                                    v25.clone()
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file.txt"); } LIT.with(|lit| lit.clone()) };
            let mut v38: Rc<str> = Rc::<str>::from(std::path::Path::new(v0.as_ref()).join(v37.as_ref()).display().to_string());
            let mut v39: i64 = v1.wrapping_add(1i64);
            let mut v40: Rc<str> = method2(v35.clone(), v39);
            let mut v41: i32 = 0i32;
            let mut v42: i32 = -1i32;
            let mut v43: i32 = method3(v38.clone(), v41, v42);
            let mut v44: bool = v43 == -1i32;
            let mut v55: Rc<str> = if v44 {
                let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v45.clone()
            } else {
                let mut v46: i32 = v43.wrapping_sub(1i32);
                let mut v47: Rc<str> = string_slice(&v38.clone(), 0i32 as i64, v46 as i64);
                let mut v48: i32 = (v47.clone().len() as i32);
                let mut v49: bool = v48 == 2i32;
                let mut v52: bool = if v49 {
                    let mut v50: u8 = v47.clone().as_bytes()[1i32 as usize];
                    let mut v51: bool = v50 == b':';
                    v51
                } else {
                    false
                };
                if v52 {
                    let mut v53: Rc<str> = string_slice(&v38.clone(), 0i32 as i64, v43 as i64);
                    v53.clone()
                } else {
                    v47.clone()
                }
            };
            let mut v56: i32 = (v55.clone().len() as i32);
            let mut v57: bool = v56 == 0i32;
            let mut v60: i32 = if v57 {
                0i32
            } else {
                let mut v59: i32 = i32::from(std::fs::create_dir_all(v55.as_ref()).is_err());
                v59
            };
            let mut v61: bool = v60 == 0i32;
            let mut v64: i32 = if v61 {
                let mut v63: i32 = i32::from(std::fs::write(v38.as_ref(), v40.as_ref().as_bytes()).is_err());
                v63
            } else {
                v60
            };
            let mut v66: Rc<str> = Rc::<str>::from(std::path::Path::new(v0.as_ref()).join(v35.as_ref()).display().to_string());
            let mut v67: i64 = v1.wrapping_sub(1i64);
            (v0, v1) = (v66.clone(), v67);
            continue;
        }
    }
}
fn method5(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: i32 = (v0.clone().len() as i32);
        let mut v3: bool = v1 == v2;
        if v3 {
            return v1;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v1 as usize];
            let mut v5: bool = v4 == b'\n';
            if v5 {
                return v1;
            } else {
                let mut v6: i32 = v1.wrapping_add(1i32);
                (v0, v1) = (v0.clone(), v6);
                continue;
            }
        }
    }
}
fn method6(mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32) -> i32 {
    loop {
        let mut v4: bool = v1 == v2;
        if v4 {
            return v3;
        } else {
            let mut v5: i32 = v1.wrapping_add(1i32);
            let mut v6: i32 = v3.wrapping_mul(10i32);
            let mut v7: u8 = v0.clone().as_bytes()[v1 as usize];
            let mut v8: bool = v7 == b'0';
            let mut v27: i32 = if v8 {
                0i32
            } else {
                let mut v9: bool = v7 == b'1';
                if v9 {
                    1i32
                } else {
                    let mut v10: bool = v7 == b'2';
                    if v10 {
                        2i32
                    } else {
                        let mut v11: bool = v7 == b'3';
                        if v11 {
                            3i32
                        } else {
                            let mut v12: bool = v7 == b'4';
                            if v12 {
                                4i32
                            } else {
                                let mut v13: bool = v7 == b'5';
                                if v13 {
                                    5i32
                                } else {
                                    let mut v14: bool = v7 == b'6';
                                    if v14 {
                                        6i32
                                    } else {
                                        let mut v15: bool = v7 == b'7';
                                        if v15 {
                                            7i32
                                        } else {
                                            let mut v16: bool = v7 == b'8';
                                            if v16 {
                                                8i32
                                            } else {
                                                let mut v17: bool = v7 == b'9';
                                                if v17 {
                                                    9i32
                                                } else {
                                                    0i32
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            let mut v28: i32 = v6.wrapping_add(v27);
            (v0, v1, v2, v3) = (v0.clone(), v5, v2, v28);
            continue;
        }
    }
}
fn method4(mut v0: Rc<str>, mut v1: i32) -> Rc<UH0> {
    let mut v2: i32 = (v0.clone().len() as i32);
    let mut v3: bool = v1 == v2;
    if v3 {
        { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) }
    } else {
        let mut v5: i32 = v1.wrapping_add(2i32);
        let mut v6: i32 = method5(v0.clone(), v5);
        let mut v7: i32 = 0i32;
        let mut v8: i32 = method6(v0.clone(), v5, v6, v7);
        let mut v9: i32 = v6.wrapping_add(1i32);
        let mut v10: i32 = v9.wrapping_add(v8);
        let mut v11: i32 = v10.wrapping_sub(1i32);
        let mut v12: Rc<str> = string_slice(&v0.clone(), v9 as i64, v11 as i64);
        let mut v13: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v14: bool = v13 == b'1';
        let mut v15: i32 = if v14 {
            1i32
        } else {
            0i32
        };
        let mut v16: Rc<UH0> = method4(v0.clone(), v10);
        Rc::new(UH0::UH0_1(v15, v12.clone(), v16.clone()))
    }
}
fn method9(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: i32) -> i32 {
    loop {
        let mut v3: i32 = (v0.clone().len() as i32);
        let mut v4: i32 = (v1.clone().len() as i32);
        let mut v5: bool = v2 == v3;
        let mut v7: bool = if v5 {
            let mut v6: bool = v2 == v4;
            v6
        } else {
            false
        };
        if v7 {
            return 0i32;
        } else {
            if v5 {
                return -1i32;
            } else {
                let mut v8: bool = v2 == v4;
                if v8 {
                    return 1i32;
                } else {
                    let mut v9: u8 = v0.clone().as_bytes()[v2 as usize];
                    let mut v10: u8 = v1.clone().as_bytes()[v2 as usize];
                    let mut v11: bool = v9 == v10;
                    if v11 {
                        let mut v12: i32 = v2.wrapping_add(1i32);
                        (v0, v1, v2) = (v0.clone(), v1.clone(), v12);
                        continue;
                    } else {
                        let mut v14: bool = v9 < v10;
                        if v14 {
                            return -1i32;
                        } else {
                            return 1i32;
                        }
                    }
                }
            }
        }
    }
}
fn method8(mut v0: i32, mut v1: Rc<str>, mut v2: Rc<UH0>) -> Rc<UH0> {
    match &*v2 {
        UH0::UH0_1(v5, v6, v7) => { // Child
            let mut v5: i32 = *v5;
            let mut v6: Rc<str> = v6.clone();
            let mut v7: Rc<UH0> = v7.clone();
            let mut v8: bool = v0 == v5;
            let mut v13: bool = if v8 {
                let mut v9: i32 = 0i32;
                let mut v10: i32 = method9(v1.clone(), v6.clone(), v9);
                let mut v11: bool = v10 < 0i32;
                v11
            } else {
                let mut v12: bool = v0 > v5;
                v12
            };
            if v13 {
                Rc::new(UH0::UH0_1(v0, v1.clone(), v2.clone()))
            } else {
                let mut v15: Rc<UH0> = method8(v0, v1.clone(), v7.clone());
                Rc::new(UH0::UH0_1(v5, v6.clone(), v15.clone()))
            }
        }
        UH0::UH0_0 => { // ChildEnd
            let mut v3: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            Rc::new(UH0::UH0_1(v0, v1.clone(), v3.clone()))
        }
    }
}
fn method7(mut v0: Rc<UH0>) -> Rc<UH0> {
    match &*v0 {
        UH0::UH0_1(v2, v3, v4) => { // Child
            let mut v2: i32 = *v2;
            let mut v3: Rc<str> = v3.clone();
            let mut v4: Rc<UH0> = v4.clone();
            let mut v5: Rc<UH0> = method7(v4.clone());
            method8(v2, v3.clone(), v5.clone())
        }
        UH0::UH0_0 => { // ChildEnd
            { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) }
        }
    }
}
fn method10(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<UH0>) -> Rc<UH1> {
    match &*v2 {
        UH0::UH0_1(v4, v5, v6) => { // Child
            let mut v4: i32 = *v4;
            let mut v5: Rc<str> = v5.clone();
            let mut v6: Rc<UH0> = v6.clone();
            let mut v7: Rc<UH1> = method10(v0.clone(), v1.clone(), v6.clone());
            let mut v8: bool = v4 == 1i32;
            if v8 {
                let mut v10: Rc<str> = Rc::<str>::from(std::path::Path::new(v0.as_ref()).join(v5.as_ref()).display().to_string());
                let mut v11: i32 = (v1.clone().len() as i32);
                let mut v12: bool = v11 == 0i32;
                let mut v15: Rc<str> = if v12 {
                    v5.clone()
                } else {
                    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v1.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) }));
                    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13.clone(), v5.clone()));
                    v14.clone()
                };
                let mut v17: Rc<str> = { let mut out = String::new(); if let Ok(read) = std::fs::read_dir(v10.as_ref()) { for entry in read.flatten() { let child = entry.path(); let Some(name) = child.file_name() else { continue }; let name = name.to_string_lossy(); if child.is_dir() { out.push(char::from(49)); } else if child.is_file() { out.push(char::from(48)); } else { continue }; out.push(char::from(32)); out.push_str(&name.len().to_string()); out.push(char::from(10)); out.push_str(&name); } } Rc::<str>::from(out) };
                let mut v18: i32 = 0i32;
                let mut v19: Rc<UH0> = method4(v17.clone(), v18);
                let mut v20: Rc<UH0> = method7(v19.clone());
                let mut v21: Rc<UH1> = method10(v10.clone(), v15.clone(), v20.clone());
                Rc::new(UH1::UH1_2(v5.clone(), v15.clone(), v21.clone(), v7.clone()))
            } else {
                let mut v24: Rc<str> = Rc::<str>::from(std::path::Path::new(v0.as_ref()).join(v5.as_ref()).display().to_string());
                let mut v26: i64 = std::fs::metadata(v24.as_ref()).map(|meta| meta.len() as i64).unwrap_or(0);
                Rc::new(UH1::UH1_1(v5.clone(), v1.clone(), v26, v7.clone()))
            }
        }
        UH0::UH0_0 => { // ChildEnd
            { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) }
        }
    }
}
fn method12(mut v0: Rc<UH1>) -> i64 {
    match &*v0 {
        UH1::UH1_0 => { // End
            0i64
        }
        UH1::UH1_1(v1, v2, v3, v4) => { // File
            let mut v1: Rc<str> = v1.clone();
            let mut v2: Rc<str> = v2.clone();
            let mut v3: i64 = *v3;
            let mut v4: Rc<UH1> = v4.clone();
            let mut v5: i64 = method12(v4.clone());
            let mut v6: i64 = v3.wrapping_add(v5);
            v6
        }
        UH1::UH1_2(v7, v8, v9, v10) => { // Folder
            let mut v7: Rc<str> = v7.clone();
            let mut v8: Rc<str> = v8.clone();
            let mut v9: Rc<UH1> = v9.clone();
            let mut v10: Rc<UH1> = v10.clone();
            let mut v11: i64 = method12(v9.clone());
            let mut v12: i64 = method12(v10.clone());
            let mut v13: i64 = v11.wrapping_add(v12);
            v13
        }
    }
}
fn method11(mut v0: Rc<UH1>) -> Rc<str> {
    match &*v0 {
        UH1::UH1_0 => { // End
            let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v1.clone()
        }
        UH1::UH1_1(v2, v3, v4, v5) => { // File
            let mut v2: Rc<str> = v2.clone();
            let mut v3: Rc<str> = v3.clone();
            let mut v4: i64 = *v4;
            let mut v5: Rc<UH1> = v5.clone();
            let mut v6: i32 = (v3.clone().len() as i32);
            let mut v7: bool = v6 == 0i32;
            let mut v10: Rc<str> = if v7 {
                v2.clone()
            } else {
                let mut v8: Rc<str> = Rc::<str>::from(format!("{}{}", v3.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) }));
                let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v8.clone(), v2.clone()));
                v9.clone()
            };
            let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("&#128196; <a href=\""); } LIT.with(|lit| lit.clone()) }, v10.clone()));
            let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v11.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\""); } LIT.with(|lit| lit.clone()) }));
            let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(">"); } LIT.with(|lit| lit.clone()) }));
            let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13.clone(), v2.clone()));
            let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</a><span> ("); } LIT.with(|lit| lit.clone()) }));
            let mut v16: bool = v4 > 1048576i64;
            let mut v56: Rc<str> = if v16 {
                let mut v17: i64 = v4.wrapping_mul(100i64);
                let mut v18: i64 = v17.wrapping_add(524288i64);
                let mut v19: i64 = v18.wrapping_div(1048576i64);
                let mut v20: i64 = v19.wrapping_div(100i64);
                let mut v21: Rc<str> = method0(v20);
                let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                let mut v23: i64 = v19.wrapping_rem(100i64);
                let mut v24: Rc<str> = method0(v23);
                let mut v25: bool = v23 < 10i64;
                let mut v27: Rc<str> = if v25 {
                    let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v24.clone()));
                    v26.clone()
                } else {
                    v24.clone()
                };
                let mut v28: Rc<str> = Rc::<str>::from(format!("{}{}", v22.clone(), v27.clone()));
                let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v28.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" MB"); } LIT.with(|lit| lit.clone()) }));
                v29.clone()
            } else {
                let mut v30: bool = v4 > 1024i64;
                if v30 {
                    let mut v31: i64 = v4.wrapping_mul(100i64);
                    let mut v32: i64 = v31.wrapping_add(512i64);
                    let mut v33: i64 = v32.wrapping_div(1024i64);
                    let mut v34: i64 = v33.wrapping_div(100i64);
                    let mut v35: Rc<str> = method0(v34);
                    let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                    let mut v37: i64 = v33.wrapping_rem(100i64);
                    let mut v38: Rc<str> = method0(v37);
                    let mut v39: bool = v37 < 10i64;
                    let mut v41: Rc<str> = if v39 {
                        let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v38.clone()));
                        v40.clone()
                    } else {
                        v38.clone()
                    };
                    let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v36.clone(), v41.clone()));
                    let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" KB"); } LIT.with(|lit| lit.clone()) }));
                    v43.clone()
                } else {
                    let mut v44: i64 = v4.wrapping_mul(100i64);
                    let mut v45: i64 = v44.wrapping_div(100i64);
                    let mut v46: Rc<str> = method0(v45);
                    let mut v47: Rc<str> = Rc::<str>::from(format!("{}{}", v46.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                    let mut v48: i64 = v44.wrapping_rem(100i64);
                    let mut v49: Rc<str> = method0(v48);
                    let mut v50: bool = v48 < 10i64;
                    let mut v52: Rc<str> = if v50 {
                        let mut v51: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v49.clone()));
                        v51.clone()
                    } else {
                        v49.clone()
                    };
                    let mut v53: Rc<str> = Rc::<str>::from(format!("{}{}", v47.clone(), v52.clone()));
                    let mut v54: Rc<str> = Rc::<str>::from(format!("{}{}", v53.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" B"); } LIT.with(|lit| lit.clone()) }));
                    v54.clone()
                }
            };
            let mut v57: Rc<str> = Rc::<str>::from(format!("{}{}", v15.clone(), v56.clone()));
            let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v57.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(")</span>"); } LIT.with(|lit| lit.clone()) }));
            let mut v59: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<div>"); } LIT.with(|lit| lit.clone()) }, v58.clone()));
            let mut v60: Rc<str> = Rc::<str>::from(format!("{}{}", v59.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</div>"); } LIT.with(|lit| lit.clone()) }));
            let mut v61: Rc<str> = method11(v5.clone());
            let mut v62: Rc<str> = Rc::<str>::from(format!("{}{}", v60.clone(), v61.clone()));
            v62.clone()
        }
        UH1::UH1_2(v63, v64, v65, v66) => { // Folder
            let mut v63: Rc<str> = v63.clone();
            let mut v64: Rc<str> = v64.clone();
            let mut v65: Rc<UH1> = v65.clone();
            let mut v66: Rc<UH1> = v66.clone();
            let mut v67: i64 = method12(v65.clone());
            let mut v68: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("&#128194; <a href=\""); } LIT.with(|lit| lit.clone()) }, v64.clone()));
            let mut v69: Rc<str> = Rc::<str>::from(format!("{}{}", v68.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\""); } LIT.with(|lit| lit.clone()) }));
            let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", v69.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(">"); } LIT.with(|lit| lit.clone()) }));
            let mut v71: Rc<str> = Rc::<str>::from(format!("{}{}", v70.clone(), v63.clone()));
            let mut v72: Rc<str> = Rc::<str>::from(format!("{}{}", v71.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</a><span> ("); } LIT.with(|lit| lit.clone()) }));
            let mut v73: bool = v67 > 1048576i64;
            let mut v113: Rc<str> = if v73 {
                let mut v74: i64 = v67.wrapping_mul(100i64);
                let mut v75: i64 = v74.wrapping_add(524288i64);
                let mut v76: i64 = v75.wrapping_div(1048576i64);
                let mut v77: i64 = v76.wrapping_div(100i64);
                let mut v78: Rc<str> = method0(v77);
                let mut v79: Rc<str> = Rc::<str>::from(format!("{}{}", v78.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                let mut v80: i64 = v76.wrapping_rem(100i64);
                let mut v81: Rc<str> = method0(v80);
                let mut v82: bool = v80 < 10i64;
                let mut v84: Rc<str> = if v82 {
                    let mut v83: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v81.clone()));
                    v83.clone()
                } else {
                    v81.clone()
                };
                let mut v85: Rc<str> = Rc::<str>::from(format!("{}{}", v79.clone(), v84.clone()));
                let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v85.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" MB"); } LIT.with(|lit| lit.clone()) }));
                v86.clone()
            } else {
                let mut v87: bool = v67 > 1024i64;
                if v87 {
                    let mut v88: i64 = v67.wrapping_mul(100i64);
                    let mut v89: i64 = v88.wrapping_add(512i64);
                    let mut v90: i64 = v89.wrapping_div(1024i64);
                    let mut v91: i64 = v90.wrapping_div(100i64);
                    let mut v92: Rc<str> = method0(v91);
                    let mut v93: Rc<str> = Rc::<str>::from(format!("{}{}", v92.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                    let mut v94: i64 = v90.wrapping_rem(100i64);
                    let mut v95: Rc<str> = method0(v94);
                    let mut v96: bool = v94 < 10i64;
                    let mut v98: Rc<str> = if v96 {
                        let mut v97: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v95.clone()));
                        v97.clone()
                    } else {
                        v95.clone()
                    };
                    let mut v99: Rc<str> = Rc::<str>::from(format!("{}{}", v93.clone(), v98.clone()));
                    let mut v100: Rc<str> = Rc::<str>::from(format!("{}{}", v99.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" KB"); } LIT.with(|lit| lit.clone()) }));
                    v100.clone()
                } else {
                    let mut v101: i64 = v67.wrapping_mul(100i64);
                    let mut v102: i64 = v101.wrapping_div(100i64);
                    let mut v103: Rc<str> = method0(v102);
                    let mut v104: Rc<str> = Rc::<str>::from(format!("{}{}", v103.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                    let mut v105: i64 = v101.wrapping_rem(100i64);
                    let mut v106: Rc<str> = method0(v105);
                    let mut v107: bool = v105 < 10i64;
                    let mut v109: Rc<str> = if v107 {
                        let mut v108: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v106.clone()));
                        v108.clone()
                    } else {
                        v106.clone()
                    };
                    let mut v110: Rc<str> = Rc::<str>::from(format!("{}{}", v104.clone(), v109.clone()));
                    let mut v111: Rc<str> = Rc::<str>::from(format!("{}{}", v110.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" B"); } LIT.with(|lit| lit.clone()) }));
                    v111.clone()
                }
            };
            let mut v114: Rc<str> = Rc::<str>::from(format!("{}{}", v72.clone(), v113.clone()));
            let mut v115: Rc<str> = Rc::<str>::from(format!("{}{}", v114.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(")</span>"); } LIT.with(|lit| lit.clone()) }));
            let mut v116: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<details open=\"true\"><summary>"); } LIT.with(|lit| lit.clone()) }, v115.clone()));
            let mut v117: Rc<str> = Rc::<str>::from(format!("{}{}", v116.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</summary><div>"); } LIT.with(|lit| lit.clone()) }));
            let mut v118: Rc<str> = method11(v65.clone());
            let mut v119: Rc<str> = Rc::<str>::from(format!("{}{}", v117.clone(), v118.clone()));
            let mut v120: Rc<str> = Rc::<str>::from(format!("{}{}", v119.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</div></details>"); } LIT.with(|lit| lit.clone()) }));
            let mut v121: Rc<str> = method11(v66.clone());
            let mut v122: Rc<str> = Rc::<str>::from(format!("{}{}", v120.clone(), v121.clone()));
            v122.clone()
        }
    }
}
fn method13(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
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
                let mut v7: i32 = v1.wrapping_add(1i32);
                (v0, v1, v2) = (v0.clone(), v7, v2);
                continue;
            }
        }
    }
}
fn spiral_main() -> i32 {
    let mut v1: i32 = std::env::args().count() as i32;
    let mut v2: bool = v1 == 2i32;
    if v2 {
        let mut v4: Rc<str> = Rc::<str>::from(std::env::args().nth(1i32 as usize).unwrap_or_default());
        let mut v5: bool = v4.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--self-test"); } LIT.with(|lit| lit.clone()) };
        if v5 {
            let mut v7: Rc<str> = Rc::<str>::from(std::env::temp_dir().display().to_string());
            let mut v9: i64 = std::process::id() as i64;
            let mut v10: Rc<str> = method0(v9);
            let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v10.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("-"); } LIT.with(|lit| lit.clone()) }));
            let mut v13: i64 = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).unwrap().as_nanos() as i64;
            let mut v14: Rc<str> = method0(v13);
            let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v11.clone(), v14.clone()));
            let mut v17: Rc<str> = Rc::<str>::from(std::path::Path::new(v7.as_ref()).join(v15.as_ref()).display().to_string());
            let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("_.root"); } LIT.with(|lit| lit.clone()) };
            let mut v20: Rc<str> = Rc::<str>::from(std::path::Path::new(v17.as_ref()).join(v19.as_ref()).display().to_string());
            let mut v21: i64 = 3i64;
            let mut v22: i32 = method1(v20.clone(), v21);
            let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v25: Rc<str> = { let mut out = String::new(); if let Ok(read) = std::fs::read_dir(v17.as_ref()) { for entry in read.flatten() { let child = entry.path(); let Some(name) = child.file_name() else { continue }; let name = name.to_string_lossy(); if child.is_dir() { out.push(char::from(49)); } else if child.is_file() { out.push(char::from(48)); } else { continue }; out.push(char::from(32)); out.push_str(&name.len().to_string()); out.push(char::from(10)); out.push_str(&name); } } Rc::<str>::from(out) };
            let mut v26: i32 = 0i32;
            let mut v27: Rc<UH0> = method4(v25.clone(), v26);
            let mut v28: Rc<UH0> = method7(v27.clone());
            let mut v29: Rc<UH1> = method10(v17.clone(), v23.clone(), v28.clone());
            let mut v30: Rc<str> = method11(v29.clone());
            let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n  <meta charset=\"UTF-8\">\n  <style>\nbody {\n    background-color: #222;\n    color: #ccc;\n}\na {\n  color: #777;\n  font-size: 15px;\n}\nspan {\n  font-size: 11px;\n}\ndiv > div {\n  padding-left: 10px;\n}\ndetails > div {\n  padding-left: 19px;\n}\n  </style>\n</head>\n<body>\n  <div>"); } LIT.with(|lit| lit.clone()) }, v30.clone()));
            let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v31.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</div>\n</body>\n</html>\n"); } LIT.with(|lit| lit.clone()) }));
            let mut v33: bool = v32.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n  <meta charset=\"UTF-8\">\n  <style>\nbody {\n    background-color: #222;\n    color: #ccc;\n}\na {\n  color: #777;\n  font-size: 15px;\n}\nspan {\n  font-size: 11px;\n}\ndiv > div {\n  padding-left: 10px;\n}\ndetails > div {\n  padding-left: 19px;\n}\n  </style>\n</head>\n<body>\n  <div><details open=\"true\"><summary>&#128194; <a href=\"_.root\">_.root</a><span> (10.00 B)</span></summary><div><details open=\"true\"><summary>&#128194; <a href=\"_.root/3\">3</a><span> (6.00 B)</span></summary><div><details open=\"true\"><summary>&#128194; <a href=\"_.root/3/2\">2</a><span> (3.00 B)</span></summary><div><details open=\"true\"><summary>&#128194; <a href=\"_.root/3/2/1\">1</a><span> (1.00 B)</span></summary><div><div>&#128196; <a href=\"_.root/3/2/1/file.txt\">file.txt</a><span> (1.00 B)</span></div></div></details><div>&#128196; <a href=\"_.root/3/2/file.txt\">file.txt</a><span> (2.00 B)</span></div></div></details><div>&#128196; <a href=\"_.root/3/file.txt\">file.txt</a><span> (3.00 B)</span></div></div></details><div>&#128196; <a href=\"_.root/file.txt\">file.txt</a><span> (4.00 B)</span></div></div></details></div>\n</body>\n</html>\n"); } LIT.with(|lit| lit.clone()) };
            let mut v62: i32 = if v33 {
                0i32
            } else {
                let mut v35: Rc<str> = Rc::<str>::from(std::env::temp_dir().display().to_string());
                let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir-tree-html-got.html"); } LIT.with(|lit| lit.clone()) };
                let mut v38: Rc<str> = Rc::<str>::from(std::path::Path::new(v35.as_ref()).join(v37.as_ref()).display().to_string());
                let mut v39: i32 = 0i32;
                let mut v40: i32 = -1i32;
                let mut v41: i32 = method3(v38.clone(), v39, v40);
                let mut v42: bool = v41 == -1i32;
                let mut v52: Rc<str> = if v42 {
                    v23.clone()
                } else {
                    let mut v43: i32 = v41.wrapping_sub(1i32);
                    let mut v44: Rc<str> = string_slice(&v38.clone(), 0i32 as i64, v43 as i64);
                    let mut v45: i32 = (v44.clone().len() as i32);
                    let mut v46: bool = v45 == 2i32;
                    let mut v49: bool = if v46 {
                        let mut v47: u8 = v44.clone().as_bytes()[1i32 as usize];
                        let mut v48: bool = v47 == b':';
                        v48
                    } else {
                        false
                    };
                    if v49 {
                        let mut v50: Rc<str> = string_slice(&v38.clone(), 0i32 as i64, v41 as i64);
                        v50.clone()
                    } else {
                        v44.clone()
                    }
                };
                let mut v53: i32 = (v52.clone().len() as i32);
                let mut v54: bool = v53 == 0i32;
                let mut v57: i32 = if v54 {
                    0i32
                } else {
                    let mut v56: i32 = i32::from(std::fs::create_dir_all(v52.as_ref()).is_err());
                    v56
                };
                let mut v58: bool = v57 == 0i32;
                let mut v61: i32 = if v58 {
                    let mut v60: i32 = i32::from(std::fs::write(v38.as_ref(), v32.as_ref().as_bytes()).is_err());
                    v60
                } else {
                    v57
                };
                1i32
            };
            let mut v63: i64 = method12(v29.clone());
            let mut v64: bool = v63 == 10i64;
            let mut v65: i32 = if v64 {
                0i32
            } else {
                3i32
            };
            let mut v67: Rc<str> = Rc::<str>::from(std::env::temp_dir().display().to_string());
            let mut v69: i64 = std::process::id() as i64;
            let mut v70: Rc<str> = method0(v69);
            let mut v71: Rc<str> = Rc::<str>::from(format!("{}{}", v70.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("-"); } LIT.with(|lit| lit.clone()) }));
            let mut v73: i64 = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).unwrap().as_nanos() as i64;
            let mut v74: Rc<str> = method0(v73);
            let mut v75: Rc<str> = Rc::<str>::from(format!("{}{}", v71.clone(), v74.clone()));
            let mut v77: Rc<str> = Rc::<str>::from(std::path::Path::new(v67.as_ref()).join(v75.as_ref()).display().to_string());
            let mut v79: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("m"); } LIT.with(|lit| lit.clone()) };
            let mut v80: Rc<str> = Rc::<str>::from(std::path::Path::new(v77.as_ref()).join(v79.as_ref()).display().to_string());
            let mut v82: i32 = i32::from(std::fs::create_dir_all(v80.as_ref()).is_err());
            let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("b.txt"); } LIT.with(|lit| lit.clone()) };
            let mut v85: Rc<str> = Rc::<str>::from(std::path::Path::new(v77.as_ref()).join(v84.as_ref()).display().to_string());
            let mut v86: i32 = 0i32;
            let mut v87: i32 = -1i32;
            let mut v88: i32 = method3(v85.clone(), v86, v87);
            let mut v89: bool = v88 == -1i32;
            let mut v99: Rc<str> = if v89 {
                v23.clone()
            } else {
                let mut v90: i32 = v88.wrapping_sub(1i32);
                let mut v91: Rc<str> = string_slice(&v85.clone(), 0i32 as i64, v90 as i64);
                let mut v92: i32 = (v91.clone().len() as i32);
                let mut v93: bool = v92 == 2i32;
                let mut v96: bool = if v93 {
                    let mut v94: u8 = v91.clone().as_bytes()[1i32 as usize];
                    let mut v95: bool = v94 == b':';
                    v95
                } else {
                    false
                };
                if v96 {
                    let mut v97: Rc<str> = string_slice(&v85.clone(), 0i32 as i64, v88 as i64);
                    v97.clone()
                } else {
                    v91.clone()
                }
            };
            let mut v100: i32 = (v99.clone().len() as i32);
            let mut v101: bool = v100 == 0i32;
            let mut v104: i32 = if v101 {
                0i32
            } else {
                let mut v103: i32 = i32::from(std::fs::create_dir_all(v99.as_ref()).is_err());
                v103
            };
            let mut v105: bool = v104 == 0i32;
            let mut v109: i32 = if v105 {
                let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("x"); } LIT.with(|lit| lit.clone()) };
                let mut v108: i32 = i32::from(std::fs::write(v85.as_ref(), v107.as_ref().as_bytes()).is_err());
                v108
            } else {
                v104
            };
            let mut v111: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("a.txt"); } LIT.with(|lit| lit.clone()) };
            let mut v112: Rc<str> = Rc::<str>::from(std::path::Path::new(v77.as_ref()).join(v111.as_ref()).display().to_string());
            let mut v113: i32 = 0i32;
            let mut v114: i32 = -1i32;
            let mut v115: i32 = method3(v112.clone(), v113, v114);
            let mut v116: bool = v115 == -1i32;
            let mut v126: Rc<str> = if v116 {
                v23.clone()
            } else {
                let mut v117: i32 = v115.wrapping_sub(1i32);
                let mut v118: Rc<str> = string_slice(&v112.clone(), 0i32 as i64, v117 as i64);
                let mut v119: i32 = (v118.clone().len() as i32);
                let mut v120: bool = v119 == 2i32;
                let mut v123: bool = if v120 {
                    let mut v121: u8 = v118.clone().as_bytes()[1i32 as usize];
                    let mut v122: bool = v121 == b':';
                    v122
                } else {
                    false
                };
                if v123 {
                    let mut v124: Rc<str> = string_slice(&v112.clone(), 0i32 as i64, v115 as i64);
                    v124.clone()
                } else {
                    v118.clone()
                }
            };
            let mut v127: i32 = (v126.clone().len() as i32);
            let mut v128: bool = v127 == 0i32;
            let mut v131: i32 = if v128 {
                0i32
            } else {
                let mut v130: i32 = i32::from(std::fs::create_dir_all(v126.as_ref()).is_err());
                v130
            };
            let mut v132: bool = v131 == 0i32;
            let mut v136: i32 = if v132 {
                let mut v134: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("yy"); } LIT.with(|lit| lit.clone()) };
                let mut v135: i32 = i32::from(std::fs::write(v112.as_ref(), v134.as_ref().as_bytes()).is_err());
                v135
            } else {
                v131
            };
            let mut v138: Rc<str> = Rc::<str>::from(std::path::Path::new(v77.as_ref()).join(v79.as_ref()).display().to_string());
            let mut v140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file.txt"); } LIT.with(|lit| lit.clone()) };
            let mut v141: Rc<str> = Rc::<str>::from(std::path::Path::new(v138.as_ref()).join(v140.as_ref()).display().to_string());
            let mut v142: i32 = 0i32;
            let mut v143: i32 = -1i32;
            let mut v144: i32 = method3(v141.clone(), v142, v143);
            let mut v145: bool = v144 == -1i32;
            let mut v155: Rc<str> = if v145 {
                v23.clone()
            } else {
                let mut v146: i32 = v144.wrapping_sub(1i32);
                let mut v147: Rc<str> = string_slice(&v141.clone(), 0i32 as i64, v146 as i64);
                let mut v148: i32 = (v147.clone().len() as i32);
                let mut v149: bool = v148 == 2i32;
                let mut v152: bool = if v149 {
                    let mut v150: u8 = v147.clone().as_bytes()[1i32 as usize];
                    let mut v151: bool = v150 == b':';
                    v151
                } else {
                    false
                };
                if v152 {
                    let mut v153: Rc<str> = string_slice(&v141.clone(), 0i32 as i64, v144 as i64);
                    v153.clone()
                } else {
                    v147.clone()
                }
            };
            let mut v156: i32 = (v155.clone().len() as i32);
            let mut v157: bool = v156 == 0i32;
            let mut v160: i32 = if v157 {
                0i32
            } else {
                let mut v159: i32 = i32::from(std::fs::create_dir_all(v155.as_ref()).is_err());
                v159
            };
            let mut v161: bool = v160 == 0i32;
            let mut v165: i32 = if v161 {
                let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("z"); } LIT.with(|lit| lit.clone()) };
                let mut v164: i32 = i32::from(std::fs::write(v141.as_ref(), v163.as_ref().as_bytes()).is_err());
                v164
            } else {
                v160
            };
            let mut v167: Rc<str> = { let mut out = String::new(); if let Ok(read) = std::fs::read_dir(v77.as_ref()) { for entry in read.flatten() { let child = entry.path(); let Some(name) = child.file_name() else { continue }; let name = name.to_string_lossy(); if child.is_dir() { out.push(char::from(49)); } else if child.is_file() { out.push(char::from(48)); } else { continue }; out.push(char::from(32)); out.push_str(&name.len().to_string()); out.push(char::from(10)); out.push_str(&name); } } Rc::<str>::from(out) };
            let mut v168: i32 = 0i32;
            let mut v169: Rc<UH0> = method4(v167.clone(), v168);
            let mut v170: Rc<UH0> = method7(v169.clone());
            let mut v171: Rc<UH1> = method10(v77.clone(), v23.clone(), v170.clone());
            let mut v172: Rc<str> = method11(v171.clone());
            let mut v173: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n  <meta charset=\"UTF-8\">\n  <style>\nbody {\n    background-color: #222;\n    color: #ccc;\n}\na {\n  color: #777;\n  font-size: 15px;\n}\nspan {\n  font-size: 11px;\n}\ndiv > div {\n  padding-left: 10px;\n}\ndetails > div {\n  padding-left: 19px;\n}\n  </style>\n</head>\n<body>\n  <div>"); } LIT.with(|lit| lit.clone()) }, v172.clone()));
            let mut v174: Rc<str> = Rc::<str>::from(format!("{}{}", v173.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</div>\n</body>\n</html>\n"); } LIT.with(|lit| lit.clone()) }));
            let mut v175: bool = v174.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n  <meta charset=\"UTF-8\">\n  <style>\nbody {\n    background-color: #222;\n    color: #ccc;\n}\na {\n  color: #777;\n  font-size: 15px;\n}\nspan {\n  font-size: 11px;\n}\ndiv > div {\n  padding-left: 10px;\n}\ndetails > div {\n  padding-left: 19px;\n}\n  </style>\n</head>\n<body>\n  <div><details open=\"true\"><summary>&#128194; <a href=\"m\">m</a><span> (1.00 B)</span></summary><div><div>&#128196; <a href=\"m/file.txt\">file.txt</a><span> (1.00 B)</span></div></div></details><div>&#128196; <a href=\"a.txt\">a.txt</a><span> (2.00 B)</span></div><div>&#128196; <a href=\"b.txt\">b.txt</a><span> (1.00 B)</span></div></div>\n</body>\n</html>\n"); } LIT.with(|lit| lit.clone()) };
            let mut v204: i32 = if v175 {
                0i32
            } else {
                let mut v177: Rc<str> = Rc::<str>::from(std::env::temp_dir().display().to_string());
                let mut v179: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir-tree-html-order-got.html"); } LIT.with(|lit| lit.clone()) };
                let mut v180: Rc<str> = Rc::<str>::from(std::path::Path::new(v177.as_ref()).join(v179.as_ref()).display().to_string());
                let mut v181: i32 = 0i32;
                let mut v182: i32 = -1i32;
                let mut v183: i32 = method3(v180.clone(), v181, v182);
                let mut v184: bool = v183 == -1i32;
                let mut v194: Rc<str> = if v184 {
                    v23.clone()
                } else {
                    let mut v185: i32 = v183.wrapping_sub(1i32);
                    let mut v186: Rc<str> = string_slice(&v180.clone(), 0i32 as i64, v185 as i64);
                    let mut v187: i32 = (v186.clone().len() as i32);
                    let mut v188: bool = v187 == 2i32;
                    let mut v191: bool = if v188 {
                        let mut v189: u8 = v186.clone().as_bytes()[1i32 as usize];
                        let mut v190: bool = v189 == b':';
                        v190
                    } else {
                        false
                    };
                    if v191 {
                        let mut v192: Rc<str> = string_slice(&v180.clone(), 0i32 as i64, v183 as i64);
                        v192.clone()
                    } else {
                        v186.clone()
                    }
                };
                let mut v195: i32 = (v194.clone().len() as i32);
                let mut v196: bool = v195 == 0i32;
                let mut v199: i32 = if v196 {
                    0i32
                } else {
                    let mut v198: i32 = i32::from(std::fs::create_dir_all(v194.as_ref()).is_err());
                    v198
                };
                let mut v200: bool = v199 == 0i32;
                let mut v203: i32 = if v200 {
                    let mut v202: i32 = i32::from(std::fs::write(v180.as_ref(), v174.as_ref().as_bytes()).is_err());
                    v202
                } else {
                    v199
                };
                1i32
            };
            let mut v205: i64 = 1024i64;
            let mut v206: Rc<str> = method0(v205);
            let mut v207: Rc<str> = Rc::<str>::from(format!("{}{}", v206.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
            let mut v208: i64 = 0i64;
            let mut v209: Rc<str> = method0(v208);
            let mut v210: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v209.clone()));
            let mut v211: Rc<str> = Rc::<str>::from(format!("{}{}", v207.clone(), v210.clone()));
            let mut v212: Rc<str> = Rc::<str>::from(format!("{}{}", v211.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" B"); } LIT.with(|lit| lit.clone()) }));
            let mut v213: bool = v212.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("1024.00 B"); } LIT.with(|lit| lit.clone()) };
            let mut v244: i32 = if v213 {
                let mut v214: i64 = 1i64;
                let mut v215: Rc<str> = method0(v214);
                let mut v216: Rc<str> = Rc::<str>::from(format!("{}{}", v215.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                let mut v217: i64 = 0i64;
                let mut v218: Rc<str> = method0(v217);
                let mut v219: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v218.clone()));
                let mut v220: Rc<str> = Rc::<str>::from(format!("{}{}", v216.clone(), v219.clone()));
                let mut v221: Rc<str> = Rc::<str>::from(format!("{}{}", v220.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" KB"); } LIT.with(|lit| lit.clone()) }));
                let mut v222: bool = v221.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("1.00 KB"); } LIT.with(|lit| lit.clone()) };
                if v222 {
                    let mut v223: i64 = 1024i64;
                    let mut v224: Rc<str> = method0(v223);
                    let mut v225: Rc<str> = Rc::<str>::from(format!("{}{}", v224.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                    let mut v226: i64 = 0i64;
                    let mut v227: Rc<str> = method0(v226);
                    let mut v228: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v227.clone()));
                    let mut v229: Rc<str> = Rc::<str>::from(format!("{}{}", v225.clone(), v228.clone()));
                    let mut v230: Rc<str> = Rc::<str>::from(format!("{}{}", v229.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" KB"); } LIT.with(|lit| lit.clone()) }));
                    let mut v231: bool = v230.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("1024.00 KB"); } LIT.with(|lit| lit.clone()) };
                    if v231 {
                        let mut v232: i64 = 1i64;
                        let mut v233: Rc<str> = method0(v232);
                        let mut v234: Rc<str> = Rc::<str>::from(format!("{}{}", v233.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) }));
                        let mut v235: i64 = 0i64;
                        let mut v236: Rc<str> = method0(v235);
                        let mut v237: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("0"); } LIT.with(|lit| lit.clone()) }, v236.clone()));
                        let mut v238: Rc<str> = Rc::<str>::from(format!("{}{}", v234.clone(), v237.clone()));
                        let mut v239: Rc<str> = Rc::<str>::from(format!("{}{}", v238.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" MB"); } LIT.with(|lit| lit.clone()) }));
                        let mut v240: bool = v239.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("1.00 MB"); } LIT.with(|lit| lit.clone()) };
                        if v240 {
                            0i32
                        } else {
                            1i32
                        }
                    } else {
                        1i32
                    }
                } else {
                    1i32
                }
            } else {
                1i32
            };
            let mut v245: bool = v62 == 0i32;
            if v245 {
                let mut v246: bool = v65 == 0i32;
                if v246 {
                    let mut v247: bool = v204 == 0i32;
                    if v247 {
                        v244
                    } else {
                        v204
                    }
                } else {
                    v65
                }
            } else {
                v62
            }
        } else {
            let mut v251: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--dir"); } LIT.with(|lit| lit.clone()) };
            let mut v252: i32 = 1i32;
            let mut v254: i32 = std::env::args().count() as i32;
            let mut v255: i32 = method13(v251.clone(), v252, v254);
            let mut v256: bool = v255 == -1i32;
            let mut v262: i32 = if v256 {
                -1i32
            } else {
                let mut v257: i32 = v255.wrapping_add(1i32);
                let mut v259: i32 = std::env::args().count() as i32;
                let mut v260: bool = v257 < v259;
                if v260 {
                    v257
                } else {
                    -1i32
                }
            };
            let mut v263: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--html"); } LIT.with(|lit| lit.clone()) };
            let mut v264: i32 = 1i32;
            let mut v266: i32 = std::env::args().count() as i32;
            let mut v267: i32 = method13(v263.clone(), v264, v266);
            let mut v268: bool = v267 == -1i32;
            let mut v274: i32 = if v268 {
                -1i32
            } else {
                let mut v269: i32 = v267.wrapping_add(1i32);
                let mut v271: i32 = std::env::args().count() as i32;
                let mut v272: bool = v269 < v271;
                if v272 {
                    v269
                } else {
                    -1i32
                }
            };
            let mut v275: bool = v262 == -1i32;
            if v275 {
                2i32
            } else {
                let mut v276: bool = v274 == -1i32;
                if v276 {
                    2i32
                } else {
                    let mut v278: Rc<str> = Rc::<str>::from(std::env::args().nth(v274 as usize).unwrap_or_default());
                    let mut v280: Rc<str> = Rc::<str>::from(std::env::args().nth(v262 as usize).unwrap_or_default());
                    let mut v281: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v283: Rc<str> = { let mut out = String::new(); if let Ok(read) = std::fs::read_dir(v280.as_ref()) { for entry in read.flatten() { let child = entry.path(); let Some(name) = child.file_name() else { continue }; let name = name.to_string_lossy(); if child.is_dir() { out.push(char::from(49)); } else if child.is_file() { out.push(char::from(48)); } else { continue }; out.push(char::from(32)); out.push_str(&name.len().to_string()); out.push(char::from(10)); out.push_str(&name); } } Rc::<str>::from(out) };
                    let mut v284: i32 = 0i32;
                    let mut v285: Rc<UH0> = method4(v283.clone(), v284);
                    let mut v286: Rc<UH0> = method7(v285.clone());
                    let mut v287: Rc<UH1> = method10(v280.clone(), v281.clone(), v286.clone());
                    let mut v288: Rc<str> = method11(v287.clone());
                    let mut v289: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n  <meta charset=\"UTF-8\">\n  <style>\nbody {\n    background-color: #222;\n    color: #ccc;\n}\na {\n  color: #777;\n  font-size: 15px;\n}\nspan {\n  font-size: 11px;\n}\ndiv > div {\n  padding-left: 10px;\n}\ndetails > div {\n  padding-left: 19px;\n}\n  </style>\n</head>\n<body>\n  <div>"); } LIT.with(|lit| lit.clone()) }, v288.clone()));
                    let mut v290: Rc<str> = Rc::<str>::from(format!("{}{}", v289.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</div>\n</body>\n</html>\n"); } LIT.with(|lit| lit.clone()) }));
                    let mut v291: i32 = 0i32;
                    let mut v292: i32 = -1i32;
                    let mut v293: i32 = method3(v278.clone(), v291, v292);
                    let mut v294: bool = v293 == -1i32;
                    let mut v304: Rc<str> = if v294 {
                        v281.clone()
                    } else {
                        let mut v295: i32 = v293.wrapping_sub(1i32);
                        let mut v296: Rc<str> = string_slice(&v278.clone(), 0i32 as i64, v295 as i64);
                        let mut v297: i32 = (v296.clone().len() as i32);
                        let mut v298: bool = v297 == 2i32;
                        let mut v301: bool = if v298 {
                            let mut v299: u8 = v296.clone().as_bytes()[1i32 as usize];
                            let mut v300: bool = v299 == b':';
                            v300
                        } else {
                            false
                        };
                        if v301 {
                            let mut v302: Rc<str> = string_slice(&v278.clone(), 0i32 as i64, v293 as i64);
                            v302.clone()
                        } else {
                            v296.clone()
                        }
                    };
                    let mut v305: i32 = (v304.clone().len() as i32);
                    let mut v306: bool = v305 == 0i32;
                    let mut v309: i32 = if v306 {
                        0i32
                    } else {
                        let mut v308: i32 = i32::from(std::fs::create_dir_all(v304.as_ref()).is_err());
                        v308
                    };
                    let mut v310: bool = v309 == 0i32;
                    if v310 {
                        let mut v312: i32 = i32::from(std::fs::write(v278.as_ref(), v290.as_ref().as_bytes()).is_err());
                        v312
                    } else {
                        v309
                    }
                }
            }
        }
    } else {
        let mut v317: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--dir"); } LIT.with(|lit| lit.clone()) };
        let mut v318: i32 = 1i32;
        let mut v320: i32 = std::env::args().count() as i32;
        let mut v321: i32 = method13(v317.clone(), v318, v320);
        let mut v322: bool = v321 == -1i32;
        let mut v328: i32 = if v322 {
            -1i32
        } else {
            let mut v323: i32 = v321.wrapping_add(1i32);
            let mut v325: i32 = std::env::args().count() as i32;
            let mut v326: bool = v323 < v325;
            if v326 {
                v323
            } else {
                -1i32
            }
        };
        let mut v329: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--html"); } LIT.with(|lit| lit.clone()) };
        let mut v330: i32 = 1i32;
        let mut v332: i32 = std::env::args().count() as i32;
        let mut v333: i32 = method13(v329.clone(), v330, v332);
        let mut v334: bool = v333 == -1i32;
        let mut v340: i32 = if v334 {
            -1i32
        } else {
            let mut v335: i32 = v333.wrapping_add(1i32);
            let mut v337: i32 = std::env::args().count() as i32;
            let mut v338: bool = v335 < v337;
            if v338 {
                v335
            } else {
                -1i32
            }
        };
        let mut v341: bool = v328 == -1i32;
        if v341 {
            2i32
        } else {
            let mut v342: bool = v340 == -1i32;
            if v342 {
                2i32
            } else {
                let mut v344: Rc<str> = Rc::<str>::from(std::env::args().nth(v340 as usize).unwrap_or_default());
                let mut v346: Rc<str> = Rc::<str>::from(std::env::args().nth(v328 as usize).unwrap_or_default());
                let mut v347: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v349: Rc<str> = { let mut out = String::new(); if let Ok(read) = std::fs::read_dir(v346.as_ref()) { for entry in read.flatten() { let child = entry.path(); let Some(name) = child.file_name() else { continue }; let name = name.to_string_lossy(); if child.is_dir() { out.push(char::from(49)); } else if child.is_file() { out.push(char::from(48)); } else { continue }; out.push(char::from(32)); out.push_str(&name.len().to_string()); out.push(char::from(10)); out.push_str(&name); } } Rc::<str>::from(out) };
                let mut v350: i32 = 0i32;
                let mut v351: Rc<UH0> = method4(v349.clone(), v350);
                let mut v352: Rc<UH0> = method7(v351.clone());
                let mut v353: Rc<UH1> = method10(v346.clone(), v347.clone(), v352.clone());
                let mut v354: Rc<str> = method11(v353.clone());
                let mut v355: Rc<str> = Rc::<str>::from(format!("{}{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n  <meta charset=\"UTF-8\">\n  <style>\nbody {\n    background-color: #222;\n    color: #ccc;\n}\na {\n  color: #777;\n  font-size: 15px;\n}\nspan {\n  font-size: 11px;\n}\ndiv > div {\n  padding-left: 10px;\n}\ndetails > div {\n  padding-left: 19px;\n}\n  </style>\n</head>\n<body>\n  <div>"); } LIT.with(|lit| lit.clone()) }, v354.clone()));
                let mut v356: Rc<str> = Rc::<str>::from(format!("{}{}", v355.clone(), { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("</div>\n</body>\n</html>\n"); } LIT.with(|lit| lit.clone()) }));
                let mut v357: i32 = 0i32;
                let mut v358: i32 = -1i32;
                let mut v359: i32 = method3(v344.clone(), v357, v358);
                let mut v360: bool = v359 == -1i32;
                let mut v370: Rc<str> = if v360 {
                    v347.clone()
                } else {
                    let mut v361: i32 = v359.wrapping_sub(1i32);
                    let mut v362: Rc<str> = string_slice(&v344.clone(), 0i32 as i64, v361 as i64);
                    let mut v363: i32 = (v362.clone().len() as i32);
                    let mut v364: bool = v363 == 2i32;
                    let mut v367: bool = if v364 {
                        let mut v365: u8 = v362.clone().as_bytes()[1i32 as usize];
                        let mut v366: bool = v365 == b':';
                        v366
                    } else {
                        false
                    };
                    if v367 {
                        let mut v368: Rc<str> = string_slice(&v344.clone(), 0i32 as i64, v359 as i64);
                        v368.clone()
                    } else {
                        v362.clone()
                    }
                };
                let mut v371: i32 = (v370.clone().len() as i32);
                let mut v372: bool = v371 == 0i32;
                let mut v375: i32 = if v372 {
                    0i32
                } else {
                    let mut v374: i32 = i32::from(std::fs::create_dir_all(v370.as_ref()).is_err());
                    v374
                };
                let mut v376: bool = v375 == 0i32;
                if v376 {
                    let mut v378: i32 = i32::from(std::fs::write(v344.as_ref(), v356.as_ref().as_bytes()).is_err());
                    v378
                } else {
                    v375
                }
            }
        }
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
