using System;
using Service;

namespace ConverterProgram
{
    class Program
    {
        //Hello and welcome to this wonderfull group with members such as Johan, Martin, Marco and Robert plus our little friend called Google
        //And this is our project "Theme music starts" DUM DUM DUM
        static void Main(string[] args)
        {
            ConverterService converter = new ConverterService();
            //Start point for the program.
            // Console.WriteLine("Start point for the program.");
            string UserInput;
            bool ProgramExit = false;

            do{
                Console.WriteLine("Hello and welcome to this unit conversion program!");
                Console.WriteLine("As of today we've got the following services available:");
                Console.WriteLine("1. Calculate Ampere");
                Console.WriteLine("2. Calculate Resistance");
                Console.WriteLine("3. Calculate Diameter From Area");
                Console.WriteLine("4. Calculate Radius From Area");
                Console.WriteLine("5. Calculate Travel Time");
                Console.WriteLine("6. Calculate Travel Distance");
                Console.WriteLine("7. Calculate Speed");
                Console.WriteLine("8. Calculate Voltage");
                Console.WriteLine("9. Convert Celcius To Fahrenheit ");
                Console.WriteLine("10. Convert Fahrenheit To Celsius");
                Console.WriteLine("11. Convert From Gallon To Liter");
                Console.WriteLine("12. Convert From Liter To Gallon");
                Console.WriteLine("13. Convert From Hours To Minutes");
                Console.WriteLine("14. Convert From Minutes To Hours");
                Console.WriteLine("15. Exit the program");
                Console.WriteLine("Input the number of the one you would like to access please:");
                UserInput = Console.ReadLine();

                switch (UserInput) {
                    case "1":
                    CalculateAmps(converter);
                    break;
                    
                    case "2":
                    CalculateResistance(converter);
                    break;
                    
                    case "3":
                    CalculateDiameterFromArea(converter);
                    break;
                    
                    case "4":
                    CalculateRadiusFromArea(converter);
                    break;
                    
                    case "5":
                    CalculateTravelTime(converter);
                    break;
                    
                    case "6":
                    CalculateTraveledDistance(converter);
                    break;
                    
                    case "7":
                    CalculateSpeed(converter);
                    break;
                    
                    case "8":
                    CalculateVoltage(converter);
                    break;
                    
                    case "9":
                    ConvertCelciusToFahrenheit(converter);
                    break;
                    
                    case "10":
                    ConvertFahrenheitToCelcius(converter);
                    break;
                    
                    case "11":
                    ConvertFromGallonToLiter(converter);
                    break;
                    
                    case "12":
                    ConvertFromLiterToGallon(converter); /*o/ \o*/
                    break;                  //  "\(I.I)/"
                    
                    case "13":
                    ConvertFromHoursToMinutes(converter);
                    break;
                    
                    case "14":
                    ConvertFromMinutesToHours(converter);
                    break;
                    
                    case "15":
                    ProgramExit = true;
                    break;

                    default:
                    Console.WriteLine("Okay...");
                    Console.WriteLine("So what you wrote wasn't one of the numbers, sending you back to the beginning of the program.");
                    break;
                }
            }while(!ProgramExit);
        }
        static void CalculateAmps(ConverterService converter)
        {   //Robert was here
            Console.WriteLine("Okay, so you wanna calculate the Ampere from the resistance and voltage.");
            Console.WriteLine("Please enter the voltage:");
            bool VoltageCheck = Single.TryParse(Console.ReadLine(), out float Voltage); //Converts the users string input to a float for voltage and creates a bool that is true if it can convert
            Console.WriteLine("Please enter the resistance:");
            bool ResistanceCheck = Single.TryParse(Console.ReadLine(), out float Resistance);   //Converts the users string input to a float for resistance and creates a bool that is true if it can convert
            if (VoltageCheck && ResistanceCheck) {  //Checks if the parse went through and proceeds to the converter if it has both inputs
                float Ampere = converter.CalculateAmps(Voltage, Resistance);
                Console.WriteLine("The Ampere is {0}", Ampere);
            }
            else {
                Console.WriteLine("Ooops, some invalid inputs there. Sending ya back to tha main menu...");
            }
        }

        static void CalculateResistance(ConverterService converter)
        {   //Robert was here
            Console.WriteLine("Okay, so you wanna calculate the Resistance from the Ampere and voltage.");
            Console.WriteLine("Please enter the voltage:");
            bool VoltageCheck = Single.TryParse(Console.ReadLine(), out float Voltage); //Converts the users string input to a float for voltage and creates a bool that is true if it can convert
            Console.WriteLine("Please enter the Ampere:");
            bool AmpereCheck = Single.TryParse(Console.ReadLine(), out float Ampere);   //Converts the users string input to a float for Ampere and creates a bool that is true if it can convert
            if (VoltageCheck && AmpereCheck) {  //Checks if the parse went through and proceeds to the converter if it has both inputs
                float Resistance = converter.CalculateResistance(Voltage, Ampere);
                Console.WriteLine("The Resistance is {0} Ohm", Resistance);
            }
            else {
                Console.WriteLine("Ooops, some invalid inputs there. Sending ya back to tha main menu...");
            }
        }

