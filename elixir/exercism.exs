# Elixir / Hello World

# Instructions
# The classical introductory exercise. Just say "Hello, World!".

# "Hello, World!" is the traditional first program for beginning programming in a new language or environment.

# The objectives are simple:

# Modify the provided code so that it produces the string "Hello, World!".
# Run the test suite and make sure that it succeeds.
# Submit your solution and check it at the website.
# If everything goes well, you will be ready to fetch your first real exercise.

# How to debug
# To help with debugging, you can use the fact that all console output will be captured and shown in the test results window. You can output any value by passing it to IO.inspect.

# IO.inspect returns the value unchanged, which makes it especially useful for inspecting intermediate values in function call chains.

# "hello"
# |> String.upcase()
# |> IO.inspect()
# |> String.split("", trim: true)
# Note that for security reasons, the output for each test will get truncated after 500 characters.


defmodule HelloWorld do
  @doc """
  Simply returns "Hello, World!"
  """
  @spec hello :: String.t()
  def hello do
    "Hello, World!"
  end
end



# Elixir / Lasagna

# Introduction
# Basics
# Variables
# Elixir is a dynamically-typed language, meaning that the type of a variable is only checked at runtime. Using the match = operator, we can bind a value of any type to a variable name:

# count = 1 # Bound an integer value of 1
# count = 2 # You may re-bind variables

# count = false # You may re-bind any type to a variable

# message = "Success!" # Strings can be created by enclosing characters within double quotes
# Modules
# Elixir is a functional-programming language and requires all named functions to be defined in a module. The defmodule keyword is used to define a module. All modules are available to all other modules at runtime and do not require an access modifier to make them visible to other parts of the program. A module is analogous to a class in other programming languages.

# defmodule Calculator do
#   # ...
# end
# Named functions
# Named Functions must be defined in a module. The def keyword is used to define a public named function.

# Each function can have zero or more arguments. The value of the last expression in a function is always implicitly returned.

# defmodule Calculator do
#   def add(x, y) do
#     x + y
#   end
# end
# Invoking a function is done by specifying its module and function name and passing arguments for each of the function's arguments.

# sum = Calculator.add(1, 2)
# # => 3
# The defp keyword can be used instead of def to define a private function. Private functions can only be used from within the same module that defined them.

# When invoking a function inside the same module where it's defined, the module name can be omitted.

# You may also write short functions using a one-line syntax (note the comma , and the colon : around the keyword do).

# defmodule Calculator do
#   def subtract(x, y) do
#     private_subtract(x, y)
#   end

#   defp private_subtract(x, y), do: x - y
# end

# difference = Calculator.subtract(7, 2)
# # => 5

# difference = Calculator.private_subtract(7, 2)
# # => ** (UndefinedFunctionError) function Calculator.private_subtract/2 is undefined or private
# #       Calculator.private_subtract(7, 2)
# Arity of functions
# It is common to refer to functions with their arity. The arity of a function is the number of arguments it accepts.

# # add/3 because this function has three arguments, thus an arity of 3
# def add(x, y, z) do
#   x + y + z
# end
# Standard library
# Elixir has a very rich and well-documented standard library. The documentation is available online at hexdocs.pm/elixir. Save this link somewhere - you will use it a lot!

# Most built-in data types have a corresponding module that offers functions for working with that data type, e.g. there's the Integer module for integers, String module for strings, List module for lists and so on.

# A notable module is the Kernel module. It provides the basic capabilities on top of which the rest of the standard library is built, like arithmetic operators, control-flow macros, and much more. Functions for the Kernel module are automatically imported, so you can use them without the Kernel. prefix.

# Code comments
# Comments can be used to leave notes for other developers reading the source code. Single line comments in Elixir are preceded by #.

# Instructions
# In this exercise you're going to write some code to help you cook a brilliant lasagna from your favorite cooking book.

# You have five tasks, all related to the time spent cooking the lasagna.

# Task 1
# Define the expected oven time in minutes

# Define the Lasagna.expected_minutes_in_oven/0 function that does not take any arguments and returns how many minutes the lasagna should be in the oven. According to the cooking book, the expected oven time in minutes is 40:

# Lasagna.expected_minutes_in_oven()
# # => 40

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Calculate the remaining oven time in minutes

# Define the Lasagna.remaining_minutes_in_oven/1 function that takes the actual minutes the lasagna has been in the oven as an argument and returns how many minutes the lasagna still has to remain in the oven, based on the expected oven time in minutes from the previous task.

# Lasagna.remaining_minutes_in_oven(30)
# # => 10

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Calculate the preparation time in minutes

# Define the Lasagna.preparation_time_in_minutes/1 function that takes the number of layers you added to the lasagna as an argument and returns how many minutes you spent preparing the lasagna, assuming each layer takes you 2 minutes to prepare.

# Lasagna.preparation_time_in_minutes(2)
# # => 4

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Calculate the total working time in minutes

# Define the Lasagna.total_time_in_minutes/2 function that takes two arguments: the first argument is the number of layers you added to the lasagna, and the second argument is the number of minutes the lasagna has been in the oven. The function should return how many minutes in total you've worked on cooking the lasagna, which is the sum of the preparation time in minutes, and the time in minutes the lasagna has spent in the oven at the moment.

# Lasagna.total_time_in_minutes(3, 20)
# # => 26

# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Create a notification that the lasagna is ready

# Define the Lasagna.alarm/0 function that does not take any arguments and returns a message indicating that the lasagna is ready to eat.

# Lasagna.alarm()
# # => "Ding!"


defmodule Lasagna do
  def expected_minutes_in_oven, do: 40
  def remaining_minutes_in_oven(elapsed), do: expected_minutes_in_oven - elapsed
  def preparation_time_in_minutes(layers), do: layers * 2
  def total_time_in_minutes(layers, elapsed), do: elapsed + preparation_time_in_minutes(layers)
  def alarm, do: "Ding!"
end



# Elixir / Pacman Rules

# Introduction
# Booleans
# Elixir represents true and false values with the boolean type. There are only two values: true and false. These values can be bound to a variable:

# true_variable = true
# false_variable = false
# We can evaluate strict boolean expressions using the and/2, or/2, and not/1 operators.

# true_variable = true and true
# false_variable = true and false

# true_variable = false or true
# false_variable = false or false

# true_variable = not false
# false_variable = not true
# When writing a function that returns a boolean value, it is idiomatic to end the function name with a ?.

# def either_true?(a, b) do
#   a or b
# end
# Instructions
# In this exercise, you need to translate some rules from the classic game Pac-Man into Elixir functions.

# You have four rules to translate, all related to the game states.

# Don't worry about how the arguments are derived, just focus on combining the arguments to return the intended result.

# Task 1
# Define if Pac-Man eats a ghost

# Define the Rules.eat_ghost?/2 function that takes two arguments (if Pac-Man has a power pellet active and if Pac-Man is touching a ghost) and returns a boolean value if Pac-Man is able to eat the ghost. The function should return true only if Pac-Man has a power pellet active and is touching a ghost.

# Rules.eat_ghost?(false, true)
# # => false

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Define if Pac-Man scores

# Define the Rules.score?/2 function that takes two arguments (if Pac-Man is touching a power pellet and if Pac-Man is touching a dot) and returns a boolean value if Pac-Man scored. The function should return true if Pac-Man is touching a power pellet or a dot.

# Rules.score?(true, true)
# # => true

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Define if Pac-Man loses

# Define the Rules.lose?/2 function that takes two arguments (if Pac-Man has a power pellet active and if Pac-Man is touching a ghost) and returns a boolean value if Pac-Man loses. The function should return true if Pac-Man is touching a ghost and does not have a power pellet active.

# Rules.lose?(false, true)
# # => true

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Define if Pac-Man wins

# Define the Rules.win?/3 function that takes three arguments (if Pac-Man has eaten all of the dots, if Pac-Man has a power pellet active, and if Pac-Man is touching a ghost) and returns a boolean value if Pac-Man wins. The function should return true if Pac-Man has eaten all of the dots and has not lost based on the arguments defined in part 3.

# Rules.win?(false, true, false)
# # => false


defmodule Rules do
  def eat_ghost?(true, true), do: true
  def eat_ghost?(_power_pellet_active, _touching_ghost), do: false

  def score?(false, false), do: false
  def score?(_touching_power_pellet, _touching_dot), do: true

  def lose?(false, true), do: true
  def lose?(_power_pellet_active, _touching_ghost), do: false

  def win?(true, false, true), do: false
  def win?(has_eaten_all_dots, _power_pellet_active, _touching_ghost), do: has_eaten_all_dots
end



# Elixir / Log Level

# Introduction
# Atoms
# Elixir's atom type represents a fixed constant. An atom's value is simply its own name. This gives us a type-safe way to interact with data. Atoms can be defined as follows:

# # All atoms are preceded with a ':' then follow with alphanumeric snake-cased characters
# variable = :an_atom
# Atoms are internally represented by an integer in a lookup table, which are set automatically. It is not possible to change this internal value.

# Cond
# Often, we want to write code that can branch based on a condition. While there are many ways to do this in Elixir, one of the simplest ways is using cond/1.

# At its simplest, cond follows the first path that evaluates to true with one or more branches:

# cond do
#   x > 10 -> :this_might_be_the_way
#   y < 7 -> :or_that_might_be_the_way
#   true -> :this_is_the_default_way
# end
# If no path evaluates to true, an error is raised by the runtime.

# Instructions
# You are running a system that consists of a few applications producing many logs. You want to write a small program that will aggregate those logs and give them labels according to their severity level. All applications in your system use the same log codes, but some of the legacy applications don't support all the codes.

