using System;

namespace ConsoleAppProject.App01
{
    /// This app is a distance converter that converts miles into feet
    /// <AbdulSalam>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        private double miles;
        private double feet;
        private double metres;

        // This is a run method containing all the class methods
        // in a single method. I am calling my class methods in this 
        // method.
        public void Run()
        {
            InputMiles();
            CalculateMetres();
            OutputMetres();
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputHeading();
            OutputFeet();
            InputFeets();
            CalculateMiles();
            OutputMiles();
            OutputHeading();
            SelectInputUnit();
            CalculateDistance();
        }
        // The method to calculate miles into the metres.
       private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }
        
        // A print method to output the display of miles into metres.
        private void OutputMetres()
        {
            Console.WriteLine(miles + "is equiavalent to " + metres + "metres");
        }
        
        //My heading output for the user.
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("     Distance Converter       ");
            Console.WriteLine("       By Abdul Salam         ");
            Console.WriteLine("----------------------------\n");
        }


        // Prompt the user to enter the miles 
        // The miles will be in the double data type.
        private void InputMiles()
        {
            Console.WriteLine("Hi there enter the number of miles ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        // My input distance method for choosing which type
        // of unit to convert from.
        double inputDistance=0; 
        private void InputDistance()
        {
            Console.WriteLine("Enter distance ");
            string value = Console.ReadLine();
            inputDistance = Convert.ToDouble(value);
           
        }

        // A method asking for the input as feet and storing it inside
        // a string value. Then storing it in feet.
        private void InputFeets()
        {
            Console.WriteLine("Hi there enter the number of feet ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        // The method for calculating feet into miles
        private double CalculateMiles()
        {
            return miles = feet * 0.000189394;
        }

        // The method will calculate the feet
        // The miles will be in the double data type.
        private double CalculateFeet()
        {
            return feet = miles * 5280;
        }

        // Print out the output in feet.
        // The miles will be in the double data type.
        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + "feet");
        }

        // Print out the output in miles.
        // The miles will be in the double data type.
        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is  " + miles + "miles");
        }

        string choice1;
        // The input unit method determining which unit was selected then
        // displaying an output dependant on your selection.
        private void SelectInputUnit()
        {
            Console.WriteLine("Hi there please choose your desired unit to convert from");
            Console.WriteLine("1. Metres" + "\n2. Miles\n" + "3. Feet");
            choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                Console.WriteLine("You have chosen Metres ");
                SelectOutputUnit();
            }

            else if (choice1 == "2")
            {
                Console.WriteLine("You have chosen Miles");
                SelectOutputUnit();
            }

            else if (choice1 == "3")
            {
                Console.WriteLine("You have chosen Feet");
                SelectOutputUnit();
            }

            else
            {
                Console.WriteLine("Select 1 2 or 3");
            }

        }

        string choice2;
        // The output unit method determining which unit was selected then
        // displaying an output dependant on your selection.
        private void SelectOutputUnit()
        {
            Console.WriteLine("\nSelect a distance to convert into\n");
            Console.WriteLine("1. Metres" + "\n2. Miles\n" + "3. Feet");
            Console.WriteLine("Please enter your choice ");
            choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.WriteLine("You have chosen Metres ");
            }

            else if (choice2 == "2")
            {
                Console.WriteLine("You have chosen Miles");
            }

            else if (choice2 == "3")
            {
                Console.WriteLine("You have chosen Feet");
            }

            else
            {
                Console.WriteLine("Select 1 2 or 3");
            }
        }

        double outputDistance=0;

        // The method to calculate the distance of the users 
        // two selected units.
        private void CalculateDistance()
        {
            if (choice1=="1" && choice2 == "1")
            {
                Console.WriteLine("\nConverting metres into metres\n");
                InputDistance();
                outputDistance = inputDistance;
                Console.WriteLine(inputDistance + " metres = " + outputDistance + " metres");
            }

           else if (choice1=="1" && choice2 =="2")
            {
                Console.WriteLine("\nConverting metres into miles\n");
                InputDistance();
                outputDistance = inputDistance / METRES_IN_MILES;
                Console.WriteLine(inputDistance + " metres = " + outputDistance + " miles");
            }

            else if (choice1 == "1" && choice2 == "3")
            {
                Console.WriteLine("\nConverting metres into feet\n");
                InputDistance();
                outputDistance = inputDistance * FEET_IN_METRES ;
                Console.WriteLine(inputDistance + " metres = " + outputDistance + " feet");
            }

            else if (choice1 == "2" && choice2 == "1")
            {
                Console.WriteLine("\nConverting miles into metres\n");
                InputDistance();
                outputDistance = inputDistance * METRES_IN_MILES * 2;
                Console.WriteLine(inputDistance + " miles = " + outputDistance + " metres");
            }

            else if (choice1 == "2" && choice2 == "2")
            {
                Console.WriteLine("\nConverting miles into miles\n");
                InputDistance();
                outputDistance = inputDistance;
                Console.WriteLine(inputDistance + " miles = " + outputDistance + " miles");
            }

            else if (choice1 == "2" && choice2 == "3")
            {
                Console.WriteLine("\nConverting miles into feet\n");
                InputDistance();
                outputDistance = inputDistance * 5280;
                Console.WriteLine(inputDistance + " miles = " + outputDistance + " feet");
            }

            else if (choice1 == "3" && choice2 == "1")
            {
                Console.WriteLine("\nConverting feet into metres\n");
                InputDistance();
                outputDistance = inputDistance / FEET_IN_METRES;
                Console.WriteLine(inputDistance + " feet = " + outputDistance + " metres");
            }

            else if (choice1 == "3" && choice2 == "2")
            {
                Console.WriteLine("\nConverting feet into miles\n");
                InputDistance();
                outputDistance = inputDistance / 5280;
                Console.WriteLine(inputDistance + " feet = " + outputDistance + " miles");
            }

            else if (choice1 == "3" && choice2 == "3")
            {
                Console.WriteLine("\nConverting feet into feet\n");
                InputDistance();
                outputDistance = inputDistance;
                Console.WriteLine(inputDistance + " feet = " + outputDistance + " feet ");
            }
        }

    }  

    }

