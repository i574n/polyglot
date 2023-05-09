use qoqo::operations::*;
use qoqo_calculator::CalculatorFloat;
use rand::Rng;


fn apply_oracle(circuit: &mut Circuit, marked: usize) {
    if marked == 1 {
        circuit += PauliX::new(0);
    }
}

fn apply_grover_iteration(circuit: &mut Circuit, marked: usize) {
    apply_oracle(circuit, marked);
    circuit += Hadamard::new(0);
    circuit += PauliX::new(0);
    circuit += RotateAroundSphericalAxis::new(0, CalculatorFloat::FRAC_PI_2, CalculatorFloat::ZERO);
    circuit += PauliX::new(0);
    circuit += Hadamard::new(0);
}

fn run_grover(marked: usize) -> usize {
    let mut circuit = Circuit::new();
    circuit += Hadamard::new(0);
    apply_grover_iteration(&mut circuit, marked);
    circuit += Measure::new(0, "result".to_string());

    let statevector_simulator = StateVectorSimulator::new();
    let result = statevector_simulator.run_circuit(&circuit).unwrap();

    *result.get_bit_registers().get("result").unwrap().get(0).unwrap() as usize
}



fn main() {
    let num_trials = 100;
    let mut rng = rand::thread_rng();

    let classical_success_rate = 1.0 / 8.0;
    let mut success_count = 0;

    for _ in 0..num_trials {
        let marked = rng.gen_range(0..8);
        let result = run_grover(marked);
        if marked == result {
            success_count += 1;
        }
    }

    let success_rate = (success_count as f64) / (num_trials as f64);
    let test_result = success_rate > classical_success_rate;
    println!("Grover's Algorithm Property-Based Test: {}", test_result);
}
