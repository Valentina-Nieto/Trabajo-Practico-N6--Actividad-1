using System;

namespace ComoPrepararUnCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba por pantalla los pasos en secuencia para preparar una taza de café. Por cada paso se
            debe esperar que el usuario presiones una tecla. Limpiar la pantalla al comenzar el programa.*/
            
            Console.Clear();
            Console.WriteLine("Pasos para preparar un Café");
            Console.WriteLine("Presionar una tecla para avanzar");
            Console.ReadKey();

            Console.WriteLine("Poner agua a calentar en una pava");
            Console.WriteLine("Presionar una tecla para avanzar");
            Console.ReadKey();

            Console.WriteLine("Mientras tanto, agarre una taza y ponga (en caso de ser un cafe instantaneo) tres cucharadas de cafe, en otro caso ponga el saquito en la taza");
            Console.WriteLine("Presionar una tecla para avanzar");
            Console.ReadKey();

            Console.WriteLine("Cuando el agua este bastante caliente, tiene que vertirla en la taza donde se encuentra el cafe");
            Console.WriteLine("Presionar una tecla para avanzar");
            Console.ReadKey();

            Console.WriteLine("Mientras agrega agua, ir mezclando con cuidado de no quemarse");
            Console.WriteLine("Presionar una tecla para avanzar");
            Console.ReadKey();

            Console.WriteLine("Por último agregar azúcar a gusto y mezclar");
            Console.WriteLine("Presionar una tecla para avanzar");
            Console.ReadKey();
        }
    }
}