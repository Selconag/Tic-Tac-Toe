using UnityEngine;

public class AudioManager : MonoBehaviour 
{
    public static AudioManager Instance { get; private set; }

    void Awake()
    {
        Instance = this;
    }

    public AudioSource AudioSource;
    public AudioClip SuccessSound;
    public AudioClip FailureSound;
    public AudioClip MergeSound;
    public AudioClip WrongMergeSound;
    public AudioClip LevelCompleteSound;
    public AudioClip CreakyDoorSound;

    public void PlayCustomSoundSound(AudioClip customClip)
    {
        AudioSource.clip = customClip;
        AudioSource.Play();
    }

    public void PlaySuccessSound()
    {
        AudioSource.clip = SuccessSound;
        AudioSource.Play();
    }
    public void PlayFailureSound()
    {
        AudioSource.clip = FailureSound;
        AudioSource.Play();
    }
    public void PlayMergeSound()
    {
        AudioSource.clip = MergeSound;
        AudioSource.Play();
    }
    public void PlayWrongMergeSound()
    {
        AudioSource.clip = WrongMergeSound;
        AudioSource.Play();
    }
    public void PlayLevelCompleteSound()
    {
        AudioSource.clip = LevelCompleteSound;
        AudioSource.Play();
    }

    public void PlayCreakyDoorSound()
    {
        AudioSource.clip = CreakyDoorSound;
        AudioSource.Play();
    }
}