        static void CalculateDiameterFromArea(ConverterService converter)
        { //lil Mar
            Console.WriteLine("You chose to see what the diameter is of a selected area huh?");
            Console.WriteLine("Well, let's start of shall we? Please input an area number.");
            bool IsThisCorrect = Single.TryParse(Console.ReadLine(), out float area);
            if (IsThisCorrect == true)
            {
                float epicSvar= converter.CalculateDiameterFromArea(area);
                Console.WriteLine("The area {0}! The Diameter from that is {1}",area, epicSvar);
            }
            else {
                Console.WriteLine("ey foo don do dat D:");
            }
            
        }
        static void CalculateRadiusFromArea(ConverterService converter)
        { //lil Mar
            Console.WriteLine("You chose to see what the radius is of a selected area huh?");
            Console.WriteLine("Well, let's start of shall we? Please input an area number.");
            bool IsThisCorrect = Single.TryParse(Console.ReadLine(), out float area);
            if (IsThisCorrect == true) //Checking if the input user put in is valid otherwise the console says no
            {
                float epicSvar = converter.CalculateRadiusFromArea(area);
                Console.WriteLine("You chose the area: {0}! Well it has the radius: {1}",area,epicSvar);
            }
            else {
                Console.WriteLine("ey foo don do dat D:");
            }
        }
        static void CalculateTravelTime(ConverterService converter)
        { //lil johan
            Console.WriteLine("You have chosen to Calculate the TravelTime!");
            Console.WriteLine("To Calculate the Traveltime, you'll need to enter some stuff!");
            Console.WriteLine("Input Speed:");
            bool speedchecker = Single.TryParse(Console.ReadLine(), out float speed); //tryparse speed
            Console.WriteLine("Input Distance:");
            bool distancechecker = Single.TryParse(Console.ReadLine(), out float distance); //tryparse distance
            if (speedchecker == false || distancechecker == false) {//if checks on speedcheck and distancecheck failed do this
                Console.WriteLine("you done goofed");
            } else { //if checks didnt fail do this
                float timeResults = converter.CalculateTravelTime(speed, distance);
                //
                Console.WriteLine("You have inputed the speed{0}, and the distance{1}.", speed, distance);
                Console.WriteLine("It has resulted in the TravelTime of {0}!", timeResults);
            }
            
        }
        static void CalculateTraveledDistance(ConverterService converter)
        { //lil johan
            Console.WriteLine("You have chosen to Calculate the Traveled Distance!");
            Console.WriteLine("To Calculate the Traveled Distance, you'll need to enter some stuff!");
            Console.WriteLine("Input Speed:");
            bool speedchecker = Single.TryParse(Console.ReadLine(), out float speed); //tryparse speed
            Console.WriteLine("Input Time:");
            bool timechecker = Single.TryParse(Console.ReadLine(), out float time); //tryparse time
            if (speedchecker == false || timechecker == false) {//if checks on speedcheck and timecheck failed do this
                Console.WriteLine("you done goofed");
            } else { //if checks didnt fail do this
                float distanceResults = converter.CalculateTraveledDistance(speed, time);
                //
                Console.WriteLine("You have inputed the speed {0}, and the time {1}.", speed, time);
                Console.WriteLine("It has resulted in the TravelTime of {0}!", distanceResults);
            }
        }
        static void CalculateSpeed(ConverterService converter)
        { //lil johan
            Console.WriteLine("You have chosen to Calculate the Speed!");
            Console.WriteLine("To Calculate the Speed, you'll need to enter some stuff!");
            Console.WriteLine("Input Time:");
            bool timechecker = Single.TryParse(Console.ReadLine(), out float time); //tryparse time
            Console.WriteLine("Input Distance:");
            bool distancechecker = Single.TryParse(Console.ReadLine(), out float distance); //tryparse distance
            if (timechecker == false || distancechecker == false) {//if checks on timecheck and distancecheck failed do this
                Console.WriteLine("you done goofed");
            } else { //if checks didnt fail do this
                float timeResults = converter.CalculateSpeed(time, distance);
                //
                Console.WriteLine("You have inputed the time {0}, and the distance {1}.", time, distance);
                Console.WriteLine("It has resulted in the Speed of {0}!", timeResults);
            }
        }

