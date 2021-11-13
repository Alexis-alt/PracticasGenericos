using System;
using System.Linq;

namespace genericos
{
    class Program
    {



        public static int cajas;
        public static string nombre;

        static void Main(string[] args)
        {
            Console.WriteLine("Número de cajas que desea crear");
            cajas = Int32.Parse(Console.ReadLine());
            nombre = "";
            IFactory<Doll> factory = new DollFactory();

            var boxes = BoxHeper.GenerateBoxes<Doll>(cajas, factory.MakeElement);

            //Practica 2


            var tree = new FruitTree<Watermelon>();
            var arbol = tree.CreateFruit();
            arbol.name = "";

            //Practica 3

            var cajita = new Caja<Watermelon>(40);
            var sandia = new Watermelon() { Weigth=5};
            var sandia2 = new Watermelon() { Weigth = 5};
            cajita.Add(sandia);
            cajita.Add(sandia2);



            //Practica 4
            //Métodos de extensión
            //Caja es una clase que tiene un List<T> que guarda elementos de tipo Fruit (Clases que hereden de ella)
          //Aquí utilizamos métodos extensores de IEnumerable
            var watermelonTree = new FruitTree<Watermelon>();//Creamos un árbol con tipo de fruta
            var caja3 = new Caja<Watermelon>(40000);//Creamos una caja con capacidad de 40000 gr
            caja3.LlenarCaja(watermelonTree);//Invocamos el método de extensión del objeto perteneciente a la clase caja 
            //Dicha clase no tiene definido el método puesto que lo toma por extensión de BoxExtensions
            Console.WriteLine($"En la caja han caido {caja3.Count()} watwermelons");

            var water= caja3.ToList();
            Console.WriteLine($"La watermelon más grande pesa {water.Max(i=>i.Weigth)}");
            Console.WriteLine($"Esta caja pesa {water.Sum(i=>i.Weigth)}");
            var SmallWater = water.Where(i => i.Weigth < 250);

            Console.WriteLine($"Waremelons que pesan menos de 250gr: {SmallWater.Count()}");

            Console.ReadLine();



        }
    }
}
