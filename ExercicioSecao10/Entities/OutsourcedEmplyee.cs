using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao10.Entities
{
    internal class OutsourcedEmplyee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmplyee() 
        { 
        }

        public OutsourcedEmplyee(double additionalCharge)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
