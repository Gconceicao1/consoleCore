using GameTOP.Interface;

namespace GameTOP.lib
{
     public class Jogador1: ijogador{
        public readonly string _Nome;     

       
        //Chuta
        public string Chuta(){
          return "Gabgol está Chutando\n";
        }
        //Corre
        public string Corre(){
          return "Gabgol está correndo\n";
        }
        //Passe
        public string Passa(){
          return "Gabgol está passando\n";
        }

      }
}