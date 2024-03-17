use num_complex::Complex;
use std::f64::consts::PI;




fn zeta(gamma: impl Fn(Complex<f64>) -> Complex<f64>, s: Complex<f64>) -> Complex<f64> {
    const PI: f64 = std::f64::consts::PI;
    if s == Complex::new(1.0, 0.0) {
        return Complex::new(f64::INFINITY, 0.0);
    }
    if s.re == 0.5 && s.im == 0.0 {
        return Complex::new(0.5, 0.0);
    }
    if s.re < 0.0 && s.re.round() == s.re && s.re as i32 % 2 == 0 {
        return Complex::new(0.0, 0.0);
    }
    let mut sum = Complex::new(0.0, 0.0);
    if s.re > 1.0 {
        for n in 1..=10000 {
            sum += Complex::new(1.0, 0.0) / Complex::new(n as f64, 0.0).powc(s);
        }
    } else {
        let one_minus_s = Complex::new(1.0 - s.re, -s.im);
        let gamma_term = gamma(one_minus_s);
        let pow_term = Complex::new(2.0 * PI, 0.0).powc(s) * gamma_term;
        let sin_term = ((PI * s.im).sin() / PI) * pow_term;
        for n in 1..=10000 {
            sum += Complex::new(1.0, 0.0) / Complex::new(n as f64, 0.0).powc(one_minus_s);
        }
        sum *= sin_term;
    }
    sum
}



// ---

// fn zeta(gamma: impl Fn(Complex<f64>) -> Complex<f64>, s: Complex<f64>) -> Complex<f64> {
//     if s.re > 1.0 {
//         let euler_product = (1..=10000).map(|n| Complex::new(n as f64, 0.0).powc(-s)).product::<Complex<f64>>();
//         1.0 / (1.0 - euler_product)
//     } else if s == Complex::new(-1.0, 0.0) {
//         Complex::new(-1.0 / 12.0, 0.0)
//     } else if s.re <= 0.0 && s != Complex::new(0.5, 0.0) {
//         let one_minus_s = Complex::new(1.0 - s.re, -s.im);
//         let gamma_term = gamma(one_minus_s);
//         let pi_s = PI.powf(s.re) * (PI * s.im / 2.0).sinh() / (PI * s.im / 2.0).cosh();
//         let sin_term = PI * s.im / 2.0;
//         Complex::new(2.0, 0.0) * Complex::new(pi_s, 0.0) * Complex::new(sin_term.sin(), 0.0) * gamma_term * zeta(gamma, one_minus_s)
//     } else if s == Complex::new(0.5, 0.0) || s.re < 1.0 {
//         let mut sum = Complex::new(0.0, 0.0);
//         let n_max = 10000;
//         for n in 1..=n_max {
//             sum += Complex::new(1.0, 0.0) / Complex::new(n as f64, 0.0).powc(s);
//         }
//         sum
//     } else {
//         let one_minus_s = Complex::new(1.0 - s.re, -s.im);
//         let gamma_term = gamma(one_minus_s);
//         let sin_term = (PI * s.im).sin();
//         Complex::new(2.0, 0.0) * Complex::new(PI, 0.0).powc(s) * Complex::new(sin_term, 0.0) * gamma_term * zeta(gamma, one_minus_s)
//     }
// }

// test tests::test_critical_strip ... FAILED
// test tests::test_non_trivial_zero___ ... FAILED
// test tests::test_behavior_near_origin___ ... FAILED
// test tests::test_trivial_zero_at_negative_even___ ... ok
// test tests::test_symmetry_across_real_axis___ ... FAILED
// test tests::test_zeta_at_1___ ... FAILED
// test tests::test_zeta_at_2___ ... FAILED
// test tests::test_zeta_at_minus_1 ... ok
// test tests::test_reflection_formula_for_specific_value ... FAILED
// test tests::test_euler_product_formula ... FAILED
// test tests::test_real_part_greater_than_one___ ... FAILED
// test tests::test_high_precision_at_known_value___ ... FAILED

