using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void RoomOne()
    {
        SceneManager.LoadScene("Room One");
    }
    public void RoomTwo()
    {
        SceneManager.LoadScene("Room Two");
    }
    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
}
