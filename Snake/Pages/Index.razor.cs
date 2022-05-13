using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Snake.Pages
{
    public partial class Index : ComponentBase
    {
        /// <summary> Mapa donde se jugará la partida </summary>
        private static MapObject mapa = new(); // Primero el mapa se creará en su tamaño por defecto, 40 casillas
        /// <summary> Variable auxiliar que controla para que la propiedad Size del mapa tenga un valor correcto </summary>
        private int _mapSize = mapa.Size; // Al inicio de la página establezco el tamaño del contenedor al tamaño del mapa
        private string _colorCasilla = "transparent"; // Establezco el color inicial a transparent

        /// <summary> Acciones a realizar en el caso de que el usuario haya introducido un tamaño de mapa inválido </summary>
        private void MapOnInvalidSubmit()
        {
            mapa.Size = _mapSize; // Vuelvo a establecer el valor del tamaño del mapa al último escrito válido
        }

        /// <summary> Acciones a realizar en el caso de que el usuario haya introducido un tamaño de mapa válido </summary>
        private void MapOnValidSubmit()
        {
            _mapSize = mapa.Size; // Actualizo la variable a ese valor y por lo tanto, se actualizará el tamaño del mapa
            mapa.Casillas = new string[mapa.Size-2, mapa.Size]; // Actualizo el array de casillas
        }


        /// <summary> Serpiente que controlará el jugador </summary>
        private static SnakeObject snake = new(mapa.Size); // La creo por defecto con el nivel de dificultad 1


        private static Random rnd = new(); // Un generador de números aleatorios
        // Creo una instancia del objeto AppleObject llamando a su constructor y metiéndole parámetros                                           
        private AppleObject manzana = new(rnd.Next(0, mapa.Casillas.GetLength(0)), rnd.Next(0, mapa.Casillas.GetLength(1)));

        private string _textoBotonIniciar = "Iniciar partida"; // Referente al texto que se mostrará en el botón

        private void startGame(SnakeObject snake, AppleObject manzana)
        {

        }
    }
}
