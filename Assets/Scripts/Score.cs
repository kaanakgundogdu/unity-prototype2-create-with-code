using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;

    private void Start()
    {
        score = 0;
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score;

    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }



}