# Log code	Log label	Supported in legacy apps?
# 0	trace	no
# 1	debug	yes
# 2	info	yes
# 3	warning	yes
# 4	error	yes
# 5	fatal	no
# ?	unknown	-
# Task 1
# Return the logging code label

# Implement the LogLevel.to_label/2 function. It should take an integer code and a boolean flag telling you if the log comes from a legacy app, and return the label of a log line as an atom. Unknown log codes and codes unsupported in a legacy app should return an unknown label.

# LogLevel.to_label(0, false)
# # => :trace

# LogLevel.to_label(0, true)
# # => :unknown

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Send an alert

# Somebody has to be notified when unexpected things happen.

# Implement the LogLevel.alert_recipient/2 function to determine to whom the alert needs to be sent. The function should take an integer code and a boolean flag telling you if the log comes from a legacy app, and return the name of the recipient as an atom.

# If the log label is error or fatal, send the alert to the ops team. If you receive a log with an unknown label from a legacy system, send the alert to the dev1 team, other unknown labels should be sent to the dev2 team. All other log labels can be safely ignored.

# LogLevel.alert_recipient(-1, true)
# # => :dev1

# LogLevel.alert_recipient(0, false)
# # => false


defmodule LogLevel do
  def to_label(0, false), do: :trace
  def to_label(1, _), do: :debug
  def to_label(2, _), do: :info
  def to_label(3, _), do: :warning
  def to_label(4, _), do: :error
  def to_label(5, false), do: :fatal
  def to_label(_level, _legacy?), do: :unknown

  def alert_recipient(level, legacy?) when is_number(level), do: alert_recipient(to_label(level, legacy?), legacy?)
  def alert_recipient(:error, _), do: :ops
  def alert_recipient(:fatal, _), do: :ops
  def alert_recipient(:unknown, true), do: :dev1
  def alert_recipient(:unknown, false), do: :dev2
  def alert_recipient(_, _), do: false
end



# Elixir / Secrets

# Introduction
# Anonymous Functions
# Functions are treated as first class citizens in Elixir. This means that:

# Named and anonymous functions can be assigned to variables.
# Named and anonymous functions can be passed around like data as arguments and return values.
# Anonymous functions can be created dynamically.
# Anonymous functions, in contrast to named functions, don't have a static reference available to them, they are only available if they are assigned to a variable or immediately invoked.

# We might use anonymous functions to:

# Hide data using lexical scope (also known as a closure).
# Dynamically create functions at run-time.
# Anonymous functions start with the reserved word fn, the arguments are separated from the body of the function with the -> token, and they are finished with an end. As with named functions, the last expression in the function is implicitly returned to the calling function.

# To invoke a function reference, you must use a . between the reference variable and the list of arguments:

# function_variable = fn param ->
#   param + 1
# end

# function_variable.(1)
# # => 2
# You can even use short hand capture notation to make this more concise:

# variable = &(&1 + 1)

# variable.(1)
# # => 2
# Bit Manipulation
# Elixir supports many functions for working with bits found in the Bitwise module.

# band/2: bitwise AND
# bsl/2: bitwise SHIFT LEFT
# bsr/2: bitwise SHIFT RIGHT
# bxor/2: bitwise XOR
# bor/2: bitwise OR
# bnot/1: bitwise NOT
# Here is an example how to use a bitwise function:

# Bitwise.bsl(1, 3)
# # => 8
# All bitwise functions only work on integers.

# If you are running Elixir version 1.9 or lower, you will need to call require Bitwise at the beginning of the module definition to be able to use the Bitwise module.

# Instructions
# In this exercise, you've been tasked with writing the software for an encryption device that works by performing transformations on data. You need a way to flexibly create complicated functions by combining simpler functions together.

# For each task, return an anonymous function that can be invoked from the calling scope.

# All functions should expect integer arguments. Integers are also suitable for performing bitwise operations in Elixir.

# Task 1
# Create an adder

# Implement Secrets.secret_add/1. It should return a function which takes one argument and adds to it the argument passed in to secret_add.

# adder = Secrets.secret_add(2)
# adder.(2)
# # => 4

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Create a subtractor

# Implement Secrets.secret_subtract/1. It should return a function which takes one argument and subtracts the secret passed in to secret_subtract from that argument.

# subtractor = Secrets.secret_subtract(2)
# subtractor.(3)
# # => 1

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Create a multiplier

# Implement Secrets.secret_multiply/1. It should return a function which takes one argument and multiplies it by the secret passed in to secret_multiply.

# multiplier = Secrets.secret_multiply(7)
# multiplier.(3)
# # => 21

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Create a divider

# Implement Secrets.secret_divide/1. It should return a function which takes one argument and divides it by the secret passed in to secret_divide.

# divider = Secrets.secret_divide(3)
# divider.(32)
# # => 10
# Make use of integer division so the output is compatible with the other functions' expected input.


# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Create an "and"-er

# Implement Secrets.secret_and/1. It should return a function which takes one argument and performs a bitwise and operation on it and the secret passed in to secret_and.

# ander = Secrets.secret_and(1)
# ander.(2)
# # => 0

# Stuck? Reveal Hints
# Opens in a modal
# Task 6
# Create an "xor"-er

# Implement Secrets.secret_xor/1. It should return a function which takes one argument and performs a bitwise xor operation on it and the secret passed in to secret_xor.

# xorer = Secrets.secret_xor(1)
# xorer.(3)
# # => 2

# Stuck? Reveal Hints
# Opens in a modal
# Task 7
# Create a function combiner

# Implement Secrets.secret_combine/2. It should return a function which takes one argument and applies to it the two functions passed in to secret_combine in order.

# multiply = Secrets.secret_multiply(7)
# divide = Secrets.secret_divide(3)
# combined = Secrets.secret_combine(multiply, divide)

# combined.(6)
# # => 14


defmodule Secrets do
  use Bitwise, only_operators: true
  def secret_add(secret), do: &(&1 + secret)
  def secret_subtract(secret), do: &(&1 - secret)
  def secret_multiply(secret), do: &(&1 * secret)
  def secret_divide(secret) when secret != 0, do: &(div &1, secret)
  def secret_and(secret), do: &(&1 &&& secret)
  def secret_xor(secret), do: &(&1 ^^^ secret)
  def secret_combine(f, g), do: fn x -> x |> f.() |> g.() end
end



# Elixir / Guessing Game

# Introduction
# Multiple Clause Functions
# Elixir facilitates Open-Close Principle practices by allowing functions to have multiple clauses, so instead of sprawling and hard-coded control-logic, pointed functions can be written to add/remove behavior easily.

# Elixir offers multiple function clauses and guards to write:

# def number(n) when n == 7 do
#   "Awesome, that's my favorite"
# end
# def number(_n) do
#   "That's not my favorite"
# end
# At run-time, Elixir will test, from top to bottom of the source file, which function clause to invoke.

# Variables that are unused should be prefixed with an underscore.

# Guards
# Guards are used to prevent Elixir from invoking functions based on evaluation of the arguments by guard functions. Guards begin with the when keyword, followed by a boolean expression. Guard functions are special functions which:

# Must be pure and not mutate any global states.
# Must return strict true or false values.
# A list of common guards can be found in the Elixir documentation. It includes type checks, basic arithmetic, comparisons, and strictly boolean operators.

# Default Arguments
# Functions may declare default values for one or more arguments. Let's consider this function:

# def number(n \\ 13), do: "That's not my favorite"
# When compiled, Elixir creates a function definition for number/0 (no arguments), and number/1 (one argument).

# If more than one argument has default values, the default values will be applied to the function from left to right to fill in for missing arguments.

# If the function has more than one clause, the default arguments should be defined in a function header (a function without a body) before the function clauses:

# def number(n \\ 13)
# def number(n) when n < 10, do: "Dream bigger!"
# def number(n) when n > 100, do: "Not that big..."
# Instructions
# You are creating a trivial online game where a friend can guess a secret number. You want to give some feedback, but not give away the answer with a guess. You need to devise a function to provide different responses depending on how the guess relates to the secret number.

# Condition	Response
# When the guess matches the secret number	"Correct"
# When the guess is one more or one less than the secret number	"So close"
# When the guess is greater than the secret number	"Too high"
# When the guess is less than the secret number	"Too low"
# When a guess isn't made	"Make a guess"
# All guesses and secret numbers are integer numbers.

# Task 1
# Make the response when the guess matches the secret number

# Implement the compare/2 function which takes two arguments, secret_number and guess, which are both integers.

# GuessingGame.compare(5, 5)
# # => "Correct"

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Make the response when the guess is greater than the secret number

# Modify the compare function to respond to guesses that are higher than the secret number.

# GuessingGame.compare(5, 8)
# # => "Too high"

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Make the response when the guess is less than the secret number

# Modify the compare function to respond to guesses that are lower than the secret number.

# GuessingGame.compare(5, 2)
# # => "Too low"

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Make the responses when the guess is one more or one less than the secret number

# Modify the compare function to respond to guesses that are close to the secret number.

# GuessingGame.compare(5, 6)
# # => "So close"
# GuessingGame.compare(5, 4)
# # => "So close"

# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Make the response when there is no guess

# Modify the compare function to respond to a lack of guess.

# GuessingGame.compare(5)
# # => "Make a guess"

# GuessingGame.compare(5, :no_guess)
# # => "Make a guess"


defmodule GuessingGame do
  def compare(secret_number, guess) when guess == secret_number, do: "Correct"
  def compare(secret_number, guess \\ :no_guess) when guess == :no_guess, do: "Make a guess"
  def compare(secret_number, guess) when guess == secret_number - 1, do: "So close"
  def compare(secret_number, guess) when guess == secret_number + 1, do: "So close"
  def compare(secret_number, guess) when guess > secret_number, do: "Too high"
  def compare(secret_number, guess) when guess < secret_number, do: "Too low"
end



# Elixir / Freelancer Rates

