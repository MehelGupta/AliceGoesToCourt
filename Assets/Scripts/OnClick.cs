using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject uiElement; // UI element to control

    public void ToggleUIElement()
    {
        if (uiElement.activeSelf)
        {
            uiElement.SetActive(false); // Hide the UI element
        }
        else
        {
            uiElement.SetActive(true); // Show the UI element
        }
    }
}
