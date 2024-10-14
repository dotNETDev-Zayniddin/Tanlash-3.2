/*
    Temperatura o'girish: Foydalanuvchidan o'zbek tilida graduslar (Selsiyus) bo'yicha temperaturani kiritishni so'rang. 
    Keyin kiritilgan temperaturani Fahrenheit va Kelvin ga o'girib, natijalarni ekranga chiqaring. 
    Switch-operatoridan foydalaning.
    Input: 25
    Output: Selsiyus: 25, Fahrenheit: 77.0, Kelvin: 298.15
*/
using System;
namespace Tanlash
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Graduslar(°C) bo'yicha temperaturani kiriting: ");
            int temperature = Convert.ToInt32(Console.ReadLine());  
            switch(temperature)
            {
                default:
                {
                    decimal temperatureAsF =(decimal)((temperature * 9.0 / 5.0) + 32);
                    decimal temperatureAsK = (decimal) (temperature + 273.15);
                    System.Console.WriteLine($"Graduslar(°C): {temperature}\nFahrenheit(F): {temperatureAsF}\nKelvin: {temperatureAsK}");
                    break;  
                }
            }
        }
    }
}