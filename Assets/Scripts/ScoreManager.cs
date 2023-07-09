using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton instance of the ScoreManager

    public Text scoreText; // Text object to display the current score
    public Text highScoreText; // Text object to display the high score



    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this; // Assign the current instance to the static instance variable for singleton access
    }


    private void Start()
    {
        scoreText.text = score.ToString() + " POINTS"; // Display the initial score
        highScoreText.text = "HIGHSCORE " + highscore.ToString();  // Display the initial high score
    }

    public void Addpoint()
    {
        score += 1; // Increase the score by 1
        scoreText.text = score.ToString() + " POINTS"; // Update the score text

        if (score > highscore) // If the current score is higher than the high score
        {
            highscore = score; // Update the high score
            highScoreText.text = "HIGHSCORE " + highscore.ToString(); // Update the high score text
        }
    }

}
