using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskForNPC : MonoBehaviour
{
    public GameObject questItem;
    public NPCDialogue dialogueData;
    public string[] oldDialougeLines;
    public bool[] oldAutoProgressLines;
    public string[] newDialougeLines;
    public bool[] newAutoProgressLines;

    private void Update()
    {
        if (questItem.activeSelf == false)
        {
            dialogueData.dialogueLines = newDialougeLines;
            dialogueData.autoProgressLines = newAutoProgressLines;
        }

        if (questItem.activeSelf == true)
        {
            dialogueData.dialogueLines = oldDialougeLines;
            dialogueData.autoProgressLines = oldAutoProgressLines;
        }
    }

}
