using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DentedPixel;

//---------------------------------------------------------------------------------
// Author		: Yeo Siok Chin Jazlyn
// Date  		: 2022-11-11
// Description	: This is where you write a summary of what the role of this file.
//---------------------------------------------------------------------------------

public class SplashMenuLT : MonoBehaviour
{
    #region Variables
    //---------------------
    // Private Variables
    //---------------------
    [SerializeField] private GameObject _splashScr;

    [Header("SplashScreen Settings")]
    // Create more variables here to give you flexibility to control timing

    [Header("Decal on Floor")]
    [SerializeField] private GameObject _decalJetHammer;
    [SerializeField] private CanvasGroup _mainMenuPanel;
    private RectTransform _splashScrRectTransform;

    #endregion

    #region Unity Methods
    protected void Awake()
    {
        _splashScr.transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        _splashScrRectTransform = _splashScr.GetComponent<RectTransform>();

        /*
        If you do not want to code this, in inspector change alpha of image to zero. 
        Image img = _splashScr.GetComponent<Image>();
        Color imgColor = img.color;
        imgColor.a = of;
        img.color = imgColor;
        */
    }

    protected void Start()
    {
        var seq = LeanTween.sequence();
        seq.append(2f); // delay everythign 2 second
        seq.append( () => {
            FadeInLogo();
        });
        seq.append(3f); // delay everything by Showtime in second
        seq.append( () => {
            FadeOutLogo();
        });
        seq.append(1f); // delay everything by fadeout time in second
        seq.append( () => {
            ShowDecalAndMenu();
        });
    }


    #endregion

    #region Own Methods

    private void FadeInLogo()
    {
        // delay 2sec before show else it will be missed when VR starts
        LeanTween.scaleX(_splashScr, 0.1f, 1f);
        LeanTween.scaleY(_splashScr, 0.1f, 1f);
        LeanTween.alpha(_splashScrRectTransform, 1f, 1f);
        Debug.Log("fade in logo");

        /*
        LeanTween.scaleX(_splashScr, _zoomAmountEnd, _fadeInTime).setDelay(2f);
        LeanTween.scaleY(_splashScr, _zoomAmountEnd, _fadeInTime).setDelay(2f);
        LeanTween.alpha(_splashScr.GetComponent<RectTransform>(), 1f, _fadeInTime.setDelay(2f).setOnComplete(FadeOutLogo);
        */
    }

    private void FadeOutLogo()
    {
        LeanTween.scaleX(_splashScr, 0.05f, 1f);
        LeanTween.scaleY(_splashScr, 0.05f, 1f);
        LeanTween.alpha(_splashScrRectTransform, 0f, 1f);
        Debug.Log("fade out logo");
    }

    private void ShowDecalAndMenu()
    {
        _decalJetHammer.SetActive(true);
        LeanTween.alphaCanvas(_mainMenuPanel, 1f, 1f);
        Debug.Log("show menu");
    }

    public void FadeMenu()
    {
        LeanTween.alphaCanvas(_mainMenuPanel, 0f, 1f);
        Debug.Log("fade menu");

    }

    #endregion

}
