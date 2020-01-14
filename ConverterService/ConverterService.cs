using System;

namespace Service
{
    public class ConverterService : IConverterService
    {
        public ConverterService()
        {
        }

        // 1 gallon = 3.78541178 liters     
        // 1 liter = 0.264172052 gallons   
        //Fahrenheit = Celsius * 9/5 + 32
        //Time = distance / speed
        //Ohm law says: amp = voltage / resistance
        //Radius = square root (area / pi)
        //Diameter = radius * 2

        public float CalculateAmps(float voltage, float resistance)
        {   //Robert was here
            //Ohm's law: U = R * I (U=Voltage, R=Resistance, I=Ampere) thus I = U / R
            float I = voltage / resistance; //where I is ampere
            return I;   //returns the calculated ampere
        }

        public float CalculateResistance(float voltage, float amps)
        {   //Robert was here
            //Ohm's law: U = R * I (U=Voltage, R=Resistance, I=Ampere) thus R = U / I
            float R = voltage / amps;   //where R is resistance
            return R;   //Returns the calculated resistance
        }

        public float CalculateDiameterFromArea(float area)
        { //lil Mar
            float A = area;
            const float PI = 3.14159265358979F;
            float ADivided = A/PI;
            Convert.ToDouble(ADivided); 

            Double Radius = Math.Sqrt(ADivided); //Finds the square root of ADivided
            Double Result = Radius * 2; //Takes the Divided results and multiply it with the power of 2

            float PrintResult = Convert.ToSingle(Result); //Converts double value to a float
            return PrintResult; //Returns value "radius";
            
        }

        public float CalculateRadiusFromArea(float area)
        { //lil Mar
            float A = area;
            const float PI = 3.14159265358979F;

            float ADividedByPI = A/PI;
            Convert.ToDouble(ADividedByPI); 

            Double Radius = Math.Sqrt(ADividedByPI);
            float PrintResult = Convert.ToSingle(Radius); //Converts double value to a float
            return PrintResult; //Returns value "radius";
        }
        public float CalculateTravelTime(float speed, float distance)
        { //lil johan
            //Time = distance / speed
            float TravelTime = distance / speed; // tid = distans / hastighet
            return TravelTime; //returnerar tidsmängden
        }
        public float CalculateTraveledDistance(float speed, float time)
        { //lil johan
            //distance = speed * time
            float TraveledDistance = speed * time; // distans = hastighet * tidsenhet
            return TraveledDistance; //returnerar distansen
        }
        public float CalculateSpeed(float time, float distance)
        { //lil johan
            //speed = distance / time
            float calcSpeed = distance / time; //hastighet = distans / tid
            return calcSpeed; // returnerar hastighet
        }

        public float CalculateVoltage(float res, float amp)
        {   //Robert and Martin was here spectating Martin
            //Ohm's law: U = R * I (U=Voltage, R=Resistance, I=Ampere) thus U = R * I
            float U =  res * amp;   //Where U is voltage
            return U;   //Returns the calculated voltage
            
        }
        
        public float ConvertCelciusToFahrenheit(float celcius)
        {   //martini was here
            float ConCelcius = celcius;
            float ConResult = (float)9/5 * ConCelcius + 32; //The formula for converting Celcius to Fahrenheit is 9/5 * C-32
            return ConResult; //Returns printed results
        }

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {   //Robot was probably here
            float Celsius = (float)5 / 9 * (fahrenheit - 32);  //Calculates Celsius from fahrenheit
            return Celsius; //Returns the calculated value
        }

        public float ConvertFromGallonToLiter(float gallon)
        {
        ////////////// 1 liter = 0.264172052 gallons 
        Convert.ToDouble(gallon);
        Double Liter = gallon * 3.78541178;
        float liter = Convert.ToSingle(Liter);
        return liter;
        }
        
        public float ConvertFromLiterToGallon(float liter)
        {   //Robortoninator was here
            // 1 liter = 0.264172052 gallons 
            double gallonTemp = liter * 0.264172052; //calculates gallons based on liters
            float gallon = Convert.ToSingle(gallonTemp);
            return gallon;  //returns the calculated gallons
        }

        public float ConvertFromHoursToMinutes(float hours)
        //marko 
        // "hours" * 60 = minutes
        { 
            float ConvMin = hours * 60; // Minuter = timmar * 60
            return ConvMin; // returnerar mintuer
        }

        public float ConvertFromMinutesToHours(float minutes)
        //marko
        // "minutes" / 60 = hours
        {
            float ConvHours = minutes / 60; // Timmar = minuter / 60
            return ConvHours;  // returnerar timmar
        }
    }
}