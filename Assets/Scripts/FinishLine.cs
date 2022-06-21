using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "Player")
        {
            ScoreScript.scoreValue++;
            if (BestScoreScript.bestScoreValue<ScoreScript.scoreValue)
            {
                BestScoreScript.bestScoreValue=ScoreScript.scoreValue;
            }
        }
    }
}