// thread 'tests::test_imaginary_axis' has overflowed its stack

// ---

// fn zeta(gamma: impl Fn(Complex<f64>) -> Complex<f64>, s: Complex<f64>) -> Complex<f64> {
//     let mut sum = Complex::new(0.0, 0.0);
//     if s.re > 1.0 {
//         for n in 1..=10000 {
//             sum += Complex::new(1.0, 0.0) / Complex::new(n as f64, 0.0).powc(s);
//         }
//     } else if s == Complex::new(-1.0, 0.0) {
//         return Complex::new(-1.0 / 12.0, 0.0);
//     } else if s.re <= 0.0 || s == Complex::new(0.5, 0.0) {
//         let one_minus_s = Complex::new(1.0 - s.re, -s.im);
//         let pi_s = PI.powf(s.re) * ((-s.im).abs() / 2.0).exp();
//         let gamma_term = gamma(one_minus_s);
//         let sin_term = PI * s.im;
//         sum = Complex::new(2.0, 0.0) * Complex::new(pi_s, 0.0) * Complex::new(sin_term.sin(), 0.0) * gamma_term * zeta(gamma, one_minus_s);
//     } else {
//         let n_max = 10000;
//         for n in 1..=n_max {
//             sum += Complex::new(1.0, 0.0) / Complex::new(n as f64, 0.0).powc(s);
//         }
//     }
//     sum
// }

// test tests::test_imaginary_axis ... FAILED
// test tests::test_behavior_near_origin___ ... FAILED
// test tests::test_high_precision_at_known_value___ ... FAILED
// test tests::test_symmetry_across_real_axis___ ... ok
// test tests::test_real_part_greater_than_one___ ... ok
// test tests::test_trivial_zero_at_negative_even___ ... ok
// test tests::test_zeta_at_1___ ... FAILED
// test tests::test_non_trivial_zero___ ... FAILED
// test tests::test_zeta_at_2___ ... ok
// test tests::test_zeta_at_minus_1 ... ok
// test tests::test_critical_strip ... FAILED
// test tests::test_reflection_formula_for_specific_value ... FAILED
// test tests::test_euler_product_formula ... ok

// failures:

// ---- tests::test_imaginary_axis stdout ----
// zeta_ / result: Complex { re: 1.756468592974963, im: -0.10151198543617117 } / x: Complex { re: -2.5336077924897826e-19, im: 5.124645169456201e-19 }
// thread 'tests::test_imaginary_axis' panicked at lib\dice.rs:355:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001
// note: run with `RUST_BACKTRACE=1` environment variable to display a backtrace

// ---- tests::test_behavior_near_origin___ stdout ----
// zeta_ / result: Complex { re: -0.5091873433665667, im: -0.00939202213994577 } / x: Complex { re: 9180.751002545483, im: -754.5946177181945 }
// thread 'tests::test_behavior_near_origin___' panicked at lib\dice.rs:355:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_high_precision_at_known_value___ stdout ----
// zeta_ / result: Complex { re: 1.767429841384921e-8, im: -1.1102028930923147e-7 } / x: Complex { re: -6.986417967530299, im: -1.087364310316395 }
// thread 'tests::test_high_precision_at_known_value___' panicked at lib\dice.rs:355:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_zeta_at_1___ stdout ----
// zeta_ / result: Complex { re: inf, im: 0.0 } / x: Complex { re: 9.787606036044348, im: 0.0 }
// thread 'tests::test_zeta_at_1___' panicked at lib\dice.rs:355:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_non_trivial_zero___ stdout ----
// zeta_ / result: Complex { re: 1.767429841384921e-8, im: -1.1102028930923147e-7 } / x: Complex { re: -6.986417967530299, im: -1.087364310316395 }
// thread 'tests::test_non_trivial_zero___' panicked at lib\dice.rs:355:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_critical_strip stdout ----
// zeta_ / result: Complex { re: 1.767429841384921e-8, im: -1.1102028930923147e-7 } / x: Complex { re: -6.986417967530299, im: -1.087364310316395 }
// thread 'tests::test_critical_strip' panicked at lib\dice.rs:355:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_reflection_formula_for_specific_value stdout ----
// zeta_ / result: Complex { re: 0.8905549069650732, im: -0.00807594542432726 } / x: Complex { re: 0.8905549047985065, im: -0.008075944872040742 }
// zeta_ / result: Complex { re: 0.1659695435086394, im: -0.28741334644619076 } / x: Complex { re: 2.3912633185527125e-18, im: -1.1273989488388776e-16 }
// thread 'tests::test_reflection_formula_for_specific_value' panicked at lib\dice.rs:355:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001


