using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    public class Caja<T> : IEnumerable<T> where T : IWeighable
    {
        //Atributos

        private readonly List<T> lstContent = new List<T>();

        public int MaxWeigth { get; private set; }


        //Constructor

        public Caja(int maxweigth)
        {
            this.MaxWeigth = maxweigth;
            lstContent = new List<T>();

        }


        //Método que regresa un true o false dependiendo de si el peso es exedido, solo es usado dentro de la clase
        private bool CanAdd(int weigth)
        {                       
            //Metodo sum(elementos_de_List){regresa la suma de una propiedad int de todos los elementos}

            //Si la suma es menor o igual regresa un true 
            return lstContent.Sum(i => i.Weigth) + weigth <= MaxWeigth;
        }


        //Método para añadir elementos
        //Recibe el obejeto que implemente la interfaz establecida  
        public void Add(T item)
        {
            if (lstContent.Contains(item))//Revisa si la lista ya lo contiene
            {
                throw new Exception("Este elemento ya esta en la caja");
            }

           else if (!CanAdd(item.Weigth))//Si se regresa un false despues de invocar el método CanAdd(pasandole como parametro la propiedad peso)
            {
               

                throw new Exception("No puedo añadir ese peso a la caja. La caja ya pesa demasiado");

            }

            lstContent.Add(item);
        }

        public bool Remove(T item)
        {
            return lstContent.Remove(item);
        }




        public IEnumerator<T> GetEnumerator()
        {
            return lstContent.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lstContent.GetEnumerator();
        }
    }
}
