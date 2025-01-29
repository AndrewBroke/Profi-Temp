using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public Dropdown screenSize;
    public Toggle screenMode;
    public Toggle musicMode;
    public Slider volume;
    public MusicController musicController;

    private void Update()
    {
        print(Screen.height);
        print(Screen.fullScreenMode);
    }

    public void SaveSettings()
    {
        // Смена разрешения экрана
        switch (screenSize.value)
        {
            case 0:
                Screen.SetResolution(1280, 720, Screen.fullScreen);
                break;
            case 1:
                Screen.SetResolution(1366, 768, Screen.fullScreen);
                break;
            case 2:
                Screen.SetResolution(1600, 900, Screen.fullScreen);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, Screen.fullScreen);
                break;
            
        }
        
        // Смена режима экрана
        if (screenMode.isOn == true)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }

        // Звук
        PlayerPrefs.SetInt("Volume", (int)volume.value);
        if (musicMode.isOn == true)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }

        musicController.LoadMusicSettings();
    }
}