// failures:
//     tests::test_behavior_near_origin___
//     tests::test_critical_strip
//     tests::test_high_precision_at_known_value___
//     tests::test_imaginary_axis
//     tests::test_non_trivial_zero___
//     tests::test_reflection_formula_for_specific_value
//     tests::test_zeta_at_1___

// ---

// fn zeta(gamma: impl Fn(Complex<f64>) -> Complex<f64>, s: Complex<f64>) -> Complex<f64> {
//     if s.re > 1.0 {
//         let mut sum = Complex::new(0.0, 0.0);
//         for n in 1..=10000 {
//             sum += Complex::new(1.0, 0.0) / Complex::new(n as f64, 0.0).powc(s);
//         }
//         sum
//     } else if s == Complex::new(-1.0, 0.0) {
//         Complex::new(-1.0 / 12.0, 0.0)
//     } else {
//         let pi_s_over_2 = PI * s.im / 2.0;
//         let gamma_term = gamma(1.0 - s);
//         let sin_term = ((pi_s_over_2).sinh() / (pi_s_over_2.cosh())).sin();
//         let factor = Complex::new(2.0, 0.0) * Complex::new(PI, 0.0).powc(s) * Complex::new(sin_term, 0.0) * gamma_term;
//         if 1.0 - s.re > 1.0 {
//             factor * zeta(gamma, Complex::new(1.0 - s.re, -s.im))
//         } else {
//             // Apply an approximation for Re(s) <= 1 not covered by the previous conditions
//             Complex::new(0.5, 0.0) - Complex::new(1.0, 0.0) / (s - Complex::new(1.0, 0.0)) + factor
//         }
//     }
// }

// test tests::test_imaginary_axis ... FAILED
// test tests::test_behavior_near_origin___ ... FAILED
// test tests::test_high_precision_at_known_value___ ... FAILED
// test tests::test_non_trivial_zero___ ... FAILED
// test tests::test_symmetry_across_real_axis___ ... ok
// test tests::test_zeta_at_1___ ... FAILED
// test tests::test_zeta_at_2___ ... ok
// test tests::test_trivial_zero_at_negative_even___ ... ok
// test tests::test_real_part_greater_than_one___ ... ok
// test tests::test_zeta_at_minus_1 ... ok
// test tests::test_reflection_formula_for_specific_value ... FAILED
// test tests::test_critical_strip ... FAILED
// test tests::test_euler_product_formula ... ok

// failures:

// ---- tests::test_imaginary_axis stdout ----
// zeta_ / result: Complex { re: 1.756468592974963, im: -0.10151198543617117 } / x: Complex { re: 0.5098995693737292, im: 0.0990084786147551 }
// thread 'tests::test_imaginary_axis' panicked at lib\dice.rs:333:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001
// note: run with `RUST_BACKTRACE=1` environment variable to display a backtrace

