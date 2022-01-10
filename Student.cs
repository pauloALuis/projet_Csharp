using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_projet
{
    class Student
    {

        public string Name { get; set; }
        public double[] Classification  = new double[3];
        private const double Points = 60.00;



        private double _MediaClassification {
            
            get {
                
                double sum = 0.0;

                sum =    (Classification[0] * (30 / 100.0))+
                         (Classification[1] * (35 / 100.0)) +
                         (Classification[2] * (35 / 100.0));


               /* for (int i = 0; i < Classification.Length; i++)
                {
                    sum += Classification[i];
                }*/

                return sum / Classification.Length;
            }
            
        }


        public void CheckApproval() {
            if ( _MediaClassification > Points )
            {
               Console.WriteLine($"NOTA fINAL: {_MediaClassification} \n Aprovado");
            }
            else
            {
                //double diff = Points - _MediaClassification;
               Console.WriteLine($"NOTA FINAL: {_MediaClassification} \n Reprovado \n Faltaram {Points - _MediaClassification} Pontos");
            }
        
        }




       // public override string ToString() => "Employee: " + _name.ToUpper() + ",€ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture) + "  ";

    }
}
