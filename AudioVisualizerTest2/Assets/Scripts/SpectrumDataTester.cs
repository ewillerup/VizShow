using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectrumDataTester : MonoBehaviour
{
    public static float[] samples = new float[512];

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }
}
