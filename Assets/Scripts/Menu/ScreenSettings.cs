using UnityEngine;

using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;

public class ScreenSettings : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resolutions = Screen.resolutions;

        for (int i = 0; i < resolutions.Length; i++)
        {
            resolutionDropdown.options.Add(new TMP_Dropdown.OptionData(resolutions[i].ToString()));
        }

        Resolution currentResolution = Screen.currentResolution;

        int currentIndex = PlayerPrefs.GetInt("resolutionIndex", -1);
        if (currentIndex == -1)
        {
            currentIndex = Array.IndexOf(resolutions, currentResolution);
        }
        resolutionDropdown.value = currentIndex;
    }

    public void SetResolution()
    {
        int currentIndex = resolutionDropdown.value;
        Resolution selectedResolution = resolutions[currentIndex];
        Screen.SetResolution(selectedResolution.width, selectedResolution.height, Screen.fullScreen);
        PlayerPrefs.SetInt("resolutionIndex", currentIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
