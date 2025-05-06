using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingsMenu : MonoBehaviour
{
    public void SetTypingSpeed (float speed)
    {
        NPC[] npcs = FindObjectsByType<NPC>(FindObjectsSortMode.None);
        Debug.Log("changed speed");
        for(int i = 0; i < npcs.Length; i++)
        {
            npcs[i].setTypingSpeed(speed);
        }
    }
    public void skipDialouge(float skipOrNoSkip)
    {
        NPC[] npcs = FindObjectsByType<NPC>(FindObjectsSortMode.None);
        if (skipOrNoSkip == 0)
        {
            Debug.Log("changed skip");
            for(int i = 0; i < npcs.Length; i++)
            {
                npcs[i].setAutoSkipOverride(false);
            }
        }
        if (skipOrNoSkip == 1)
        {
            Debug.Log("changed skip");
            for(int i = 0; i < npcs.Length; i++)
            {
                npcs[i].setAutoSkipOverride(true);
            }
        }
    }
}
