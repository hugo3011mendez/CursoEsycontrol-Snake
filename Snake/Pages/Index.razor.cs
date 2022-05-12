using System;
using Microsoft.AspNetCore.Components;

namespace Snake.Pages
{
    public partial class Index : ComponentBase
    {
        /// <summary> Mapa donde se jugará la partida </summary>
        private static MapObject mapa = new(); // Primero el mapa se creará en su tamaño por defecto, 40 casillas
        /// <summary> Variable auxiliar que controla para que la propiedad Size del mapa tenga un valor correcto </summary>
        private int _mapSize = mapa.Size; // Al inicio de la página establezco el tamaño del contenedor al tamaño del mapa

        /// <summary> Acciones a realizar en el caso de que el usuario haya introducido un tamaño de mapa inválido </summary>
        private void MapOnInvalidSubmit()
        {
            mapa.Size = _mapSize; // Vuelvo a establecer el valor del tamaño del mapa al último escrito válido
        }

        /// <summary> Acciones a realizar en el caso de que el usuario haya introducido un tamaño de mapa válido </summary>
        private void MapOnValidSubmit()
        {
            _mapSize = mapa.Size; // Actualizo la variable a ese valor y por lo tanto, se actualizará el tamaño del mapa
        }


        /// <summary> Serpiente que controlará el jugador </summary>
        private static SnakeObject snake = new(1); // La creo por defecto con el nivel de dificultad 1
        /// <summary> Variable auxiliar que controla para que la propiedad Dificultad de la serpiente tenga un valor correcto </summary>
        private int _levelSnake = snake.Dificultad;

        /// <summary> Acciones a realizar en el caso de que el usuario haya introducido una dificultad inválida </summary>
        private void SnakeOnInvalidSubmit()
        {
            snake.Dificultad = _levelSnake; // Vuelvo a establecer la dificultad al último escrito válido
        }

        /// <summary> Acciones a realizar en el caso de que el usuario haya introducido una dificultad válida </summary>
        private void SnakeOnValidSubmit() // En el caso de que el valor introducido sea uno válido
        {
            _levelSnake = snake.Dificultad; // Actualizo la variable a ese valor y por lo tanto, se actualizará la dificultad
        }


        private static Random rnd = new(); // Un generador de números aleatorios
        // Creo una instancia del objeto AppleObject llamando a su constructor y metiéndole parámetros                                           
        private AppleObject manzana = new(rnd.Next(1, mapa.Size), rnd.Next(1, mapa.Size), "red");

        private string _textoBotonIniciar = "Iniciar partida"; // Referente al texto que se mostrará en el botón
    }
}
