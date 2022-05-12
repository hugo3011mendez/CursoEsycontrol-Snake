using System;
using System.ComponentModel.DataAnnotations;

namespace Snake.Pages
{
    /// <summary> Representa al mapa sobre el que se va a jugar la partida </summary>
    public class MapObject
    {
        // Hace referencia a las dimensiones en px del mapa, que será este número tanto para el eje X como el eje Y
        [Range(100, 800)] // Establezco un rango para el tamaño del mapa, para que no sea ni muy pequeño ni muy grande
        public int Size { get; set; }

       public  string[,] casillas { get; set; }

        /// <summary> Constructor pasándole su tamaño como parámetro </summary>
        /// <param name="size">Tamaño del mapa, en píxeles</param>
        public MapObject(int size)
        {
            Size = size;
            string[,] casillas = new string[size, size];
        }

        /// <summary> Constructor vacío, por si el usuario no escribe ningún tamaño </summary>
        public MapObject()
        {
            Size = 400;
            string[,] casillas = new string[Size, Size];
        }

      



    }
}
