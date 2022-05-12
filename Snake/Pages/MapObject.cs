using System;
using System.ComponentModel.DataAnnotations;

namespace Snake.Pages
{
    public class MapObject
    {
        // Hace referencia a las dimensiones en px del mapa, que será este número tanto para el eje X como el eje Y
        [Range(100, 800)] // Establezco un rango para el tamaño del mapa, para que no sea ni muy pequeño ni muy grande
        public int Size { get; set; }

        public MapObject(int size) // Constructor, pasándole el tamaño del mapa como parámetro
        {
            Size = size;
        }

        public MapObject() // Constructor vacío, por si el usuario no escribe ningún tamaño
        {
            Size = 400;
        }

        public void TableCreate()
        {
            string[,] names = new string[Size, Size];

            for (int i = 0;i<names.Length;i++)
            {

                for (int z = 0; z < names.Length; z++)
                {

                    names[i,z] = "X";

                }
            }

            
        }



    }
}
