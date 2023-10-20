using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.UI;

public class FadeMenu : MonoBehaviour
{
    [SerializeField] private GameObject _splashScr;
    [SerializeField] private CanvasGroup _mainMenuPanel;
    private RectTransform _splashScrRectTransform;

    protected void Start()
    {
        var seq = LeanTween.sequence();
        seq.append(2f); // delay everythign 2 second
        seq.append( () => {
            fadeMenu();
        });

    }
    private void fadeMenu()
    {
        LeanTween.alphaCanvas(_mainMenuPanel, 1f, 1f);
    }
}
