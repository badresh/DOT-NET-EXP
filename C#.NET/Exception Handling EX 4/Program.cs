using System;
class ExceptionHandling4
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 10 / number;
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException ex)
        {
       
            Console.WriteLine("Format Exception: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            
            Console.WriteLine("Divide By Zero Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
   
            Console.WriteLine("Exception: " + ex.Message);
        }
        finally
        {
          
            Console.WriteLine("Finally block executed.");
        }
    }
}
