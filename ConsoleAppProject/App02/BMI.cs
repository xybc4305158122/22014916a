using System;
namespace ConsoleAppProject.App02
{
    /// This app is a bmi calculator which calculates your 
    /// Body Mass Index by looking at your height and weight.
    /// <AbdulSalam>
    /// Abdul Salam version 0.1
    public class BMI
    {
        double weightImperial;
        double heightImperial;
        string unitChoice;
        double heightInFeet;
        double heightInInches;
        double heightInMetres;
        double weightInStones;
        double weightInPounds;
        double weightInKg;
        double imperialBMI;
        double metricBMI;


        public void Run()
        {
            OutputHeading();
            TypeOfUnit();
            ethnicMessage();
        }

        private void OutputHeading()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("        Body Mass Index Calculator" + "\n             by Abdul Salam\n");
            Console.WriteLine("-------------------------------------------------");
        }


        private void TypeOfUnit()
        {
            Console.WriteLine(" 1. Metric Units ");
            Console.WriteLine(" 2. Imperial Units ");
            Console.Write(" Please enter your choice >");
            unitChoice = Console.ReadLine();

            if (unitChoice == "1")
            {
                Console.WriteLine("Enter your height in the nearest height in metres ");
                Console.Write("Enter your height in metres> ");
                string height = Console.ReadLine();
                heightInMetres = Convert.ToDouble(height);
                Console.Write("Enter your weight in kg> ");
                string kg = Console.ReadLine();
                weightInKg = Convert.ToDouble(kg);
                Console.WriteLine();
                Console.WriteLine();
                MetricFormula();
                BMIConditions(metricBMI);
         }

            else if (unitChoice == "2")
            {
                Console.WriteLine("Enter your height in the nearest feet and inches \n \n ");
                Console.Write("Enter your height in feet> ");
                string height = Console.ReadLine();
                heightInFeet = Convert.ToDouble(height);


                Console.Write("Enter your height in inches> ");
                string inches = Console.ReadLine();
                heightInInches = Convert.ToDouble(inches);

                Console.WriteLine("\n Enter your weight to the nearest stones and pounds ");
                Console.Write("Enter your weight in stones> ");
                string stones = Console.ReadLine();
                weightInStones = Convert.ToDouble(stones);

                Console.Write("Enter your weight in pounds> ");
                string pounds = Console.ReadLine();
                weightInPounds = Convert.ToDouble(pounds);

                ImperialFormula();
                BMIConditions(imperialBMI);
            }
        }

        private void ImperialFormula()
        {
           double Pounds = weightInStones * 14;
            weightImperial = weightInPounds + Pounds;

            double inches = heightInFeet * 12;
            heightImperial = heightInInches+ inches;

            imperialBMI = (weightImperial * 703) / (heightImperial * heightImperial);
        }

        private void MetricFormula()
        {
            metricBMI = (weightInKg) / (heightInMetres * heightInMetres);
        }

        private void BMIConditions(double BMI)
        {
            if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI is " + BMI);
                Console.WriteLine("You are undeweight");
            }

            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("Your BMI is " + BMI);
                Console.WriteLine("You are Normal");
            }

            else if (BMI >= 25.0 && BMI <= 29.9)
            {
                Console.WriteLine("Your BMI is " + BMI);
                Console.WriteLine("You are overweight");
            }

            else if (BMI >= 30.0 && BMI <= 34.9)
            {
                Console.WriteLine("Your BMI is " + BMI);
                Console.WriteLine("You are obese Class 1");
            }

            else if (BMI >= 35.0 && BMI <= 39.9)
            {
                Console.WriteLine("Your BMI is " + BMI);
                Console.WriteLine("You are Obese Class 2");
            }

            else if (BMI >= 40.0)
            {
                Console.WriteLine("Your BMI is " + BMI);
                Console.WriteLine("You are Obese Class 3");
            }
        }

        private void ethnicMessage()
        {
            Console.WriteLine("If you are Black, Asian or minority \n ethnic groups, you have a risk");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("Adults 27.5 or more at high risk");
        }

    }
}
    

