using Microsoft.AspNetCore.Components.Web;
using System.Timers;
using System.ComponentModel.DataAnnotations;

namespace Snake.Pages
{
    /// <summary>Representa a la serpiente que el usuario controla en el juego</summary>
    public class SnakeObject : Props
    {
        /// <summary> Representa la velocidad a la que se mueve </summary>
        public int Velocidad { get; set; }

        /// <summary> Representa el nivel de dificultad </summary>
        [Range(1,3)]
        public int Dificultad { get; set; }

        /// <summary> Indica la puntuación que tiene el jugador </summary>
        public int Puntuacion { get; set; }

        public bool gameOver = false;

        private Timer movementTimer = new(); //Creo el temporizador que repite el movimiento cada 100 milisegundos


        public SnakeObject(int nivel, int size) // Constructor con parámetros
        {
            Dificultad = nivel;
            Velocidad = Dificultad * 2; // Así la velocidad dependerá del nivel de la partida

            // Posición inicial
            PosX = size/2;
            PosY = size/2;

            // Tamaño por defecto
            SizeX = 4;
            SizeY = 10;

            movementTimer.Start(); //Inicio el temporizador
        }


        // Funciones de movimiento :
        /// <summary> Movimiento </summary>
        /// <param name="e"></param>
        ///
        public void moveY(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyUp")
            {
                PosY += Velocidad;
            }

            if (e.Key == "vbKeyDown")
            {
                PosY -= Velocidad;
            }
        }

        public void moveX(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyRight")
            {
                PosX += Velocidad;
            }

            if (e.Key == "vbKeyLeft")
            {
                PosX -= Velocidad;
            }
        }


        //Funcion para detectar la colision de la serpiente con los bordes del mapa o consigo misma
        public bool hasCollide(int mapSize)
        {
            if(PosX < 0 || PosX > mapSize || PosY < 0 || PosY > mapSize)
            {
                gameOver = true;
            }

            return gameOver;
        }


        /// <summary> Acciones a realizar cuando la serpiente come una manzana </summary>
        public void eatApple()
        {
            SizeY+=Dificultad; // Aumento su tamaño, dependiendo de la dificultad
        }
    }  
}
