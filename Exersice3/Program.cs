

namespace Exersice3
{

    internal class Program
    {
        

        static void Main(string[] args)
        {

            try
            {
               
               PersonHandler handler= new PersonHandler();
               var emil= handler.CreatePerson(20, "Emil", "Lönneberga", 1.70, 75);
               var ida = handler.CreatePerson(17, "Ida", "Lönneberga", 1.66, 75);

               Console.WriteLine("We are now trying to change the data for a person");
               handler.SetAge(emil, 21);
               handler.ChangeLName(ida, "Jo");

                
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ex.Message);
               
            }
            
            catch(Exception ex)
            
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(ex.Message);
                Console.WriteLine("WRONG");
            }
            finally
            {
                Console.ResetColor();
            }
            

        //    try
        //    {
        //        emil.PrintPerson();
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine($"It did work to access and print the person");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("It did not work!");
        //        Console.ResetColor();
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.StackTrace);
        //    }
        //    finally
        //    {
        //        Console.ResetColor();
        //    }
        }

    }

} 