// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: MovimientoEnemigo
// Descripcion del uso de este codigo:
// *
//Este script se utilizara para generer el alcance, la velocidad y los movimientos de los armadillos
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    [SerializeField]
    Transform[] armadillo;

    [SerializeField]
    Vector3[] posicionInicial;

    private float velocidad = 1.5f; //La velocidad en que se moveran los armadillos
    private float extension = 1.0f;  //El alcance que tiene los armadillos para moverse en el eje X
    
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = new Vector3[armadillo.Length];

        for (int i = 0; i < armadillo.Length; i++) // Crea un array donde se guarda la posicion inicial de los enemigos
        {
            posicionInicial[i]= armadillo[i].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 senoPos = new Vector3(Mathf.Sin(Time.time * velocidad) * extension, 0, 0);  // A cada armadillo se le agrega velocidad y extension de su movimiento en el eje X
                                                                                            //segun su posicion inicial

        for (int i = 0; i < armadillo.Length; i++)
        {
            armadillo[i].position = posicionInicial[i] + senoPos;
        }
    }
}
