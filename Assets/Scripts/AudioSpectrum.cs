using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class AudioSpectrum : MonoBehaviour
{
    public static float[] _sample = new float[512];
    AudioSource _audioSource;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }


    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_sample,0,FFTWindow.Blackman);
    }
}
