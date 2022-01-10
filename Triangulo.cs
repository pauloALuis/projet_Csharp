using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Triangulo
    {
        private double _xA;
        private double _xB; 
        private double _xC;


        public Triangulo ( double ladoA, double ladoB, int ladoC)
        {
            this._xA = ladoA;
            this._xB = ladoB;
            this._xC = ladoC;

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

    }
}
