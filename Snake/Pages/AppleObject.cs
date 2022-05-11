namespace Snake.Pages
{
    public class AppleObject : Props
    {
        public AppleObject(int x, int y)
        {
            PosX = x;
            PosY = y;

            // Se le establece un tamaño por defecto, las manzanas siempre serán del mismo tamaño
            SizeX = 5;
            SizeY = 5;
        }
    }
}
