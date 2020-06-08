using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives_Counter : MonoBehaviour
{
    public Text livesCounter;
    int lives;
    // Start is called before the first frame update
    void Start()
    {
        livesCounter = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        lives = GhostKill.lives;
        livesCounter.text = " Lives";
    }
}