# Introduction
# Integers
# There are two different kinds of numbers in Elixir - integers and floats.

# Integers are whole numbers.

# integer = 3
# # => 3
# Floating Point Numbers
# Floats are numbers with one or more digits behind the decimal separator. They use the 64-bit double precision floating-point format.

# float = 3.45
# # => 3.45
# Working with numbers
# In the Integer and Float modules you can find some useful functions for working with those types. Basic arithmetic operators are defined in the Kernel module.

# Conversion
# Integers and floats can be mixed together in a single arithmetic expression. Using a float in an expression ensures the result will be a float too.

# 2 * 3
# # => 6

# 2 * 3.0
# # => 6.0
# However, when doing division, the result will always be a float, even if only integers are used.

# 6 / 2
# # => 3.0
# To convert a float to an integer, you can discard the decimal part with trunc/1.

# Instructions
# In this exercise you'll be writing code to help a freelancer communicate with a project manager by providing a few utilities to quickly calculate daily and monthly rates, optionally with a given discount.

# We first establish a few rules between the freelancer and the project manager:

# The daily rate is 8 times the hourly rate.
# A month has 22 billable days.
# The freelancer is offering to apply a discount if the project manager chooses to let the freelancer bill per month, which can come in handy if there is a certain budget the project manager has to work with.

# Discounts are modeled as fractional numbers representing percentage, for example 25.0 (25%).

# Task 1
# Calculate the daily rate given an hourly rate

# Implement a function to calculate the daily rate given an hourly rate:

# FreelancerRates.daily_rate(60)
# # => 480.0
# The returned daily rate should be a float.


# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Calculate a discounted price

# Implement a function to calculate the price after a discount.

# FreelancerRates.apply_discount(150, 10)
# # => 135.0
# The returned value should always be a float, not rounded in any way.


# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Calculate the monthly rate, given an hourly rate and a discount

# Implement a function to calculate the monthly rate, and apply a discount:

# FreelancerRates.monthly_rate(77, 10.5)
# # => 12130
# The returned monthly rate should be rounded up (take the ceiling) to the nearest integer.


# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Calculate the number of workdays given a budget, hourly rate and discount

# Implement a function that takes a budget, an hourly rate, and a discount, and calculates how many days of work that covers.

# FreelancerRates.days_in_budget(20000, 80, 11.0)
# # => 35.1
# The returned number of days should be rounded down (take the floor) to one decimal place.


defmodule FreelancerRates do
  @daily_rate 8.0
  @monthly_billable_days 22

  def daily_rate(hourly_rate), do: hourly_rate * @daily_rate
  def apply_discount(before_discount, discount), do: before_discount * (1 - discount / 100)

  def monthly_rate(hourly_rate, discount) do
    daily_rate(hourly_rate) * @monthly_billable_days
    |> apply_discount(discount)
    |> Float.ceil()
    |> round()
  end

  def days_in_budget(budget, hourly_rate, discount) do
    budget / apply_discount(daily_rate(hourly_rate), discount)
    |> Float.floor(1)
  end
end



# Elixir / Language List

# Introduction
# Lists
# Lists are built-in to the Elixir language. They are considered a basic type, denoted by square brackets. Lists may be empty or hold any number of items of any type. For example:

# empty_list = []
# one_item_list = [1]
# two_item_list = [1, 2]
# multiple_type_list = [1, :pi, 3.14, "four"]
# Elixir implements lists as a linked list, where each node stores the reference to the next list. The first item in the list is referred to as the head and the remaining list of items is called the tail. We can use this notation in code:

# # [1] represented in [head | tail] notation
# [1 | []]

# # [1, 2, 3] represented in [head | tail] notation
# [1 | [2 | [3 | []]]]
# We can use [head | tail] notation to prepend elements to a list:

# # Suppose
# list = [2, 1]

# [3, 2, 1] == [3 | list]
# # => true
# There are several functions in the Kernel module for working with lists, as well as the whole List module.

# # Check if 1 is a member of the list
# 1 in [1, 2, 3, 4]
# # => true
# Instructions
# In this exercise you need to implement some functions to manipulate a list of programming languages.

# Task 1
# Define a function to return an empty language list

# Define the new/0 function that takes no arguments and returns an empty list.

# LanguageList.new()
# # => []

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Define a function to add a language to the list

# Define the add/2 function that takes 2 arguments (a language list and a string literal of a language). It should return the resulting list with the new language prepended to the given list.

# language_list = LanguageList.new()
# # => []
# language_list = LanguageList.add(language_list, "Clojure")
# # => ["Clojure"]
# language_list = LanguageList.add(language_list, "Haskell")
# # => ["Haskell", "Clojure"]

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Define a function to remove a language from the list

# Define the remove/1 function that takes 1 argument (a language list). It should return the list without the first item. Assume the list will always have at least one item.

# language_list = LanguageList.new()
# # => []
# language_list = LanguageList.add(language_list, "Clojure")
# # => ["Clojure"]
# language_list = LanguageList.add(language_list, "Haskell")
# # => ["Haskell", "Clojure"]
# language_list = LanguageList.remove(language_list)
# # => ["Clojure"]

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Define a function to return the first item in the list

# Define the first/1 function that takes 1 argument (a language list). It should return the first language in the list. Assume the list will always have at least one item.

# language_list = LanguageList.new()
# # => []
# language_list = LanguageList.add(language_list, "Elm")
# # => ["Elm"]
# language_list = LanguageList.add(language_list, "Prolog")
# # => ["Prolog", "Elm"]
# LanguageList.first(language_list)
# # => "Prolog"

# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Define a function to return how many languages are in the list

# Define the count/1 function that takes 1 argument (a language list). It should return the number of languages in the list.

# language_list = LanguageList.new()
# # => []
# language_list = LanguageList.add(language_list, "Elm")
# # => ["Elm"]
# language_list = LanguageList.add(language_list, "Prolog")
# # => ["Prolog", "Elm"]
# LanguageList.count(language_list)
# # => 2

# Stuck? Reveal Hints
# Opens in a modal
# Task 6
# Define a function to determine if the list includes a functional language

# Define the functional_list?/1 function which takes 1 argument (a language list). It should return a boolean value. It should return true if "Elixir" is one of the languages in the list.

# language_list = LanguageList.new()
# # => []
# language_list = LanguageList.add(language_list, "Elixir")
# # => ["Elixir"]
# LanguageList.functional_list?(language_list)
# # => true


defmodule LanguageList do
  def new(), do: []
  def add(list, language), do: [language | list]
  def remove([_ | tail]), do: tail
  def first([head | _]), do: head
  def count(list), do: length(list)
  def functional_list?(list), do: "Elixir" in list
end



# Elixir / Leap

# Instructions
# Given a year, report if it is a leap year.

# The tricky thing here is that a leap year in the Gregorian calendar occurs:

# on every year that is evenly divisible by 4
#   except every year that is evenly divisible by 100
#     unless the year is also evenly divisible by 400
# For example, 1997 is not a leap year, but 1996 is. 1900 is not a leap year, but 2000 is.

# Notes
# Though our exercise adopts some very simple rules, there is more to learn!

# For a delightful, four minute explanation of the whole leap year phenomenon, go watch this youtube video.


defmodule Year do
  def leap_year?(year) when rem(year, 400) == 0, do: true
  def leap_year?(year) when rem(year, 100) == 0, do: false
  def leap_year?(year) when rem(year, 4) == 0, do: true
  def leap_year?(_), do: false
end



# Elixir / Darts

# Instructions
# Write a function that returns the earned points in a single toss of a Darts game.

# Darts is a game where players throw darts at a target.

# In our particular instance of the game, the target rewards 4 different amounts of points, depending on where the dart lands:

# If the dart lands outside the target, player earns no points (0 points).
# If the dart lands in the outer circle of the target, player earns 1 point.
# If the dart lands in the middle circle of the target, player earns 5 points.
# If the dart lands in the inner circle of the target, player earns 10 points.
# The outer circle has a radius of 10 units (this is equivalent to the total radius for the entire target), the middle circle a radius of 5 units, and the inner circle a radius of 1. Of course, they are all centered at the same point (that is, the circles are concentric) defined by the coordinates (0, 0).

# Write a function that given a point in the target (defined by its Cartesian coordinates x and y, where x and y are real), returns the correct amount earned by a dart landing at that point.


defmodule Darts do
  def score({x, y}) do
    r = :math.sqrt(x * x + y * y)
    cond do
      r > 10 -> 0
      r > 5 -> 1
      r > 1 -> 5
      true -> 10
    end
  end
end



# Elixir / Kitchen Calculator

# Introduction
# Tuples
# In Elixir, a tuple is a data structure which organizes data, holding a fixed number of items of any type, but without explicit names for each element. Tuples are often used in Elixir for memory read-intensive operations, since read-access of an element is a constant-time operation. They are not usually used when elements may need to be added/removed dynamically because rather than modifying the existing tuple, a new tuple is created which requires memory to be allocated upfront.

# In practice, tuples are created in Elixir using curly braces. Elements in a tuple can be individually accessed using the elem/2 function using 0-based indexing:

# empty_tuple = {}
# one_element_tuple = {1}
# multiple_element_tuple = {1, :a, "hello"}

# elem(multiple_element_tuple, 2)
# # => "hello"
# Tuples as grouped information
# Tuples are often used in practice to represent grouped information.

# Float.ratio(0.25)
# # => {1, 4} indicating the numerator and denominator of the fraction ¼
# Pattern Matching
# The use of pattern matching is dominant in assertive, idiomatic Elixir code. You might recall that =/2 is described as a match operator rather than as an assignment operator. When using the match operator, if the pattern on the left matches the right, any variables on the left are bound, and the value of the right side is returned. A MatchError is raised if there is no match.

