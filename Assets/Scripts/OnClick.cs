using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject mainMenu; // UI element to control
    public GameObject settingsMenu; // UI element to control
    public GameObject controlsMenu; // UI element to control

    public GameObject journalMenu; // UI element to control
    public GameObject dialougeScreen;
    private bool isDialougeActive;
    private void Update()
    {
        if (dialougeScreen.activeSelf)
            isDialougeActive = true;
        else
            isDialougeActive = false;
    }


    public void BackButton()
    {
        if (settingsMenu.activeSelf)
        {
            settingsMenu.SetActive(false);
        }
        else if(controlsMenu.activeSelf)
        {
            controlsMenu.SetActive(false);
        }
        else if(journalMenu.activeSelf)
        {
            journalMenu.SetActive(false);
        }
        else if(mainMenu.activeSelf)
        {
            mainMenu.SetActive(false);
        }
        
    }
    public void openSettings()
    {
        settingsMenu.SetActive(true);
    }
    public void openJournal()
    {
        journalMenu.SetActive(true);
    }
    public void openControls()
    {
        controlsMenu.SetActive(true);
    }
    public void openMainMenu()
    {
        if(isDialougeActive == false)
            mainMenu.SetActive(true);
    }
}
