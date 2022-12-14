using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScaleBounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(transform.localScale.x, AudioMain._bandBuffer[3] * 5000, transform.localScale.z);
    }
}
