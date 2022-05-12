using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;

namespace Snake.Pages
{
    public class SnakeObject : Props // Este objeto representa a la serpiente que el usuario controla en el juego
    {
        public int Velocidad { get; set; } // Para la velocidad a la que se mueve
        [Range(1, 3)]
        public int Dificultad { get; set; } // Para el nivel de de dificultad
        public int Puntuacion { get; set; } // Indica la puntuación que tiene el jugador

        public SnakeObject(int nivel) // Constructor con parámetros
        {
            Dificultad = nivel;
            Velocidad = Dificultad * 2; // Así la velocidad dependerá del nivel de la partida

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
                PosY += Velocidad;
            }
        }
        public void moveDown(KeyboardEventArgs e) // Movimiento hacia abajo
        {
            if (e.Key == "vbKeyDown")
            {
                PosY -= Velocidad;
            }
        }
        public void moveRight(KeyboardEventArgs e) // Movimiento hacia la derecha
        {
            if (e.Key == "vbKeyRight")
            {
                PosX += Velocidad;
            }
        }
        public void moveLeft(KeyboardEventArgs e) // Movimiento hacia la izquierda
        {
            if (e.Key == "vbKeyLeft")
            {
                PosX -= Velocidad;
            }
        }


        public void eatApple() // Acciones a realizar cuando la serpiente come una manzana
        {
            SizeY += Dificultad; // Aumento su tamaño, dependiendo de la dificultad
        }
    }
}
