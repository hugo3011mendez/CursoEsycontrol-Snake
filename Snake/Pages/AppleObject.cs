using System;

namespace Snake.Pages
{
    /// <summary>Este objeto representa a la manzana que la serpiente debe comer y así ganar más puntuación.
    /// Hereda de Props e implementa la interfaz IDisposable</summary>
    public class AppleObject : Props, IDisposable 
    {
        /// <summary>Referente al color de la manzana, que lo aplicaremos via CSS</summary>
        public string Color { get; set; }

        /// <summary>Constructor con su posición y su color como parámetros</summary>
        public AppleObject(int x, int y, string color)
        {
            PosX = x;
            PosY = y;
            Color = color;

            // Se le establece un tamaño por defecto, las manzanas siempre serán del mismo tamaño
            SizeX = 5;
            SizeY = 5;
        }

        public void Dispose(){}
    }
}
