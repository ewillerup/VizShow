using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public List<Color> systemColors;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void LoadPrefs()
    {
        Color color1 = new Color(PlayerPrefs.GetFloat("Color 1 (Red)", 1), PlayerPrefs.GetFloat("Color 1 (Green)", 0), PlayerPrefs.GetFloat("Color 1 (Blue)", 0));
        Color color2 = new Color(PlayerPrefs.GetFloat("Color 2 (Red)", 1), PlayerPrefs.GetFloat("Color 2 (Green)", 0), PlayerPrefs.GetFloat("Color 2 (Blue)", 0));
        Color color3 = new Color(PlayerPrefs.GetFloat("Color 3 (Red)", 1), PlayerPrefs.GetFloat("Color 3 (Green)", 0), PlayerPrefs.GetFloat("Color 3 (Blue)", 0));
        Color color4 = new Color(PlayerPrefs.GetFloat("Color 4 (Red)", 1), PlayerPrefs.GetFloat("Color 4 (Green)", 0), PlayerPrefs.GetFloat("Color 4 (Blue)", 0));
        Color color5 = new Color(PlayerPrefs.GetFloat("Color 5 (Red)", 1), PlayerPrefs.GetFloat("Color 5 (Green)", 0), PlayerPrefs.GetFloat("Color 5 (Blue)", 0));
        Color color6 = new Color(PlayerPrefs.GetFloat("Color 6 (Red)", 1), PlayerPrefs.GetFloat("Color 6 (Green)", 0), PlayerPrefs.GetFloat("Color 6 (Blue)", 0));
        Color color7 = new Color(PlayerPrefs.GetFloat("Color 7 (Red)", 1), PlayerPrefs.GetFloat("Color 7 (Green)", 0), PlayerPrefs.GetFloat("Color 7 (Blue)", 0));
        Color color8 = new Color(PlayerPrefs.GetFloat("Color 8 (Red)", 1), PlayerPrefs.GetFloat("Color 8 (Green)", 0), PlayerPrefs.GetFloat("Color 8 (Blue)", 0));

        ChangeColor(color1, system1);
        ChangeColor(color2, system2);
        ChangeColor(color3, system3);
        ChangeColor(color4, system4);
        ChangeColor(color5, system5);
        ChangeColor(color6, system6);
        ChangeColor(color7, system7);
        ChangeColor(color8, system8);
    }

    public void SaveColors()
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

        PlayerPrefs.SetFloat("Color 1 (Red)", systemColors[0].r);
        PlayerPrefs.SetFloat("Color 1 (Green)", systemColors[0].g);
        PlayerPrefs.SetFloat("Color 1 (Blue)", systemColors[0].b);

        PlayerPrefs.SetFloat("Color 2 (Red)", systemColors[1].r);
        PlayerPrefs.SetFloat("Color 2 (Green)", systemColors[1].g);
        PlayerPrefs.SetFloat("Color 2 (Blue)", systemColors[1].b);

        PlayerPrefs.SetFloat("Color 3 (Red)", systemColors[2].r);
        PlayerPrefs.SetFloat("Color 3 (Green)", systemColors[2].g);
        PlayerPrefs.SetFloat("Color 3 (Blue)", systemColors[2].b);

        PlayerPrefs.SetFloat("Color 4 (Red)", systemColors[3].r);
        PlayerPrefs.SetFloat("Color 4 (Green)", systemColors[3].g);
        PlayerPrefs.SetFloat("Color 4 (Blue)", systemColors[3].b);

        PlayerPrefs.SetFloat("Color 5 (Red)", systemColors[4].r);
        PlayerPrefs.SetFloat("Color 5 (Green)", systemColors[4].g);
        PlayerPrefs.SetFloat("Color 5 (Blue)", systemColors[4].b);

        PlayerPrefs.SetFloat("Color 6 (Red)", systemColors[5].r);
        PlayerPrefs.SetFloat("Color 6 (Green)", systemColors[5].g);
        PlayerPrefs.SetFloat("Color 6 (Blue)", systemColors[5].b);

        PlayerPrefs.SetFloat("Color 7 (Red)", systemColors[6].r);
        PlayerPrefs.SetFloat("Color 7 (Green)", systemColors[6].g);
        PlayerPrefs.SetFloat("Color 7 (Blue)", systemColors[6].b);

        PlayerPrefs.SetFloat("Color 8 (Red)", systemColors[7].r);
        PlayerPrefs.SetFloat("Color 8 (Green)", systemColors[7].g);
        PlayerPrefs.SetFloat("Color 8 (Blue)", systemColors[7].b);
    }

    public void SaveShapes()
    {

    }

    private void ChangeColor(Color color, ParticleSystem particle)
    {
        try
        {
            var main = particle.main;
            main.startColor = color;
            Debug.Log("Fucking did it");
        }

        catch { }
    }
}
