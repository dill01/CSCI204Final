using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOneGame : MonoBehaviour
{
    private int progression;
    //public bool CellLockPanelFlag = false;
    public GameObject WireOneBrokeTop;
    public GameObject WireOneBrokeBottom;
    public GameObject WireTwoBrokeTop;
    public GameObject WireTwoBrokeBottom;
    public GameObject WireThreeBrokeTop;
    public GameObject WireThreeBrokeBottom;
    public GameObject WireFourBrokeTop;
    public GameObject WireFourBrokeBottom;
    public GameObject CellLockPanel;
    public GameObject CellDoor;
    Animator CellLockPanelAnim, CellDoorAnim;
    // Start is called before the first frame update
    void Start()
    {
        CellLockPanelAnim = CellLockPanel.GetComponent<Animator>();
        CellDoorAnim = CellDoor.GetComponent<Animator>();
        CellLockPanelAnim.SetBool("Slide", false);
        CellDoorAnim.SetBool("Slide", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void interact(string inString)
    {
        if (inString == "CellLockPanel")
        {
            Debug.Log("animation started");
            CellLockPanelAnim.SetBool("Slide", true);
        }
        else if (inString == "Wire 1")
        {
            Debug.Log("wire 1 is wrong");
            WireOneBrokeTop.SetActive(true);
            WireOneBrokeBottom.SetActive(true);
        }
        else if (inString == "Wire 2")
        {
            Debug.Log("wire 2 is wrong");
            WireTwoBrokeTop.SetActive(true);
            WireTwoBrokeBottom.SetActive(true);
        }
        else if (inString == "Wire 3")
        {
            Debug.Log("wire 3 is correct");
            WireThreeBrokeTop.SetActive(true);
            WireThreeBrokeBottom.SetActive(true);
            CellDoorAnim.SetBool("Slide", true);
        }
        else if (inString == "Wire 4")
        {
            Debug.Log("wire 4 is wrong");
            WireFourBrokeTop.SetActive(true);
            WireFourBrokeBottom.SetActive(true);
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

