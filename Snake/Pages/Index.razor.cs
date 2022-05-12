using System;
using Microsoft.AspNetCore.Components;

namespace Snake.Pages
{
    public partial class Index : ComponentBase
    {
        private static MapObject mapa = new(); // Primero el mapa se creará en su tamaño por defecto, 400px
        private int _mapSize = mapa.Size; // Al inicio de la página establezco el tamaño del contenero al tamaño del mapa

        private void MapOnInvalidSubmit() // En el caso de que el usuario haya introducido un valor inválido
        {
            mapa.Size = _mapSize; // Vuelvo a establecer el valor del tamaño del mapa al último escrito válido
        }

        private void MapOnValidSubmit() // En el caso de que el valor introducido sea uno válido
        {
            _mapSize = mapa.Size; // Actualizo la variable a ese valor y por lo tanto, se actualizará el tamaño del mapa
        }


        private static SnakeObject snake = new(1);
        private int @_levelSnake = snake.Dificultad;
        private void SnakeOnInvalidSubmit() // En el caso de que el usuario haya introducido un valor inválido
        {
            snake.Dificultad = _levelSnake; // Vuelvo a establecer el valor del tamaño del mapa al último escrito válido
        }

        private void SnakeOnValidSubmit() // En el caso de que el valor introducido sea uno válido
        {
            _levelSnake = snake.Dificultad; // Actualizo la variable a ese valor y por lo tanto, se actualizará el tamaño del mapa
        }


        private static Random rnd = new(); // Un generador de números aleatorios
        // Creo una instancia del objeto AppleObject llamando a su constructor y metiéndole parámetros                                           
        private AppleObject manzana = new(rnd.Next(1, mapa.Size), rnd.Next(1, mapa.Size), "red");

        private string _textoBotonIniciar = "Iniciar partida"; // Referente al texto que se mostrará en el botón
    }
}
