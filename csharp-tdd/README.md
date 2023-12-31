# C# - Test Driven Development

## Learning Objectives

At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General

- What are solutions in VSCode
- How are solutions different from projects in VSCode
- What is a class library
- What is a unit test
- What are the benefits of unit testing
- How to create and run tests using NUnit
- What is the Arrange, Act, Assert methodology
- How to effectively name your unit tests
- How to utilize the TDD approach
- How to consider edge cases

## C# Tasks

### 0. They're good dogs

Write a method that adds 2 numbers

- Namespace: MyMath
- Class: Operations
- Prototype: public static int Add(int a, int b)
- Returns: sum of a and b
- Test Library Namespace: MyMath.Tests
- It is not necessary to account for integer overflow in this task

### 1. Divide a matrix

Write a method that divides all elements of a matrix.

- Namespace: MyMath
- Class: Matrix
- Prototype: public static int[,] Divide(int[,] matrix, int num)
- Returns: a new matrix containing divided elements
- If num is 0, print Num cannot be 0 and return null. (Hint: use try / catch)
- If matrix is null, return null

### 2. Max integer

Write a method that returns the max integer in a list of integers.

- Namespace: MyMath
- Class: Operations
- Prototype: public static int Max(List<int> nums)
- Returns: max integer in list
- If nums is empty, return 0

### 3. Desserts, I stressed!

Write a method that returns True if a string is a palindrome or False if it’s not.

- Namespace: Text
- Class: Str
- Prototype: public static bool IsPalindrome(string s)
- Returns: True if string is a palindrome, False if it’s not

- In this task, palindromes are not case sensitive
    - Racecar = True
    - level = True
- Spaces and punctuation should be ignored
    - A man, a plan, a canal: Panama. = True
- An empty string is considered a palindrome

### 4. Unique character

Write a method that returns the index of the first non-repeating character of a string.

- Namespace: Text
- Class: Str
- Prototype: public static int UniqueChar(string s)
- Returns: index of first non-repeating character or -1 if there is no non-repeating character
- You can assume the string contains only lowercase letters, no spaces or special characters

### 5. camelCase

Write a method that determines how many words are in a string. Each word begins with a capital letter except the first word.

- Namespace: Text
- Class: Str
- Prototype: public static int CamelCase(string s)
- Returns: number of words in s
