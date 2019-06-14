using System;

public class Humano:Personaje
{
    
    public  Humano(string sonido)
    {
        this.TipoPersonaje = "Humano";
        this.EstaVivo = true;
        this.Comida = "Come de todo";
        this.ComoCamina = "Como un humano";
        this.Sonido = sonido;

    }
    


}