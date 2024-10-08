using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingForward : MonoBehaviour
{
    public float speed = 35.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
