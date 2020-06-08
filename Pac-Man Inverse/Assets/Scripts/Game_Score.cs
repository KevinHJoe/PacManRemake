using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Score : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = EatMe.score;
        scoreText.text = "Score: " + score;
        print(score);

    }

}
