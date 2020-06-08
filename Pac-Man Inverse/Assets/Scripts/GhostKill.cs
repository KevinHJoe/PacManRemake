using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class GhostKill : MonoBehaviour
{
    public GameObject ghost;
    public GameObject prey;
    private GameObject pacman;

    private Vector3 respawnPosition = new Vector3(-2,0.75f,-6);
    private Quaternion rp = new Quaternion(0, 90, 0, 0);

    public static int lives = 3;

    void Start()
    {
        ghost = GameObject.FindGameObjectWithTag("Enemy");
        //ghost = GameObject.FindGameObjectWithTag("Prey");
        pacman = GameObject.FindGameObjectWithTag("Player");

    }

    private void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag == "Player" && gameObject.tag == "Enemy")
        {
            lives--;
            print("OnTriggerEnter");
            respawn();

            if (lives <= 0)
            {
                restartGame();
                EatMe.score = 0;
                lives = 3;
            }
        }
        deadGhostWalking(col);
    }

    public void deadGhostWalking(Collider col)
    {
        if (col.gameObject.tag == "Player" && gameObject.tag == "Prey")
        {
            //GameObject.FindGameObjectWithTag("Prey").SetActive(false);    //this will look for an array of the objects and deactivate  each object sequentially
            resurrect();
            gameObject.SetActive(false);
        }
    }

    private void resurrect()
    {
        StartCoroutine(resTimer());
    }

    private IEnumerator resTimer()
    {

        yield return new WaitForSeconds(5f);
        gameObject.SetActive(true);
    }


    private void respawn()
    {
        print("respawn()");
        pacman.gameObject.SetActive(false);
        StartCoroutine(respawnTimer());
    }

    private IEnumerator respawnTimer()
    {
        yield return new WaitForSecondsRealtime(1f);
        pacman.transform.SetPositionAndRotation(respawnPosition, rp);
        pacman.gameObject.SetActive(true);
    }

    
    public void restartGame()
    {
        if (lives <= 0)
        {
            lives = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            FindObjectOfType<Button>().gameObject.SetActive(false);
        }
        else if (gameObject.activeInHierarchy.Equals(true)) 
        {
            FindObjectOfType<Button>().gameObject.SetActive(false);
        }
    }
    
}
