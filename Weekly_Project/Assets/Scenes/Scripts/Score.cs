using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highscoreText;

    int currentScore;
    int highscore;

    public void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreText.text = highscore.ToString();
    }

    private void Update()
    {
        currentScore = Mathf.FloorToInt(player.position.z);
        scoreText.text = currentScore.ToString();

        if (currentScore > highscore)
        {
            highscore = currentScore;
            highscoreText.text = highscore.ToString();
            PlayerPrefs.SetInt("highscore", currentScore);
        }
    }
}
