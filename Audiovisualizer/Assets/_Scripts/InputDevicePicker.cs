using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDevicePicker : MonoBehaviour
{
    public GameObject audioGO;
    public List<string> inputDeviceList;

    private bool devicesAdded = false;

    private void Update()
    {
        if (audioGO.GetComponent<MicrophoneAudio>().options.Count > 0)
        {
            inputDeviceList = audioGO.GetComponent<MicrophoneAudio>().options;
            
            if (!devicesAdded)
            {
                GetComponent<Dropdown>().AddOptions(inputDeviceList);
                devicesAdded = true;
            }
        }
    }
}
