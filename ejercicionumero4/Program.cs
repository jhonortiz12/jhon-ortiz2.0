namespace ejercicio4
{
    public class Program
    {

        public static void Main()
        {
            
            int contador, limit, sumatoria;
            contador = 1;
            limit = 10;
            sumatoria = 0;
            for (contador = 1; contador <= limit; contador++)
            {
                sumatoria = sumatoria + contador;
            }
            Console.WriteLine("el resultao de la sumatoria es: " + sumatoria);
        }
    }

}
