using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NPC : MonoBehaviour, NPCInteractable 
{
    public float typingSpeed;
    public NPCDialogue dialogueData;
    public GameObject dialoguePanel;
    public Text dialogueText, nameText;
    public Image portraitImage;
    private int index;
    private bool isTyping, isDialougeActive;

    public void Interact()
    {
        Debug.Log("INteracting");
        /*
        if (dialogueData == null || !isDialougeActive)
            return;
        */
        if (isDialougeActive)
        {
            NextLine();
        }
        else
        {
            StartDialogue();
        }
    }

    public bool CanInteract()
    {
        return !isDialougeActive;
    }

    void StartDialogue()
    {
        isDialougeActive = true;
        index = 0;

        nameText.text = dialogueData.npcName;
        nameText.color = dialogueData.npcTextColor;
        portraitImage.sprite = dialogueData.npcPortrait;

        dialoguePanel.SetActive(true);
         
        StartCoroutine(TypeLine());
    }

    void NextLine()
    {
        if(isTyping)
        {
            //skip typing animation and show the full thing
            StopAllCoroutines();
            dialogueText.text = dialogueData.dialogueLines[index];
            isTyping = false;
        }
        else if(++index < dialogueData.dialogueLines.Length)
        {
            //If another line type next
            StartCoroutine(TypeLine());
        }
        else
        {
            EndDialogue();
        }
    
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        dialogueText.text = "";

        foreach(char letter in dialogueData.dialogueLines[index])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;

        if(dialogueData.autoProgressLines.Length > index && dialogueData.autoProgressLines[index])
        {
            yield return new WaitForSeconds(dialogueData.autoProgressDelay);
            NextLine();
        }
    }

    public void EndDialogue()
    {
        StopAllCoroutines();
        isDialougeActive = false;
        dialogueText.text = "";
        dialoguePanel.SetActive(false);

    }

    public void setTypingSpeed (float typingSpeeds)
    {
        typingSpeed = typingSpeeds;
    }
}
