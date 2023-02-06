using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKepper scoreKepper;

    void Awake()
    {
        scoreKepper = FindObjectOfType<ScoreKepper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Cogratulation!\nYou got a score of " +
                                   scoreKepper.CalculateScore() + "%";
    }
}
