using Ejercicio01.Entidades;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el valor del radio: ");
                int radio = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de la altura: ");
                int altura = int.Parse(Console.ReadLine());

                Cilindro cilindro = new Cilindro(radio, altura);

                Console.WriteLine(cilindro.GetInfo());
            }
            catch(ArgumentException exepcion)
            {
                Console.WriteLine($"Error:{exepcion.Message}");
            }

        }
    }
}