        static void CalculateVoltage(ConverterService converter)
        { //Martin did this
            Console.WriteLine("Okay, so you wanna calculate the amps from the resistance and voltage.");
            Console.WriteLine("Please enter the Ampere:");
            bool AmpereCheck = Single.TryParse(Console.ReadLine(), out float Ampere);   //Converts the users string input to a float for Ampere and creates a bool that is true if it can convert
            Console.WriteLine("Please enter the resistance:");
            bool ResistanceCheck = Single.TryParse(Console.ReadLine(), out float Resistance);   //Converts the users string input to a float for resistance and creates a bool that is true if it can convert
            if (AmpereCheck && ResistanceCheck) {  //Checks if the parse went through and proceeds to the converter if it has both inputs
                float Voltage = converter.CalculateVoltage(Resistance, Ampere);
                Console.WriteLine("The voltage is {0} Volts", Voltage);
            }
            else {
                Console.WriteLine("Ooops, some invalid inputs there. Sending ya back to tha main menu...");
            }
        }
        
        static void ConvertCelciusToFahrenheit(ConverterService converter)
        {
            Console.WriteLine("So you want to see a celcius to fahrenheit converter huh...");
            Console.WriteLine("Well, let's start of shall we? Please input the number you want to convert to Fahrenheit");
            bool IsThisCorrect = Single.TryParse(Console.ReadLine(), out float celcius);
            if (IsThisCorrect == true)
            {
                float epicSvar= converter.ConvertCelciusToFahrenheit(celcius);
                Console.WriteLine("The celsius you inputted is: {0}! In fahrenheit that is: {1}",celcius, epicSvar);  
            }
            else {
                Console.WriteLine("ey foo don do dat D:");
            }
        }

        static void ConvertFahrenheitToCelcius(ConverterService converter)
        {
            Console.WriteLine("So you want to see a Fahrenheit to Celcius converter huh...");
            Console.WriteLine("Well, let's start of shall we? Please input the number you want to convert to Celcius");
            bool IsThisCorrect = Single.TryParse(Console.ReadLine(), out float fahrenheit); //Tries to parse the number given by the user into a float. If the number ain't a float then it will send an exception
            if (IsThisCorrect == true) 
            {
                float epicSvar= converter.ConvertFahrenheitToCelcius(fahrenheit);
                Console.WriteLine("The fahrenheit you put in is: {0}! In celsius that is: {1}",fahrenheit, epicSvar); 
            }
            else { //this is the exception it will send.
                Console.WriteLine("ey foo don do dat D:"); 
            }
        }

        static void ConvertFromGallonToLiter(ConverterService converter)
        {
            Console.WriteLine("So you want to see a Gallon to Liter converter huh...");
            Console.WriteLine("Well, let's start of shall we? Please input the number you want to convert to Liter");
            bool IsThisCorrect = Single.TryParse(Console.ReadLine(), out float gallon); //Tries to parse the number given by the user into a float. If the number ain't a float then it will send an exception
            if (IsThisCorrect == true) 
            {
                float epicSvar= converter.ConvertFromGallonToLiter(gallon);
                Console.WriteLine("The gallon you put in is: {0}! In liter that is: {1}",gallon, epicSvar); 
            }
            else { //this is the exception it will send.
                Console.WriteLine("ey foo don do dat D:"); 
            }
        }

        static void ConvertFromLiterToGallon(ConverterService converter)
        {
            Console.WriteLine("You wanna convert from metric liters to imperial gallons huh?");
            Console.WriteLine("Okay, hom many liters is it?");
            bool LiterCheck = Single.TryParse(Console.ReadLine(), out float Liters);    //creates a bool that's true if it's possible to parse it and outputs it to a float
            if (LiterCheck) {   //If there is correct data it goes here and if it's incorrect it sends ya back to tha main menu
                float Gallons = converter.ConvertFromLiterToGallon(Liters);
                Console.WriteLine("Okay, it's {0} gallons if it's {1} liters", Gallons, Liters);
            }
            else {
                Console.WriteLine("Bruh, you just entered the wrong data. You're gonna get sent back to the main menu.");
            }
        }

        static void ConvertFromHoursToMinutes(ConverterService converter)
        //marko 
        { 
            Console.Write("You have chosen to convert hours to minutes. Please insert a number: ");
            bool HourCheck = Single.TryParse(Console.ReadLine(), out float hours);
            if (HourCheck == true)
            {
                float Svar = converter.ConvertFromHoursToMinutes(hours);
                Console.WriteLine("The minutes are {0}",Svar);
            }
            else 
            {
                Console.WriteLine("No, you cannot write that");
            }
        }

        static void ConvertFromMinutesToHours(ConverterService converter)
        //marko
        {
            Console.Write("You have chosen to convert minutes to hours. Please insert a number: ");
            bool MinuteCheck = Single.TryParse(Console.ReadLine(), out float minutes); //Tries to parse the number given by the user into a float.
            if (MinuteCheck == true) // checks if the user inputs something valid
            {
                float Svar = converter.ConvertFromMinutesToHours(minutes);
                Console.WriteLine("The hours are {0}",Svar);
            }
            else // otherwise its a no go
            {
                Console.WriteLine("No, you cannot write that");
            }
        }
    }
}