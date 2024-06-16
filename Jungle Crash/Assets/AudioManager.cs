using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;
    public AudioMixerGroup soundEffectMixer;

    public static AudioManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de AudioManager dans la scène");
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playlist != null && playlist.Length > 0 && audioSource != null)
        {
            audioSource.clip = playlist[0];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Playlist is empty or AudioSource is not assigned.");
        }
    }

    public AudioSource PlayClipAt(AudioClip clip, Vector3 pos)
    {
        GameObject tempGO = new GameObject("TempAudio");
        tempGO.transform.position = pos;
        AudioSource tempAudioSource = tempGO.AddComponent<AudioSource>();
        tempAudioSource.clip = clip;
        tempAudioSource.outputAudioMixerGroup = soundEffectMixer;
        tempAudioSource.Play();
        Destroy(tempGO, clip.length);
        return tempAudioSource;
    }
}
