namespace Dependency_injection__example_2_C_
{
    public class Program
    {
        static void Main(string[] args)
        {
           // PinaColada pinaColada = new PinaColada();   // alternativ
            IDrinks pinaColada = new PinaColada();   

            Bartender bartender = new Bartender(pinaColada);
            bartender.Prepare();    
        }
    }
}
