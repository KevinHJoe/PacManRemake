using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{

    int lives;
    //gk = FindObjectOfType<GhostKill>();   

    
    static void Start()
    {
    }
    private void Update()
    {
        //print(GhostKill.lives);
    }

    public void restart()
    {
        if (lives <= 0)
        {
            lives = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            FindObjectOfType<Canvas>().gameObject.SetActive(false);
        }
        else if (gameObject.activeInHierarchy.Equals(true))
        {
            FindObjectOfType<Canvas>().gameObject.SetActive(false);
        }
    }
   
}
