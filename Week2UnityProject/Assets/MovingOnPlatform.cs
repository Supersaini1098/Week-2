using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingOnPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        
        other.transform.SetParent(transform);
    }

    void OnTriggerExit(Collider other)
    {

        other.transform.SetParent(null);

    }
}
