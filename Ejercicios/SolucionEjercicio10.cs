using System; 

namespace Ejercicios
{
    public class SolucionEjercicio10
    {

        public void Ejecutar()
        {
            int dimensionArray = 0; 
            Console.WriteLine("Escriba el array de cuantos números es.");

            dimensionArray = Int32.Parse(Console.ReadLine());

            int[] ingresado = new int[dimensionArray];

            for(int i = 0; i < dimensionArray; i++)
            {
                Console.WriteLine("Escriba un número");

                ingresado[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El menor número a partir de cero noescrito en el array es: {MenorNumeroNoEscrito(ingresado)}");


        }
        int numAValidar; 
        public int MenorNumeroNoEscrito(int[] a) 
        {
            bool encontreNum = false;

            for(int i = 0; i < a.Length; i++) 
            {

                numAValidar = i + 1; 
                encontreNum = false; 

                for(int q = 0; q < a.Length; q++)
                {

                    if (a[q] == numAValidar)
                    {
                        encontreNum = true;
                        break; 
                    }

                }

                if(encontreNum == false)
                {
                    break; 
                }
            }
            
            return numAValidar; 

        }

    }
}