namespace ejercicio2
{
    public class Program
    {

        public static void Main()
        {

            double num1, num2, num3, num4, sum, media, produc;
            Console.WriteLine("Digite 4 numeros ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());
            num4 = double.Parse(Console.ReadLine());
            sum = num1 + num2 + num3 + num4;
            produc = num1 * num2 * num3 * num4;
            Console.WriteLine("el produto es de : " + produc);
            Console.WriteLine("el resultdo de la suma es: " + sum);
            media = sum / 4;
            Console.WriteLine("la media  es: " + media);

        }
    }

}