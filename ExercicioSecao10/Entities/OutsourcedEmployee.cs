using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao10.Entities
{
    internal class OutsourcedEmployee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() 
        { 
        }

        public OutsourcedEmployee(double additionalCharge)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
