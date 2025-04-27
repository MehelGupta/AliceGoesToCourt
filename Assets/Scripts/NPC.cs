using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;
    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if(dialoguePanel.activeInHierarchy)
            {
                zeroText();
                Debug.Log("zeroig true");
            }
            else
            {
                Debug.Log("ok set active true");
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        //if the current text is equal to what its supposed to be
        //then go show the button
        if(dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
        
    }
    //empty the text box
    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }
    //Types one character by one making it seem like a typewriter
    IEnumerator Typing()
    {
        foreach (char c in dialogue[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    //continues typing or clears it if there is nothing else to say
    public void NextLine()
    {
        contButton.SetActive(false);
        
        if(index < dialogue.Length-1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }
    //when the player is within range of the npc or not
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsClose = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}
