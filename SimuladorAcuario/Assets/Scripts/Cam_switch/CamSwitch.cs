using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera FpsCam;
    public Camera TpsCam;
    bool fpsCam = true;

    void Start()
    {
        FpsCam.enabled = false;
        TpsCam.enabled = !fpsCam;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //fps =  false
            fpsCam = !fpsCam;
            //primera persona es true
            FpsCam.enabled = fpsCam;
            //tercera persona es false
            TpsCam.enabled = !fpsCam;
            fpsCam = !fpsCam;
   
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            TpsCam.enabled = false;
        }
    
    }
}
