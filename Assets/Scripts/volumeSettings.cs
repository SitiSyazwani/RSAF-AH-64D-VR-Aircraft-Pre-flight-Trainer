using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class volumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider mainSlider;
    [SerializeField] Slider bgmSlider;


    const string MIXER_MUSIC = "Main";
    const string MIXER_SFX = "SFX";


    void Awake()
    {
        mainSlider.onValueChanged.AddListener(SetMusicVolume);
        bgmSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    void SetMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }

    void SetSFXVolume(float value)
    {
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);
    }

}
