using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDevicePicker : MonoBehaviour
{
    public GameObject audioGO;
    public List<string> inputDeviceList;
    public bool devicesAdded = false;

    private void Update()
    {
        if (audioGO.GetComponent<AudioMicrophone>().options.Count > 0)
        {
            inputDeviceList = audioGO.GetComponent<AudioMicrophone>().options;
            
            if (!devicesAdded)
            {
                GetComponent<Dropdown>().AddOptions(inputDeviceList);
                devicesAdded = true;
            }
        }
    }
}
