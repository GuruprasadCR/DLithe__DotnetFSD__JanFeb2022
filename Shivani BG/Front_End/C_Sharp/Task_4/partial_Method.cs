class Program  
   {  
       static void Main(string[] args)  
       {  
           ClassA cls = new ClassA();  
           cls.SetSalary();  
       }  
   }  
   public partial class ClassA  
   {  
       partial void SetData();  
   }  
  
   public partial class ClassA  
   {  
       public void SetSalary()  
       {  
           SetData();  
           // Perform other functionality here  
       }  
       partial void SetData()  
       {  
           Console.Write("This is partial method.");  
           Console.ReadKey();  
       }  
   }  