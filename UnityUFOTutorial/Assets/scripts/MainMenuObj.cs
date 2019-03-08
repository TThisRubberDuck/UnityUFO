using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuObj : MonoBehaviour
{
  

    void Update()
    {
        if (Input.anyKey)
        {  // Detects if any key has been pressed.
            Debug.Log("A key or mouse click has been detected");
            SceneManager.LoadScene("Main");
        }
    }
}