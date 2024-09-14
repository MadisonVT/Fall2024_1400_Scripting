using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves GameObject
        var x = Mathf.PingPong(Time.time, 1);
        var p = new Vector3(0, 0, x);
        transform.position = p;
        //Rotates GameObject
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
    }
}
