// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: DisparoEnemigo
// Descripcion del uso de este codigo:
// *
//Este script se utilizara para que el enemigo pueda lanzar los proyectiles desde un punto especifico a traves de un array para que sean lanzados simultaneamente 
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [SerializeField] Rigidbody2D proyectil;
    [SerializeField] Transform[] bocaCañon;
    [SerializeField] float fuerzaDisparo;
    


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("shoot", 1, 5f);// Shoot es el nombre de la funcion, 1 es el segundo en el que empezaran a lanzar los proyectiles y 5f es el intervalo de tiempo
                                        // en el que tardara para lanzar el siguiente proyectil
    }

    // Update is called once per frame
    void shoot()
    {
        foreach (var bc in bocaCañon) // Se almcanen los datos desde donde seran lanzados los proyectiles multiplicado por la fuerza con la que saldran
        {
            var proyectilPos = Instantiate(proyectil) as Rigidbody2D;

            proyectilPos.transform.position = bc.position;

            proyectilPos.AddForce(bc.right * fuerzaDisparo);
        }
        

    }
    
}
