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

      
    }

    public int Getprogression()
    {
        return progression;
    }
    
}
