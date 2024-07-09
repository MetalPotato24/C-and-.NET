using System;

public class World 
{

    static float vat = 19f;
    public static void Main(string[] args)
    {
       
       //float a =2.3f;
       //float b= 11.77f;
       //float c= 14.55f;
       //float summed = a+b+c;
       //float totalTax = (summed/100)*vat;
       //summed += totalTax;
       // System.Console.WriteLine("vat is "+ vat);
       // Calculate();

       string name = Console.ReadLine();
       System.Console.WriteLine(name);
    }
    public static void Calculate()
    {
        System.Console.WriteLine("Total Vat "+ vat);
    }
    
}
