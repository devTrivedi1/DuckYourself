using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCurrentObject : MonoBehaviour
{
    



    public void DestroyObject(float DestroyTimer)
    {
        Destroy(gameObject,DestroyTimer);
    }
}
