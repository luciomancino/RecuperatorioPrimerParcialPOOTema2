using Ejercicio03.Entidades;


namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metro metro = new Metro(25);
            Yarda yarda = new Yarda(77);

            Console.WriteLine($"Metro: {metro.GetLongitud} metros");
            Console.WriteLine($"Yarda: {yarda.GetLongitud} yardas");

          
            Metro metroConverted = (Metro)yarda;
            Yarda yardaConverted = (Yarda)metro;

            Console.WriteLine(
                $"Yarda convertido a Metro: {metroConverted.GetLongitud} metros");
            Console.WriteLine(
                $"Metro convertido a Yarda: {yardaConverted.GetLongitud} yardas");

           
            Metro sumaMetro = metro + metroConverted;
            Yarda sumaYarda = yarda + yardaConverted;

            Console.WriteLine($"Suma de Metros: {sumaMetro.GetLongitud} metros");
            Console.WriteLine($"Suma de Yardas: {sumaYarda.GetLongitud} yardas");

          
            Console.WriteLine(
                metro == metroConverted
                ? "Las distancias en metros son iguales."
                : "Las distancias en metros no son iguales.");
            Console.WriteLine(
                yarda == yardaConverted
                ? "Las distancias en yardas son iguales."
                : "Las distancias en yardas no son iguales.");
        }
    }
}