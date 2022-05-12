namespace Snake.Pages
{
    public class AppleObject : Props // Este objeto representa a la manzana que la serpiente debe comer y así ganar más puntuación
    {
        public string Color { get; set; } // Referente al color de la manzana, que lo aplicaremos via CSS
        public AppleObject(int x, int y, string color) // Constructor con su posición como parámetro
        {
            PosX = x;
            PosY = y;
            Color = color;

            // Se le establece un tamaño por defecto, las manzanas siempre serán del mismo tamaño
            SizeX = 5;
            SizeY = 5;
        }
    }
}
