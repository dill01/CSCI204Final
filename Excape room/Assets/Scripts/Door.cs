using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpen;
    public bool complete;
    public GameObject Doorup;
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = Doorup.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOpen)
        {
            if (complete)
            {
                slideDoor(true);
            }
        }
    }

    void slideDoor(bool state)
    {
        Anim.SetBool("slide", state);
    }

    
}
