using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    public AudioMixer mixer;

    /// <summary>
    /// Функция загружает значения настроек из сохранений
    /// И ставит нужную громкость
    /// </summary>
    public void LoadMusicSettings()
    {
        // Загружаем сохранения
        int volume = PlayerPrefs.GetInt("Volume", 0);
        int muted = PlayerPrefs.GetInt("Muted", 0);

        // Ставим громкость
        mixer.SetFloat("MasterVolume", volume);

        // Если mute, то громкость ставим в 0
        if(muted == 1)
        {
            // Ставим значение
            mixer.SetFloat("MasterVolume", -80);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadMusicSettings();
    }
}
