﻿using Microsoft.AspNetCore.Components.Web;

namespace Snake.Pages
{
    /// <summary>Representa a la serpiente que el usuario controla en el juego</summary>
    public class SnakeObject : Props
    {
        /// <summary> Representa la velocidad a la que se mueve </summary>
        public int Velocidad { get; set; }

        /// <summary> Representa el nivel de dificultad </summary>
        public int Dificultad { get; set; }

        /// <summary> Indica la puntuación que tiene el jugador </summary>
        public int Puntuacion { get; set; } 

        /// <summary> Constructor con parámetros </summary>
        /// <param name="nivel">Dificultad de la partida</param>
        public SnakeObject(int nivel)
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

        /// <summary> Movimiento hacia arriba </summary>
        /// <param name="e"></param>
        public void moveUp(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyUp")
            {
                PosY+=Velocidad;
            }
        }
        /// <summary> Movimiento hacia abajo </summary>
        /// <param name="e"></param>
        public void moveDown(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyDown")
            {
                PosY-=Velocidad;
            }
        }
        /// <summary> Movimiento hacia la derecha </summary>
        /// <param name="e"></param>
        public void moveRight(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyRight")
            {
                PosX+=Velocidad;
            }
        }
        /// <summary> Movimiento hacia la izquierda </summary>
        /// <param name="e"></param>
        public void moveLeft(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyLeft")
            {
                PosX-=Velocidad;
            }
        }

        /// <summary> Acciones a realizar cuando la serpiente come una manzana </summary>
        public void eatApple() // 
        {
            SizeY+=Dificultad; // Aumento su tamaño, dependiendo de la dificultad
        }
    }  
}
