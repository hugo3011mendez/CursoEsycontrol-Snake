namespace Snake.Pages
{
    public class MapObject
    {
        // Hace referencia a las dimensiones en px del mapa, que será este número tanto para el eje X como el eje Y
        public int Size { get; set; }

        public MapObject(int size) // Constructor, pasándole el tamaño del mapa como parámetro
        {
            Size = size;
        }

        public MapObject() // Constructor vacío, por si el usuario no escribe ningún tamaño
        {
            Size = 400;
        }

        private void TableCreate(int Size)
        {
            string[,] names = new string[Size, Size];

            for (int i = 0;i<names.Length;i++)
            {

                for (int z = 0; z < names.Length; z++)
                {

                    names[i,z] = " ";

                }
            }


        }



    }
}