# 2 = 2
# # => 2
# # Literals can be matched if they are the same

# 2 = 3
# # => ** (MatchError) no match of right hand side value: 3

# {_, denominator} = Float.ratio(0.25)
# # => {1, 4}
# # the variable `denominator` is bound to the value 4
# Remember, matches occur from the right side to the left side.

# In the last example if we don't need a variable in a pattern match, we can discard it by referencing _. Any variable starting with an _ is not tracked by the runtime.

# Pattern matching in named functions
# Pattern matching is also a useful tool when creating multiple function clauses. Pattern matching can be used on the functions' arguments which then determines which function clause to invoke -- starting from the top of the file down until the first match. Variables may be bound in a function head and used in the function body.

# defmodule Example do
#   def named_function(:a = variable_a) do
#     {variable_a, 1}
#   end

#   def named_function(:b = variable_b) do
#     {variable_b, 2}
#   end
# end

# Example.named_function(:a)
# # => {:a, 1}

# Example.named_function(:b)
# # => {:b, 2}

# Example.named_function(:c)
# # => ** (FunctionClauseError) no function clause matching in Example.named_function/1
# Instructions
# While preparing to bake cookies for your friends, you have found that you have to convert some of the measurements used in the recipe. Being only familiar with the metric system, you need to come up with a way to convert common US baking measurements to milliliters (mL) for your own ease.

# Use this conversion chart for your solution:

# Unit to convert	volume	in milliliters (mL)
# mL	1	1
# US cup	1	240
# US fluid ounce	1	30
# US teaspoon	1	5
# US tablespoon	1	15
# Being a talented programmer in training, you decide to use milliliters as a transition unit to facilitate the conversion from any unit listed to any other (even itself).

# Task 1
# Get the numeric component from a volume-pair

# Implement the KitchenCalculator.get_volume/1 function. Given a volume-pair tuple, it should return just the numeric component.

# KitchenCalculator.get_volume({:cup, 2.0})
# # => 2.0

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Convert the volume-pair to milliliters

# Implement the KitchenCalculator.to_milliliter/1 function. Given a volume-pair tuple, it should convert the volume to milliliters using the conversion chart.

# Use multiple function clauses and pattern matching to create the functions for each unit. The atoms used to denote each unit are: :cup, :fluid_ounce, :teaspoon, :tablespoon, :milliliter. Return the result of the conversion wrapped in a tuple.

# KitchenCalculator.to_milliliter({:cup, 2.5})
# # => {:milliliter, 600.0}

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Convert the milliliter volume-pair to another unit

# Implement the KitchenCalculator.from_milliliter/2 function. Given a volume-pair tuple and the desired unit, it should convert the volume to the desired unit using the conversion chart.

# Use multiple function clauses and pattern matching to create the functions for each unit. The atoms used to denote each unit are: :cup, :fluid_ounce, :teaspoon, :tablespoon, :milliliter

# KitchenCalculator.from_milliliter({:milliliter, 1320.0}, :cup)
# # => {:cup, 5.5}

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Convert from any unit to any unit

# Implement the KitchenCalculator.convert/2 function. Given a volume-pair tuple and the desired unit, it should convert the given volume to the desired unit.

# KitchenCalculator.convert({:teaspoon, 9.0}, :tablespoon)
# # => {:tablespoon, 3.0}


defmodule KitchenCalculator do
  def get_volume({_unit, volume}), do: volume
  def to_milliliter({unit, volume}), do: {:milliliter, volume * factor(unit)}
  def from_milliliter({:milliliter, volume}, unit), do: {unit, volume / factor(unit)}
  def convert(volume_pair, unit), do: volume_pair |> to_milliliter() |> from_milliliter(unit)
  defp factor(:milliliter), do: 1
  defp factor(:teaspoon), do: 5
  defp factor(:tablespoon), do: 15
  defp factor(:fluid_ounce), do: 30
  defp factor(:cup), do: 240
end



# Elixir  / Rational Numbers

# Instructions
# A rational number is defined as the quotient of two integers a and b, called the numerator and denominator, respectively, where b != 0.

# Note
# Note that mathematically, the denominator can't be zero. However in many implementations of rational numbers, you will find that the denominator is allowed to be zero with behaviour similar to positive or negative infinity in floating point numbers. In those cases, the denominator and numerator generally still can't both be zero at once.

# The absolute value |r| of the rational number r = a/b is equal to |a|/|b|.

# The sum of two rational numbers r₁ = a₁/b₁ and r₂ = a₂/b₂ is r₁ + r₂ = a₁/b₁ + a₂/b₂ = (a₁ * b₂ + a₂ * b₁) / (b₁ * b₂).

# The difference of two rational numbers r₁ = a₁/b₁ and r₂ = a₂/b₂ is r₁ - r₂ = a₁/b₁ - a₂/b₂ = (a₁ * b₂ - a₂ * b₁) / (b₁ * b₂).

# The product (multiplication) of two rational numbers r₁ = a₁/b₁ and r₂ = a₂/b₂ is r₁ * r₂ = (a₁ * a₂) / (b₁ * b₂).

# Dividing a rational number r₁ = a₁/b₁ by another r₂ = a₂/b₂ is r₁ / r₂ = (a₁ * b₂) / (a₂ * b₁) if a₂ is not zero.

# Exponentiation of a rational number r = a/b to a non-negative integer power n is r^n = (a^n)/(b^n).

# Exponentiation of a rational number r = a/b to a negative integer power n is r^n = (b^m)/(a^m), where m = |n|.

# Exponentiation of a rational number r = a/b to a real (floating-point) number x is the quotient (a^x)/(b^x), which is a real number.

# Exponentiation of a real number x to a rational number r = a/b is x^(a/b) = root(x^a, b), where root(p, q) is the qth root of p.

# Implement the following operations:

# addition, subtraction, multiplication and division of two rational numbers,
# absolute value, exponentiation of a given rational number to an integer power, exponentiation of a given rational number to a real (floating-point) power, exponentiation of a real number to a rational number.
# Your implementation of rational numbers should always be reduced to lowest terms. For example, 4/4 should reduce to 1/1, 30/60 should reduce to 1/2, 12/8 should reduce to 3/2, etc. To reduce a rational number r = a/b, divide a and b by the greatest common divisor (gcd) of a and b. So, for example, gcd(12, 8) = 4, so r = 12/8 can be reduced to (12/4)/(8/4) = 3/2. The reduced form of a rational number should be in "standard form" (the denominator should always be a positive integer). If a denominator with a negative integer is present, multiply both numerator and denominator by -1 to ensure standard form is reached. For example, 3/-4 should be reduced to -3/4

# Assume that the programming language you are using does not have an implementation of rational numbers.


defmodule RationalNumbers do
  @type rational :: {integer, integer}

  @spec add(a :: rational, b :: rational) :: rational
  def add({a1, b1}, {a2, b2}), do: {(a1 * b2) + (a2 * b1), b1 * b2} |> reduce()

  @spec subtract(a :: rational, b :: rational) :: rational
  def subtract({a1, b1}, {a2, b2}), do: {(a1 * b2) - (a2 * b1), b1 * b2} |> reduce()

  @spec multiply(a :: rational, b :: rational) :: rational
  def multiply({a1, b1}, {a2, b2}), do: {a1 * a2, b1 * b2} |> reduce()

  @spec divide_by(num :: rational, den :: rational) :: rational
  def divide_by({a1, b1}, {a2, b2}), do: {a1 * b2, a2 * b1} |> reduce()

  @spec abs(a :: rational) :: rational
  def abs({a, b}), do: {Kernel.abs(a), Kernel.abs(b)} |> reduce()

  @spec pow_rational(a :: rational, n :: integer) :: rational
  def pow_rational({a, b}, n) when n < 0, do: {b ** -n, a ** -n} |> reduce()
  def pow_rational({a, b}, n), do: {a ** n, b ** n} |> reduce()

  @spec pow_real(x :: integer, n :: rational) :: float
  def pow_real(x, {a, b}), do: x ** (a / b)

  @spec reduce(a :: rational) :: rational
  def reduce({a, b}) when b < 0, do: reduce({-a, -b})
  def reduce({a, b}) do
    gcd = Integer.gcd(a, b)
    {a / gcd, b / gcd}
  end
end



# Elixir / High School Sweetheart

# Introduction
# Strings
# Strings in Elixir are delimited by double quotes, and they are encoded in UTF-8:

# "Hi!"
# Strings can be concatenated using the <>/2 operator:

# "Welcome to" <> " " <> "New York"
# # => "Welcome to New York"
# Strings in Elixir support interpolation using the #{} syntax:

# "6 * 7 = #{6 * 7}"
# # => "6 * 7 = 42"
# To put a newline character in a string, use the \n escape code:

# "1\n2\n3\n"
# To comfortably work with texts with a lot of newlines, use the triple-double-quote heredoc syntax instead:

# """
# 1
# 2
# 3
# """
# Elixir provides many functions for working with strings in the String module.

# Pipe Operator
# The |> operator is called the pipe operator. It can be used to chain function calls together in such a way that the value returned by the previous function call is passed as the first argument to the next function call.

# "hello"
# |> String.upcase()
# |> Kernel.<>("?!")
# # => "HELLO?!"
# Instructions
# In this exercise, you are going to help high school sweethearts profess their love on social media by generating an ASCII heart with their initials:

#      ******       ******
#    **      **   **      **
#  **         ** **         **
# **            *            **
# **                         **
# **     J. K.  +  M. B.     **
#  **                       **
#    **                   **
#      **               **
#        **           **
#          **       **
#            **   **
#              ***
#               *
# Task 1
# Get the name's first letter

# Implement the HighSchoolSweetheart.first_letter/1 function. It should take a name and return its first letter. It should clean up any unnecessary whitespace from the name.

