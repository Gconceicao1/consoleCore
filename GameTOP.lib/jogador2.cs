using GameTOP.Interface;

namespace GameTOP.lib
{
    public class jogador2 : ijogador
    {
        public string Chuta()
        {
            return "maradona está Chutando\n";
        }

        public string Corre()
        {
            return "maradona está Correndo\n";
        }

        public string Passa()
        {
            return "maradona está Passando\n";
        }
    }
}