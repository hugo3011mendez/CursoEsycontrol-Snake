using Microsoft.AspNetCore.Components.Web;

namespace Snake.Pages
{
    public class SnakeObject : Props
    {
        
        public SnakeObject()
        {
            PosX = 0;
            PosY = 0;

            // Tamaño por defecto
            SizeX = 4;
            SizeY = 10;
        }

        public void moveUp(KeyboardEventArgs e)
        {
            if(e.Key == "vbKeyUp")
            {
                Y++;
            }
        }

        public void moveDown(KeyboardEventArgs e)
        {
            if(e.Key == "vbKeyDown")
            {
                Y--;
            }
        }

        public void moveRight(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyRight")
            {
                X++;
            }
        }

        public void moveLeft(KeyboardEventArgs e)
        {
            if (e.Key == "vbKeyLeft")
            {
                X--;
            }
        }
    }
}
