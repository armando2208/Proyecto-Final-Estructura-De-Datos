// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: NuevoJuego
// Descripcion del uso de este codigo:
// *
//Este script se utilizara cuando el personaje llegue a la escena final pueda regresar al menu principal para iniciar un nuevo juego
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NuevoJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaMenu()  
    {
        SceneManager.LoadScene("Menu"); //Cuando se presiones el boton de Menu que se encuentra en la escena final, va a carga la escena Menu 
                                        //Llevandolo al menu principal para poder inicar un nuevo juego 
    }
}
