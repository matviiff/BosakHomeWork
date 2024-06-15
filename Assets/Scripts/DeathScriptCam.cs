using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScriptCam : MonoBehaviour

{
    public GameObject Cameras;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Death")) ;
        {
            Destroy(Cameras);
        }

    }
}
