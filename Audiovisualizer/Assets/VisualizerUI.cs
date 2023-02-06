using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizerUI : MonoBehaviour
{
    void Start() {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel")) this.gameObject.SetActive(true);
    }
}