# HighSchoolSweetheart.first_letter("Jane")
# # => "J"

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Format the first letter as an initial

# Implement the HighSchoolSweetheart.initial/1 function. It should take a name and return its first letter, uppercase, followed by a dot. Make sure to reuse HighSchoolSweetheart.first_letter/1 that you defined in the previous step.

# HighSchoolSweetheart.initial("Robert")
# # => "R."

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Split the full name into the first name and the last name

# Implement the HighSchoolSweetheart.initials/1 function. It should take a full name, consisting of a first name and a last name separated by a space, and return the initials. Make sure to reuse HighSchoolSweetheart.initial/1 that you defined in the previous step.

# HighSchoolSweetheart.initials("Lance Green")
# # => "L. G."

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Put the initials inside of the heart

# Implement the HighSchoolSweetheart.pair/2 function. It should take two full names and return the initials. Make sure to reuse HighSchoolSweetheart.initials/1 that you defined in the previous step.

# HighSchoolSweetheart.pair("Blake Miller", "Riley Lewis")
# # => """
# #      ******       ******
# #    **      **   **      **
# #  **         ** **         **
# # **            *            **
# # **                         **
# # **     B. M.  +  R. L.     **
# #  **                       **
# #    **                   **
# #      **               **
# #        **           **
# #          **       **
# #            **   **
# #              ***
# #               *
# # """


defmodule HighSchoolSweetheart do
  def first_letter(name), do: name |> String.trim() |> String.first()
  def initial(name), do: first_letter(name) <> "." |> String.upcase()
  def initials(full_name), do: full_name |> String.split(" ") |> Enum.map(&initial/1) |> Enum.join(" ")
  def pair(full_name1, full_name2) do
    i1 = initials(full_name1)
    i2 = initials(full_name2)
    """
       ******       ******
     **      **   **      **
   **         ** **         **
  **            *            **
  **                         **
  **     #{i1}  +  #{i2}     **
   **                       **
     **                   **
       **               **
         **           **
           **       **
             **   **
               ***
                *
  """
    end
end



# Elixir / Two Fer

# Instructions
# Two-fer or 2-fer is short for two for one. One for you and one for me.

# Given a name, return a string with the message:

# One for name, one for me.
# Where "name" is the given name.

# However, if the name is missing, return the string:

# One for you, one for me.
# Here are some examples:

# Name	String to return
# Alice	One for Alice, one for me.
# Bob	One for Bob, one for me.
# One for you, one for me.
# Zaphod	One for Zaphod, one for me.


defmodule TwoFer do
  def two_fer(name \\ "you") when is_binary(name), do: "One for #{name}, one for me."
end



# Elixir / Bird Count

# Introduction
# Recursion
# Recursive functions are functions that call themselves.

# A recursive function needs to have at least one base case and at least one recursive case.

# A base case returns a value without calling the function again. A recursive case calls the function again, modifying the input so that it will at some point match the base case.

# Very often, each case is written in its own function clause.

# # base case
# def count([]), do: 0

# # recursive case
# def count([_head | tail]), do: 1 + count(tail)
# Instructions
# You're an avid bird watcher that keeps track of how many birds have visited your garden on any given day.

# You decided to bring your bird watching to a new level and implement a few tools that will help you track and process the data.

# You have chosen to store the data as a list of integers. The first number in the list is the number of birds that visited your garden today, the second yesterday, and so on.

# Task 1
# Check how many birds visited today

# Implement the BirdCount.today/1 function. It should take a list of daily bird counts and return today's count. If the list is empty, it should return nil.

# BirdCount.today([2, 5, 1])
# # => 2

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Increment today's count

# Implement the BirdCount.increment_day_count/1 function. It should take a list of daily bird counts and increment the today's count by 1. If the list is empty, return [1].

# BirdCount.increment_day_count([4, 0, 2])
# # => [5, 0, 2]

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Check if there was a day with no visiting birds

# Implement the BirdCount.has_day_without_birds?/1 function. It should take a list of daily bird counts. It should return true if there was at least one day when no birds visited the garden, and false otherwise.

# BirdCount.has_day_without_birds?([2, 0, 4])
# # => true

# BirdCount.has_day_without_birds?([3, 8, 1, 5])
# # => false

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Calculate the total number of visiting birds

# Implement the BirdCount.total/1 function. It should take a list of daily bird counts and return the total number that visited your garden since you started collecting the data.

# BirdCount.total([4, 0, 9, 0, 5])
# # => 18

# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Calculate the number of busy days

# Some days are busier than others. A busy day is one where five or more birds have visited your garden.

# Implement the BirdCount.busy_days/1 function. It should take a list of daily bird counts and return the number of busy days.

# BirdCount.busy_days([4, 5, 0, 0, 6])
# # => 2


defmodule BirdCount do
  @busy_day_count 5
  def today(list), do: list |> List.first()
  def increment_day_count([]), do: [1]
  def increment_day_count([head | tail]), do: [head + 1 | tail]
  def has_day_without_birds?(list), do: list |> Enum.member?(0)
  def total(list), do: list |> Enum.sum()
  def busy_days(list), do: list |> Enum.count(& &1 >= @busy_day_count)
end



# Elixir / Binary Search

# Instructions
# Implement a binary search algorithm.

# Searching a sorted collection is a common task. A dictionary is a sorted list of word definitions. Given a word, one can find its definition. A telephone book is a sorted list of people's names, addresses, and telephone numbers. Knowing someone's name allows one to quickly find their telephone number and address.

# If the list to be searched contains more than a few items (a dozen, say) a binary search will require far fewer comparisons than a linear search, but it imposes the requirement that the list be sorted.

# In computer science, a binary search or half-interval search algorithm finds the position of a specified input value (the search "key") within an array sorted by key value.

# In each step, the algorithm compares the search key value with the key value of the middle element of the array.

# If the keys match, then a matching element has been found and its index, or position, is returned.

# Otherwise, if the search key is less than the middle element's key, then the algorithm repeats its action on the sub-array to the left of the middle element or, if the search key is greater, on the sub-array to the right.

# If the remaining array to be searched is empty, then the key cannot be found in the array and a special "not found" indication is returned.

# A binary search halves the number of items to check with each iteration, so locating an item (or determining its absence) takes logarithmic time. A binary search is a dichotomic divide and conquer search algorithm.


defmodule BinarySearch do
  @spec search(tuple, integer) :: {:ok, integer} | :not_found
  def search(tuple, key), do: search(tuple, key, 0, tuple_size(tuple) - 1)
  defp search(_tuple, _key, left, right) when left > right, do: :not_found
  defp search(tuple, key, left, right) do
    mid = div(left + right, 2)
    case elem(tuple, mid) do
      ^key -> {:ok, mid}
      value when value > key -> search(tuple, key, left, mid - 1)
      value when value < key -> search(tuple, key, mid + 1, right)
    end
  end
end



# Elixir / Collatz Conjecture

# Instructions
# The Collatz Conjecture or 3x+1 problem can be summarized as follows:

# Take any positive integer n. If n is even, divide n by 2 to get n / 2. If n is odd, multiply n by 3 and add 1 to get 3n + 1. Repeat the process indefinitely. The conjecture states that no matter which number you start with, you will always reach 1 eventually.

# Given a number n, return the number of steps required to reach 1.

# Examples
# Starting with n = 12, the steps would be as follows:

# 12
# 6
# 3
# 10
# 5
# 16
# 8
# 4
# 2
# 1
# Resulting in 9 steps. So for input n = 12, the return value would be 9.


defmodule CollatzConjecture do
  import Integer

  @spec calc(input :: pos_integer()) :: non_neg_integer()
  def calc(1), do: 0
  def calc(input) when input > 0 and is_even(input), do: 1 + calc(div(input, 2))
  def calc(input) when input > 0 and is_odd(input), do: 1 + calc(input * 3 + 1)
end



# Elixir / High Score

# Introduction
# Maps
# Maps in Elixir are the data structure for storing information in key-value pairs. In other languages, these might also be known as associative arrays (PHP), hashes (Perl 5, Raku), or dictionaries (Python).

# Keys and values can be of any data type, but if the key is an atom we can use a shorthand syntax. Maps do not guarantee the order of their entries when accessed or returned.

# Literal forms
# An empty map is simply declared with %{}. If we want to add items to a map literal, we can use two forms:

# # If the key is an atom:
# %{atom_key: 1}

# # If the key is a different type:
# %{1 => :atom_value}

# # You can even mix these if the atom form comes second:
# %{"first_form" => :a, atom_form: :b}
# While there is no canonical format, choose a consistent way to represent the key-value literal pairs.

# Map module functions
# Elixir provides many functions for working with maps in the Map module. Some Map module functions require an anonymous function to be passed into the function to assist with the map transformation.

# Module Attributes As Constants
# In Elixir, we can define module attributes which can be used as constants in our functions.

# defmodule Example do

#   # Defines the attribute as the value 1
#   @constant_number 1

#   def example_value() do
#     # Returns the value 1
#     @constant_number
#   end
# end
# When used to define module constants, attributes can be any expression which can be evaluated at compilation time. After compilation, module attributes are not accessible since they are expanded during compilation, similar to defined macros in languages like C.

# Instructions
# In this exercise, you're implementing a way to keep track of the high scores for the most popular game in your local arcade hall.

# Task 1
# Define a new high score map

# To make a new high score map, define the HighScore.new/0 function which doesn't take any arguments and returns a new, empty map of high scores.

# HighScore.new()
# # => %{}

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Add players to the high score map

# To add a player to the high score map, define HighScore.add_player/3, which is a function which takes 3 arguments:

# The first argument is the map of scores.
# The second argument is the name of a player as a string.
# The third argument is the score as an integer. The argument is optional, implement the third argument with a default value of 0.
# Store the default initial score in a module attribute. It will be needed again.

