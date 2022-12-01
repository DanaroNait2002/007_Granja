using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Camera : MonoBehaviour
{
    [SerializeField]
    GameObject infoIcon, info;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetMouseButtonDown(0))
            {

            }
            
                Vector3 mousePos = Input.mousePosition;

            Camera.main.transform.position = mousePos;

            if (Input.GetMouseButtonUp(0))
            {
                
            }

        }


        if (Input.GetMouseButtonUp(0))
        {
            LeanTween.scale(infoIcon, Vector3.zero, 0.25f);
            LeanTween.scale(info, Vector3.zero, 0.25f);
        }
    }
}
