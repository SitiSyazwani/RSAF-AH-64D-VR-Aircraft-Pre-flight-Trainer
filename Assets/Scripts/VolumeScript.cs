using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class VolumeScript : MonoBehaviour
{
    public AudioMixer mixer;

    public TMP_Text mastLabel, bgmLabel, sfxLabel;
    public Slider mastSlider, bgmSlider, sfxSlider;

    // Start is called before the first frame update
    void Start()
    {


        float vol = 0f;
        mixer.GetFloat("MasterVol", out vol);
        mastSlider.value = vol;

        mixer.GetFloat("BGMVol", out vol);
        bgmSlider.value = vol;

        mixer.GetFloat("SFXVol", out vol);
        sfxSlider.value = vol;

        mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString();
        bgmLabel.text = Mathf.RoundToInt(bgmSlider.value + 80).ToString();
        sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterVol()
    {
        mastLabel.text = Mathf.RoundToInt(mastSlider.value + 80).ToString();

        mixer.SetFloat("MasterVol", mastSlider.value);

        PlayerPrefs.SetFloat("MasterVol", mastSlider.value);
    }

    public void SetBGMVol()
    {
        bgmLabel.text = Mathf.RoundToInt(bgmSlider.value + 80).ToString();

        mixer.SetFloat("BGMVol", bgmSlider.value);

        PlayerPrefs.SetFloat("BGMVol", bgmSlider.value);
    }

    public void SetSFXVol()
    {
        sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString();

        mixer.SetFloat("SFXVol", sfxSlider.value);

        PlayerPrefs.SetFloat("SFXVol", sfxSlider.value);
    }

}