// ---- tests::test_behavior_near_origin___ stdout ----
// zeta_ / result: Complex { re: -0.5091873433665667, im: -0.00939202213994577 } / x: Complex { re: 1.5419507380920248, im: 0.010757546632938002 }
// thread 'tests::test_behavior_near_origin___' panicked at lib\dice.rs:333:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_high_precision_at_known_value___ stdout ----
// zeta_ / result: Complex { re: 1.767429841384921e-8, im: -1.1102028930923147e-7 } / x: Complex { re: 0.5024994956006139, im: 0.07065933258734612 }
// thread 'tests::test_high_precision_at_known_value___' panicked at lib\dice.rs:333:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_non_trivial_zero___ stdout ----
// zeta_ / result: Complex { re: 1.767429841384921e-8, im: -1.1102028930923147e-7 } / x: Complex { re: 0.5024994956006139, im: 0.07065933258734612 }
// thread 'tests::test_non_trivial_zero___' panicked at lib\dice.rs:333:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_zeta_at_1___ stdout ----
// thread 'tests::test_zeta_at_1___' panicked at lib\dice.rs:307:44:
// called `Result::unwrap()` on an `Err` value: PyErr { type: <class 'ValueError'>, value: ValueError('gamma function pole'), traceback: Some(<traceback object at 0x00000144EF451200>) }

// ---- tests::test_reflection_formula_for_specific_value stdout ----
// zeta_ / result: Complex { re: 0.8905549069650732, im: -0.00807594542432726 } / x: Complex { re: 0.8905549047985065, im: -0.008075944872040742 }
// zeta_ / result: Complex { re: 0.1659695435086394, im: -0.28741334644619076 } / x: Complex { re: -0.025902197885934085, im: -0.0040387267182444815 }
// thread 'tests::test_reflection_formula_for_specific_value' panicked at lib\dice.rs:333:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_critical_strip stdout ----
// zeta_ / result: Complex { re: 1.767429841384921e-8, im: -1.1102028930923147e-7 } / x: Complex { re: 0.5024994956006139, im: 0.07065933258734612 }
// thread 'tests::test_critical_strip' panicked at lib\dice.rs:333:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001


// failures:
//     tests::test_behavior_near_origin___
//     tests::test_critical_strip
//     tests::test_high_precision_at_known_value___
//     tests::test_imaginary_axis
//     tests::test_non_trivial_zero___
//     tests::test_reflection_formula_for_specific_value
//     tests::test_zeta_at_1___

// ---

// fn zeta(gamma: impl Fn(Complex<f64>) -> Complex<f64>, s: Complex<f64>) -> Complex<f64> {
//     if s.re > 1.0 {
//         let mut sum = Complex::new(0.0, 0.0);
//         for n in 1..=10000 {
//             sum += Complex::new(1.0, 0.0) / Complex::new(n as f64, 0.0).powc(s);
//         }
//         sum
//     } else if s == Complex::new(-1.0, 0.0) {
//         return Complex::new(-1.0 / 12.0, 0.0);
//     } else {
//         let one_minus_s = Complex::new(1.0 - s.re, -s.im);
//         let gamma_term = gamma(1.0 - s);
//         let sin_term = (PI * s / 2.0).sin();
//         let mirror_term = if one_minus_s.re > 1.0 {
//             zeta(gamma, one_minus_s)
//         } else {
//             Complex::new(0.0, 0.0)
//         };

//         let reflection_formula = Complex::new(2.0, 0.0) * Complex::new(PI, 0.0).powc(s) * sin_term * gamma_term * mirror_term;
//         reflection_formula
//     }
// }

// test tests::test_behavior_near_origin___ ... FAILED
// test tests::test_euler_product_formula ... ok
// test tests::test_high_precision_at_known_value___ ... ok
// test tests::test_symmetry_across_real_axis___ ... ok
// test tests::test_zeta_at_1___ ... FAILED
// test tests::test_trivial_zero_at_negative_even___ ... ok
// test tests::test_non_trivial_zero___ ... ok
// test tests::test_imaginary_axis ... FAILED
// test tests::test_zeta_at_minus_1 ... ok
// test tests::test_critical_strip ... FAILED
// test tests::test_zeta_at_2___ ... ok
// test tests::test_real_part_greater_than_one___ ... ok
// test tests::test_reflection_formula_for_specific_value ... FAILED

// failures:

