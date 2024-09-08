// Author:  Brendan Obilo
// Date:    September 6, 2024
// Description:
// A program to determine a BMI value for a person
// based on an entered mass in lbs and an entered
// height in inches.

// DECLARATIONS
float weight = 0;
double height = 0;
decimal bmi;
bool isValid = false;
const int UnitConversion = 703;
const int MinWeight = 25;
const int MinHeight = 24;
const int MaxHeight = 120;

// INPUT
while (!isValid)
{
    // Get a valid numeric value for weight.
    Console.Write("Please enter the weight in pounds: ");
    if (float.TryParse(Console.ReadLine(), out weight))
    {
        if (weight >= MinWeight)
        {
            Console.Write("Please enter the height in inches: ");
            if (double.TryParse(Console.ReadLine(), out height))
            {
                if (height >= MinHeight && height <= MaxHeight)
                {
                    // Everything's valid!
                    isValid = true;
                }
                else
                {
                    // Height is out of range.
                    Console.WriteLine("Height must be between " + MinHeight + " and " + MaxHeight);
                }
            }
            else
            {
                // Height can't be treated as a number.
                Console.WriteLine("Height must be a number.");
            }
        }
        else
        {
            // The weight was too low.
            Console.WriteLine("The weight must be greater than " + MinWeight.ToString());
        }
    }
    else
    {
        Console.WriteLine("The weight must be a number greater than " + MinWeight.ToString());
    }

}

// PROCESS
bmi = (decimal)((weight / (height * height)) * UnitConversion);
bmi = Math.Round(bmi, 2);


// OUTPUT
Console.WriteLine("The BMI for a person who weighs " + weight + "lbs and is " + height + "\" tall is " + bmi + ".");
