using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))] 
public class CollisionCheck : MonoBehaviour
{
    [SerializeField] string ObjectToCollideTag;
    [SerializeField] UnityEvent DoSomethingOnCollision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag==ObjectToCollideTag)
        {
            DoSomethingOnCollision.Invoke();
            

        }
    }

  




}
