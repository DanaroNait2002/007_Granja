using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Create : MonoBehaviour
{
    [SerializeField]
    GameObject createCanvas, mainInterface;

    public void Click_Create()
    {
        LeanTween.alphaCanvas(mainInterface.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Disabled);
    }

    public void Click_Back()
    {
        LeanTween.alphaCanvas(createCanvas.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Enabled);
    }
    public void Disabled()
    {
        mainInterface.SetActive(false);
        createCanvas.SetActive(true);
        LeanTween.alphaCanvas(createCanvas.GetComponent<CanvasGroup>(), 1.0f, 0.75f);
    }

    public void Enabled()
    {
        createCanvas.SetActive(false);
        mainInterface.SetActive(true);
        LeanTween.alphaCanvas(mainInterface.GetComponent<CanvasGroup>(), 1.0f, 0.75f);
    }
}
