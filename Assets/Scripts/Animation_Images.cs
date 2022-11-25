using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Images : MonoBehaviour
{
    public void ScaleEnter()
    {
        LeanTween.scale(gameObject, Vector3.one * 1.1f, 0.5f).setEaseInSine();
    }

    public void ScaleExit()
    {
        LeanTween.cancel(gameObject);
        LeanTween.scale(gameObject, Vector3.one, 0.25f).setEaseInSine();
    }
}
