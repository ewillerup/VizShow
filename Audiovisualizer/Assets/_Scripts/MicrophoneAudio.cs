using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneAudio : MonoBehaviour
{
    public float frequency;
    public int audioSampleRate = 44100;
    public string microphone;
    public FFTWindow fftWindow;

    private int samples = 8192;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        foreach (string device in Microphone.devices)
        {
            if (microphone == null)
            {
                microphone = device;
            }
        }

        UpdateMicrophone();
    }

    void UpdateMicrophone()
    {
        audioSource.Stop();
        audioSource.clip = Microphone.Start(microphone, true, 10, audioSampleRate);
        audioSource.loop = true;
        Debug.Log(Microphone.IsRecording(microphone).ToString());

        if (Microphone.IsRecording(microphone))
        {
            while (!(Microphone.GetPosition(microphone) > 0))
            {
                // Wait until recording starts
            }

            Debug.Log("Started recording with " + microphone);
            audioSource.Play();
        }

        else
        {
            Debug.Log(microphone + " is not recording properly.");
        }
    }
}
