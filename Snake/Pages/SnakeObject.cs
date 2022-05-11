namespace Snake.Pages
{
    public class SnakeObject : Props
    {

        public int Velocidad { get; set; }
        public int Longitud { get; set; }

        public SnakeObject(int velocidad)
        {
            Velocidad = velocidad;
            PosX = 0;
            PosY = 0;

            // Tamaño por defecto
            SizeX = 4;
            SizeY = 10;
        }
    }
}
