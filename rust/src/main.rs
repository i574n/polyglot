mod old;
mod tests;

pub mod main {
    use std::vec::Vec;

    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let mut _result = vec![];

        for (k1, v1) in nums.iter().enumerate() {
            // for k2 in k1 + 1 .. nums.len() {
            for (k2, v2) in nums.iter().enumerate().skip(k1 + 1) {
                if k1 < k2 && v1 + v2 == target {
                    _result.push(k1 as i32);
                    _result.push(k2 as i32);
                }
            }
        }

        _result
    }


}

fn main() {
    let q = main::two_sum(vec![3, 2, 4], 6);

    if q != vec![1, 2] {
        println!("NOT EQUAL")
    }

    println!("{:?}", q);
    println!("Hello, world28!");
}
