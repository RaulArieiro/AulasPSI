using System;

namespace BCPropriedades
{
    public class Cor
    {
        // Variáveis que representam estado  de uma instância de Cor
        
        public int Red{get; set;}
        public int Green{get; set;}
        public int Blue{get; set;}
        public int Alpha{get; set;}
        

        // Construtor que aceita todos os parâmetros necessários para
        // inicializar o estado de uma Cor
        public Cor(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        // Construtor que aceita parâmetros RGB e define alpha com
        // o valor máximo
        public Cor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = byte.MaxValue;
        }

        // Getter que retorna o grau de cinzento da cor
        public int GetCinzento()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}