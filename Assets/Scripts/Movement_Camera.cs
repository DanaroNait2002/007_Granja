using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Camera : MonoBehaviour
{
    [SerializeField]
    GameObject infoIcon, info;

    [SerializeField]
    Vector3 oldPos;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 newPos = oldPos - Input.mousePosition;
            Camera.main.transform.position += new Vector3(newPos.y, 0.0f, newPos.x) * Time.deltaTime;
        }

        oldPos = Input.mousePosition;

        if (Input.GetMouseButtonUp(0))
        {
            LeanTween.scale(infoIcon, Vector3.zero, 0.25f);
            LeanTween.scale(info, Vector3.zero, 0.25f);
        }

    }
}