# score_map = HighScore.new()
# # => %{}
# score_map = HighScore.add_player(score_map, "Dave Thomas")
# # => %{"Dave Thomas" => 0}
# score_map = HighScore.add_player(score_map, "José Valim", 486_373)
# # => %{"Dave Thomas" => 0, "José Valim"=> 486_373}

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Remove players from the score map

# To remove a player from the high score map, define HighScore.remove_player/2, which takes 2 arguments:

# The first argument is the map of scores.
# The second argument is the name of the player as a string.
# score_map = HighScore.new()
# # => %{}
# score_map = HighScore.add_player(score_map, "Dave Thomas")
# # => %{"Dave Thomas" => 0}
# score_map = HighScore.remove_player(score_map, "Dave Thomas")
# # => %{}

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Reset a player's score

# To reset a player's score, define HighScore.reset_score/2, which takes 2 arguments:

# The first argument is the map of scores.
# The second argument is the name of the player as a string, whose score you wish to reset.
# The function should also work if the player doesn't have a score.

# score_map = HighScore.new()
# # => %{}
# score_map = HighScore.add_player(score_map, "José Valim", 486_373)
# # => %{"José Valim"=> 486_373}
# score_map = HighScore.reset_score(score_map, "José Valim")
# # => %{"José Valim"=> 0}

# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Update a player's score

# To update a player's score by adding to the previous score, define HighScore.update_score/3, which takes 3 arguments:

# The first argument is the map of scores.
# The second argument is the name of the player as a string, whose score you wish to update.
# The third argument is the score that you wish to add to the stored high score.
# The function should also work if the player doesn't have a previous score - assume the previous score is 0.

# score_map = HighScore.new()
# # => %{}
# score_map = HighScore.add_player(score_map, "José Valim", 486_373)
# # => %{"José Valim"=> 486_373}
# score_map = HighScore.update_score(score_map, "José Valim", 5)
# # => %{"José Valim"=> 486_378}

# Stuck? Reveal Hints
# Opens in a modal
# Task 6
# Get a list of players

# To get a list of players, define HighScore.get_players/1, which takes 1 argument:

# The first argument is the map of scores.
# score_map = HighScore.new()
# # => %{}
# score_map = HighScore.add_player(score_map, "Dave Thomas", 2_374)
# # => %{"Dave Thomas" => 2_374}
# score_map = HighScore.add_player(score_map, "José Valim", 486_373)
# # => %{"Dave Thomas" => 2_374, "José Valim"=> 486_373}
# HighScore.get_players(score_map)
# # => ["Dave Thomas", "José Valim"]


defmodule HighScore do
  @initial_score 0
  def new(), do: %{}
  def add_player(scores, name, score \\ @initial_score), do: scores |> Map.put(name, score)
  def remove_player(scores, name), do: scores |> Map.delete(name)
  def reset_score(scores, name), do: add_player(scores, name)
  def update_score(scores, name, score), do: scores |> Map.update(name, score, & &1 + score)
  def get_players(scores), do: scores |> Map.keys()
end



# Elixir / Knapsack

# Instructions
# In this exercise, let's try to solve a classic problem.

# Bob is a thief. After months of careful planning, he finally manages to crack the security systems of a high-class apartment.

# In front of him are many items, each with a value (v) and weight (w). Bob, of course, wants to maximize the total value he can get; he would gladly take all of the items if he could. However, to his horror, he realizes that the knapsack he carries with him can only hold so much weight (W).

# Given a knapsack with a specific carrying capacity (W), help Bob determine the maximum value he can get from the items in the house. Note that Bob can take only one of each item.

# All values given will be strictly positive. Items will be represented as a list of pairs, wi and vi, where the first element wi is the weight of the ith item and vi is the value for that item.

# For example:

# Items: [ { "weight": 5, "value": 10 }, { "weight": 4, "value": 40 }, { "weight": 6, "value": 30 }, { "weight": 4, "value": 50 } ]

# Knapsack Limit: 10

# For the above, the first item has weight 5 and value 10, the second item has weight 4 and value 40, and so on.

# In this example, Bob should take the second and fourth item to maximize his value, which, in this case, is 90. He cannot get more than 90 as his knapsack has a weight limit of 10.


defmodule Knapsack do
  def maximum_value([], _), do: 0
  def maximum_value([item | items], max_weight) when item.weight > max_weight, do: maximum_value(items, max_weight)
  def maximum_value([item | items], max_weight) do
    [
      maximum_value(items, max_weight),
      maximum_value(items, max_weight - item.weight) + item.value
    ]
    |> Enum.max()
  end
end



# Elixir / City Office

# Introduction
# Docs
# Documentation in Elixir is a first-class citizen.

# There are two module attributes commonly used to document your code - @moduledoc for documenting a module and @doc for documenting a function that follows the attribute. The @moduledoc attribute usually appears on the first line of the module, and the @doc attribute usually appears right before a function definition, or the function's typespec if it has one. The documentation is commonly written in a multiline string using the heredoc syntax.

# Elixir documentation is written in Markdown.

# defmodule String do
#   @moduledoc """
#   Strings in Elixir are UTF-8 encoded binaries.
#   """

#   @doc """
#   Converts all characters in the given string to uppercase according to `mode`.

#   ## Examples

#       iex> String.upcase("abcd")
#       "ABCD"

#       iex> String.upcase("olá")
#       "OLÁ"
#   """
#   def upcase(string, mode \\ :default)
# end
# Typespecs
# Elixir is a dynamically typed language, which means it doesn't provide compile-time type checks. Still, type specifications can be used as a form of documentation.

# A type specification can be added to a function using the @spec module attribute right before the function definition. @spec is followed by the function name and a list of all of its arguments' types, in parentheses, separated by commas. The type of the return value is separated from the function's arguments with a double colon ::.

# @spec longer_than?(String.t(), non_neg_integer()) :: boolean()
# def longer_than?(string, length), do: String.length(string) > length
# Types
# Most commonly used types include:

# booleans: boolean()
# strings: String.t()
# numbers: integer(), non_neg_integer(), pos_integer(), float()
# lists: list()
# a value of any type: any()
# Some types can also be parameterized, for example list(integer) is a list of integers.

# Literal values can also be used as types.

# A union of types can be written using the pipe |. For example, integer() | :error means either an integer or the atom literal :error.

# A full list of all types can be found in the "Typespecs" section in the official documentation.

# Naming arguments
# Arguments in the typespec could also be named which is useful for distinguishing multiple arguments of the same type. The argument name, followed by a double colon, goes before the argument's type.

# @spec to_hex({hue :: integer, saturation :: integer, lightness :: integer}) :: String.t()
# Custom types
# Typespecs aren't limited to just the built-in types. Custom types can be defined using the @type module attribute. A custom type definition starts with the type's name, followed by a double colon and then the type itself.

# @type color :: {hue :: integer, saturation :: integer, lightness :: integer}

# @spec to_hex(color()) :: String.t()
# A custom type can be used from the same module where it's defined, or from another module.

# Instructions
# You have been working in the city office for a while, and you have developed a set of tools that speed up your day-to-day work, for example with filling out forms.

# Now, a new colleague is joining you, and you realized your tools might not be self-explanatory. There are a lot of weird conventions in your office, like always filling out forms with uppercase letters and avoiding leaving fields empty.

# You decide to write some documentation so that it's easier for your new colleague to hop right in and start using your tools.

# Task 1
# Document the purpose of the form tools

# Add documentation to the Form module that describes its purpose. It should read:

# A collection of loosely related functions helpful for filling out various forms at the city office.

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Document filling out fields with blank values

# Add documentation and a typespec to the Form.blanks/1 function. The documentation should read:

# Generates a string of a given length.

# This string can be used to fill out a form field that is supposed to have no value.
# Such fields cannot be left empty because a malicious third party could fill them out with false data.
# The typespec should explain that the function accepts a single argument, a non-negative integer, and returns a string.


# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Document splitting values into lists of uppercase letters

# Add documentation and a typespec to the Form.letters/1 function. The documentation should read:

# Splits the string into a list of uppercase letters.

# This is needed for form fields that don't offer a single input for the whole string,
# but instead require splitting the string into a predefined number of single-letter inputs.
# The typespec should explain that the function accepts a single argument, a string, and returns a list of strings.


# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Document checking if a value fits a field with a max length

# Add documentation and a typespec to the Form.check_length/2 function. The documentation should read:

# Checks if the value has no more than the maximum allowed number of letters.

# This is needed to check that the values of fields do not exceed the maximum allowed length.
# It also tells you by how much the value exceeds the maximum.
# The typespec should explain that the function accepts two arguments, a string and a non-negative integer, and returns one of two possible values. It returns either the :ok atom or a 2-tuple with the first element being the :error atom, and the second a positive integer.


# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Document different address formats

# For some unknown to you reason, the city office's internal system uses two different ways of representing addresses - either as a map or as a tuple.

# Document this fact by defining three custom public types:

# address_map - a map with the keys :street, :postal_code, and :city. Each key holds a value of type string.
# address_tuple - a tuple with three values - street, postal_code, and city. Each value is of type string. Differentiate the values by giving them names in the typespec.
# address - can be either an address_map or an address_tuple.

# Stuck? Reveal Hints
# Opens in a modal
# Task 6
# Document formatting the address

# Add documentation and a typespec to the Form.format_address/1 function. The documentation should read:

# Formats the address as an uppercase multiline string.
# The typespec should explain that the function accepts one argument, an address, and returns a string.


