using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Intro : MonoBehaviour
{
    [SerializeField]
    GameObject canvasMainMenu, logo;

    void Start()
    {
        //Hide the Tittle at the start
        LeanTween.moveLocalY(logo, -1000f, 0.0f);

        //Hago aparecer el logo desde su posición
        //Animación que dura 1.0f
        LeanTween.moveLocalY(logo, 0f, 2.0f).setEaseSpring().setOnComplete(Beat);

        void Beat()
        {
            LeanTween.scale(logo, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(() => {
                LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Disabled);

            });
        }

        void Disabled()
        {
            gameObject.SetActive(false);
            canvasMainMenu.SetActive(true);
        }
    }
}
