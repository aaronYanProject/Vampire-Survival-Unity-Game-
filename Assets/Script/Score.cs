using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text=score.ToString();
    }
}
