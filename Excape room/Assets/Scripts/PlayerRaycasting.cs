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
        if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            if (whatIHit.collider.CompareTag("Interactable"))
            {
                text.SetActive(true);
            }
            if(whatIHit.collider.gameObject.name == "Correct")
            {
                Debug.Log("I touched the thing");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("You Killed the thing");
                    whatIHit.collider.gameObject.SetActive(false);
                    if(test.name.Equals("Room One"))
                    {

                    }
                    else if(test.name.Equals("Room Two"))
                    {
                        Debug.Log("um wtf jim");
                        RoomTwoGame hmm = Gamecontroller.GetComponent<RoomTwoGame>();
                        hmm.progress();

                        
                    }
                }
            }
        }
    }
}
