using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DentedPixel;

//---------------------------------------------------------------------------------
// Author		: Jazlyn & Siti Syazwani
// Date  		: 2023-10-20
// Description	: This is for splashscreen animation.
//---------------------------------------------------------------------------------

public class SplashMenuLT : MonoBehaviour
{
    #region Variables
    //---------------------
    // Private Variables
    //---------------------
    [SerializeField] private GameObject _splashScr;
    [SerializeField] private GameObject _splashScr2;

    [Header("SplashScreen Settings")]
    // Create more variables here to give you flexibility to control timing

    [Header("Decal on Floor")]
    [SerializeField] private GameObject _decalJetHammer;
    [SerializeField] private CanvasGroup _mainMenuPanel;
    private RectTransform _splashScrRectTransform;
    private RectTransform _splashScr2RectTransform;

    #endregion

    #region Unity Methods
    protected void Awake()
    {
        //_splashScr.transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        _splashScrRectTransform = _splashScr.GetComponent<RectTransform>();

        //_splashScr2.transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
        _splashScr2RectTransform = _splashScr2.GetComponent<RectTransform>();

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
        seq.append(2f); // delay everything 2 second
        seq.append( () => {
            FadeInLogo1();
        });
        seq.append(3f); // delay everything by Showtime in second
        seq.append( () => {
            FadeOutLogo1();
        });
        seq.append(2f); // delay everything 2 second
        seq.append(() => {
            FadeInLogo2();
        });
        seq.append(3f); // delay everything by Showtime in second
        seq.append(() => {
            FadeOutLogo2();
        });
        seq.append(1f); // delay everything by fadeout time in second
        seq.append( () => {
            ShowDecalAndMenu();
        });
    }


    #endregion

    #region Own Methods

    /*
    ////////////////////////////////
     SP Logo
    ////////////////////////////////
     */
    private void FadeInLogo1()
    {
        // delay 2sec before show else it will be missed when VR starts
        LeanTween.scaleX(_splashScr, 0.1f, 1f);
        LeanTween.scaleY(_splashScr, 0.061f, 1f);
        LeanTween.alpha(_splashScrRectTransform, 1f, 1f);
        Debug.Log("fade in SP logo");
    }

    private void FadeOutLogo1()
    {
        LeanTween.scaleX(_splashScr, 0.05f, 1f);
        LeanTween.scaleY(_splashScr, 0.05f, 1f);
        LeanTween.alpha(_splashScrRectTransform, 0f, 1f);
        Debug.Log("fade out SP logo");
    }

    /*
    ////////////////////////////////
     RSAF Logo
    ////////////////////////////////
     */
    private void FadeInLogo2()
    {
        // delay 2sec before show else it will be missed when VR starts
        LeanTween.scaleX(_splashScr2, 0.066f, 1f);
        LeanTween.scaleY(_splashScr2, 0.085f, 1f);
        LeanTween.alpha(_splashScr2RectTransform, 1f, 1f);
        Debug.Log("fade in RSAF logo");

    }

    private void FadeOutLogo2()
    {
        LeanTween.scaleX(_splashScr2, 0.05f, 1f);
        LeanTween.scaleY(_splashScr2, 0.05f, 1f);
        LeanTween.alpha(_splashScr2RectTransform, 0f, 1f);
        Debug.Log("fade out RSAF logo");
    }

    /*
    ////////////////////////////////
     Menu
    ////////////////////////////////
     */
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
