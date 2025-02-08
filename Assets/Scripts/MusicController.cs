using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    public AudioMixer mixer;

    /// <summary>
    /// Function loads values from PlayerPrefs
    /// And sets it to the mixer
    /// </summary>
    public void LoadMusicSettings()
    {
        // Load values
        int volume = PlayerPrefs.GetInt("Volume", 0);
        int muted = PlayerPrefs.GetInt("Muted", 0);

        // Set volume
        mixer.SetFloat("MasterVolume", volume);

        // If muted == 1 then set volume to -80
        if(muted == 1)
        {
            // Set volume to master in mixer
            mixer.SetFloat("MasterVolume", -80);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadMusicSettings();
    }
}
