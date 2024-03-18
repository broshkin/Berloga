using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using System;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TMP_Dropdown resolutionDropDown;

    public TMP_Dropdown qualityDropDown;

    public List<string> options = new List<string>();

    public Slider volumeSlider;

    public Toggle fullscreenToggle;

    static public float vol = 0;

    static public bool isFullScreen = true;

    static public int resolutionIndex;

    static public bool firstTime = true;
    Resolution[] resolutions;

    private void Start()
    {
        resolutions = Screen.resolutions;
           
        resolutionDropDown.ClearOptions();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            if (!options.Contains(option))
            {
                options.Add(option);
            }
        }
        if (firstTime)
        {
            resolutionIndex = options.Count - 1;
            firstTime = false;
        }
        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = resolutionIndex;
        resolutionDropDown.RefreshShownValue();
        qualityDropDown.SetValueWithoutNotify(QualitySettings.GetQualityLevel());
        volumeSlider.value = vol;
        fullscreenToggle.isOn = isFullScreen;
    }
    public void SetResolution(int resIndex)
    {
        string[] resolution = options[resIndex].Split('x');
        Screen.SetResolution(Convert.ToInt32(resolution[0]), Convert.ToInt32(resolution[1]), Screen.fullScreen);
        resolutionIndex = resIndex;
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        vol = volume;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        isFullScreen = isFullscreen;
    }
    
    public void QuitFromGame()
    {
        Application.Quit();
    }
}
