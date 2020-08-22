// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: VidaExtra
// Descripcion del uso de este codigo:
// *
//Este script se utilizara para generar una vida extra al jugador y que se destruya el objeto despues de darle la vida extra  
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaExtra : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    PlayerControl playerVida;

    [SerializeField]
    SpriteRenderer spriteVida;

    private int ActualizacionVida = 1;

    private void Start()
    {
        spriteVida = GameObject.Find("Power Up").GetComponent<SpriteRenderer>(); //Busca al objeto llamado "Power Up" y le asigna el componente SpriteRenderer
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")                      //Si colisiona con el objeto con el Tag "Player" sucedera las siguientes acciones                                                                    
        {
            playerVida.vida = playerVida.vida + ActualizacionVida;     //La vida del jugador se le sumara la ActualizacionVida que en este caso es 1
            ActualizacionVida = 0;                                     //Se actualizara el valor de ActualizacionVida a 0 para que ya no aumente mas vida
            Destroy(this.gameObject);                                  //Se destruira el objeto "Power Up"
        }

    }
}
