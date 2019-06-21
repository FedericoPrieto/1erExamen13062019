using System;

namespace Ejercicios
{
    public class SolucionEjercicio1
    {
             public void Ejecutar()
            {
            //For example, the following code should output &quot;10&quot;:
            
                TextInput input = new NumericInput();
                input.Add('1');
                input.Add('a');
                input.Add('0');
                Console.WriteLine(input.GetValue()); 
            
            }             
    }
}