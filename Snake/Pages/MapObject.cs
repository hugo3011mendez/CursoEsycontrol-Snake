using System;
using System.ComponentModel.DataAnnotations;

namespace Snake.Pages
{
    /// <summary> Representa al mapa sobre el que se va a jugar la partida </summary>
    public class MapObject
    {
        // Hace referencia a las dimensiones en casillas del mapa, que será este número tanto para el eje X como el eje Y
        [Range(10, 100)] // Establezco un rango para el tamaño del mapa, para que no sea ni muy pequeño ni muy grande
        public int Size { get; set; }

        /// <summary> Representa las casillas del mapa, que serán divs de 10x10 px </summary>
        public string[,] Casillas { get; set; }

        /// <summary> Enumerado para saber qué color debe pintarse en la casilla correspondiente </summary>
        enum Colores
        {
            Vacío = 0, // Para las casillas vacías
            Snake = 1, // Para la serpiente
            Apple = 2, // Para la manzana
        }


        /// <summary> Constructor pasándole su tamaño como parámetro </summary>
        /// <param name="size">Tamaño del mapa, en píxeles</param>
        public MapObject(int size)
        {
            Size = size;
            Casillas = new string[Size, Size];
        }

        /// <summary> Constructor vacío, por si el usuario no escribe ningún tamaño </summary>
        public MapObject()
        {
            Size = 40;
            Casillas = new string[Size, Size];
        }

    }
}
