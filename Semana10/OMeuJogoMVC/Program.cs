using System;

namespace OMeuJogo
{
    class Program
    {
        static void Main(string[] args)
        {
          Inimigo[] er;

        // Criar o controlador, passando uma referência aos elementos do modelo
          InimigoController controller = new InimigoController(er);

    // Criar a view, passando uma referência ao controlador
          View view = new View(controller);

    // Correr o jogo, passando uma referência da view ao controlador
          controller.Iniciar(view);


        }
    }
}
