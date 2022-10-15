using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyCurrentObject : MonoBehaviour
{

    public UnityEvent DoSomethingWhenObjectIsDestroyed;


    public void DestroyObject(float DestroyTimer)
    {
        Invoke(nameof(delayDestroy), DestroyTimer);
    }

    void delayDestroy()
    {
        DoSomethingWhenObjectIsDestroyed.Invoke();
        Destroy(gameObject);
       
    }
}
