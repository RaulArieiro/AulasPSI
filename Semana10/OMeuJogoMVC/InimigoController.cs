using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OMeuJogoMVC
{
  public class InimigoController
    {
      Inimigo[] rr;
        public InimigoController(Inimigo[] gg){
          rr = gg;
        }
          
        public void Iniciar(View wer){
          rr = new Inimigo[wer.Inimostra()];
           for(int i = 0; i < rr.Length; i++){
                  rr[i] = new Inimigo(wer.Nome());
            }
          for(int i =0; i < rr.Length; i++){
              wer.MostraNome(rr, i);
          }
          for(int i =0; i< rr.Length; i++){
            int dano = wer.Dano(); 
            rr[i].Danificar(dano);
            wer.Daniicar(rr, dano, i);
          }
          for(int i = 0; i< rr.Length; i++){
            wer.ResVida(rr, i);
            int hp = wer.CuraVida();
            int escudo = wer.CuraEscudo();
            rr[i].Abastecer(hp, Abastecimento.Vida);
            rr[i].Abastecer(escudo, Abastecimento.Escudo);
          }
          for(int i = 0; i<rr.Length; i++){
            wer.MostraALL(rr, i);
          }
        }        
    }
}
