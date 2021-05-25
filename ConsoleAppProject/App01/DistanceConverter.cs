using System;

namespace ConsoleAppProject.App01
{
    /// This app is a distance converter which is converts a selected distance of certain unit to the other.
    /// The units that the user can chose from are Feets, Metres and miles to do their conversions from one 
    /// to the other.
    /// <AbdulSalam>
    public class DistanceConverter
    {
        /// <summary>
        /// My global variables and constants for magic numbers.
        /// </summary>
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double OutputDistance { get; set; }
        public double InputDistance { get; set; }

        /// <summary>
        /// This is a run method containing some the class methods in a single method.
        /// I am calling my class methods in this method and adding some Console.WriteLine 
        /// code so the datais outputted for the user to see.
        /// Furthermore I have storedsome methods inside some variables.
        /// </summary>

        public void Run()
        {
            
            Console.WriteLine("Select distance to convert from > ");
            string input = InputChoices();
            FromUnit = SelectChoice(input);
            Console.WriteLine($"\nYou have selected {FromUnit}");

            Console.WriteLine("\nSelect distance to convert into > ");
            string input2 = InputChoices();
            ToUnit = SelectChoice(input2);
            Console.WriteLine($"\nYou have selected {ToUnit}");
            Console.WriteLine($"\nConverting {FromUnit} to {ToUnit}");
            Console.Write($"\nEnter distance in {FromUnit} > ");
            InputDistance = InputData();
            CalculateDistance(); 
        }

        /// <summary>
        /// This is method is taking in the data and storing it in a string variabe
        /// then it is converting the string variable to a double and returning it.
        /// </summary>
        /// <returns></returns>
        public double InputData()
        {
            string data = Console.ReadLine();
            return Convert.ToDouble(data);
        }

        /// <summary>
        /// This is the method is taking in the first choice of the user then 
        /// returning the choice.I have added an if statement so if there is 
        /// a wrong choice it should give a message to the user telling them.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string SelectChoice(string input)
        {
            if (input.Equals("1"))
            {
                return FEET;
            }
            else if (input.Equals("2"))
            {
                return METRES;
            }
            else if (input.Equals("3"))
            {
                return MILES;
            }
            Console.WriteLine("Invalid input. Select 1, 2 or 3");
            return null; 
        }

        // This method is printing out the choices the user can pick
        // storing the choice in a variable and then returning it.
        public string InputChoices()
        {
            Console.WriteLine($"\n1. {FEET}\n2. {METRES} \n3. {MILES} ");
            Console.Write("\nPlease enter your choice > ");
            string input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// The method to calculate the distance of the users  two selected units.
        /// </summary>

        public void CalculateDistance()
        {
            if (FromUnit == METRES && ToUnit == METRES)
            {
                OutputDistance = InputDistance;
            }
            else if (FromUnit == METRES && ToUnit == MILES)
            {
                OutputDistance = InputDistance / METRES_IN_MILES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                OutputDistance = InputDistance * FEET_IN_METRES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                OutputDistance = InputDistance * METRES_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == MILES)
            {
                OutputDistance = InputDistance;
            }
            else if (FromUnit == MILES && ToUnit == FEET)
            {
                OutputDistance = InputDistance * FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                OutputDistance = InputDistance / FEET_IN_METRES;
            }
            else if (FromUnit == FEET && ToUnit == MILES)
            {
                OutputDistance = InputDistance / FEET_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == FEET)
            {
                OutputDistance = InputDistance;
            }
            Console.WriteLine($"\n{InputDistance} {FromUnit} = {OutputDistance} {ToUnit}");
        }
    }  
}

