using System.Text;

namespace Ejercicio01.Entidades
{
    public class Cilindro
    {
        public int Radio { get;}
        public int Altura { get;}

        private double diametro;

        

        public Cilindro(int radio, int altura)
        {
            if (radio <= 0)
            {
                throw new ArgumentException("El Radio debe ser mayor a 0");
            }

            if(altura <= 0) 
            {
                throw new ArgumentException("La Altura debe ser mayor a 0");
            }

            Radio = radio;
            Altura = altura;
            diametro = CalcularDiametro();
        }

        private double CalcularDiametro()
        {
            return Radio * 2;
        }

        public double CalcularArea()
        {
            return 2* Math.PI * Radio * (Radio + Altura);
        }

        public double CalcularVolumen()
        {
            return Math.PI* Math.Pow(Radio, 2)* Altura;
        }

        public string GetInfo()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Radio: {Radio}");
            sb.AppendLine($"Altura: {Altura}");
            sb.AppendLine($"Diametro: {CalcularDiametro()}");
            sb.AppendLine($"Area: {CalcularArea()}");
            sb.AppendLine($"Volumen:{CalcularVolumen()}");
            return sb.ToString();
        }

    }
}
