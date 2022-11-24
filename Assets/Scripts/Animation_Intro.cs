using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Intro : MonoBehaviour
{
    [SerializeField]
    GameObject CanvasMainMenu, Logo;

    void Start()
    {
        //Hide the Tittle at the start
        LeanTween.moveLocalY(Logo, -1000f, 0.0f);

        //Hago aparecer el logo desde su posición
        //Animación que dura 1.0f
        LeanTween.moveLocalY(Logo, 0f, 2.0f).setEaseSpring().setOnComplete(Beat);

        void Beat()
        {
            LeanTween.scale(Logo, Vector3.one, 0.25f).setEaseOutBack().setOnComplete(() => {
                LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.75f).setOnComplete(Disabled);

            });
        }

        void Disabled()
        {
            gameObject.SetActive(false);
            CanvasMainMenu.SetActive(true);
        }
    }
}
