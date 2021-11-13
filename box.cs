using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    public class box <T>
    {

        public T Content { get; private set; }

        public bool tieneCotenido { get; set; }


        public void Put(T content)
        {
            if (tieneCotenido)
            {

                throw new Exception("Ya hay algo en la caja");


            }

            this.Content = content;
            tieneCotenido = true;

        }


        public T Extract()
        {
            if (!tieneCotenido)
            {
                throw new Exception("No hay nada para extraer de la caja");
            }

            var content = Content;
            this.Content = default(T);
            tieneCotenido = false;
            return content;


        }



    }
}
