using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [Header("Game Controller")]
    [Header("Sound")]
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private AudioClip ClickSound;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        myAudioSource.PlayOneShot(ClickSound);
    }

    public void PlayGame()
    {
        PlayClickSound();
        SceneManager.LoadScene("0");
    }

    public void QuitGame()
    {
        PlayClickSound();
        Application.Quit();
    }

}
