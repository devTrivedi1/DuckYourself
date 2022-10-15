using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextDisplayer : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI textType;


    public void DisplayText(string textToDisplay)
    {
        textType.text = textToDisplay;
    }
}
