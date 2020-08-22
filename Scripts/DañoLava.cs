// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: DañoLava
// Descripcion del uso de este codigo:
// *
//Este script se utilizara para disminuirle vida al personaje cada vez que toque la lava  
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoLava : MonoBehaviour
{
    
    [SerializeField]
    SpriteRenderer spriteLava;

    [SerializeField]
    PlayerControl playerVida;


    private void Start()
    {
        spriteLava = GameObject.Find("Lava1").GetComponent<SpriteRenderer>(); //Busca al objeto llamado "Lava1" y le asigna el componente SpriteRenderer
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")       //Si colisiona con el objeto con el Tag "Player" sucedera las siguientes acciones 
        {
            playerVida.vida--;                          //La vida del "Player" disminuira cada vez que toque la Lava
            if (playerVida.vida <= 0) //Es un condicionante, cuando la vida del jugador llegue a 0 el jugador se hace invisible en la escena del juego
            {
                playerVida.spritePlayer.enabled = false; 
            }

        }
    }
}