defmodule Form do
  @moduledoc """
  A collection of loosely related functions helpful for filling out various forms at the city office.
  """

  @type address_map :: %{street: String.t(), postal_code: String.t(), city: String.t()}
  @type address_tuple :: {street :: String.t(), postal_code :: String.t(), city :: String.t()}
  @type address :: address_map | address_tuple

  @doc """
  Generates a string of a given length.

  This string can be used to fill out a form field that is supposed to have no value.
  Such fields cannot be left empty because a malicious third party could fill them out with false data.
  """
  @spec blanks(non_neg_integer()) :: String.t()
  def blanks(n), do: String.duplicate("X", n)

  @doc """
  Splits the string into a list of uppercase letters.

  This is needed for form fields that don't offer a single input for the whole string,
  but instead require splitting the string into a predefined number of single-letter inputs.
  """
  @spec letters(String.t()) :: [String.t()]
  def letters(word), do: word |> String.upcase() |> String.split("", trim: true)

  @doc """
  Checks if the value has no more than the maximum allowed number of letters.

  This is needed to check that the values of fields do not exceed the maximum allowed length.
  It also tells you by how much the value exceeds the maximum.
  """
  @spec check_length(String.t(), non_neg_integer()) :: :ok | {:error, pos_integer()}
  def check_length(word, length) do
    diff = String.length(word) - length

    if diff <= 0 do
      :ok
    else
      {:error, diff}
    end
  end

  @doc """
  Formats the address as an uppercase multiline string.
  """
  @spec format_address(address()) :: String.t()
  def format_address(%{street: street, postal_code: postal_code, city: city}) do
    format_address({street, postal_code, city})
  end

  def format_address({street, postal_code, city}) do
    """
    #{String.upcase(street)}
    #{String.upcase(postal_code)} #{String.upcase(city)}
    """
  end
end



# Elixir / German Sysadmin

# Introduction
# Charlists
# Charlists are created using single quotes.

# 'hello'
# Although they look similar to strings, the two data types are quite different from one another. A charlist is a list of integers. The integers represent the Unicode values of a given character — also known as code points.

# [65, 66, 67]
# # => 'ABC'
# You can prepend a character with ? to get its code point.

# ?A
# # => 65

# [?:, ?)]
# # => ':)'
# Because charlist are lists, you can work with them just like with any other list - using recursion and pattern matching.

# [first_letter | _] = 'cat'
# first_letter
# # => 99
# You can concatenate two lists using ++.

# 'hi' ++ '!'
# # => 'hi!'
# The longer the first list is, the slower the concatenation, so avoid repeatedly appending to lists of arbitrary length.

# Case
# case is a control flow structure that allows us to compare a given value against many patterns. Clauses in a case expression are evaluated from top to bottom, until a match is found.

# age = 15

# case age do
#   0 -> 'infant'
#   age when age < 4 -> 'baby'
#   age when age < 13 -> 'child'
#   age when age < 18 -> 'teenager'
#   _ -> 'adult'
# end

# # => 'teenager'
# Instructions
# You are working as a system administrator for a big company in Munich, Germany. One of your responsibilities is managing email accounts.

# You have been hearing complaints from people saying they are unable to write emails to Mr. Müller. You quickly realize that most of the company uses an old email client that doesn't recognize müller@firma.de as a valid email address because of the non-Latin character.

# Telling people to give up their favorite old email client is a lost battle, so you decide to create sanitized aliases for all email accounts.

# Task 1
# Sanitize existing usernames by removing everything but lowercase letters

# Implement the sanitize/1 function. It should accept a username as a charlist and return the username with all characters but lowercase letters removed.

# Username.sanitize('schmidt1985')
# # => 'schmidt'

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Allow underscores

# Extend the sanitize/1 function. It should not remove underscores from the username.

# Username.sanitize('mark_fischer$$$')
# # => 'mark_fischer'

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Substitute German characters

# There are 4 non-Latin characters in the German alphabet, and all of them have commonly-recognized Latin substitutes.

# German character	Latin substitute
# ä	ae
# ö	oe
# ü	ue
# ß	ss
# Extend the sanitize/1 function. It should substitute German characters according to the table. You can safely assume all usernames are already downcase.

# Username.sanitize('cäcilie_weiß')
# # => 'caecilie_weiss'


defmodule Username do
  def sanitize([]), do: []
  def sanitize([?ä | t]), do: 'ae' ++ sanitize(t)
  def sanitize([?ö | t]), do: 'oe' ++ sanitize(t)
  def sanitize([?ü | t]), do: 'ue' ++ sanitize(t)
  def sanitize([?ß | t]), do: 'ss' ++ sanitize(t)
  def sanitize([h | t]) when h in ?a..?z or h == ?_, do: [h | sanitize(t)]
  def sanitize([h | t]), do: sanitize(t)
end



# Elixir / RPG Character Sheet

# Introduction
# IO
# Functions for handling input and output are provided by the IO module.

# Output
# To write a string to the standard output, use IO.puts. IO.puts always adds a new line at the end of the string. If you don't want that behavior, use IO.write instead. Both functions return the atom :ok if they succeed.

# IO.puts("Hi!")
# # > Hi!
# # => :ok
# IO.puts is useful for writing strings, but not much else. If you need a tool for debugging that will allow you to write any value to standard output, use IO.inspect instead. IO.inspect returns the value it was passed unchanged, so it can be inserted in any point in your code. It also accepts many options, for example :label, that will allow you to distinguish it from other IO.inspect calls.

# Input
# To read a line from the standard input, use IO.gets. IO.gets accepts one argument - a string that it will print as a prompt for the input. IO.gets doesn't add a new line after the prompt, include it yourself if you need it.

# IO.gets("What's your name?\n")
# # > What's your name?
# # < Mary
# # => "Mary\n"
# Instructions
# You and your friends love to play pen-and-paper role-playing games, but you noticed that it's difficult to get new people to join your group. They often struggle with character creation. They don't know where to start. To help new players out, you decided to write a small program that will guide them through the process.

# Task 1
# Welcome the new player

# Implement the RPG.CharacterSheet.welcome/0 function. It should print a welcome message, and return :ok.

# RPG.CharacterSheet.welcome()
# # > Welcome! Let's fill out your character sheet together.
# # => :ok

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Ask for the character's name

# Implement the RPG.CharacterSheet.ask_name/0 function. It should print a question, wait for an answer, and return the answer without leading and trailing whitespace.

# RPG.CharacterSheet.ask_name()
# # > What is your character's name?
# # < Mathilde
# # => "Mathilde"

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Ask for the character's class

# Implement the RPG.CharacterSheet.ask_class/0 function. It should print a question, wait for an answer, and return the answer without leading and trailing whitespace.

# RPG.CharacterSheet.ask_class()
# # > What is your character's class?
# # < healer
# # => "healer"

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Ask for the character's level

# Implement the RPG.CharacterSheet.ask_level/0 function. It should print a question, wait for an answer, and return the answer as an integer.

# RPG.CharacterSheet.ask_level()
# # > What is your character's level?
# # < 2
# # => 2

# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Combine previous steps into one

# Implement the RPG.CharacterSheet.run/0 function. It should welcome the new player, ask for the character's name, class, and level, and return the character sheet as a map. It should also print the map with the label "Your character".

# RPG.CharacterSheet.run()
# # > Welcome! Let's fill out your character sheet together.
# # > What is your character's name?
# # < Mathilde
# # > What is your character's class?
# # < healer
# # > What is your character's level?
# # < 2
# # > Your character: %{class: "healer", level: 2, name: "Mathilde"}
# # => %{class: "healer", level: 2, name: "Mathilde"}


defmodule RPG.CharacterSheet do
  def welcome(), do: IO.puts("Welcome! Let's fill out your character sheet together.")
  def ask_name(), do: IO.gets("What is your character's name?\n") |> String.trim()
  def ask_class(), do: IO.gets("What is your character's class?\n") |> String.trim()
  def ask_level(), do: IO.gets("What is your character's level?\n") |> String.trim() |> String.to_integer()
  def run() do
    welcome()
    name = ask_name()
    class = ask_class()
    level = ask_level()

    %{name: name, class: class, level: level}
    |> IO.inspect(label: "Your character")
  end
end



# Elixir / Name Badge

# Introduction
# Nil
# Nil is an English word meaning "nothing" or "zero". In Elixir, nil is a special value that means an absence of a value.

# # I do not have a favorite color
# favorite_color = nil
# In other programming languages, null or none values might play a similar role.

# If
# Besides cond, Elixir also provides the macro if/2 which is useful when you need to check for only one condition.

# if/2 accepts a condition and two options. It returns the first option if the condition is truthy, and the second option if the condition is falsy.

# age = 15

# if age >= 16 do
#   "You are allowed to drink beer in Germany."
# else
#   "No beer for you!"
# end

# # => "No beer for you!"
# It is also possible to write an if expression on a single line. Note the comma after the condition.

# if age > 16, do: "beer", else: "no beer"
# This syntax is helpful for very short expressions, but should be avoided if the expression won't fit on a single line.

# Truthy and falsy
# In Elixir, all datatypes evaluate to a truthy or falsy value when they are encountered in a boolean context (like an if expression). All data is considered truthy except for false and nil. In particular, empty strings, the integer 0, and empty lists are all considered truthy in Elixir.

# Instructions
# In this exercise you'll be writing code to print name badges for factory employees. Employees have an ID, name, and department name. Employee badge labels are formatted as follows: "[id] - name - DEPARTMENT".

# Task 1
# Print a badge for an employee

# Implement the NameBadge.print/3 function. It should take an id, name, and a department. It should return the badge label, with the department name in uppercase.

# NameBadge.print(67, "Katherine Williams", "Strategic Communication")
# # => "[67] - Katherine Williams - STRATEGIC COMMUNICATION"

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Print a badge for a new employee

# Due to a quirk in the computer system, new employees occasionally don't yet have an ID when they start working at the factory. As badges are required, they will receive a temporary badge without the ID prefix.

