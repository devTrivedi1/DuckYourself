using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseDuckScore : MonoBehaviour
{
    public ScoreCounter ScoreToIncrease;
    public void IncrementDuckScore()
    {
        ScoreToIncrease.IncrementScore(1);
    }
}
