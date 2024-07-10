using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource audioSource, clickAudioSource;
    public Slider musicVolumeSlider;

    private float musicVolumeFloat = 0.5f;

    private void Start()
    {
        audioSource.playOnAwake = true;
        audioSource.loop = true;
        audioSource.Play();

        musicVolumeFloat = PlayerPrefs.GetFloat("musicVolumePref");
        audioSource.volume = musicVolumeFloat;
        musicVolumeSlider.value = musicVolumeFloat;
    }

    private void Update()
    {
        if (audioSource.volume != musicVolumeFloat)
        {
            audioSource.volume = musicVolumeFloat;
            PlayerPrefs.SetFloat("musicVolumePref", musicVolumeFloat);
        }

        if (musicVolumeSlider == null)
        {
            musicVolumeSlider = GameObject.Find("MusicVolumeSlider").GetComponent<Slider>();
            musicVolumeSlider.onValueChanged.AddListener(UpdateMusicVolume);
            musicVolumeSlider.value = musicVolumeFloat;
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickAudioSource.Play();
        }
    }

    public void UpdateMusicVolume(float musicVolume)
    {
        musicVolumeFloat = musicVolume;
    } 
}
