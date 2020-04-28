using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        // Find the sound
        Sound s = Array.Find(sounds, sound => sound.name == name);

        // If sound is not found, error
        if (s == null)
            return;

        // If the game is paused, lower the volume
        if (PauseGame.isGamePaused)
        {
            s.source.pitch *= 0.05f;
            s.source.volume *= 0.1f;
        }

        // Play the sound
        s.source.Play();
    }
}
