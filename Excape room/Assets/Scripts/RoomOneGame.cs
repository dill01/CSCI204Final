using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOneGame : MonoBehaviour
{
    private int progression;
    public bool CellLockPanelFlag;

    GameObject CellLockPanel;
    GameObject CellDoor;
    Animator CellLockPanelAnim, CellDoorAnim;
    // Start is called before the first frame update
    void Start()
    {
        CellLockPanelAnim = CellLockPanel.GetComponent<Animator>();
        CellDoorAnim = CellDoor.GetComponent<Animator>();
        CellLockPanelFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CellLockPanelFlag == true)
        {
            CellLockPanelAnim.SetBool("Slide", true);
        }
    }

    public void setFlag(bool inFlag)
    {
        inFlag = true;
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


        }
        else if (hmm == 2)
        {

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

