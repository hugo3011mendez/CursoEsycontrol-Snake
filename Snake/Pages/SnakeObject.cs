namespace Snake.Pages
{
    public class SnakeObject : Props
    {

        public int Velocidad { get; set; }
        public int Nivel { get; set; }
        public int Puntos { get; set; }

        public SnakeObject(int velocidad,int nivel)
        {
            Nivel = nivel;
            Velocidad = velocidad;
            PosX = 0;
            PosY = 0;

            // Tamaño por defecto
            SizeX = 4;
            SizeY = 10;
        }




       
}
