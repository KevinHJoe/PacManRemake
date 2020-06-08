using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageLivesCounter : MonoBehaviour
{
    int lives;
    public GameObject life1, life2, life3;


    void Start()
    {
        life1.name = "PacmanLife1";
        life2.name = "PacmanLife2";
        life3.name = "PacmanLife3";
    }

    // Update is called once per frame
    void Update()
    {
        lives = GhostKill.lives;
        if(lives == 2)
        {
            life3.SetActive(false);
        }
        if(lives == 1)
        {
            life2.SetActive(false);
        }
        if(lives == 0)
        {
            life1.SetActive(false);
        }
    }    
}
