# CLI RPN Calculator - Mickey Santomartino

## Description
This repository contains an implementation of a command line Reverse Polish Notation Calculator. Users can input their equations line by line, in a single line, or a mixture of both to solve equations using the 4 basic arithmetic operations. 
A Unit Testing file for the program is also included.

### Line by line:
> 5 <br />
> 5 <br />
> '+' <br />
= 10 

### Single line:
> 5 5 + <br />
10

### Both:
> 5 5 <br />
> '+' <br />
10

## Design Choices
I built the progam to be 3 seperate classes:

### CliRpnCalculator
- Controls the UI
- Gathers user input
- Outputs the results of calculations

Constants for each command like quit or clear are defined at the top to make the code more easily readable and editable in the future.

### RpnOperations
- takes in 2 values and an operator symbol
- if the operator is valid it returns the result of performing the operation on the 2 values

The code was designed so that operations could be added and removed easily in future iterations. Constants for each operator symbol are defined at the top to make the code more easily readable. If a new operation needs to be added it can
easily be done so by adding a new constant with its corresponding operation symbol to the top and adding a new case to the switch statement in PerformOperation to return the calculated value.

### RpnInputManager
- Maintains and stores user input
- Processes the input by type; if it is a number it is stored on a stack, if its another character it marks it as an operator and calls method from RpnOperations to perform the calculation if possible

In the ProcessInput function I chose to split the user input string into an array by blank spaces " ". This way the code works regardless of if the input has multiple values in a single line or just one, it will process it the same.
I chose to use a Stack to store the number values within the user input so they can easily be popped off and operated on in the correct order they were entered by the user. Whenever a potential operator symbol is found it will 
immediately call CalculateResult so all the operator symbols don't have to be stored in another object and it handles each equation one by one.

-----

I designed these three classes to be modular so if you make changes to one of them, like adding in a new operation or using a different interface that isn't the current command line approach, the other classes would still work.
I chose to add compatibility with both combined single and multi line input (example above) beacuse I believe it intuitively makes sense for the user. If you can either write the calculation in multiple lines or a single line 
you should be able to also combine the two. Designing it this way also removes the need to check for a lot of other potential unwanted input cases if the user did decided to enter their input mixed.

## Trade-Offs / other considerations

My code also works for input where the values and operator symbols are mixed in a single line:

> 5 5 + 5

I at first had the output produce something like this where the result of 5 5 + and 5 are both displayed and are printed as:
> 10 5

But considering the example input/output given in the ruberic does not account for this and all output on the ruberic was a single value, I decided that in this case I would also only print a single value to the screen, 
which is the next value in the stack that could be popped. I did this purely to keep the format of the output consistent in the program and inline with the ruberic. So my input/output in this case looks like this:

> 5 5 + 5 <br />
5

The resulting 10 computed from 5 5 + is still pushed on the stack but the leftover "5" is the only one displayed so that if the user wants to add anymore numbers to the equation they can easily see what the last value is.








