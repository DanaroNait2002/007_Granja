using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Camera : MonoBehaviour
{
    [SerializeField]
    GameObject cameraCanvas, mainInterface;

    public void Click_Camera()
    {
        LeanTween.alphaCanvas(mainInterface.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Disabled);
    }

    public void Click_Back()
    {
        LeanTween.alphaCanvas(cameraCanvas.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Enabled);
    }
    public void Disabled()
    {
        mainInterface.SetActive(false);
        cameraCanvas.SetActive(true);
        LeanTween.alphaCanvas(cameraCanvas.GetComponent<CanvasGroup>(), 1.0f, 0.75f);
    }

    public void Enabled()
    {
        cameraCanvas.SetActive(false);
        mainInterface.SetActive(true);
        LeanTween.alphaCanvas(mainInterface.GetComponent<CanvasGroup>(), 1.0f, 0.75f);
    }
}
