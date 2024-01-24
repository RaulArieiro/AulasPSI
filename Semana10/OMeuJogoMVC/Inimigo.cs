using System;

namespace OMeuJogo

{
   public class Inimigo
    {
        private string nome;
	    private int vida;
        public int escudo; 
        public int inicialvida = 100;
        public int inicialescudo = 150;

	    public Inimigo(string nome){

	        this.nome = nome;
	        vida = inicialvida;
            escudo = inicialescudo;
        }
        public string GetNome(){
	        return nome;
        }
        public int GetEscudo(){
           return escudo;
        }
        public void Danificar(int dano){
            escudo -= dano;
            int add = escudo;
            if(escudo <= 0){
                escudo = 0;
                vida += add;
            }
            if(vida < 0) {
                vida = 0;
            }
        }
        
        public int GetVida(){
            
	        return vida;
        }
        public void SetNome(string name){
            string set = name.Trim();
            nome = name;

        }
        public void Abastecer(int hp, Abastecimento cura){
            if(cura == Abastecimento.Vida){
                vida += hp;
                if(vida> inicialvida){
                    vida = inicialvida;
                }
            }else{
                escudo += hp;
                if(escudo> inicialescudo){
                    escudo = inicialescudo;
                }
            }
        }
    }
}
