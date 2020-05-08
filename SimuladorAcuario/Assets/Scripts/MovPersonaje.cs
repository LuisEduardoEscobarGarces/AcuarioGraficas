using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed; //10
    //para limitar velocidad
    public float maxSpeed; //20
    //para que rote con la camara
    public GameObject referencia;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");
        //para limitar velocidad
        if (rb.velocity.magnitude > maxSpeed) {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
        //aplicar la fuerza que se crea
        rb.AddForce(moverVertical * referencia.transform.forward * speed);
        rb.AddForce(moverHorizontal * referencia.transform.right * speed);
    }
}
