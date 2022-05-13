using System;

namespace Snake.Pages
{
    /// <summary>Este objeto representa a la manzana que la serpiente debe comer y así ganar más puntuación.
    /// Hereda de Props e implementa la interfaz IDisposable</summary>
    public class AppleObject : Props, IDisposable 
    {
        /// <summary> Constructor con sus parámetros representando su posición </summary>
        public AppleObject(int x, int y)
        {
            PosX = x;
            PosY = y;

            // Tamaño por defecto de 1 casilla
            SizeX = 1;
            SizeY = 1;
        }

        public void CrearManzana(int mapax,int mapay){
            this.Dispose();

            AppleObject manzana = new AppleObject(mapax,mapay);
        }

        public void Dispose(){}
    }
}
