using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class options : MonoBehaviour

{
    [Header ("Audio")]
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterVolumeSlider;
    [SerializeField] Slider musicSlider;

    [SerializeField] Slider vsfxSlider;

    
    void Start()
    {
        masterVolumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        vsfxSlider.value = PlayerPrefs.GetFloat("vsfx");
    }

    
    void Update()
    {
        
    }

    public void SetMasterVolume(){
        audioMixer.SetFloat("MasterVolume",ConvertToDec(masterVolumeSlider.value));
        PlayerPrefs.SetFloat("MasterVolume", masterVolumeSlider.value);
    }

    public void SetMusicVolume(){
        audioMixer.SetFloat("MusicVolume",ConvertToDec(musicSlider.value));
        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
    }

    public void SetVSFXVolume(){
        audioMixer.SetFloat("vsfx",ConvertToDec(vsfxSlider.value));
        PlayerPrefs.SetFloat("vsfx", vsfxSlider.value);
    }

    float ConvertToDec(float sliderValue){
        return Mathf.Log10(Mathf.Max(sliderValue, 0.0001f)) * 20;
    }
}
