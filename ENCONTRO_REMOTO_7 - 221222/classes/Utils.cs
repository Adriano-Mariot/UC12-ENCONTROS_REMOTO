using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENCONTRO_REMOTO_2.classes
{
    public static class Utils
    {
        public static void loading (string texto, int pontos, int tempo)
        {
            // Carregando
            Console.BackgroundColor=ConsoleColor.Green;
            Console.ForegroundColor=ConsoleColor.White;
            
            Console.Write(texto);
            Thread.Sleep(tempo);
            for (int i = 0; i< pontos; i++) 
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
                Console.ResetColor();
                
            Console.Clear();
        }

        public static void ParadaNoConsole (string texto)
        {
            Console.WriteLine(texto);
            Console.WriteLine($"Tecle <ENTER> para Continuar");
            Console.ReadLine();//para o sistema
            Console.Clear();
        }
    }
}