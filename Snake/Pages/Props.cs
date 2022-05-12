namespace Snake.Pages
{
    /// <summary> Clase padre de la que heredarán los diferentes props del juego, como la serpiente y la manzana </summary>
    public class Props
    {
        /// <summary> Posición inicial en el eje X del prop, en píxeles </summary>
        public int PosX { get; set; }
        /// <summary> Posición inicial en el eje Y del prop, en píxeles </summary>
        public int PosY { get; set; }

        /// <summary> Tamaño del prop en el eje X, en píxeles </summary>
        public int SizeX { get; set; } 
        /// <summary> Tamaño del prop en el eje Y, en píxeles </summary>
        public int SizeY { get; set; }        
    }
}
