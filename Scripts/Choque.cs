// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: Choque
// Descripcion del uso de este codigo:
// *
//Este script se utilizara para disminuirle vida al personaje cada vez que toque a los armadillos
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque : MonoBehaviour
{
    

    [SerializeField]
    SpriteRenderer spriteArmadillo;

   [SerializeField]
    PlayerControl playerVida;

    private void Start()
    {
        spriteArmadillo = GameObject.Find("armadillo1").GetComponent<SpriteRenderer>(); //Busca al objeto llamado "armadillo1" y le asigna el componente SpriteRenderer



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") //Si colisiona con el objeto con el Tag "Player" sucedera las siguientes acciones
        {
            playerVida.vida--;    //La vida del "Player" disminuira cada vez que toque a cualquiera de los armadillos de la escena
            if (playerVida.vida == 0) //Es un condicionante, cuando la vida del jugador llegue a 0 el jugador se hace invisible en la escena del juego
            {
                playerVida.spritePlayer.enabled = false;
            }

        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            playerVida.vida--;  //La vida del "Player" disminuira
            Destroy(this.gameObject); // Se destruira el objeto 
        }
    }

    


}
