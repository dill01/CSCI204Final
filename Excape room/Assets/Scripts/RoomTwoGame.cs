using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTwoGame : MonoBehaviour
{
    private int progression;
    public GameObject Doorup;
    public GameObject LeftWall;
    public GameObject RightWall;
    Animator DoorAnim, RightAnim, LeftAnim;
    // Start is called before the first frame update
    void Start()
    {
        DoorAnim = Doorup.GetComponent<Animator>();
        LeftAnim = LeftWall.GetComponent<Animator>();
        RightAnim = RightWall.GetComponent<Animator>();
        LeftAnim.SetBool("Close", true);
        RightAnim.SetBool("Close", true);
        progression = 0;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void progress()
    {
        Debug.Log("I added a number");
        progression++;
        Debug.Log("Progesstion is now " + progression);
        int hmm = progression;
        if (hmm == 1)
        {
            Debug.Log("wtf dude");
            LeftAnim.SetBool("Close", false);
            RightAnim.SetBool("Close", false);
            LeftAnim.SetBool("Open", true);
            RightAnim.SetBool("Open", true);

        }
        else if (hmm == 2)
        {
            DoorAnim.SetBool("Slide", true);
        }
        else if (hmm == 3)
        {

        }
        else if (hmm == 4)
        {

        }

    }

    public int Getprogression()
    {
        return progression;
    }
    
}
