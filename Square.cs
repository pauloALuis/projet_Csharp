using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Square
    {


        private double _width;
        private double _heigth;


        public Square(double width, double heigth)
        {
            this._heigth = heigth;
            this._width = width;

        }



        /// <summary>
        /// calculete area of square
        /// </summary>
        /// <returns></returns>
        public double Area()
        {

            return _width * _heigth;
        }

        /// <summary>
        /// calculete the square is diagonal
        /// </summary>
        /// <returns> Area </returns>
        public double Diagonal()
        {

            return _width * Math.Sqrt(2);
        }

        /// <summary>
        /// calculete the perimeter of the square
        /// </summary>
        /// <returns> Perimeter </returns>
        public double Perimeter()
        {

            return _width * 4;
        }




    }


}
