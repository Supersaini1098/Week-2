using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (points == 4)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}
