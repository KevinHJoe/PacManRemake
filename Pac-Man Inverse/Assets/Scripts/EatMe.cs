using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EatMe : MonoBehaviour
{
    public static int score;
    private GameObject pacman;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            newGame();
 
        }
    }

    private void newGame()
    {

        score += 10; ;

        if (score % 2230 == 0)
        {
            GhostKill.lives = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
