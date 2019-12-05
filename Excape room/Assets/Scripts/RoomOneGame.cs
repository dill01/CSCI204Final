using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomOneGame : MonoBehaviour
{
    private int position;
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
    public GameObject BlastDoor;
    public GameObject ForceFieldControlPanel;
    public GameObject ForceField;
    public GameObject ForceFieldParticle;
    public GameObject ForceFieldPuzzle;
    public GameObject ServiceGrate;
    Animator CellLockPanelAnim, CellDoorAnim, BlastDoorAnim, ForceFieldControlPanelAnim, ForceFieldAnim, ForceFieldPuzzleAnim, ServiceGrateAnim;
    // Start is called before the first frame update
    void Start()
    {
        CellLockPanelAnim = CellLockPanel.GetComponent<Animator>();
        CellDoorAnim = CellDoor.GetComponent<Animator>();
        BlastDoorAnim = BlastDoor.GetComponent<Animator>();
        ForceFieldControlPanelAnim = ForceFieldControlPanel.GetComponent<Animator>();
        ForceFieldAnim = ForceField.GetComponent<Animator>();
        ForceFieldPuzzleAnim = ForceFieldPuzzle.GetComponent<Animator>();
        ServiceGrateAnim = ServiceGrate.GetComponent<Animator>();
        CellLockPanelAnim.SetBool("Slide", false);
        CellDoorAnim.SetBool("Slide", false);
        BlastDoorAnim.SetBool("Slide", false);
        ForceFieldControlPanelAnim.SetBool("Slide", false);
        ForceFieldAnim.SetBool("Slide", false);
        ServiceGrateAnim.SetBool("Slide", false);
        position = 1;
        ForceFieldControlPanelAnim.SetInteger("Position", 4);
        ServiceGrateAnim.SetBool("GameOver", false);
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
        else if (inString == "Correct Button")
        {
            Debug.Log("Button 3 is Correct");
            BlastDoorAnim.SetBool("Slide", true);
            
        }
        else if (inString == "Wrong Button")
        {
            Debug.Log("Wrong Button is wrong");
            
        }
        else if (inString == "Panel Switch")
        {
            Debug.Log("opening the thing");
            ForceFieldControlPanelAnim.SetBool("Slide", true);
        }
        else if (inString == "Force Field Rotor")
        {
            Debug.Log("opening the thing");

            if (position == 1)
            {
                Debug.Log("position 1");
                ForceFieldPuzzleAnim.SetInteger("Position", position);
                position++;
            }
            else if (position == 2)
            {
                Debug.Log("Position 2");
                ForceFieldPuzzleAnim.SetInteger("Position", position);
                position++;
            }
            else if (position == 3)
            {
                Debug.Log("Position 3");
                ForceFieldPuzzleAnim.SetInteger("Position", position);
                position++;
            }
            else if (position == 4)
            {
                Debug.Log("Position 4");
                ForceFieldPuzzleAnim.SetInteger("Position", position);
                position++;
            }
            else
            {
                Debug.Log("resetting to position 1");
                position = 1;
            }

        }
        else if (inString == "Force Field Switch" && position == 3)
        {
            Debug.Log("Correct Setting disabling force field");
            ForceFieldAnim.SetBool("Slide", true);
            ForceFieldParticle.SetActive(false);
        }
        else if (inString == "Force Field Switch" && position != 3)
        {
            Debug.Log("wrong try again force field still enabled");
            
        }
        else if (inString == "Service Grate")
        {
            Debug.Log("Room Complete");
            ServiceGrateAnim.SetBool("Slide", true);
            StartCoroutine(waitForSec(5.0f));
            
        }
    }
    private IEnumerator waitForSec(float sec)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene("Room Two");
    }
}

