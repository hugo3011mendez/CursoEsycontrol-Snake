namespace Snake.Pages
{
    public class AppleObject : Props // Este objeto representa a la manzana que la serpiente debe comer y así ganar más puntuación
    {
        public AppleObject(int x, int y) // Constructor con su posición como parámetro
        {
            PosX = x;
            PosY = y;

            // Se le establece un tamaño por defecto, las manzanas siempre serán del mismo tamaño
            SizeX = 5;
            SizeY = 5;
        }
    }
}
