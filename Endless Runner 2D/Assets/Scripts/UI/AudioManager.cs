using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Background Music")]
    [SerializeField] private AudioClip bgMusic;
    [SerializeField] private AudioClip shoot;
    [SerializeField] private AudioClip explosion;

    public static AudioManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if(musicSource != null && bgMusic != null)
        {
            musicSource.clip = bgMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    public void PlayShoot()
    {
        sfxSource.PlayOneShot(shoot);
    }

    public void PlayExplosion()
    {
        sfxSource.PlayOneShot(explosion);
    }
}