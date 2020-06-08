using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletGhostKiller : MonoBehaviour
{
    GameObject[] ghostEnemy;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //print("gameObject = " + gameObject);                      //gameObject = Special Pellet
            EatMe.score += 10;                                                          //  GhostKill ghost =  ghostEnemy.GetComponent<GhostKill>();
            gameObject.SetActive(false);
            //NEED TO FIX
            /*//  ghost.deadGhostWalking();
            ghostEnemy = GameObject.FindGameObjectsWithTag("Enemy");
            for(int i =0; i < ghostEnemy.Length; i++)
            {
                ghostEnemy[i].tag = "Prey";
            }

            print("Going into corutine");
            StartCoroutine(turnBackToEnemy());
            print("exiting corutine after calling function");

            resurect();
            gameObject.SetActive(false);
            */
        }
    }

    private void resurect()
    {

        GameObject.Find("Ghost_1").SetActive(true);
        GameObject.Find("Ghost_2").SetActive(true);
        GameObject.Find("Ghost_3").SetActive(true);
        GameObject.Find("Ghost_4").SetActive(true);
    }

    private IEnumerator turnBackToEnemy()
    {
        print("inside corutine before yield return");

        yield return new WaitForSecondsRealtime(15);
        for (int i = 0; i < ghostEnemy.Length; i++)
        {
            ghostEnemy[i].tag = "Prey";
        }
        print("exiting corutine after yield return");
    }
}
