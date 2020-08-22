// Nombre del desarrollador: Armando Michel Flores Sanchez
// Asignatura: Estructura de datos
// Profesor: Josue Israel Rivas Diaz
// Nombre de codigo: Reloj
// Descripcion del uso de este codigo:
// *
//Este script se utilizara para generar un reloj en la parte superior central que mostrara el tiempo que llevas en el nivel
// *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    public int tiempoInicial;

    public float escalaDeTiempo =1;

    private Text myText;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoEnSegundosAMostrar = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    private bool estaPausado = false;



    // Start is called before the first frame update
    void Start()
    {
        //Establecer la escala de tiempo original
        escalaDeTiempoInicial = escalaDeTiempo;

        //Se obtiene el componente Text
        myText = GetComponent<Text>();

        //Inicializamos la variable que acumula los tiempos de cada frame con el tiempo inicial
        tiempoEnSegundosAMostrar = tiempoInicial;

        actualizarReloj(tiempoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        //La siguiente variable representa el tiempo de cada frame considerando la escala de tiempo
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;

        //La siguiente variable va acumulando el tiempo transcurrido para luego mostrarlo en el reloj
        tiempoEnSegundosAMostrar += tiempoDelFrameConTimeScale;
        actualizarReloj(tiempoEnSegundosAMostrar);
    }

    public void actualizarReloj(float tiempoenSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        //Se asegura que el tiempo no sea negativo
        if (tiempoenSegundos < 0) tiempoenSegundos = 0;

        //Calcular minutos y segundos
        minutos = (int)tiempoenSegundos / 60;
        segundos = (int)tiempoenSegundos % 60;

        //Crear la cadena de caracteres con 2 digistos para los minutos y segundos, separados por ":"
        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        //Actualizar el elemento de text de UI con la cadena de caracteres
        myText.text = textoDelReloj;
    }
}
