using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.UI;

//---------------------------------------------------------------------------------
// Author		: Yeo Siok Chin Jazlyn
// Date  		: 2022-11-11
// Description	: This is where you write a summary of what the role of this file.
//---------------------------------------------------------------------------------

public class FadeCamera : MonoBehaviour
{
    #region Variables
    //----------------------
    // Private Variables
    //----------------------
    [SerializeField] private RectTransform _fadeScreenRectTransform;

    [Header("Fade Settings")]
    [SerializeField] [Range(0.1f, 3.0f)] private float _fadeInTime = 1.0f;
    [SerializeField] [Range(0.1f, 3.0f)] private float _fadeOutTime = 1.0f;
    #endregion

    #region Unity Methods
    protected void Start()
    {
        // For testing the Fade in and out only. Can remove or comment out.
        var seq = LeanTween.sequence();
        seq.append(6f); // delay everything 6 second
        seq.append( () => {
            FadeOutCam();
        });
        seq.append(5f); //delay everything by 5 second
        seq.append( () => {
            FadeInCam();
        });
    }
    #endregion

    #region Own Methods

    // FadeInCam() and FadeOut can be used to prevent user looking through objects and walls using triggers
    public void FadeInCam()
    {
        LeanTween.alpha(_fadeScreenRectTransform, 0f, _fadeInTime);
        Debug.Log("fade in");
    }

    public void FadeOutCam()
    {
        LeanTween.alpha(_fadeScreenRectTransform, 1f, _fadeOutTime);
        Debug.Log("fade out");
    }
    #endregion

}


