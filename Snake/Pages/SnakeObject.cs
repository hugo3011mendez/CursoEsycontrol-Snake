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


        // Funciones de movimiento :
        public void moveUp(KeyboardEventArgs e) // Movimiento hacia arriba
        {
            if (e.Key == "vbKeyUp")
            {
                PosY++;
            }
        }
        public void moveDown(KeyboardEventArgs e) // Movimiento hacia abajo
        {
            if (e.Key == "vbKeyDown")
            {
                PosY--;
            }
        }
        public void moveRight(KeyboardEventArgs e) // Movimiento hacia la derecha
        {
            if (e.Key == "vbKeyRight")
            {
                PosX++;
            }
        }
        public void moveLeft(KeyboardEventArgs e) // Movimiento hacia la izquierda
        {
            if (e.Key == "vbKeyLeft")
            {
                PosX--;
            }
        }


        public void eatApple() // Acciones a realizar cuando la serpiente come una manzana
        {
            SizeY++; // Aumento su tamaño un poco
        }
    }  
}
