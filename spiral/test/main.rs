// #![crate_name = "test"]

mod test;



use proptest::prelude::*;
use proptest::arbitrary::{Arbitrary, any};
use proptest::string::{string_regex};
use nom::{IResult, bytes::complete::{escaped, tag, take_till, take_while1}, character::complete::{alphanumeric1, char, digit1, one_of}, combinator::opt};






#[derive(Debug, Clone, PartialEq, Eq)]
enum Item {
    Weapon { name: String, damage: u32 },
    Potion { name: String, healing: u32 },
    Armor { name: String, defense: u32 },
}

impl Arbitrary for Item {
    type Parameters = ();
    type Strategy = BoxedStrategy<Self>;

    fn arbitrary_with(_args: Self::Parameters) -> Self::Strategy {
        let weapon_strategy = (any::<String>(), any::<u32>())
            .prop_map(|(name, damage)| Item::Weapon { name, damage });

        let potion_strategy = (any::<String>(), any::<u32>())
            .prop_map(|(name, healing)| Item::Potion { name, healing });

        let armor_strategy = (any::<String>(), any::<u32>())
            .prop_map(|(name, defense)| Item::Armor { name, defense });

        prop_oneof![weapon_strategy, potion_strategy, armor_strategy].boxed()
    }
}

#[derive(Debug, Clone, PartialEq, Eq)]
struct Cart {
    items: Vec<Item>,
}

impl Cart {
    fn new() -> Cart {
        Cart { items: vec![] }
    }

    fn add_item(&mut self, item: Item) {
        if !self.items.contains(&item) {
            self.items.push(item);
        }
    }

    fn remove_item(&mut self, item: &Item) {
        self.items.retain(|i| i != item);
    }
}

proptest! {
    #[test]
    fn adding_and_then_removing_an_item_from_the_cart_leaves_the_cart_unchanged(
        ref item in any::<Item>(),
        ref items in prop::collection::vec(any::<Item>(), 0..100)) {

        let mut cart = Cart::new();
        for i in items {
            cart.add_item(i.clone());
        }
        let original_cart = cart.clone();
        cart.add_item(item.clone());
        cart.remove_item(item);
        prop_assert_eq!(cart, original_cart);
    }
}








#[derive(Debug, PartialEq, Clone)]
pub enum SpiralToken {
    Identifier(String),
    Integer(i64),
    StringLiteral(String),
    Operator(String),
    Comment(String),
}

impl Arbitrary for SpiralToken {
    type Parameters = ();
    type Strategy = BoxedStrategy<Self>;

    fn arbitrary_with(_args: Self::Parameters) -> Self::Strategy {
        let identifier_strategy = string_regex("[a-zA-Z][a-zA-Z0-9]*").unwrap().prop_map(|s| SpiralToken::Identifier(s));
        let integer_strategy = any::<i64>().prop_map(|n| SpiralToken::Integer(n));
        let string_strategy = string_regex("[ -~]*").unwrap().prop_map(|s| SpiralToken::StringLiteral(s.replace("\"", "").replace("\\", "")));
        let operator_strategy = prop_oneof![
            Just("+"),
            Just("-"),
            Just("*"),
            Just("/"),
            Just("="),
            Just("("),
            Just(")")
        ]
        .prop_map(|s| SpiralToken::Operator(s.to_string()));
        let comment_strategy = string_regex("[ -~]*").unwrap().prop_map(|s| SpiralToken::Comment(s));

        prop_oneof![
            identifier_strategy,
            integer_strategy,
            string_strategy,
            operator_strategy,
            comment_strategy
        ]
        .boxed()
    }
}


fn parse_comment(input: &str) -> IResult<&str, SpiralToken> {
    let (input, _) = tag("//")(input)?;
    let (input, comment) = take_till(|c| c == '\n')(input)?;
    Ok((input, SpiralToken::Comment(comment.to_string())))
}

fn parse_string(input: &str) -> IResult<&str, SpiralToken> {
    let (input, _) = char('\"')(input)?;
    let (input, str_lit) = opt(escaped(
        take_while1(|c: char| c != '\\' && c != '\"'),
        '\\',
        one_of("\"\\"),
    ))(input)?;
    let str_lit = match str_lit {
        Some(s) => s.replace("\\\"", "\"").replace("\\\\", "\\"),
        None => "".to_string(),
    };
    let (input, _) = char('\"')(input)?;
    Ok((input, SpiralToken::StringLiteral(str_lit)))
}

fn parse_identifier(input: &str) -> IResult<&str, SpiralToken> {
    let (input, id) = alphanumeric1(input)?;
    if id.chars().all(|c| c.is_digit(10)) {
        Err(nom::Err::Error(nom::error::Error::new(input, nom::error::ErrorKind::AlphaNumeric)))
    } else {
        Ok((input, SpiralToken::Identifier(id.to_string())))
    }
}

fn parse_integer(input: &str) -> IResult<&str, SpiralToken> {
    let (input, negative) = opt(char('-'))(input)?;
    let (input, digits) = digit1(input)?;
    let number = digits.parse::<i64>().unwrap();
    let number = if negative.is_some() { -number } else { number };
    Ok((input, SpiralToken::Integer(number)))
}


fn parse_operator(input: &str) -> IResult<&str, SpiralToken> {
    let (input, op) = one_of("=+-*/()")(input)?;
    Ok((input, SpiralToken::Operator(op.to_string())))
}

fn parse_token(input: &str) -> IResult<&str, SpiralToken> {
    nom::branch::alt((
        parse_comment,
        parse_string,
        parse_identifier,
        parse_integer,
        parse_operator,
    ))(input)
}

fn format_token(token: &SpiralToken) -> String {
    match token {
        SpiralToken::Identifier(s) => s.clone(),
        SpiralToken::Integer(n) => format!("{}", n),
        SpiralToken::StringLiteral(s) => format!("\"{}\"", s),
        SpiralToken::Operator(s) => s.clone(),
        SpiralToken::Comment(s) => format!("//{}", s),
    }
}

proptest! {
    #[test]
    fn prop_parse_format_idempotent(s in any::<SpiralToken>()) {
        let formatted = format_token(&s);
        let (_, parsed) = parse_token(&formatted).unwrap();
        prop_assert_eq!(s, parsed);
    }
}

































pub fn main() -> Result<(), Box<dyn std::error::Error>> {
    // let app = cli::Cli::v0;
    // let app = app()();
    let app = "app";
    println!("app={}", app);
    Ok(())
}
