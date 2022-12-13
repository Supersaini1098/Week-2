using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel3 : MonoBehaviour
{

    public CoinCollect cC;
    

    // Update is called once per frame
    void Update()
    {
        if (cC.points == 1)
        {
            Debug.Log("Works");
            //SceneManager.LoadScene(3);
        }
    }
}
