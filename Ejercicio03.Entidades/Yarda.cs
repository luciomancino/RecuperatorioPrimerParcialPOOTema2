using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio03.Entidades.Metro;

namespace Ejercicio03.Entidades
{
    public class Yarda
    {
        private float longitud;

        public float GetLongitud => longitud;

        public Yarda(float longitud = 5)
        {
            this.longitud = longitud;
        }
        public static implicit operator float(Yarda yarda)
        {
            return yarda.longitud;
        }

        public static bool operator ==(Yarda y1, Yarda y2)
        {
            return y1.longitud == y2.longitud;
        }
        public static bool operator !=(Yarda y1, Yarda y2)
        {
            return !(y1 == y2);
        }

        public static explicit operator Yarda(Metro metro)
        {
            return new Yarda(metro.GetLongitud * 1.09361f);
        }

        public static bool operator ==(Yarda y, Metro m)
        {
            return y == (Yarda)m;
        }
        public static bool operator !=(Yarda y, Metro m)
        {
            return !(y == (Yarda)m);
        }

        public static Yarda operator +(Yarda y1, Yarda y2)
        {
            return new Yarda(y1.longitud + y2.longitud);
        }
        public static Yarda operator +(Yarda y1, Metro m)
        {
            return y1 + (Yarda)m;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Yarda yarda)) return false;
            return this.Equals(yarda);

        }
        public override int GetHashCode()
        {
            return this.longitud.GetHashCode();
        }
    }
}
