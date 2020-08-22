// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: MainMenu
// Descripcion del uso de este codigo:
// *
//Este script se utilizara para cargar el nivel 1 del juego, se utiliza en el menu principal
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EscenaNivel1()
    {
        SceneManager.LoadScene("Nivel 1"); // Cuando se presione el boton de jugar se cargara la escena "Nivel 1" y comenzara el juego
    }
}