# Extend the NameBadge.print/3 function. When the id is missing, it should print a badge without it.

# NameBadge.print(nil, "Robert Johnson", "Procurement")
# # => "Robert Johnson - PROCUREMENT"

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Print a badge for the owner

# Even the factory's owner has to wear a badge at all times. However, an owner does not have a department. In this case, the label should print "OWNER" instead of the department name.

# Extend the NameBadge.print/3 function. When the department is missing, assume the badge belongs to the company owner.

# NameBadge.print(204, "Rachel Miller", nil)
# # => "[204] - Rachel Miller - OWNER"
# Note that it is possible for the owner to also be a new employee.

# NameBadge.print(nil, "Rachel Miller", nil)
# # => "Rachel Miller - OWNER"


defmodule NameBadge do
  def print(id, name, nil), do: print(id, name, "Owner")
  def print(nil, name, department), do: "#{name} - #{department |> String.upcase()}"
  def print(id, name, department), do: "[#{id}] - #{print(nil, name, department)}"
end



# Elixir / Take-A-Number

# Introduction
# Processes
# In Elixir, all code runs inside processes.

# By default, a function will execute in the same process from which it was called. When you need to explicitly run a certain function in a new process, use spawn/1:

# spawn(fn -> 2 + 2 end)
# # => #PID<0.125.0>
# spawn/1 creates a new process that executes the given function and returns a process identifier (PID). The new process will stay alive as long as the function executes, and then silently exit.

# Elixir's processes should not be confused with operating system processes. Elixir's processes use much less memory and CPU. It's perfectly fine to have Elixir applications that run hundreds of Elixir processes.

# Messages
# Processes do not directly share information with one another. Processes send and receive messages to share data.

# You can send a message to any process with send/2. The first argument to send/2 is the PID of the recipient, the second argument is the message.

# A message can be of any type. Often it consists of atoms and tuples. If you want to get a response, you should include the PID of the sender somewhere in the message. You can get the PID of the current process with self().

# send/2 does not check if the message was received by the recipient, nor if the recipient is still alive. The message ends up in the recipient's mailbox and it will only be read if and when the recipient explicitly asks to receive messages.

# A message can be read from a mailbox using the receive/1 macro. It accepts a do block that can pattern match on the messages.

# receive do
#   {:ping, sender_pid} -> send(sender_pid, :pong)
#   :do_nothing -> nil
# end
# receive/1 will take one message from the mailbox that matches any of the given patterns and execute the expression given for that pattern. If there are no messages in the mailbox, or none of messages in the mailbox match any of the patterns, receive/1 is going to wait for one.

# Receive loop
# If you want to receive more than one message, you need to call receive/1 recursively. It is a common pattern to implement a recursive function, for example named loop, that calls receive/1, does something with the message, and then calls itself to wait for more messages. If you need to carry some state from one receive/1 call to another, you can do it by passing an argument to that loop function.

# PIDs
# Process identifiers are their own data type. They function as mailbox addresses - if you have a process's PID, you can send a message to that process. PIDs are usually created indirectly, as a return value of functions that create new processes, like spawn.

# Instructions
# You are writing an embedded system for a Take-A-Number machine. It is a very simple model. It can give out consecutive numbers and report what was the last number given out.

# Task 1
# Start the machine

# Implement the start/0 function. It should spawn a new process that has an initial state of 0 and is ready to receive messages. It should return the process's PID.

# TakeANumber.start()
# # => #PID<0.138.0>
# Note that each time you run this code, the PID may be different.


# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Report the machine state

# Modify the machine so that it can receive {:report_state, sender_pid} messages. It should send its current state (the last given out ticket number) to sender_pid and then wait for more messages.

# machine_pid = TakeANumber.start()
# send(machine_pid, {:report_state, self()})

# receive do
#   msg -> msg
# end
# # => 0

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Give out numbers

# Modify the machine so that it can receive {:take_a_number, sender_pid} messages. It should increase its state by 1, send the new state to sender_pid, and then wait for more messages.

# machine_pid = TakeANumber.start()
# send(machine_pid, {:take_a_number, self()})

# receive do
#   msg -> msg
# end
# # => 1

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Stop the machine

# Modify the machine so that it can receive a :stop message. It should stop waiting for more messages.


# Stuck? Reveal Hints
# Opens in a modal
# Task 5
# Ignore unexpected messages

# Modify the machine so that when it receives an unexpected message, it ignores it and continues waiting for more messages.


defmodule TakeANumber do
  def start(), do: spawn(&loop/0)

  defp loop(state \\ 0) do
    receive do
      {:report_state, sender_pid} -> send(sender_pid, state) |> loop()
      {:take_a_number, sender_pid} -> send(sender_pid, state + 1) |> loop()
      :stop -> nil
      _ -> loop(state)
    end
  end
end



# Elixir / Wine Cellar

# Introduction
# Keyword Lists
# Keyword lists are a key-value data structure.

# [month: "April", year: 2018]
# Keyword lists are lists of {key, value} tuples, and can also be written as such, but the shorter syntax is more widely used.

# [month: "April"] == [{:month, "April"}]
# # => true
# Keys in a keyword list must be atoms, but the values can be anything. Each key can be used more than once. The key-value pairs in a keyword list are ordered.

# You can work with keyword lists using the same approaches as for lists, or you can use the Keyword module.

# Instructions
# You are the manager of a fancy restaurant that has a sizable wine cellar. A lot of your customers are demanding wine enthusiasts. Finding the right bottle of wine for a particular customer is not an easy task.

# As a tech-savvy restaurant owner, you decided to speed up the wine selection process by writing an app that will let guests filter your wines by their preferences.

# Task 1
# Explain wine colors

# On the welcome screen of your app, you want to display a short explanation of each wine color.

# Implement the WineCellar.explain_colors/0 function. It takes no arguments and returns a keyword list with wine colors as keys and explanations as values.

# Color	Explanation
# :white	Fermented without skin contact.
# :red	Fermented with skin contact using dark-colored grapes.
# :rose	Fermented with some skin contact, but not enough to qualify as a red wine.

# Stuck? Reveal Hints
# Opens in a modal
# Task 2
# Get all wines of a given color

# A bottle of wine is represented as a 3-tuple of grape variety, year, and country of origin. The wines are stored by wine color in a keyword list.

# [
#   white: {"Chardonnay", 2015, "Italy"},
#   white: {"Pinot grigio", 2017, "Germany"},
#   red: {"Pinot noir", 2016, "France"},
#   rose: {"Dornfelder", 2018, "Germany"}
# ]
# Implement the WineCellar.filter/3 function. It should take a keyword list of wines, a color atom and a keyword list of options, with a default value of []. The function should return a list of wines of a given color.

# WineCellar.filter(
#   [
#     white: {"Chardonnay", 2015, "Italy"},
#     white: {"Pinot grigio", 2017, "Germany"},
#     red: {"Pinot noir", 2016, "France"},
#     rose: {"Dornfelder", 2018, "Germany"}
#   ],
#   :white
# )
# # => [
# #      {"Chardonnay", 2015, "Italy"},
# #      {"Pinot grigio", 2017, "Germany"}
# #    ]

# Stuck? Reveal Hints
# Opens in a modal
# Task 3
# Get all wines of a given color bottled in a given year

# Extend the WineCellar.filter/3 function. When given a :year option, the function should return a list of wines of a given color from a given year.

# Use the already-implemented WineCellar.filter_by_year/2 function. It takes a list of wines and a year as arguments and returns a list of wines from a given year.

# WineCellar.filter(
#   [
#     white: {"Chardonnay", 2015, "Italy"},
#     white: {"Pinot grigio", 2017, "Germany"},
#     red: {"Pinot noir", 2016, "France"},
#     rose: {"Dornfelder", 2018, "Germany"}
#   ],
#   :white,
#   year: 2015
# )
# # => [
# #      {"Chardonnay", 2015, "Italy"}
# #    ]

# Stuck? Reveal Hints
# Opens in a modal
# Task 4
# Get all wines of a given color bottled in a given country

# Extend the WineCellar.filter/3 function. When given a :country option, the function should return a list of wines of a given color from a given country.

# Use the already-implemented WineCellar.filter_by_country/2 function. It takes a list of wines and a country as arguments and returns a list of wines from a given country.

# Make sure that the function works when given both the :year and the :country option, in any order.

# WineCellar.filter(
#   [
#     white: {"Chardonnay", 2015, "Italy"},
#     white: {"Pinot grigio", 2017, "Germany"},
#     red: {"Pinot noir", 2016, "France"},
#     rose: {"Dornfelder", 2018, "Germany"}
#   ],
#   :white,
#   year: 2015,
#   country: "Germany"
# )
# # => []


defmodule WineCellar do
  def explain_colors, do:
    [
      white: "Fermented without skin contact.",
      red: "Fermented with skin contact using dark-colored grapes.",
      rose: "Fermented with some skin contact, but not enough to qualify as a red wine."
    ]

  def filter(cellar, color, opts \\ []) do
    Keyword.get_values(cellar, color)
    |> filter_by_year(opts[:year])
    |> filter_by_country(opts[:country])
  end

  defp filter_by_year(wines, nil), do: wines
  defp filter_by_year([], _year), do: []
  defp filter_by_year([{_, year, _} = wine | tail], year), do: [wine | filter_by_year(tail, year)]
  defp filter_by_year([{_, _, _} | tail], year), do: filter_by_year(tail, year)
  defp filter_by_country(wines, nil), do: wines
  defp filter_by_country([], _country), do: []
  defp filter_by_country([{_, _, country} = wine | tail], country), do: [wine | filter_by_country(tail, country)]
  defp filter_by_country([{_, _, _} | tail], country), do: filter_by_country(tail, country)
end
