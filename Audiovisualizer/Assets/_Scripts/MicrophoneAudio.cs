using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicrophoneAudio : MonoBehaviour
{
    public GameObject ui;
    public static float MicLoudness;
    
    public int chosenDevice;
    public float frequency;
    public string microphone;
    public FFTWindow fftWindow;
    public List<string> options = new List<string>();
    public GameObject inputDevicePicker;

    int count;
    private bool inputDeviceExists = false;
    private AudioSource audioSource;

    private void Start()
    {
        ui.SetActive(false);

        audioSource = GetComponent<AudioSource>();

        if (Microphone.devices.Length > 0)
        {
            foreach (string device in Microphone.devices)
            {
                if (microphone == null)
                {
                    microphone = device;
                }

                count++;

                options.Add(device);
            }

            Debug.Log(count + " input device(s) detected. Defaulting to first device.");
            microphone = options[chosenDevice];
            inputDeviceExists = true;
            UpdateMicrophone();
        }

        else
        {
            Debug.Log("There is no input device detected.");
            inputDeviceExists = false;
        }
    }

    public void UpdateMicrophone()
    {
        if (inputDevicePicker.GetComponent<InputDevicePicker>().inputDeviceList.Count > 0 && inputDevicePicker.GetComponent<Dropdown>().options.Count > 0)
        {
            microphone = inputDevicePicker.GetComponent<Dropdown>().options[inputDevicePicker.GetComponent<Dropdown>().value].text;
        }

        if (inputDeviceExists)
        {
            audioSource.Stop();
            audioSource.clip = Microphone.Start(microphone, true, 10, AudioSettings.outputSampleRate);
            audioSource.loop = true;
            Debug.Log("Microphone is recording: " + Microphone.IsRecording(microphone).ToString());

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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!ui.activeInHierarchy)
            {
                ui.SetActive(true);
            }

            else
            {
                ui.SetActive(false);
            }
        }

        if (inputDeviceExists && ui.activeInHierarchy && inputDevicePicker.GetComponent<InputDevicePicker>().inputDeviceList.Count > 0 && inputDevicePicker.GetComponent<Dropdown>().options.Count > 0)
        {
            if (inputDevicePicker.GetComponent<Dropdown>().options[inputDevicePicker.GetComponent<Dropdown>().value].text != microphone)
            {
                microphone = inputDevicePicker.GetComponent<Dropdown>().options[inputDevicePicker.GetComponent<Dropdown>().value].text;
                UpdateMicrophone();
            }
        }
    }

    public void RefreshDeviceList()
    {
        Debug.Log("Device list refreshed.");
        options.Clear();
        count = 0;

        if (Microphone.devices.Length > 0)
        {
            foreach (string device in Microphone.devices)
            {
                if (microphone == null)
                {
                    microphone = device;
                }

                count++;

                options.Add(device);
            }

            Debug.Log(count + " input device(s) detected.");

            inputDevicePicker.GetComponent<InputDevicePicker>().devicesAdded = false;
            inputDevicePicker.GetComponent<Dropdown>().options.Clear();
            UpdateMicrophone();
        }

        else
        {
            Debug.Log("There is no input device detected.");
            inputDeviceExists = false;
        }
    }
}
