using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject logoImage,flagImage, buttonExit, buttonInfo, buttonNewGame, buttonContinue, buttonConfig;


    private void OnEnable()
    {
        LeanTween.scale(logoImage, Vector3.zero, 0.0f);
        LeanTween.scale(flagImage, Vector3.zero, 0.0f);
        LeanTween.scale(buttonExit, Vector3.zero, 0.0f);
        LeanTween.scale(buttonInfo, Vector3.zero, 0.0f);
        LeanTween.scale(buttonNewGame, Vector3.zero, 0.0f);
        LeanTween.scale(buttonContinue, Vector3.zero, 0.0f);
        LeanTween.scale(buttonConfig, Vector3.zero, 0.0f);
        ChangeScale();
    }

    void ChangeScale()
    {
        LeanTween.scale(logoImage, Vector3.one, 0.85f).setEaseOutBounce();
        LeanTween.scale(flagImage, Vector3.one, 0.85f).setEaseOutBounce();
        LeanTween.scale(buttonExit, Vector3.one, 0.85f).setEaseOutBounce();
        LeanTween.scale(buttonInfo, Vector3.one, 0.85f).setEaseOutBounce();
        LeanTween.scale(buttonNewGame, Vector3.one, 0.85f).setEaseOutBounce();
        LeanTween.scale(buttonContinue, Vector3.one, 0.85f).setEaseOutBounce();
        LeanTween.scale(buttonConfig, Vector3.one, 0.85f).setEaseOutBounce();
    }

   
}
