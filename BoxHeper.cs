using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    public static class BoxHeper
    {



        //Este método 

        public static List<box<T>> GenerateBoxes<T>(int numeroCajas,Func<T> delegado)
        {
            var lst = new List<box<T>>();

            for(int i = 0; i < numeroCajas; i++)
            {
                Console.WriteLine($"Caja creada: {i+1}");
                var caja = new box<T>();
                   caja.Put(delegado());
                    
                lst.Add(caja);

            }

            return lst;
        }



    }
}
