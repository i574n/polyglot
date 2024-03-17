import mpmath
from mpmath import *

mp.dps = 50

# test_zeta_at_2___
s = 2
result = zeta(s)
assert abs(result - mpmath.pi**2 / 6) < 0.001

# test_trivial_zero_at_negative_even___
for n in range(-2, -21, -2):
    s = n
    result = zeta(s)
    assert result == 0

# test_non_trivial_zero___
non_trivial_zeros = [
    (0.5, 14.134725),
    (0.5, 21.022040),
    (0.5, 25.010857),
]
for s in non_trivial_zeros:
    result = zeta(complex(*s))
    assert abs(result.real) < 0.01 and abs(result.imag) < 0.01

# test_real_part_greater_than_one___
points = [2, 3, 4, 5, 10, 20, 50]
for re in points:
    s = re
    result = zeta(s)
    assert result.real > 0 and result.imag == 0

# test_zeta_at_1___
s = 1
try:
    result = zeta(s)
    assert False, "Expected a pole at zeta(1)"
except ValueError as e:
    assert "pole" in str(e), "Expected a ValueError indicating a pole at s = 1"


# test_high_precision_at_known_value___
s = complex(0.5, 14.134725)
result = zeta(s)
assert abs(result.real) < 0.001 and abs(result.imag) < 0.001

# test_symmetry_across_real_axis___
s = complex(2, 10)
result_positive_im = zeta(s)
result_negative_im = zeta(complex(s.real, -s.imag))
assert result_positive_im == result_negative_im.conjugate()

# test_behavior_near_origin___
s = complex(0.01, 0.01)
result = zeta(s)
assert abs(result) < float('inf')

# test_zeta_at_minus_1
s = -1
result = zeta(s)
assert abs(result.real + 1/12) < 0.001 and result.imag == 0

# test_imaginary_axis
points = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
for im in points:
    s = complex(0, im)
    result = zeta(s)
    assert result.real != 0 or result.imag != 0

# test_critical_strip
test_values = [
    (0.5, 14.134725),
    (0.75, 20.5),
    (1.25, 30.1),
    (0.25, 40.0),
    (1.0, 50.0),
]
for s in test_values:
    result = zeta(complex(*s))
    assert result.real != 0 or result.imag != 0

# test_reflection_formula_for_specific_value
test_values = [
    (3.0, 4.0),
    (2.5, -3.5),
    (1.5, 2.5),
    (0.5, 14.134725),
]

for s in test_values:
    s_complex = complex(*s)
    one_minus_s = complex(1 - s[0], -s[1])
    lhs = zeta(s_complex)

    reflection_coefficient = (2**s_complex) * (pi**(s_complex-1)) * sin(pi*s_complex/2) * gamma(1-s_complex)
    rhs_calculated = reflection_coefficient * zeta(one_minus_s)

    # print(f'lhs: {lhs} / rhs_calculated: {rhs_calculated} / reflection_coefficient: {reflection_coefficient} / one_minus_s: {one_minus_s}')

    real_diff = abs(lhs.real - rhs_calculated.real)
    imag_diff = abs(lhs.imag - rhs_calculated.imag)
    assert real_diff < 0.01 and imag_diff < 0.01, "Reflection formula test failed"

# euler
s_values = [2, 3, 4, 5]
primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71]

for s in s_values:
    euler_product = fprod([1 / (1 - mp.power(p, -s)) for p in primes])
    zeta_value = zeta(s)

    real_diff = abs(zeta_value.real - euler_product)
    imag_diff = abs(zeta_value.imag)

    tolerance = 0.005 if s == 2 else 0.001
    assert real_diff < tolerance and imag_diff < tolerance, f"Euler product formula approximation failed for s={s}"
