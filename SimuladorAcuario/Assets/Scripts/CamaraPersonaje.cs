using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject personaje;
    public GameObject referencia;
    //la distancia que tendra la camara con el jugador
    private Vector3 distancia;

    void Start()
    {
        //posicion de la camara, menos para la posición del jugador
        distancia = transform.position - personaje.transform.position;
    }

    // Update is called once per frame
    //se ejecuta despues de cada frame para ver si el jugador se movio
    void LateUpdate()
    {
        //rotar con respecto al mouse
        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 8, Vector3.up) * distancia;
        //decirle a la camara que cambie su pos con respecto a la pos del jugador, mas la distancia a respetar
        transform.position = personaje.transform.position + distancia;
        //va a mirar hacia el objetivo
        transform.LookAt(personaje.transform.position);

        //referencia para que los controles no cambien
        Vector3 copiarRotacion = new Vector3(0, transform.eulerAngles.y, 0);
        referencia.transform.eulerAngles = copiarRotacion;
    }
}
