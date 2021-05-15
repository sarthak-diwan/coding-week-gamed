using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speed;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");

        // transform.Translate(h*speed*Time.deltaTime*-1,0,v*speed*Time.deltaTime*-1*3);
        transform.Translate(h*speed*Time.deltaTime*-1,0,0);
        transform.Translate(0,0,speedY*Time.deltaTime*-1*3);
        speedY+=0.0001f;
    }
}
