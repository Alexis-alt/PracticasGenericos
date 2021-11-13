using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    //Indicamos que T debe de heredar de fruta y tiene que tener un constructor vacio 
   public  class FruitTree<T> where T: Friut, new()
    {


        public T CreateFruit()
        {
            var radm = new Random(DateTime.Now.Millisecond);

            return new T { Weigth = radm.Next(180, 301) };


        }
    }
}
