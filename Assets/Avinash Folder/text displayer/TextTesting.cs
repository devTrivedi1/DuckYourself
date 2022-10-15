using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTesting : MonoBehaviour
{
    [SerializeField]TextDisplayer score;
    float count;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            count++;
           
        }
    }
}
