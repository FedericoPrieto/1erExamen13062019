using System; 

namespace Ejercicios
{
    public class NumericInput:TextInput 
    {
        

        public override void Add(char c)
        {
            if(isCaracterValido(c))
            {

                base.Add(c); 
            }
        }

        private  bool isCaracterValido(char c)
        {
            return char.IsDigit(c);
        }

        
    }
}