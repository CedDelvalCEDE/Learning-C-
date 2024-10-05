// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

// deux structures Celcius et Fahrenheit et convertion <=>

public struct Celcius
{
    public double celcius;
    public double convert_F() 
    {
        return (celcius * (1.8))+ 32;
    }
}

public struct Fahrenheit
{
    public double fahrenheit;
    public double convert_C()
    {
        double cinq_neuv = 5 / 9;
        return (fahrenheit * (cinq_neuv)) -32;
    }
}