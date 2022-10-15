using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ScoreCounter : ScriptableObject
{

    public int Scorevalue;

    private void OnValidate()
    {
        Scorevalue = 0;
    }

    public int IncrementScore(int valueToAdd)
    {
        return Scorevalue += valueToAdd;
    }

    void RestartScoreValue()
    {
        Scorevalue = 0;
    }
}
