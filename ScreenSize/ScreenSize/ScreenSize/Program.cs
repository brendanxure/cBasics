// Author:  Kyle Chapman
// Created: September 10, 2024
// Modified: September 12, 2024
// Description:
// Based on a height and width entered into this console app,
// it will print the diagonal of a screen.

// Declarations.
// A decimal value representing the width of a screen.
double width = 0.0;
// Unsigned 32-bit integer.
uint height = 0u;
// A decimal value for the diagonal.
decimal diagonal;
// Boolean.
bool isValid = false;

// Input.
// Loop to get a valid width.
while (!isValid)
{
    // Prompt the user for the width.
    Console.Write("Please enter the width of the screen: ");
    // Get the input and check if its type is double.
    if (double.TryParse(Console.ReadLine(), out width))
    {
        // Check that the width is positive.
        if (width > 0)
        {
            // Type is valid, range is valid: it's valid. Exit the loop.
            isValid = true;
        }
        // Width is not positive; write an error message.
        else
        {
            Console.WriteLine("Width must be a positive number.");
        }
    }
    // Input was not a double; write an error message.
    else
    {
        Console.WriteLine("Width must be numeric.");
    }
}

// Reset isValid to false for the next loop.
isValid = false;

// Loop until we have a valid value for height.
while (!isValid)
{
    // Prompt the user for the height.
    Console.Write("Please enter the height of the screen: ");
    // Get the height and check if it's a valid uint.
    if (uint.TryParse(Console.ReadLine(), out height))
    {
        // Check whether height is positive.
        if (height > 0)
        {
            // The type is valid and the range is valid, so exit the loop.
            isValid = true;
        }
        // The height is out of range; report an error.
        else
        {
            Console.WriteLine("Height must be a positive number.");
        }
    }
    // The height was not the right data type; report an error.
    else
    {
        Console.WriteLine("Height must be a number between " + uint.MinValue + " and " + uint.MaxValue);
    }
}

// Processing.
// Use Pythagorean theorem: square root the height squared + width squared.
diagonal = (decimal)Math.Sqrt(width * width + height * height);
diagonal = Math.Round(diagonal, 1);

// Output.
Console.WriteLine("The diagonal of a screen with width of " + width + "\" and a height of " + height + "\" is " + diagonal + "\".");