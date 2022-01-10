using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Triangulo : IEquatable<Triangulo>
    {
        private double _xA;
        private double _xB; 
        private double _xC;

        public Triangulo()
        {}
        public Triangulo ( double ladoA, double ladoB)
        {
            this._xA = ladoA;
            this._xB = ladoB;
          

        }

        public Triangulo(double ladoA, double ladoB, int ladoC) : this()
        {
             this._xC = ladoC;
            //this._xC = ladoB;

        }


        public double  LadoA
        {

            get { return _xA; }
            set { this._xA = value; }

        }
        public double LadoB{ 
            
          get{ return _xB; }
          set { this._xB = value; }
        
        }
        public double LadoC
        {

            get { return this._xC; }
            set { this._xC = value; }

        }


        public double AreaTriangulo
        {
            get 
            { 
                double p = (_xA + _xB + _xC) / 2.0;
                return Math.Sqrt(p * (p - _xA) * (p - _xB) * (p - _xC));
            }
        }




        public void PrintArea() { 
         Console.WriteLine($"{this.AreaTriangulo}");
     
        }

        public override bool Equals(object obj)
        {
            return obj is Triangulo triangulo &&
                   _xA == triangulo._xA &&
                   _xB == triangulo._xB &&
                   _xC == triangulo._xC &&
                   LadoA == triangulo.LadoA &&
                   LadoB == triangulo.LadoB &&
                   LadoC == triangulo.LadoC &&
                   AreaTriangulo == triangulo.AreaTriangulo;
        }

        public bool Equals(Triangulo other)
        {
            return other != null &&
                   _xA == other._xA &&
                   _xB == other._xB &&
                   _xC == other._xC &&
                   LadoA == other.LadoA &&
                   LadoB == other.LadoB &&
                   LadoC == other.LadoC &&
                   AreaTriangulo == other.AreaTriangulo;
        }

        public override string ToString()
        {
            return "Triangulo (_xA= " + _xA + ", _xB= " + _xB + ", _xC= " + _xC +")";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_xA, _xB, _xC, LadoA, LadoB, LadoC, AreaTriangulo);
        }

        public static bool operator ==(Triangulo left, Triangulo right)
        {
            return EqualityComparer<Triangulo>.Default.Equals(left, right);
        }

        public static bool operator !=(Triangulo left, Triangulo right)
        {
            return !(left == right);
        }
    }
}
