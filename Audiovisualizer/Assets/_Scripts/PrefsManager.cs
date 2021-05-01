using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefsManager : MonoBehaviour
{
    public ParticleSystem system1;
    public ParticleSystem system2;
    public ParticleSystem system3;
    public ParticleSystem system4;
    public ParticleSystem system5;
    public ParticleSystem system6;
    public ParticleSystem system7;
    public ParticleSystem system8;

    public GameObject colorPicker;
    public GameObject deletePresetButton;
    public GameObject saveCurrentPresetButton;

    public Dropdown colorPresetPicker;

    public List<Color> systemColors;
    public List<string> colorPresetOptions;

    private int numColorPresets;

    // Start is called before the first frame update
    void Start()
    {
        colorPresetOptions.Add("Default");

        AddColorPresetOptions();

        systemColors.Add(system1.main.startColor.color);
        systemColors.Add(system2.main.startColor.color);
        systemColors.Add(system3.main.startColor.color);
        systemColors.Add(system4.main.startColor.color);
        systemColors.Add(system5.main.startColor.color);
        systemColors.Add(system6.main.startColor.color);
        systemColors.Add(system7.main.startColor.color);
        systemColors.Add(system8.main.startColor.color);

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
    }

    private void Update()
    {
        numColorPresets = colorPresetOptions.Count;

        if (colorPresetPicker.value == 0)
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
        Color color1 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 1 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 1 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 1 (Blue)", 0));
        Color color2 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 2 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 2 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 2 (Blue)", 0));
        Color color3 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 3 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 3 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 3 (Blue)", 0));
        Color color4 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 4 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 4 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 4 (Blue)", 0));
        Color color5 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 5 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 5 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 5 (Blue)", 0));
        Color color6 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 6 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 6 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 6 (Blue)", 0));
        Color color7 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 7 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 7 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 7 (Blue)", 0));
        Color color8 = new Color(PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 8 (Red)", 1), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 8 (Green)", 0), PlayerPrefs.GetFloat(colorPresetOptions[colorPresetPicker.value] + ": Color 8 (Blue)", 0));

        ChangeColor(color1, system1);
        ChangeColor(color2, system2);
        ChangeColor(color3, system3);
        ChangeColor(color4, system4);
        ChangeColor(color5, system5);
        ChangeColor(color6, system6);
        ChangeColor(color7, system7);
        ChangeColor(color8, system8);

        if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_1)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system1.main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_2)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system2.main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_3)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system3.main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_4)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system4.main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().swirl_5)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system5.main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().square_1)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system6.main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().square_2)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system7.main.startColor.color;
        }

        else if (colorPicker.GetComponent<colorMenu>().particleToEdit == colorPicker.GetComponent<colorMenu>().square_3)
        {
            colorPicker.GetComponent<colorMenu>().colorPicker.CurrentColor = system8.main.startColor.color;
        }
    }

    public void SaveNewColorPreset()
    {
        systemColors.Clear();

        systemColors.Add(system1.main.startColor.color);
        systemColors.Add(system2.main.startColor.color);
        systemColors.Add(system3.main.startColor.color);
        systemColors.Add(system4.main.startColor.color);
        systemColors.Add(system5.main.startColor.color);
        systemColors.Add(system6.main.startColor.color);
        systemColors.Add(system7.main.startColor.color);
        systemColors.Add(system8.main.startColor.color);

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

        colorPresetOptions.Add("Preset " + numColorPresets);
        
        AddColorPresetOptions();
    }

    public void SaveShapes()
    {

    }

    public void SaveCurrentPreset()
    {
        systemColors.Clear();

        systemColors.Add(system1.main.startColor.color);
        systemColors.Add(system2.main.startColor.color);
        systemColors.Add(system3.main.startColor.color);
        systemColors.Add(system4.main.startColor.color);
        systemColors.Add(system5.main.startColor.color);
        systemColors.Add(system6.main.startColor.color);
        systemColors.Add(system7.main.startColor.color);
        systemColors.Add(system8.main.startColor.color);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 1 (Red)", systemColors[0].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 1 (Green)", systemColors[0].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 1 (Blue)", systemColors[0].b);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 2 (Red)", systemColors[1].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 2 (Green)", systemColors[1].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 2 (Blue)", systemColors[1].b);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 3 (Red)", systemColors[2].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 3 (Green)", systemColors[2].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 3 (Blue)", systemColors[2].b);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 4 (Red)", systemColors[3].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 4 (Green)", systemColors[3].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 4 (Blue)", systemColors[3].b);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 5 (Red)", systemColors[4].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 5 (Green)", systemColors[4].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 5 (Blue)", systemColors[4].b);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 6 (Red)", systemColors[5].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 6 (Green)", systemColors[5].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 6 (Blue)", systemColors[5].b);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 7 (Red)", systemColors[6].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 7 (Green)", systemColors[6].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 7 (Blue)", systemColors[6].b);

        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 8 (Red)", systemColors[7].r);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 8 (Green)", systemColors[7].g);
        PlayerPrefs.SetFloat("Preset " + colorPresetPicker.value + ": Color 8 (Blue)", systemColors[7].b);
    }

    public void DeletePreset()
    {
        colorPresetOptions.Remove(colorPresetOptions[colorPresetPicker.value]);

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 1 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 1 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 1 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 2 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 2 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 2 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 3 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 3 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 3 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 4 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 4 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 4 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 5 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 5 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 5 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 6 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 6 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 6 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 7 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 7 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 7 (Blue)");

        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 8 (Red)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 8 (Green)");
        PlayerPrefs.DeleteKey("Preset " + colorPresetPicker.value + ": Color 8 (Blue)");

        colorPresetPicker.value = 0;
        AddColorPresetOptions();
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
        colorPresetPicker.options.Clear();
        colorPresetPicker.AddOptions(colorPresetOptions);
    }
}
