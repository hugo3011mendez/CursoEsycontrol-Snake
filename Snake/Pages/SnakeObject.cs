using Microsoft.AspNetCore.Components.Web;
using System.Timers;
using System.ComponentModel.DataAnnotations;

namespace Snake.Pages
{
    /// <summary>Representa a la serpiente que el usuario controla en el juego</summary>
    public class SnakeObject : Props
    {
        /// <summary> Indica la puntuación que tiene el jugador </summary>
        public int Puntuacion { get; set; }

        /// <summary> Booleano indicando si se acabó el juego </summary>
        public bool GameOver = false;

        /// <summary> Temporizador que repite el movimiento cada 100ms </summary>
        private Timer movementTimer = new();

        private int[,] tail;


        /// <summary> Constructor de la serpiente </summary>
        /// <param name="size">Tamaño del mapa</param>
        public SnakeObject(int size) // Constructor con parámetros
        {
            // Posición inicial, según el tamaño del mapa, pasado como parámetro
            PosX = size/2;
            PosY = size/2;

            // Tamaño por defecto
            SizeX = 1;
            SizeY = 3;

            //Cola de la serpiente
            tail = new int[size, size];

            movementTimer.Start(); //Inicio el temporizador
        }


        /// <summary> Movimiento en el eje vertical </summary>
        /// <param name="e"></param>
        public void moveY(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyUp") // Movimiento hacia arriba
            {
                PosY++;
            }

            if (e.Key == "vbKeyDown") // Movimiento hacia abajo
            {
                PosY--;
            }
        }

        /// <summary> Movimiento en el eje horizontal </summary>
        /// <param name="e"></param>
        public void moveX(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyRight") // Movimiento hacia la derecha
            {
                PosX++;
            }

            if (e.Key == "vbKeyLeft") // Movimiento hacia la izquierda
            {
                PosX--;
            }
        }


        /// <summary> Detecta la colision de la serpiente con los bordes del mapa o consigo misma </summary>
        /// <param name="mapSize"> Tamaño del mapa </param>
        /// <returns> Booleano indicando si el juego se ha acabado </returns>
        public bool hasCollide(int mapSize)
        {
            if(PosX < 0 || PosX > mapSize || PosY < 0 || PosY > mapSize)
            {
                GameOver = true;
            }

            for(int i=0; i<mapSize; i++)
            {
                for(int j=0; j<mapSize; j++)
                {
                    if(tail[i,j] == 1 && PosX==i && PosY==j)
                    {
                        GameOver = true;
                    }
                }
            }

            return GameOver;
        }

        /*
        public void generateTail(int [,] tail, int posY)
        {
            for(int y=-1; y<-4; y--)
            {
                tail[] = 1;
            }
        }*/

        /// <summary> Acciones a realizar cuando la serpiente come una manzana </summary>
        public void eatApple()
        {
            SizeY++; // Aumento su tamaño en 1 casilla
        }
    }  
}
