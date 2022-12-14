using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioReactParticleSize : MonoBehaviour
{
    public ParticleSystem particles;
    public int frequencyBand = 1;
    public float minSize = 1;
    public float scaleGain = 50;

    // Update is called once per frame
    void Update()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var sz = ps.sizeOverLifetime;
        sz.enabled = true;

        AnimationCurve curve = new AnimationCurve();
        curve.AddKey(0.0f, AudioMain._bandBuffer[frequencyBand] * scaleGain + minSize);
        curve.AddKey(0.1f, AudioMain._bandBuffer[frequencyBand] * scaleGain + minSize);

        sz.size = new ParticleSystem.MinMaxCurve(1.5f, curve);
    }
}
