using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    public AudioMixer mixer;

    public void LoadMusicSettings()
    {
        int volume = PlayerPrefs.GetInt("Volume", 0);
        int muted = PlayerPrefs.GetInt("Muted", 0);

        mixer.SetFloat("MasterVolume", volume);
        if(muted == 0)
        {
            mixer.SetFloat("MasterVolume", -80);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadMusicSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
