using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AVParticle : MonoBehaviour
{
    public int _band;
    public float _minAlpha, _maxAlpha;
    ParticleSystem _ps;
    ParticleSystem.MainModule _main;

    // Start is called before the first frame update
    void Start()
    {
        _ps = GetComponent<ParticleSystem>();
        _main = _ps.main;
        _main.startColor = new Color(_main.startColor.color.r, _main.startColor.color.g, _main.startColor.color.b, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (MicrophoneAudio.MicLoudness < 0.0001f)
        {
            _main.startColor = new Color(_main.startColor.color.r, _main.startColor.color.g, _main.startColor.color.b, 0);
        }

        else
        {
            _main.startColor = new Color(_main.startColor.color.r, _main.startColor.color.g, _main.startColor.color.b, (AudioMainOld._audioBandBuffer[_band - 1] * (_maxAlpha - _minAlpha)) + _minAlpha);
        }
    }
}
