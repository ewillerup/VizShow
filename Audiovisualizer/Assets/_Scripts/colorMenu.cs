using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HSVPicker;
using TMPro;

public class colorMenu : MonoBehaviour
{
    public ParticleSystem swirl_1;
    public ParticleSystem swirl_2;
    public ParticleSystem swirl_3;
    public ParticleSystem swirl_4;
    public ParticleSystem swirl_5;
    public ParticleSystem square_1;
    public ParticleSystem square_2;
    public ParticleSystem square_3;
    private ParticleSystem particleToEdit;
    private ColorPicker colorPicker;

    private void Start()
    {
        colorPicker = FindObjectOfType<ColorPicker>();
        colorPicker.CurrentColor = swirl_1.main.startColor.color;
    }

    public void OnDropdownChanged(int index)
    {
        if(index == 0)
        {
            particleToEdit = swirl_1;
            colorPicker.CurrentColor = swirl_1.main.startColor.color;
        }
        else if(index == 1)
        {
            particleToEdit = swirl_2;
            colorPicker.CurrentColor = swirl_2.main.startColor.color;
        }
        else if (index == 2)
        {
            particleToEdit = swirl_3;
            colorPicker.CurrentColor = swirl_3.main.startColor.color;
        }
        else if (index == 3)
        {
            particleToEdit = swirl_4;
            colorPicker.CurrentColor = swirl_4.main.startColor.color;
        }
        else if (index == 4)
        {
            particleToEdit = swirl_5;
            colorPicker.CurrentColor = swirl_5.main.startColor.color;
        }
        else if (index == 5)
        {
            particleToEdit = square_1;
            colorPicker.CurrentColor = square_1.main.startColor.color;
        }
        else if (index == 6)
        {
            particleToEdit = square_2;
            colorPicker.CurrentColor = square_2.main.startColor.color;
        }
        else if (index == 7)
        {
            particleToEdit = square_3;
            colorPicker.CurrentColor = square_3.main.startColor.color;
        }
    }

    public void OnSelectedColor(Color color)
    {
        ChangeColor(color, particleToEdit);
    }

    private void ChangeColor(Color color, ParticleSystem particle)
    {
        try
        {
            var main = particle.main;
            main.startColor = color;
        }
        catch{}
        
    }
}
