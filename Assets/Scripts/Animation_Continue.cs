using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Continue : MonoBehaviour
{
    [SerializeField]
    GameObject mainInterface, mainMenu, cameraCanvas;

    public void click_MainMenu()
    {
        LeanTween.alphaCanvas(mainMenu.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Disabled);
    }
    public void click_Back()
    {
        LeanTween.alphaCanvas(mainInterface.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Enabled);
    }


    public void Enabled()
    {
        mainInterface.SetActive(false);
        mainMenu.SetActive(true);
        LeanTween.alphaCanvas(mainMenu.GetComponent<CanvasGroup>(), 1.0f, 0.75f);
    }
    
    public void Disabled()
    {
        mainMenu.SetActive(false);
        mainInterface.SetActive(true);
        LeanTween.alphaCanvas(mainInterface.GetComponent<CanvasGroup>(), 1.0f, 0.75f);
    }
}
