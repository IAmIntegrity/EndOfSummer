using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource musicAudioSource, sfxAudioSource;
    public Slider musicVolumeSlider, sfxVolumeSlider;

    private float musicVolumeFloat = 0.5f, sfxVolumeFloat = 0.5f;

    private void Start()
    {
        musicAudioSource.playOnAwake = true;
        musicAudioSource.loop = true;
        musicAudioSource.Play();

        musicVolumeFloat = PlayerPrefs.GetFloat("musicVolumePref");
        musicAudioSource.volume = musicVolumeFloat;
        musicVolumeSlider.value = musicVolumeFloat;

        sfxVolumeFloat = PlayerPrefs.GetFloat("sfxVolumePref");
        sfxAudioSource.volume = sfxVolumeFloat;
        sfxVolumeSlider.value = sfxVolumeFloat;
    }

    private void Update()
    {
        if (musicAudioSource.volume != musicVolumeFloat)
        {
            musicAudioSource.volume = musicVolumeFloat;
            PlayerPrefs.SetFloat("musicVolumePref", musicVolumeFloat);
        }

        if (musicVolumeSlider == null)
        {
            musicVolumeSlider = GameObject.Find("MusicVolumeSlider").GetComponent<Slider>();
            musicVolumeSlider.onValueChanged.AddListener(UpdateMusicVolume);
            musicVolumeSlider.value = musicVolumeFloat;
        }

        if (sfxAudioSource.volume != sfxVolumeFloat)
        {
            sfxAudioSource.volume = sfxVolumeFloat;
            PlayerPrefs.SetFloat("sfxVolumePref", sfxVolumeFloat);
        }

        if (sfxVolumeSlider == null)
        {
            sfxVolumeSlider = GameObject.Find("SFXVolumeSlider").GetComponent<Slider>();
            sfxVolumeSlider.onValueChanged.AddListener(UpdateSFXVolume);
            sfxVolumeSlider.value = sfxVolumeFloat;

            GameObject.Find("SettingsPanel").GetComponent<CanvasGroup>().alpha = 1.0f;
            GameObject.Find("SettingsPanel").SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            sfxAudioSource.Play();
        }
    }

    public void UpdateMusicVolume(float musicVolume)
    {
        musicVolumeFloat = musicVolume;
    }

    public void UpdateSFXVolume(float sfxVolume)
    {
        sfxVolumeFloat = sfxVolume;
    }
}
