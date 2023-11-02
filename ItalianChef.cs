using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class ItalianChef : Chef //Inheritance
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        public override void MakeSpecialDish() //Override
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
