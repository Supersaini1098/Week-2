using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    Animator anim;
    public KeyCollect script;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DoorAnimation();
    }

    void DoorAnimation()
    {
        if (script.points == 1)
        {
            anim.SetBool("Opened", true);
        }
       
    }
}
