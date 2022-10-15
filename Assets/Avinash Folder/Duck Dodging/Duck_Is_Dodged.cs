using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Duck_Is_Dodged : MonoBehaviour
{

    [SerializeField] bool DebugMode;
    [SerializeField] UnityEvent DoSomethingWhenDuckNotInView;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // RunEventWhenDuckOutOfBounds();
        EnableDebugMode();
    }

    Vector3 TransformFromCameraPOV()
    {
        return Camera.main.WorldToViewportPoint(transform.position);
    }

    void EnableDebugMode()
    {
        if (DebugMode)
        {
            Debug.Log(TransformFromCameraPOV());
        }
    }

    bool IsDuckNotBoundsOfCamera()
    {
        Vector3 CameraView = TransformFromCameraPOV();

        if(CameraView.x>1 || CameraView.x<0 || CameraView.y >1 || CameraView.y < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    void RunEventWhenDuckOutOfBounds()
    {
        if(IsDuckNotBoundsOfCamera())
        {
            DoSomethingWhenDuckNotInView.Invoke();
            Debug.Log("duck not in view");
        }
        else
        {
            Debug.Log("duck still in view");
        }
    }
}
