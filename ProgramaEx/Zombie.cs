using System;

public class Zombie:Personaje
{
    
    public  Zombie(string sonido)
    {
        this.TipoPersonaje = "Zombie";
        this.EstaVivo = false;
        this.Comida = "Come sólo cerebros";
        this.ComoCamina = "Como un zombie";
        this.Sonido = "Aggggggh";

    }
    


}