using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera fpsCamera;
    public float horizontalSpeed;
    public float verticalSpeed;

    float h;
    float v;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");
        //para aplicarlo en horizontal
        transform.Rotate(0, h, 0);
        //para aplicarlo en vertical
        fpsCamera.transform.Rotate(-v, 0, 0);
    }
}
