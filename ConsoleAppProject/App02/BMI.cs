using System;
namespace ConsoleAppProject.App02
{
    /// This app is a bmi calculator which calculates your 
    /// Body Mass Index by looking at your height and weight.
    /// <AbdulSalam>
    /// Abdul Salam version 0.1
    public class BMI
    {
        /// <summary>
        /// These are my global variables of my class.
        /// </summary>
        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;
        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE = 34.9;
        public const double OBESE2 = 39.9;
        public const double OBESE3 = 40.0;
        double weightImperial { get; set; }
        double heightImperial { get; set; }
        string unitChoice { get; set; }
        double heightInFeet { get; set; }
        double heightInInches { get; set; }
        double heightInMetres { get; set; }
        double weightInStones { get; set; }
        double weightInPounds { get; set; }
        double weightInKg { get; set; }
        double imperialBMI { get; set; }
        double metricBMI { get; set; }

        public UnitSystems UnitSystems 
        {
            get => default;
        }

        /// <summary>
        /// The Run method which i will call in the main class containing some of my class methods 
        /// </summary>
        public void Run()
        {
            OutputHeading();
            DisplayTypeOfUnit();
            PrintEthnicMessage();
        }

        /// <summary>
        /// A method to print out the Heading to the user
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("        Body Mass Index Calculator" + "\n             by Abdul Salam\n");
            Console.WriteLine("-------------------------------------------------");
        }

        /// <summary>
        /// The display unit method which gives an option of metric or 
        /// imperial unit then depending on the response of the user it 
        /// either executes the metric (1) or imperial (2)
        /// </summary>
        private void DisplayTypeOfUnit()
        {
            Console.WriteLine("1. Metric Units\n2. Imperial Units\n Please enter your choice >");
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
                CalculateMetricFormula();
                DisplayBMI(metricBMI);
            }
            else if (unitChoice == "2")
            {
                Console.WriteLine("Enter your height in the nearest feet and inches \n ");
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

                CalculateImperialFormula();
                DisplayBMI(imperialBMI);
            }
            else
            {
                Console.WriteLine("Please select either 1 or 2 ");
            }
        }
       
        /// <summary>
        /// This method is a formula for imperial units. It calculates
        /// the imperial BMI of the user aswell.
        /// </summary>
        public void CalculateImperialFormula()
        {
            double Pounds = weightInStones * PoundsInStones;
            weightImperial = weightInPounds + Pounds;

            double inches = heightInFeet * InchesInFeet;
            heightImperial = heightInInches + inches;

            imperialBMI = (weightImperial * 703) / (heightImperial * heightImperial);
        }
       
        /// <summary>
        /// A method to calculate the BMI for the metric choice
        /// </summary>
        public void CalculateMetricFormula()
        {
            metricBMI = (weightInKg) / (heightInMetres * heightInMetres);
        }

        /// <summary>
        /// This is a method to calculate the users BAME Class 
        /// depending on the results they had gotten from their BMI
        /// </summary>
        /// <param name="BMI"></param>
        private void DisplayBMI(double BMI)
        {
            if (BMI < UNDERWEIGHT)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are undeweight");
            }
            else if (BMI <= NORMAL)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Normal" );
            }
            else if (BMI  <= OVERWEIGHT)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Overweight");
            }
            else if (BMI <= OBESE)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Obese Class 1");
            }
            else if (BMI <= OBESE2)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Obese Class 2");
            }
            else if (BMI >= OBESE3)
            {
                Console.WriteLine("\nYour BMI is " + BMI + "\n You are Obese Class 3");
            }
        }

        /// <summary>
        /// A simple display of a message to the user about Ethnicity
        /// playing a role in the BMI.
        /// </summary>
        private void PrintEthnicMessage()
        {
            Console.WriteLine("\nIf you are Black, Asian or minority ethnic groups, you have a risk");
            Console.WriteLine("Adults 23.0 or more are at increased risk \nAdults 27.5 or more at high risk");
        }
    }
}
    

