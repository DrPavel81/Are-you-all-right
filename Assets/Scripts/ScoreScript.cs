using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    TextMeshPro score;
    public static int scoreValue = 0;

    void Start()
    {
        score = GetComponent<TextMeshPro>();
    }
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
