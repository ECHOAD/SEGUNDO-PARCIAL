/*Crear una aplicación para un sistema de votaciones. 
Caracteristicas:
- Cantidad de candidatos 4
- Cantidad de votos 1,000, estos seran de forma aleatoria.
- Los resultados se mostraran (Total de votos por candidatos, % de votos acumulados y Ordenados descendente).
- El sistema es tipo consola en C#.
- Datos candidato: Partido, Nombre completo, poscición a la que aspira (presidente).
- Partidos: Fecha de fundacion (ficticia), Nombre completo y siglas*/

using System;


namespace Votacion_Segundo_parcial
{
    class Program
    {
        public static void Nombramiento(string [] candidaypart, double [] cantvotos) 
        {
            double porcentaje = 0;

            Console.WriteLine("Los candidatos son: ");

            for (int i = 0; i < candidaypart.Length; i++)
            {
                
                porcentaje = cantvotos[i] * 0.1000;
                Console.WriteLine(candidaypart[i] + $"Con {cantvotos[i]} votos y un porcentaje de {porcentaje.ToString("#.#")}% ");




                Console.WriteLine(" ");
            }
            porcentaje = cantvotos[0] * 0.1000;
            Console.WriteLine("El Candiato ganador fue: ");

            Console.WriteLine(candidaypart[0] + $"Con {cantvotos[0]} votos y un porcentaje de {porcentaje.ToString("#.#")}%");
        }
        

        static void Main(string[] args)
        {
            string[] lugares = new string[4];
            
            Random rnd = new Random();
            

            string[] candidaypart = { " (PCS) PARTIDO COMUNISTA SOCIAL 1937, Juan Ernesto Gutierrez (Presidente)", " (PCR) PARTIDO CRISTIANO REVOLUCIONARIO 1996, Luis Gonzalez  (Presidente)",
                "(PLR) PARTIDO LIBERAL REFORMMISTA 2000, Miguel Peguerino  (Presidente)", " (AP) ALIANZA DEL PUEBLO 2013, Guillermo Perez  (Presidente)" };

            double[] cantvotos = new double[4];


            for (int i = 0; i <= 1000; ++i)
            {

                int votacionrnd = rnd.Next(1, 5);

                if (votacionrnd == 1)
                {
                    cantvotos[0]++;
                }
                else if (votacionrnd == 2)
                {
                    cantvotos[1]++;
                }
                else if (votacionrnd == 3)
                {
                    cantvotos[2]++;
                }
                else
                {
                    cantvotos[3]++;
                }

            }

        

            for (int i = 0, j = 1; i < 3 && j < 4; i++, j++)
            {
                double aux1 = 0;
                string aux2;

                if (cantvotos[i] < cantvotos[j])
                {
                    aux1 = cantvotos[i];
                    cantvotos[i] = cantvotos[j];
                    cantvotos[j] = aux1;

                    aux2 = candidaypart[i];
                    candidaypart[i] = candidaypart[j];
                    candidaypart[j] = aux2;
                }
            }

            Nombramiento(candidaypart,cantvotos);
        }
    } 
}