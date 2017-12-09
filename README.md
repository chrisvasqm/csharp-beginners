# C# Basics for Beginners's Exercises
Sample code for all the exercises from the [C# Basics for Beginners](https://www.udemy.com/csharp-tutorial-for-beginners/learn/v4/overview)
course made by [Mosh Hamedani](https://github.com/mosh-hamedani) on [Udemy](https://www.udemy.com/)

## Section 5 - Control Flow

In this section you will learn how to use **conditional statements** (_if-else_ & _switch-cases_) and **iteration statements** 
(_for_, _foreach_ & _while_).

### [ValidNumber.cs](https://goo.gl/g943yz)

Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid 
number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where 
values entered into input boxes need to be validated.)

### [MaxTwoNumbers.cs](https://goo.gl/qogfd7)

Write a program which takes two numbers from the console and displays the maximum of the two.

### [LandscapePortraitImage.cs](https://goo.gl/3EPrZX)

 Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

### [CarSpeedLimit.cs](https://goo.gl/TNQfRN)

Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and 
focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for 
the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. 
If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr 
above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points 
is above 12, the program should display License Suspended.

### [DivisibleByThree.cs](https://goo.gl/nWsmfY)

Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on 
the console.

### [SumAllEnteredNumbers.cs](https://goo.gl/APLPT9)

Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously 
entered numbers and display it on the console.

### [FindFactorial.cs](https://goo.gl/bTwHVN)

Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

### [GuessRandomNumber.cs](https://goo.gl/PxAZ7r)

Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user 
guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, 
you can display the secret number on the console first.)

### [FindMaxFromList.cs](https://goo.gl/cLa9nA)

Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and 
display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

## Section 6 - Arrays and Lists

This section is focused on how Arrays and Lists work, what are their similarities and differences, and use cases.

### [FriendsWhoLikeYourPost.cs](https://goo.gl/GRXQao)

When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying 
a name). Depending on the number of names provided, display a message based on the above pattern.

### [ReverseGivenName.cs](https://goo.gl/gfXqWt)

Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a 
new string. Display the reversed name on the console.
   
### SortFiveUniqueNumbers

Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message
and ask the user to re-try. Once the user succesfully enters 5 unique numbers, sort them and display the result on the
console.

- [x] ListSeparatedWithComa
- [x] DisplayUniqueNumbers

## Section 8 - Working with Text
- [x] ConsecutiveNumbers
- [x] FindDuplicate
- [x] ValidTimeRange
- [x] ConvertWordToPascalCase
- [x] CountVowels

## Section 9 - Working with Files
- [x] NumberOfWordsInFile
- [x] LongestWordInFile