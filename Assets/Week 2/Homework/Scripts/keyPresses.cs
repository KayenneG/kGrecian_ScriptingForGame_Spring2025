using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class keyPresses : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;

    public Image pressOne;
    public Image pressTwo;
    public Image pressThree;

    public GameObject directionalLight;

    public Transform tOne;
    public Transform tTwo;
    public Transform tThree;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            pressOne.color = Color.green;
            pressTwo.color = Color.white;
            pressThree.color = Color.white;
            directionalLight.transform.rotation = tOne.rotation;
            PlayMusicOne();
        }

        if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            pressTwo.color = Color.green;
            pressThree.color = Color.white;
            pressOne.color = Color.white;
            directionalLight.transform.rotation = tTwo.rotation;
            PlayMusicTwo();
        }

        if ( Input.GetKeyDown(KeyCode.Keypad3))
        {
            pressThree.color = Color.green;
            pressOne.color = Color.white;
            pressTwo.color= Color.white;
            directionalLight.transform.rotation = tThree.rotation;
            PlayMusicThree();
        }
    }

    void PlayMusicOne()
    {
        musicSource.Stop();
        musicSource.clip = music1;
        musicSource.Play();
    }

    void PlayMusicTwo()
    {
        musicSource.Stop();
        musicSource.clip = music2;
        musicSource.Play();
    }

    void PlayMusicThree()
    {
        musicSource.Stop();
        musicSource.clip = music3;
        musicSource.Play();
    }
}
