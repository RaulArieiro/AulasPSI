using System;

namespace OMeuJogo

{
   public class Inimigo
    {
        string name;

        private string nome;
	    private int vida;

	    public Inimigo(string nome){

	        this.nome = nome;
	        vida = 100;

        }
        public string GetNome(){
	        return nome;
        }
        public void Danificar(int dano){
	        vida -= dano;
	        if (vida < 0) vida = 0;
        }
        public int GetVida(){
            if(vida<= vida/2){
               vida = 50;
            }
	        return vida;
        }
        public void SetNome(string name){
            string set = name.Trim();
            nome = name;

        }
    }
}