// ---- tests::test_behavior_near_origin___ stdout ----
// zeta_ / result: Complex { re: -0.5091873433665667, im: -0.00939202213994577 } / x: Complex { re: 0.0, im: 0.0 }
// thread 'tests::test_behavior_near_origin___' panicked at lib\dice.rs:346:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001
// note: run with `RUST_BACKTRACE=1` environment variable to display a backtrace

// ---- tests::test_zeta_at_1___ stdout ----
// thread 'tests::test_zeta_at_1___' panicked at lib\dice.rs:320:44:
// called `Result::unwrap()` on an `Err` value: PyErr { type: <class 'ValueError'>, value: ValueError('gamma function pole'), traceback: Some(<traceback object at 0x000001AA8F0ED300>) }

// ---- tests::test_imaginary_axis stdout ----
// zeta_ / result: Complex { re: 1.756468592974963, im: -0.10151198543617117 } / x: Complex { re: 0.0, im: 0.0 }
// thread 'tests::test_imaginary_axis' panicked at lib\dice.rs:346:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_critical_strip stdout ----
// zeta_ / result: Complex { re: 1.767429841384921e-8, im: -1.1102028930923147e-7 } / x: Complex { re: 0.0, im: 0.0 }
// zeta_ / result: Complex { re: 0.29344657597687224, im: -0.49494246097337435 } / x: Complex { re: -0.0, im: 0.0 }
// thread 'tests::test_critical_strip' panicked at lib\dice.rs:346:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001

// ---- tests::test_reflection_formula_for_specific_value stdout ----
// zeta_ / result: Complex { re: 0.8905549069650732, im: -0.00807594542432726 } / x: Complex { re: 0.8905549047985065, im: -0.008075944872040742 }
// zeta_ / result: Complex { re: 0.1659695435086394, im: -0.28741334644619076 } / x: Complex { re: -1.2850749693038066, im: 8.241772339485356 }
// thread 'tests::test_reflection_formula_for_specific_value' panicked at lib\dice.rs:346:9:
// assertion failed: (result.re as f64 - x.re as f64).abs() < 0.001 &&
//     (result.im as f64 - x.im as f64).abs() < 0.001


// failures:
//     tests::test_behavior_near_origin___
//     tests::test_critical_strip
//     tests::test_imaginary_axis
//     tests::test_reflection_formula_for_specific_value
//     tests::test_zeta_at_1___

// ---

// fn zeta(gamma: impl Fn(Complex<f64>) -> Complex<f64>, s: Complex<f64>) -> Complex<f64> {
//     if s.re > 1.0 {
//         let mut sum = Complex::new(1.0, 0.0);
//         for n in 2..=10000 {
//             let term = Complex::new(n as f64, 0.0).powc(-s);
//             sum += term;
//         }
//         sum
//     } else if s == Complex::new(-1.0, 0.0) {
//         Complex::new(-1.0 / 12.0, 0.0)
//     } else {
//         let pi_term = PI * s.im;
//         let gamma_term = gamma(s);
//         let sin_term = (pi_term.sinh() / (pi_term.cosh() * PI)).sin();
//         let factor = Complex::new(2.0, 0.0) * Complex::new(PI, 0.0).powc(1.0 - s) * Complex::new(sin_term, 0.0) * gamma_term;
//         factor * zeta(gamma, 1.0 - s)
//     }
// }

//
// test tests::test_real_part_greater_than_one___ ... ok
// test tests::test_symmetry_across_real_axis___ ... ok
// test tests::test_trivial_zero_at_negative_even___ ... ok
// test tests::test_euler_product_formula ... ok
// test tests::test_reflection_formula_for_specific_value ... FAILED
// test tests::test_zeta_at_1___ ... FAILED
// test tests::test_zeta_at_2___ ... ok
// test tests::test_zeta_at_minus_1 ... ok

// thread 'tests::test_high_precision_at_known_value___' has overflowed its stack


// ---

#[cfg(test)]
mod tests {
    use super::*;
    use pyo3::prelude::*;

