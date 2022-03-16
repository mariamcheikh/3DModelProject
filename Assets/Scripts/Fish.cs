using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    // rotate the Fish
    void Update()
    {
        transform.Rotate(0, Time.deltaTime*15, 0);
        
    }
}
