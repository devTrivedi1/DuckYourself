using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] float DisableTimer;
    [SerializeField] float EnableTimer;
    public UnityEvent RunEventWhenEnabled;
    public UnityEvent RunEventWhenDisabled;
    [SerializeField] bool onlyDisableOnce;

    private void OnEnable()
    {
        if(onlyDisableOnce)
        {
            Invoke(nameof(DisableGameObject), 0);
            onlyDisableOnce = false;
        }
        else if (gameObject.activeInHierarchy)
        {
            RunEventWhenEnabled.Invoke();
            Invoke(nameof(DisableGameObject), DisableTimer);
        }

    }


    void EnableObject()
    {
        gameObject.SetActive(true);
    }

    void DisableGameObject()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        RunEventWhenDisabled.Invoke();
        if (!gameObject.activeInHierarchy)
        {
            Invoke(nameof(EnableObject), EnableTimer);
        }
           
    }
}
