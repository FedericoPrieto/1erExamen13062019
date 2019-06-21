using System; 

namespace Ejercicios
{
    public class SolucionEjercicio2
    {
        public void Ejecutar()
        {
            string palabraInput = "";
            Console.WriteLine("Ingrese palabra a verificar: ");
            palabraInput = Console.ReadLine(); 

            if (checkeaPalindrome(palabraInput) )
            {

            Console.WriteLine($"{palabraInput} es una palabra Palindrome");

            }
            else 
            {

            Console.WriteLine($"{palabraInput} NO es una palabra Palindrome");

            }


        }
        public bool checkeaPalindrome(string c)
        {

            string palabraAlReves = string.Empty; 
            
            for (int i = c.Length - 1; i >= 0; i--)
            {
                palabraAlReves += c.Substring(i,1);
            }

            return (c == palabraAlReves);

        }

    }

}