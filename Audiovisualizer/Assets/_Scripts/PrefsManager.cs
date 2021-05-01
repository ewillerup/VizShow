using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefsManager : MonoBehaviour
{
    public ParticleSystem[] systems;

    public GameObject colorPicker;
    public GameObject deletePresetButton;
    public GameObject saveCurrentPresetButton;

    public Dropdown presetPicker;
    public Dropdown[] shapePickers;

    public List<Color> systemColors;
    public List<string> colorPresetOptions;

    private int numColorPresets;

    Material swirl1;
    Material swirl2;
    Material swirl3;
    Material swirl4;
    Material swirl5;
    Material square1;
    Material square2;
    Material square3;
    Material square4;
    Material square5;
    Material curve1;
    Material curve2;
    Material curve3;
    Material curve4;
    Material curve5;

    // Start is called before the first frame update
    void Start()
    {
        swirl1 = Resources.Load("_swirl1Particle", typeof(Material)) as Material;
        swirl2 = Resources.Load("_swirl2Particle", typeof(Material)) as Material;
        swirl3 = Resources.Load("_swirl3Particle", typeof(Material)) as Material;
        swirl4 = Resources.Load("_swirl4Particle", typeof(Material)) as Material;
        swirl5 = Resources.Load("_swirl5Particle", typeof(Material)) as Material;
        square1 = Resources.Load("_square1Particle", typeof(Material)) as Material;
        square2 = Resources.Load("_square2Particle", typeof(Material)) as Material;
        square3 = Resources.Load("_square3Particle", typeof(Material)) as Material;
        square4 = Resources.Load("_square4Particle", typeof(Material)) as Material;
        square5 = Resources.Load("_square5Particle", typeof(Material)) as Material;
        curve1 = Resources.Load("_curve1Particle", typeof(Material)) as Material;
        curve2 = Resources.Load("_curve2Particle", typeof(Material)) as Material;
        curve3 = Resources.Load("_curve3Particle", typeof(Material)) as Material;
        curve4 = Resources.Load("_curve4Particle", typeof(Material)) as Material;
        curve5 = Resources.Load("_curve5Particle", typeof(Material)) as Material;

        colorPresetOptions.Add("Default");

        AddColorPresetOptions();

        foreach (ParticleSystem system in systems)
        {
            systemColors.Add(system.main.startColor.color);
        }

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 1 (Red)", systemColors[0].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 1 (Green)", systemColors[0].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 1 (Blue)", systemColors[0].b);

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 2 (Red)", systemColors[1].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 2 (Green)", systemColors[1].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 2 (Blue)", systemColors[1].b);

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 3 (Red)", systemColors[2].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 3 (Green)", systemColors[2].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 3 (Blue)", systemColors[2].b);

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 4 (Red)", systemColors[3].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 4 (Green)", systemColors[3].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 4 (Blue)", systemColors[3].b);

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 5 (Red)", systemColors[4].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 5 (Green)", systemColors[4].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 5 (Blue)", systemColors[4].b);

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 6 (Red)", systemColors[5].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 6 (Green)", systemColors[5].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 6 (Blue)", systemColors[5].b);

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 7 (Red)", systemColors[6].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 7 (Green)", systemColors[6].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 7 (Blue)", systemColors[6].b);

        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 8 (Red)", systemColors[7].r);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 8 (Green)", systemColors[7].g);
        PlayerPrefs.SetFloat(colorPresetOptions[0] + ": Color 8 (Blue)", systemColors[7].b);

        systems[0].GetComponent<ParticleSystemRenderer>().material = swirl1;
        systems[1].GetComponent<ParticleSystemRenderer>().material = swirl2;
        systems[2].GetComponent<ParticleSystemRenderer>().material = swirl3;
        systems[3].GetComponent<ParticleSystemRenderer>().material = swirl4;
        systems[4].GetComponent<ParticleSystemRenderer>().material = swirl5;
        systems[5].GetComponent<ParticleSystemRenderer>().material = square1;
        systems[6].GetComponent<ParticleSystemRenderer>().material = square2;
        systems[7].GetComponent<ParticleSystemRenderer>().material = square3;

        for (int i = 0; i < systems.Length; i++)
        {
            PlayerPrefs.SetInt(colorPresetOptions[0] + ": Shape " + (i + 1), shapePickers[i].value);
        }
    }

    private void Update()
    {
        numColorPresets = colorPresetOptions.Count;

        if (presetPicker.value == 0)
        {
            deletePresetButton.SetActive(false);
            saveCurrentPresetButton.SetActive(false);
        }

        else
        {
            deletePresetButton.SetActive(true);
            saveCurrentPresetButton.SetActive(true);
        }
    }

    public void LoadPrefs()
    {
        Color color1 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 1 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 1 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 1 (Blue)", 0));
        Color color2 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 2 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 2 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 2 (Blue)", 0));
        Color color3 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 3 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 3 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 3 (Blue)", 0));
        Color color4 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 4 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 4 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 4 (Blue)", 0));
        Color color5 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 5 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 5 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 5 (Blue)", 0));
        Color color6 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 6 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 6 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 6 (Blue)", 0));
        Color color7 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 7 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 7 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 7 (Blue)", 0));
        Color color8 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 8 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 8 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[presetPicker.value] + ": Color 8 (Blue)", 0));

        ChangeColor(color1, systems[0]);
        ChangeColor(color2, systems[1]);
        ChangeColor(color3, systems[2]);
        ChangeColor(color4, systems[3]);
        ChangeColor(color5, systems[4]);
        ChangeColor(color6, systems[5]);
        ChangeColor(color7, systems[6]);
        ChangeColor(color8, systems[7]);

        if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_1)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[0].main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_2)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[1].main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_3)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[2].main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_4)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[3].main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_5)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[4].main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().square_1)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[5].main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().square_2)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[6].main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().square_3)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = systems[7].main.startColor.color;
        }

        for (int i = 0; i < systems.Length; i++)
        {
            if (presetPicker.value == 0)
            {
                shapePickers[i].value = PlayerPrefs.GetInt("Default: Shape " + (i + 1));
            }

            else
            {
                shapePickers[i].value = PlayerPrefs.GetInt("Preset " + presetPicker.value + ": Shape " + (i + 1));
            }
        }

        ChangeShape();
    }

    public void ChangeShape()
    {
        for (int i = 0; i < shapePickers.Length; i++)
        {
            switch (shapePickers[i].value)
            {
                case 0:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = curve1;
                    break;

                case 1:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = curve2;
                    break;

                case 3:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = curve3;
                    break;

                case 4:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = curve4;
                    break;

                case 5:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = curve5;
                    break;

                case 6:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = square1;
                    break;

                case 7:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = square2;
                    break;

                case 8:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = square3;
                    break;

                case 9:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = square4;
                    break;

                case 10:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = square5;
                    break;

                case 11:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = swirl1;
                    break;

                case 12:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = swirl2;
                    break;

                case 13:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = swirl3;
                    break;

                case 14:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = swirl4;
                    break;

                default:
                    systems[i].GetComponent<ParticleSystemRenderer>().material = swirl5;
                    break;
            }
        }
    }

    public void SaveNewPreset()
    {
        systemColors.Clear();

        foreach (ParticleSystem system in systems)
        {
            systemColors.Add(system.main.startColor.color);
        }

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 1 (Red)", systemColors[0].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 1 (Green)", systemColors[0].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 1 (Blue)", systemColors[0].b);

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 2 (Red)", systemColors[1].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 2 (Green)", systemColors[1].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 2 (Blue)", systemColors[1].b);

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 3 (Red)", systemColors[2].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 3 (Green)", systemColors[2].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 3 (Blue)", systemColors[2].b);

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 4 (Red)", systemColors[3].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 4 (Green)", systemColors[3].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 4 (Blue)", systemColors[3].b);

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 5 (Red)", systemColors[4].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 5 (Green)", systemColors[4].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 5 (Blue)", systemColors[4].b);

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 6 (Red)", systemColors[5].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 6 (Green)", systemColors[5].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 6 (Blue)", systemColors[5].b);

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 7 (Red)", systemColors[6].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 7 (Green)", systemColors[6].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 7 (Blue)", systemColors[6].b);

        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 8 (Red)", systemColors[7].r);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 8 (Green)", systemColors[7].g);
        PlayerPrefs.SetFloat("Preset " + numColorPresets + ": Color 8 (Blue)", systemColors[7].b);

        for (int i = 0; i < systems.Length; i++)
        {
            PlayerPrefs.SetInt("Preset " + numColorPresets + ": Shape " + (i + 1), shapePickers[i].value);
        }

        colorPresetOptions.Add("Preset " + numColorPresets);
        
        AddColorPresetOptions();
    }

    public void SaveCurrentPreset()
    {
        systemColors.Clear();

        foreach (ParticleSystem system in systems)
        {
            systemColors.Add(system.main.startColor.color);
        }

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 1 (Red)", systemColors[0].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 1 (Green)", systemColors[0].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 1 (Blue)", systemColors[0].b);

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 2 (Red)", systemColors[1].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 2 (Green)", systemColors[1].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 2 (Blue)", systemColors[1].b);

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 3 (Red)", systemColors[2].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 3 (Green)", systemColors[2].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 3 (Blue)", systemColors[2].b);

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 4 (Red)", systemColors[3].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 4 (Green)", systemColors[3].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 4 (Blue)", systemColors[3].b);

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 5 (Red)", systemColors[4].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 5 (Green)", systemColors[4].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 5 (Blue)", systemColors[4].b);

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 6 (Red)", systemColors[5].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 6 (Green)", systemColors[5].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 6 (Blue)", systemColors[5].b);

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 7 (Red)", systemColors[6].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 7 (Green)", systemColors[6].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 7 (Blue)", systemColors[6].b);

        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 8 (Red)", systemColors[7].r);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 8 (Green)", systemColors[7].g);
        PlayerPrefs.SetFloat("Preset " + presetPicker.value + ": Color 8 (Blue)", systemColors[7].b);

        for (int i = 0; i < systems.Length; i++)
        {
            PlayerPrefs.SetInt("Preset " + presetPicker.value + ": Shape " + (i + 1), shapePickers[i].value);
        }
    }

    public void DeletePreset()
    {
        colorPresetOptions.Remove(colorPresetOptions[presetPicker.value]);

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 1 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 1 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 1 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 2 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 2 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 2 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 3 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 3 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 3 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 4 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 4 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 4 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 5 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 5 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 5 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 6 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 6 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 6 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 7 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 7 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 7 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 8 (Red)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 8 (Green)");
        PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Color 8 (Blue)");

        for (int i = 0; i < systems.Length; i++)
        {
            PlayerPrefs.DeleteKey("Preset " + presetPicker.value + ": Shape " + (i + 1));
        }

        presetPicker.value = 0;
        AddColorPresetOptions();
    }

    public void ResetToDefault()
    {
        LoadPrefs();
    }

    private void ChangeColor(Color color, ParticleSystem particle)
    {
        try
        {
            var main = particle.main;
            main.startColor = color;
        }

        catch { }
    }

    private void AddColorPresetOptions()
    {
        presetPicker.options.Clear();
        presetPicker.AddOptions(colorPresetOptions);
    }
}
