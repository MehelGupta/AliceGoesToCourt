using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject mainMenu; // UI element to control

    public void ToggleUIElement()
    {
        if (mainMenu.activeSelf)
        {
            mainMenu.SetActive(false); // Hide the UI element
        }
        else
        {
            mainMenu.SetActive(true); // Show the UI element
        }
    }
}
