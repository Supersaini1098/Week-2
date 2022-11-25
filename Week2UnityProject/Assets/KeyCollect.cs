using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public int points = 0;
    public bool keyCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        if(points == 1)
        {
            GUI.Label(new Rect(10, 20, 100, 20), "Key Collected!");
            keyCollected = true;
        }
        else
        {
            GUI.Label(new Rect(10, 20, 500, 20), "Key Not Collected");
        }
        
    }
}