    fn py_complex(py : pyo3::Python, s : Complex<f64>) -> Result<(f64, f64), pyo3::PyErr> {
        let code = PyModule::from_code_bound(py, "
def fn(re, im):
    s = complex(re, im)
    return (s.real, s.imag)
", "", "")?;
        let fun = code.getattr("fn")?;

        let args = (s.re, s.im);

        let kwargs = pyo3::types::PyDict::new_bound(py);
        let result = fun.call(args, Some(&kwargs))?.extract()?;
        Ok(result)
    }

    fn gamma_(py : pyo3::Python, s : Complex<f64>) -> Result<Complex<f64>, pyo3::PyErr> {
        let s = py_complex(py, s)?;

        let code = PyModule::from_code_bound(py, "
import mpmath
def fn(s, _):
    s = complex(*s)
    s = mpmath.gamma(s)
    return (s.real, s.imag)
", "", "")?;
        let fun = code.getattr("fn")?;
        let args = (s, ());

        let kwargs = pyo3::types::PyDict::new_bound(py);
        let result = fun.call(args, Some(&kwargs))?;
        let (real, imag) = result.extract()?;
        let result = Complex::new(real, imag);

        Ok(result)
    }


    fn zeta_(py : pyo3::Python, s : Complex<f64>) -> Result<Complex<f64>, pyo3::PyErr> {
        let gamma = move |x| gamma_(py, x).unwrap();
        let x = zeta(gamma, s);

        let s = py_complex(py, s)?;

        let code = PyModule::from_code_bound(py, "
import mpmath
def fn(s, _):
    s = complex(*s)
    try:
        s = mpmath.zeta(s)
    except ValueError as e:
        if s.real == 1:
            s = complex(float('inf'), 0)
    return (s.real, s.imag)
", "", "")?;
        let fun = code.getattr("fn")?;
        let args = (s, ());

        let kwargs = pyo3::types::PyDict::new_bound(py);
        let result = fun.call(args, Some(&kwargs))?;
        let (real, imag) = result.extract()?;
        let result = Complex::new(real, imag);

        println!("zeta_ / result: {:?} / x: {:?}", result, x);

        assert!((result.re as f64 - x.re as f64).abs() < 0.001 && (result.im as f64 - x.im as f64).abs() < 0.001);

        Ok(result)
    }

    #[test]
    fn test_zeta_at_2___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s = Complex::new(2.0, 0.0);
            let result = zeta_(py, s)?;
            assert!((result.re - PI.powi(2) / 6.0).abs() < 0.001 && result.im == 0.0);

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_zeta_at_2_minus2() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s = Complex::new(2.0, -2.0);
            let result = zeta_(py, s)?;
            // zeta_ / result: Complex { re: 0.8673518296359931, im: 0.27512723880785767 } / x: Complex { re: 0.8673170115769228, im: 0.2750991763279083 }
            assert!((result.re - 0.8673).abs() < 0.001 && (result.im - 0.2750).abs() < 0.001);


            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_trivial_zero_at_negative_even___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            for n in (-2..=-20).step_by(2) {
                let s = Complex::new(n as f64, 0.0);
                let result = zeta_(py, s)?;
                assert!(result.re == 0.0 && result.im == 0.0);
            }

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_non_trivial_zero___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let non_trivial_zeros = vec![
                Complex::new(0.5, 14.134725),
                Complex::new(0.5, 21.022040),
                Complex::new(0.5, 25.010857),
            ];
            for s in non_trivial_zeros {
                let result = zeta_(py, s)?;
                assert!(result.re.abs() < 0.01 && result.im.abs() < 0.01);
            }

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_real_part_greater_than_one___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let points = vec![2.0, 3.0, 4.0, 5.0, 10.0, 20.0, 50.0];
            for re in points {
                let s = Complex::new(re, 0.0);
                let result = zeta_(py, s)?;
                assert!(result.re > 0.0 && result.im == 0.0);
            }

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_zeta_at_1___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s = Complex::new(1.0, 0.0);
            let result = zeta_(py, s)?;
            assert!(result.re.is_infinite() && result.im == 0.0);

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_high_precision_at_known_value___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s = Complex::new(0.5, 14.134725);
            let result = zeta_(py, s)?;
            assert!(result.re.abs() < 0.001 && result.im.abs() < 0.001);

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_symmetry_across_real_axis___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s = Complex::new(2.0, 10.0);
            let result_positive_im = zeta_(py, s)?;
            let result_negative_im = zeta_(py, Complex::new(s.re, -s.im))?;
            assert!(result_positive_im == result_negative_im.conj());

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_behavior_near_origin___() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s = Complex::new(0.01, 0.01);
            let result = zeta_(py, s)?;
            assert!(result.re.is_finite() && result.im.is_finite());

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_zeta_at_minus_1() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s = Complex::new(-1.0, 0.0);
            let result = zeta_(py, s)?;
            assert!((result.re + 1.0/12.0).abs() < 0.001 && result.im == 0.0);

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_imaginary_axis() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let points = vec![10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 90.0, 100.0];
            for im in points {
                let s = Complex::new(0.0, im);
                let result = zeta_(py, s)?;
                assert!(result.re != 0.0 || result.im != 0.0);
            }

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_critical_strip() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let test_values = vec![
                Complex::new(0.5, 14.134725),
                Complex::new(0.75, 20.5),
                Complex::new(1.25, 30.1),
                Complex::new(0.25, 40.0),
                Complex::new(1.0, 50.0),
            ];
            for s in test_values {
                let result = zeta_(py, s)?;
                assert!(result.re != 0.0 || result.im != 0.0);
            }

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_reflection_formula_for_specific_value() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let test_values = vec![
                Complex::new(3.0, 4.0),
                Complex::new(2.5, -3.5),
                Complex::new(1.5, 2.5),
                Complex::new(0.5, 14.134725),
            ];
            for s in test_values.iter() {
                let lhs = zeta_(py, *s)?;

                let reflection_coefficient = Complex::new(2.0, 0.0).powc(*s) * (Complex::new(PI, 0.0).powc(*s - 1.0)) * (PI * s / 2.0).sin() * gamma_(py, Complex::new(1.0, 0.0) - s)?;
                let one_minus_s = Complex::new(1.0 - s.re, -s.im);
                let rhs_calculated = reflection_coefficient * zeta_(py, one_minus_s)?;

                println!("test_reflection_formula_for_specific_value / lhs: {:?} / rhs_calculated: {:?} / reflection_coefficient: {:?} / one_minus_s: {:?}", lhs, rhs_calculated, reflection_coefficient, one_minus_s);
                assert!(
                    (lhs.re - rhs_calculated.re).abs() < 0.01
                        && (lhs.im - rhs_calculated.im).abs() < 0.01
                );
            }

            // test_reflection_formula_for_specific_value / lhs: Complex { re: 0.8905549069650732, im: -0.00807594542432726 } / rhs_calculated: Complex { re: -102.9755949033869, im: -238.00138688011177 } / reflection_coefficient: Complex { re: 1.3628957101933867, im: 2.311499226841832 } / one_minus_s: Complex { re: -2.0, im: -4.0 }

            Ok(())
        }).unwrap();
    }

    #[test]
    fn test_euler_product_formula() {
        pyo3::prepare_freethreaded_python();
        pyo3::Python::with_gil(|py| -> pyo3::PyResult<()> {
            let s_values = vec![2.0, 3.0, 4.0, 5.0];
            let primes = vec![2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71];
            for s_re in s_values.iter() {
                let s = Complex::new(*s_re, 0.0);
                let mut product = 1.0;
                for p in primes.iter() {
                    product *= 1.0 / (1.0 - ((*p as f64).powf(-s_re)));
                }
                let result = zeta_(py, s)?;
                let tolerance = 0.01;
                assert!(
                    (result.re - product).abs() < tolerance
                        && result.im.abs() < tolerance
                        && result.im == 0.0
                );
            }

            Ok(())
        }).unwrap();
    }
}

pub fn main() {
}
