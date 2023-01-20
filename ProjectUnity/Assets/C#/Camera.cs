using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour


{
    public Transform Cam;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.position = Cam.position;
    }
}
