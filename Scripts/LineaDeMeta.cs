// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: LineaDeMeta
// Descripcion del uso de este codigo:
// *
//Este script se utilizara cuando el personaje colisione con la meta lo llevara a la escena final del juego 
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineaDeMeta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //Cuando el player colisione con el objeto Meta, se cargara la siguiente escena del juego
    {
        if (collision.tag=="Player")
        {
            SceneManager.LoadScene("Meta"); //Cuando colisione con el objeto con el Tag "Player" se cargara la escena "Meta" 
        }
    }
}
