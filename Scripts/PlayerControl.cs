//Nombre del desarrollador: Armando  Michel Flores Sanchez
//Asignatura: Estructura de datos
//Profesor: Josue Israel Rivas Diaz 
//Nombre de codigo: PlayerControl
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar el control del jugador
*/
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{// incio del cuerpo de la clase <summary>

    // +++++++++++area para declarar variables+++++

    //El tipo de dato   nombre de variable
    Rigidbody2D fisicasRB2D;
    // al declarar una variable como publica esta se podra visualizar en el inspector
    public float fuerzaSaltoPersonaje;

    public int vida;

    [SerializeField]
    PlayerControl playerVida;

    //SerializedField cumplr con el muestreo de variables en el inspector pero mantiene su acceso privado
    [SerializeField]
    float velocidadPersonaje;


    public SpriteRenderer spritePlayer;

   

         

    //+++++++++++++++++++++++++++++++++++++++++++++



    // start sirve para inicializar datos, componentes y variables
    // carga todos mis GameObjects, Componentes. acciones, valores o eventos al juego
    void Start()
    {               //lee el componente de cierto tipo
        fisicasRB2D = GetComponent<Rigidbody2D>();
        spritePlayer = GetComponent<SpriteRenderer>();
        fuerzaSaltoPersonaje = 3.0f;
        velocidadPersonaje = 2.0f;
        vida = 3;
        
        
        
    }

    // update sirve para utilizar los datos componentes y variables
    void Update()
    {
        
        // Voy a usar una entrada(Input) utilizo el operador punto para entrar en sus
        //propiedades y eligo una entrada de tecla presionada
        //le indico que va a representar en el mundo real esta entrada
        if (Input.GetKeyDown(KeyCode.Space))
        {                    
                //variable a utilizar, agrega una fuerza,
                //direccion que agrega esa fuerza, la magintud con la que aplicara la fuerza
                //agregar o traducir a un impulso
                fisicasRB2D.AddForce(Vector2.up * fuerzaSaltoPersonaje, ForceMode2D.Impulse);                       
            
        }
        

        //Voy a usar una entrada input GetKey para el movimiento a izquierda y derecha de mi personaje

        if (Input.GetKey(KeyCode.D))
        {      //cambiar la velocidad del personaje de 0 a 1 en x //Lee y manten el valor actual de velocidad en y
            fisicasRB2D.velocity = new Vector2(velocidadPersonaje,fisicasRB2D.velocity.y);
        }


        if (Input.GetKey(KeyCode.A))
        {
            fisicasRB2D.velocity = new Vector2(-velocidadPersonaje, fisicasRB2D.velocity.y);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BolaBoliche") //Si colisiona con el objeto con el Tag "BolaBoliche" sucedera las siguientes acciones 
        {
            playerVida.vida--;        //La vida del "Player" disminuira cada vez que toque cualquier bola de boliche que lanzara nuestro enemigo
            if (playerVida.vida <= 0) //Es un condicionante, cuando la vida del jugador llegue a 0 el jugador se hace invisible en la escena del juego
            {
                playerVida.spritePlayer.enabled = false;
            }
        }
        
    }
    




}// fin del cuerpo de la clase
