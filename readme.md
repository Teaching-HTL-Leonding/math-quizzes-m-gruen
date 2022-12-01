# Math Quizzes

## Introduction

So far, we have done quite a few exercises with user input. Today, we want to focus on math-related exercises.

## Finding the Operator

Write a program that starts by asking the user for three numbers:

* The first two numbers are the operands.
* The third number is the result rounded to two fractional digits

Next, you have to print out which mathematical operator has been used to combine the operands to receive the result. Note that the operands might have been combined in any order (e.g. first number divided by second number, or second number divided by first number). If there is more than one operator that leads to the result (e.g. 2 + 2 = 4 and 2 * 2 = 4), print any one of them.

Here are some examples:

| First Number | Second Number | Result | Operator       |
| -----------: | ------------: | -----: | -------------- |
|           20 |            40 |     60 | Plus           |
|           17 |             5 |     85 | Multiply       |
|          100 |            15 |   6.67 | Divide         |
|            7 |            21 |      3 | Divide         |
|            2 |             2 |      4 | Plus, Multiply |

**Advanced Finding Operator**: Support Modulo and Exponentiation operators.

| First Number | Second Number | Result | Operator       |
| -----------: | ------------: | -----: | -------------- |
|         1024 |             3 |      1 | Modulo         |
|            8 |             2 |    256 | Exponentiation |
|            2 |             6 |      0 | Modulo         |
|           10 |             3 |   1000 | Exponentiation |

## FizzBuzz

Write a program that prints all numbers between 1 and 100 on the screen. However, any number divisible by three without a remainder is replaced by the word *Fizz* and any number divisible by five without a remainder by the word *Buzz*. Numbers divisible by both three and five without a remainder (i.e. divisible by 15) become *FizzBuzz*.

Example:

```txt
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 Fizz Buzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 Fizz Buzz 31 32 Fizz 34 Buzz Fizz ...
```

**Advanced FizzBuzz**: At the beginning of your program, ask the user for three integer numbers *n*, *a*, and *b*. Write a program that prints the numbers from 1 through *n*. But for multiples of *a* print *Fizz* instead of the number and for the multiples of *b* print *Buzz*. For numbers which are multiples of both *a* and *b* print *FizzBuzz*.

## *Hailstone* Sequence (aka *Collatz Conjecture*)

![xkcd](https://imgs.xkcd.com/comics/collatz_conjecture.png)

The *Hailstone* sequence of numbers can be generated from a starting positive integer *n* by the following rules:

* If *n* is *1*, the sequence ends.
* If *n* is *even*, then the next *n* of the sequence is *n / 2*
* If *n* is *odd*, then the next *n* of the sequence is *(3 \* n) + 1*

Here are some examples:

* The *Hailstone* sequence for starting value 10 is: *10 5 16 8 4 2 1*
* For 20 it is: *20 10 5 16 8 4 2 1*
* For 3 it is: *3 10 5 16 8 4 2 1*

Write a program that asks the user for a starting value. The starting value must be an integer > 0. Print the *Hailstone* sequence for the starting value on the screen.

**Advanced Hailstone Sequence, Part 1**: Don't print the sequence, but calculate the length of it. Print the length of the *Hailstone* sequence for the given starting value on the screen.

**Advanced Hailstone Sequence, Part 2**: At the beginning of the program, ask the user for *two* starting values. Calculate the length of the *Hailstone* sequence for both numbers. Tell the user the number whose *Hailstone* sequence is the longer one.

## Check if *Palindrome*

An integer is a *palindrome* if the reverse of that number is equal to the original number. Here is a list of example palindromes: *0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 101, 111, 121, 131, 141, 151, 161, 171, 181, 191, 202, 212, 222, 232, 242, 252, 262, 272, 282, 292, 303, 313, 323, 333, 343, 353, 363, 373, 383, 393, 404, 414, 424, 434, 444, 454, 464, 474, 484, 494, 505, 515*

Write a program that asks the user for a positive integer number. Print out if the number is a palindrome. Note that you are **not** allowed to turn the number into a string and do the check using this string. You are only allowed to use integer types for palindrome checking.

*Tip:* In order to do the check, you have to *reverse* the number. Start by thinking about how you could reverse a given number.

**Advanced Palindrome**: The largest palindrome made from the product of two 2-digit numbers is *9009* (*91 \* 99*). Write a program that finds the largest palindrome made from the product of two 3-digit numbers.
