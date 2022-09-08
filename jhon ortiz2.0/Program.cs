namespace ejercicio1
{
    public class Program
    {

        public static void Main()
        {
            
            int num, resul, doble;
            Console.WriteLine("por favor escriba el numero ");
            num = int.Parse(Console.ReadLine());
            doble = num * 2;
            resul = (num * 2) * 25;
            Console.WriteLine("el doble del numero dijitado es : " + doble);
            Console.WriteLine("el redultdo final es " + resul);

        }
    }

}

