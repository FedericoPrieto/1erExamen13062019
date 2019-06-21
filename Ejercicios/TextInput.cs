using System;

namespace Ejercicios
{
    public class TextInput
    {
        private string caracterIngresado = string.Empty; 
        public virtual void Add(char c)
        {
            caracterIngresado += c.ToString(); 
        }

        public string GetValue()
        {
            return caracterIngresado;
        }

    }
}