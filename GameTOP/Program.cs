using System;
using GameTOP.lib;

namespace GameTOP.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFODA(new Jogador1(),
            new jogador2());
            jogo.IniciarJogo();
        }

    }
       
    
   
}
