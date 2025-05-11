using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

using System.Collections;
using System.Collections.Generic;
public class AudioSettings : MonoBehaviour
{
    public Slider masterSlider;

    public AudioMixer mixer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMasterVolume()
    {
        float adjustedValue = Mathf.Log10(masterSlider.value) * 20;
        if (masterSlider.value == 0)
        {
            adjustedValue = -80f;
        }
        SetVolume("MasterVolume", adjustedValue); 
    }

    void SetVolume(string groupName, float value){
        mixer.SetFloat(groupName,value);
    }
}
