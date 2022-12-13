using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColorFade : MonoBehaviour
{
    // public Color color1 = Color.red;
    // public Color color2 = Color.yellow;
    // public Color color3 = Color.blue;

    public Gradient myGradient;
    public float strobeDuration = 15f;
    
    // Color lerp1;
    // Color lerp2;

    // Color colorOutput;

    void Update()
    {
        // lerp1 = Color.Lerp(color1, color2, Mathf.PingPong(Time.time * strobeDuration, 1));
        // lerp2 = Color.Lerp(color2, color3, Mathf.PingPong(Time.time * strobeDuration, 1));
        // colorOutput = Color.Lerp(lerp1, lerp2, Mathf.PingPong(Time.time * strobeDuration, 1));

        // Debug.Log(colorOutput);

        float t = Mathf.PingPong(Time.time / strobeDuration, 1f);

        this.GetComponent<Camera>().backgroundColor = myGradient.Evaluate(t);
    }
}
