using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
