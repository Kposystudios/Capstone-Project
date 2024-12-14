using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip ---------")]
    public AudioClip Background;
    public AudioClip Death;

    private void Start()
    {
        MusicSource.clip = Background;
        MusicSource.Play();
    }
}
