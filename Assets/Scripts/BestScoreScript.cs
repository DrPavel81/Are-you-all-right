using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreScript : MonoBehaviour
{
    TextMeshPro bestScore;
    public static int bestScoreValue = 0;

    void Start()
    {
        bestScore = GetComponent<TextMeshPro>();
    }
    void Update()
    {   
        bestScore.text = "Best Score: " + bestScoreValue;
    }
}
