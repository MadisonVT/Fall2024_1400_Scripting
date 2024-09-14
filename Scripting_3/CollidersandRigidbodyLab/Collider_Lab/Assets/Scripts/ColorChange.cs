using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.magenta;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = newColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
