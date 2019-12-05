using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRaycasting : MonoBehaviour
{

    public float distanceToSee;
    RaycastHit whatIHit;
    Scene test;
    public GameObject Gamecontroller, text;
    

    // Start is called before the first frame update
    void Start()
    {
        test = SceneManager.GetActiveScene();
        text.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
   
        text.SetActive(false);
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);
        if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {

            if (test.name.Equals("Room One"))
            {
                RoomOneGame hmm = Gamecontroller.GetComponent<RoomOneGame>();
                if (whatIHit.collider.CompareTag("Interactable"))
                {
                    text.SetActive(true);
                }                             

                if (whatIHit.collider.gameObject.name == "CellLockPanel" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("CellLockPanel");
                    hmm.interact("CellLockPanel");
                }
                else if (whatIHit.collider.gameObject.name == "Wire 1" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Wire 1");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Wire 1");
                }
                else if (whatIHit.collider.gameObject.name == "Wire 2" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Wire 2");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Wire 2");
                }
                else if (whatIHit.collider.gameObject.name == "Wire 3 (correct)" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Wire 3");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Wire 3");
                }
                else if (whatIHit.collider.gameObject.name == "Wire 4" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Wire 4");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Wire 4");
                }
                else if (whatIHit.collider.gameObject.name == "Blast Door Button 1" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Wrong Button");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Wrong Button");
                }
                else if (whatIHit.collider.gameObject.name == "Blast Door Button 3 (correct)" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Correct Button");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Correct Button");
                }
                else if (whatIHit.collider.gameObject.name == "Blast Door Button 2" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Wrong Button");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Wrong Button");
                }
                else if (whatIHit.collider.gameObject.name == "Panel Switch" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("we Hit the Switch");
                    whatIHit.collider.gameObject.SetActive(false);
                    hmm.interact("Panel Switch");
                }
                else if (whatIHit.collider.gameObject.name == "Force Field Rotor" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("turning the thing");
                    hmm.interact("Force Field Rotor");
                    
                }
                else if (whatIHit.collider.gameObject.name == "Force Field Switch" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("trying the thing");
                    hmm.interact("Force Field Switch");

                }
                else if (whatIHit.collider.gameObject.name == "Grate bottom" || whatIHit.collider.gameObject.name == "Grate top" || whatIHit.collider.gameObject.name == "Grate left" || whatIHit.collider.gameObject.name == "Grate right" || whatIHit.collider.gameObject.name == "Grate bar 1" || whatIHit.collider.gameObject.name == "Grate bar 2" || whatIHit.collider.gameObject.name == "Grate bar 3")
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("moving to the next room");
                        hmm.interact("Service Grate");
                    }
                }

            }
            else if (test.name.Equals("Room Two"))
            {
                if (whatIHit.collider.CompareTag("Interactable"))
                {
                    text.SetActive(true);
                    

                }
                if (whatIHit.collider.gameObject.name == "Correct")
                {
                    Debug.Log("um wtf jim");
                    RoomTwoGame hmm = Gamecontroller.GetComponent<RoomTwoGame>();
     
                    if (whatIHit.collider.gameObject.name == "Correct" && Input.GetKeyDown(KeyCode.E))
                    {
                        
                            hmm.progress();
                            Debug.Log("You Killed the thing");
                            whatIHit.collider.gameObject.SetActive(false);
                            if (hmm.Getprogression() == 3)
                            {
                                text.GetComponent<UnityEngine.UI.Text>().text = "You Win";
                                text.SetActive(true);
                                hmm.startScreen();
                            }

                        
                    }

                }
            }
            
        }
    }
}
