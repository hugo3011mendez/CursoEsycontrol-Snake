using Microsoft.AspNetCore.Components.Web;

namespace Snake.Pages
{
    public class SnakeObject : Props // Este objeto representa a la serpiente que el usuario controla en el juego
    {
        public int Velocidad { get; set; } // Para la velocidad a la que se mueve
        public int Nivel { get; set; } // Para el nivel de de dificultad
        public int Puntuacion { get; set; } // Indica la puntuación que tiene el jugador

        public SnakeObject(int velocidad, int nivel) // Constructor con parámetros
        {
            Nivel = nivel;
            Velocidad = velocidad;

            // Posición inicial
            PosX = 0;
            PosY = 0;

            // Tamaño por defecto
            SizeX = 4;
            SizeY = 10;
        }


        public void moveUp(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyUp")
            {
                PosY++;
            }
        }

        public void moveDown(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyDown")
            {
                PosY--;
            }
        }

        public void moveRight(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyRight")
            {
                PosX++;
            }
        }

        public void moveLeft(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyLeft")
            {
                PosX--;
            }
        }
    }  
}
