using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorMenuButton : MonoBehaviour
{
    public GameObject colorMenuUI;

    public void OpenCloseMenu()
    {
        if (!colorMenuUI.activeSelf)
        {
            colorMenuUI.SetActive(true);
        }
        else
        {
            colorMenuUI.SetActive(false);
        }
    }
}
