using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRaycasting : MonoBehaviour
{

    public float distanceToSee;
    RaycastHit whatIHit;
    private RoomTwoGame two;
    Scene test;
    public GameObject Doorup;
    public GameObject LeftWall;
    public GameObject RightWall;
    Animator DoorAnim, RightAnim, LeftAnim;
    // Start is called before the first frame update
    void Start()
    {
        test = SceneManager.GetActiveScene();
        two = new RoomTwoGame();
        DoorAnim = Doorup.GetComponent<Animator>();
        LeftAnim = LeftWall.GetComponent<Animator>();
        RightAnim = RightWall.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);
        if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
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
                        two.progress();
                        int hmm = two.Getprogression();
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
                }
            }
        }
    }
}
