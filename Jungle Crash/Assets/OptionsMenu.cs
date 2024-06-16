using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Toggle fullScreenToggle; // Référence au Toggle pour le plein écran
    public Slider musicSlider;
    public Slider soundSlider;

    void Start()
    {
        // Initialiser les valeurs des sliders à partir des valeurs de l'audio mixer
        if (audioMixer.GetFloat("Music", out float musicValueForSlider))
        {
            musicSlider.value = musicValueForSlider;
        }

        if (audioMixer.GetFloat("Sound", out float soundValueForSlider))
        {
            soundSlider.value = soundValueForSlider;
        }

        // Ajouter des listeners pour les sliders
        musicSlider.onValueChanged.AddListener(SetVolume);
        soundSlider.onValueChanged.AddListener(SetSoundVolume);

        // Initialiser l'état du Toggle en fonction du mode plein écran actuel
        fullScreenToggle.isOn = Screen.fullScreen;

        // Ajouter un listener pour gérer les changements d'état du Toggle
        fullScreenToggle.onValueChanged.AddListener(SetFullScreen);

        // Assurez-vous que l'application démarre en plein écran
        Screen.fullScreen = true;
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Music", volume);
    }

    public void SetSoundVolume(float volume)
    {
        audioMixer.SetFloat("Sound", volume);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
