using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class jogoFODA

    {
        private readonly ijogador _jogador1;
        private readonly ijogador _jogador2;

         public jogoFODA(ijogador jogador1,ijogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            Console.Write(_jogador1.Corre());
            Console.Write(_jogador1.Chuta());
            Console.Write(_jogador1.Passa());

            Console.Write(_jogador2.Corre());
            Console.Write(_jogador2.Chuta());
            Console.Write(_jogador2.Passa());
        }
    }
}