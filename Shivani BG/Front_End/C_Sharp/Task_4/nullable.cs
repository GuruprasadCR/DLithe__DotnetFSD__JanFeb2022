using System;  
namespace CSharpFeatures  
{  
    class NullableExample2  
    {  
        static void Main(string[] args)  
        {  
            Nullable<int> a = 10;  
           
            // Displaying value  
            Console.WriteLine(a.Value);  
            // assigning null values  
            a = null;  
           int? num1 = null;
         int? num2 = 45;
         
         double? num3 = new double?();
         double? num4 = 3.14157;
         

         // display the values
         Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
         Console.ReadLine();
            // Checking, does "a" contain value ?  
            if (a.HasValue)  
            {  
                Console.WriteLine(a.Value);  
            }  
            if(a == null)  
             Console.WriteLine("It contains null value");  
        }  
    }  
}  