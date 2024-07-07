using System;

public class World 
{
    public static void Main(string[] args)
    {
       float vat = 19f;
       float a =2.3f;
       float b= 11.77f;
       float c= 14.55f;
       float summed = a+b+c;
       float totalTax = (summed/100)*vat;
       summed += totalTax;
        System.Console.WriteLine("total price "+ summed);
    }
}
