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
                

                if (metricBMI < 18.5)
                {
                    Console.WriteLine("Your BMI is " + metricBMI);
                    Console.WriteLine("You are undeweight");
                }

                else if (metricBMI == 18.5 && metricBMI <= 24.9)
                {
                    Console.WriteLine("Your BMI is " + metricBMI);
                    Console.WriteLine("You are Normal");
                }

                else if (metricBMI == 25.0 && metricBMI <= 29.9)
                {
                    Console.WriteLine("Your BMI is " + metricBMI);
                    Console.WriteLine("You are overweight");
                }

                else if (metricBMI == 30.0 && metricBMI <= 34.9)
                { 
                    Console.WriteLine("Your BMI is " + metricBMI);
                    Console.WriteLine("You are obese Class 1");
                }

                else if (metricBMI == 35.0 && metricBMI <= 39.9)
                {
                    Console.WriteLine("Your BMI is " + metricBMI);
                    Console.WriteLine("You are Obese Class 2");
                }

                else if (metricBMI >= 40.0)
                {
                    Console.WriteLine("Your BMI is " + metricBMI);
                    Console.WriteLine("You are Obese Class 3");
                }

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

                if (imperialBMI < 18.5)
                {
                    Console.WriteLine("Your BMI is " + imperialBMI);
                    Console.WriteLine("You are undeweight");
                }

                else if (imperialBMI == 18.5 && imperialBMI <= 24.9)
                {
                    Console.WriteLine("Your BMI is " + imperialBMI);
                    Console.WriteLine("You are Normal");
                }

                else if (imperialBMI == 25.0 && imperialBMI <= 29.9)
                {
                    Console.WriteLine("Your BMI is " + imperialBMI);
                    Console.WriteLine("You are overweight");
                }

                else if (imperialBMI == 30.0 && imperialBMI <= 34.9)
                {
                    Console.WriteLine("Your BMI is " + imperialBMI);
                    Console.WriteLine("You are obese Class 1");
                }

                else if (imperialBMI == 35.0 && imperialBMI <= 39.9)
                {
                    Console.WriteLine("Your BMI is " + imperialBMI);
                    Console.WriteLine("You are Obese Class 2");
                }

                else if (imperialBMI >= 40.0)
                {
                    Console.WriteLine("Your BMI is " + imperialBMI);
                    Console.WriteLine("You are Obese Class 3");
                }


                else
                {
                    Console.WriteLine("\n Please select either 1 or 2 ");
                }
            }
        }

        private void ImperialFormula()
         {
            weightInPounds = weightInStones * 14;
            weightImperial = weightInPounds;

            heightInFeet = heightInFeet / 12;
            heightImperial = heightInFeet;

            imperialBMI= ((weightImperial *703) / (heightImperial * heightImperial));
        }

        private void MetricFormula()
        {
            metricBMI =  weightInKg/(heightInMetres*heightInMetres);
        }

        private void ethnicMessage()
        {
            Console.WriteLine("If you are Black, Asian or minority \n ethnic groups, you have a risk");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("Adults 27.5 or more at high risk");
        }

    }
}
    

