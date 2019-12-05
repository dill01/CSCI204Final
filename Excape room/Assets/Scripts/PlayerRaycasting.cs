using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRaycasting : MonoBehaviour
{

    public float distanceToSee;
    RaycastHit whatIHit;
    Scene test;
    public GameObject Gamecontroller;

    // Start is called before the first frame update
    void Start()
    {
        test = SceneManager.GetActiveScene();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);
        if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {

            if (test.name.Equals("Room One"))
            {   
                
                RoomOneGame hmm = Gamecontroller.GetComponent<RoomOneGame>();             
                if (whatIHit.collider.gameObject.name == "CellLockPanel" && Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("Cell Lock Panel");
                    hmm.CellLockPanelFlag = true;
                    hmm.progress();
                }
                
                
            }
            else if (test.name.Equals("Room Two"))
            {
                Debug.Log("um wtf jim");                        
                RoomTwoGame hmm = Gamecontroller.GetComponent<RoomTwoGame>();
                hmm.progress();
                if (whatIHit.collider.gameObject.name == "Correct")
                {
                    Debug.Log("I touched the thing");
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Debug.Log("You Killed the thing");
                        whatIHit.collider.gameObject.SetActive(false);


                    }
                }

            }
            
        }
    }
}
