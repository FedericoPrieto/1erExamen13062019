using System;

namespace ProgramaEx
{
    class Program
    {

        static void Main(string[] args)
        {

            //todos los ejercicios los hice en el (debido q que no se pidió)
            //en el main por una cuestión de poder 
            //realizarlos más rápidos. 

            //1 - Ingresar un número y mostrar la suma de los números que lo anteceden.
            
            int NumIngresado=0;
            //suponiendo que voy a ingresar solamente 5 numeros
             for(int i = 0; i <  5; i++)
                {
                    Console.WriteLine("Ingrese un número");
                    NumIngresado = NumIngresado + Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"La suma es {Convert.ToString(NumIngresado)}");
                }


            //////////////////////////////////////////////////
            //2 - Se ingresa por teclado la temperatura máxima, en grados, día a día durante una semana.
            //Se pide determinar el día de mayor temperatura, el de menor y el promedio.

             int diaMaxTemp = 1;
             int diaMenorTemp = 1; 
             int promedioTemp = 1;
             int tempMaxDelDia  = 0; 
             int tempMaxDelDiaAnt  = 0; 
             int tempMinDelDiaAnt  = 0; 
             int sumaTemperaturas = 0; 

             //Acá ingreso la temperatura de 7 días
              for(int i = 0; i <  7; i++)
                 {
                     Console.WriteLine("Ingrese la temperatura máxima");
                     tempMaxDelDia = Convert.ToInt32(Console.ReadLine()); 

                      if (tempMaxDelDia > tempMaxDelDiaAnt)
                          {
                              tempMaxDelDiaAnt = tempMaxDelDia;
                              diaMaxTemp = i + 1; 
                          }

                      if (tempMaxDelDia < tempMinDelDiaAnt)
                          {
                              tempMinDelDiaAnt = tempMaxDelDia;
                              diaMenorTemp = i + 1; 
                          }

                     sumaTemperaturas = (sumaTemperaturas + tempMaxDelDia);
                     if (i == 6)
                         {
                             promedioTemp = (sumaTemperaturas / 7);
                         }                                
                 }

                 Console.WriteLine($"El día de mayor temperatura fue el {Convert.ToString(diaMaxTemp)}");
                 Console.WriteLine($"El día de menor temperatura fue el {Convert.ToString(diaMenorTemp)}");
                 Console.WriteLine($"El promedio de temperaturas fue {Convert.ToString(promedioTemp)} Grados");

/////////////////////////////////////////////////////////////////////////////
                //3 - En una película existen dos tipos de personajes
                //Los Humanos no infectados y los infectados (o zombies).
                //Los No infectados están vivos, los zombies: No.
                //Ambos comen, pero los zombies comen cerebros humanos.
                //Ambos caminan; pero los zombies caminan como....zombies.
                //Ambos emiten sonidos con la boca. Los no infectados hablan, los zombies hacen “Aggggggh!!!”
                //  Hacer un programa que:
                //Cree dos instancias de zombie y un no infectado.
                //Los agregue a un ArrayList.
                //Luego recorra el array y, por cada uno de ellos muestre por pantalla:
                //Si esta vivo o no
                //Como come
                //Como camina
                //Hacerlo decir algo.

                Personaje[] personajes = new Personaje[3];

                Zombie zombie1 = new Zombie("no lo toma");
                Zombie zombie2 = new Zombie("no lo toma");
                Humano humano1 = new Humano("Hola soy humano");

                personajes[0] = zombie1;
                personajes[1] = zombie2;
                personajes[2] = humano1;

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Soy un : {personajes[i].TipoPersonaje}");
                    Console.WriteLine($"Está vivo: {personajes[i].EstaVivo}");
                    Console.WriteLine($"Que come: {personajes[i].Comida}");
                    Console.WriteLine($"Camina como: {personajes[i].ComoCamina}");
                    Console.WriteLine($"Dice lo siguiente: {personajes[i].Sonido}");
                    //Le pongo una parada por cada uno
                    Console.ReadLine();
                }

        }
    }
}
