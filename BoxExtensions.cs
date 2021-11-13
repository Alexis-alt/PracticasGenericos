using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    public static class BoxExtensions
    {

                                       //Con el this estamos indicando que este sera un método de extensión de la Clase que se indica
      public static void LlenarCaja<T>(this Caja<T> caja, FruitTree<T> arbol) where T:Friut, new ( )
        {

            //Le agrega un elemento de tipo árbol el cual tiene un método que proprciona un peso a la fruta que va generando 
            do
            {
                try
                {
                   //Se añaden frutas a la caja hasta que esta no pueda contenerlas
                    caja.Add(arbol.CreateFruit());
                }
                catch (Exception)
                {
                    //La exepción que genera es romper el bucle
                    break;
                }

            } while (true);
           




        }


    }
}
