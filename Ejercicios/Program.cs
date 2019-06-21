using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1
            //User interface contains two types of user input controls: TextInput, which accepts all
            //characters and NumericInput, which accepts only digits.
            //Implement the class TextInput that contains:
            // Public method void Add(char c) - adds the given character to the current value
            // Public method string GetValue() - returns the current value
            //Implement the class NumericInput that:
            // Inherits TextInput
            // Overrides the Add method so that each non-numeric character is ignored
            //For example, the following code should output &quot;10&quot;:
            //TextInput input = new NumericInput();
            //input.Add('1');
            //input.Add('a');
            //input.Add('0');
            //Console.WriteLine(input.GetValue());
             
            SolucionEjercicio1 ejercicio1 = new SolucionEjercicio1();
            ejercicio1.Ejecutar();  
            Console.ReadLine();          

            
            
            //
            //Ejercicio 2
            //A palindrome is a word that reads the same backward or forward.
            // Write a function that checks if a given word is a palindrome. 
            //Character case should be ignored.
            //For example, IsPalindrome('Deleveled') should return true as 
            //character case should be ignored, resulting in 'deleveled';, 
            //which is a palindrome since it reads
            //the same backward and forward.
             
            SolucionEjercicio2 ejercicio2 = new SolucionEjercicio2();
            ejercicio2.Ejecutar();            
            Console.ReadLine();          

            
            
            //
            //Ejercicio 10
            //This is a demo task.
            //Write a function:
            //class Solution { public int solution(int[] A); }
            //that, given an array A of N integers, returns the smallest positive integer (greater than 0) that
            //does not occur in A.
            //For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            //Given A = [1, 2, 3], the function should return 4.
            //Given A = [−1, −3], the function should return 1.Write an efficient algorithm for the following assumptions:
            // N is an integer within the range [1..100,000];
            // each element of array A is an integer within the range [−1,000,000..1,000,000].
             
            SolucionEjercicio10 ejercicio10 = new SolucionEjercicio10();
            ejercicio10.Ejecutar();            
            Console.ReadLine();          

            
            
            //
            //Ejercicio 11
            // A non-empty array A consisting of N integers is given. The consecutive elements of array A
            //represent consecutive cars on a road.
            //Array A contains only 0s and/or 1s:
            // 0 represents a car traveling east,
            // 1 represents a car traveling west.
            //The goal is to count passing cars. We say that a pair of cars (P, Q), where 0 ≤ P &lt; Q &lt; N, is
            //passing when P is traveling to the east and Q is traveling to the west.
            //For example, consider array A such that:
            //A[0] = 0
            // A[1] = 1
            // A[2] = 0
            // A[3] = 1
            // A[4] = 1
            //We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).
            //Write a function:
            //class Solution { public int solution(int[] A); }
            //that, given a non-empty array A of N integers, returns the number of pairs of passing cars.
            //The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.
            //For example, given:
            //A[0] = 0
            // A[1] = 1
            // A[2] = 0
            // A[3] = 1
            // A[4] = 1
            //the function should return 5, as explained above.
            //Write an efficient algorithm for the following assumptions:
            // N is an integer within the range [1..100,000];
            // each element of array A is an integer that can have one of the following values: 0, 1.
            //

            //Console.WriteLine("Hello World!");
        }
    }
}
