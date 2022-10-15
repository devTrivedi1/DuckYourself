using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextDisplayer : MonoBehaviour
{
    public ScoreCounter ValueToShow;
    public string Defaultext;
    [SerializeField]TextMeshProUGUI textType;


    private void Update()
    {
        ShowAScoreCounterValue("duck");
    }
    public void ShowAScoreCounterValue(string ScoreName)
    {
        textType.text = Defaultext + ValueToShow.Scorevalue.ToString();
    }
}
