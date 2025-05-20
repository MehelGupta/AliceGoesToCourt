using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InteractionDetector : MonoBehaviour
{
    private NPCInteractable interactableRange = null; //closest Interactable
    public GameObject interactionIcon;

    // Start is called before the first frame update
    void Start()
    {
        interactionIcon.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            interactableRange?.Interact();
        }
        
    }
    public void skipDialogue()
    {
        interactableRange?.Interact();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out NPCInteractable interactable) && interactable.CanInteract())
        {
            interactableRange = interactable;
            interactionIcon.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out NPCInteractable interactable) && interactable == interactableRange)
        {
            interactableRange = null;
            interactionIcon.SetActive(false);
            interactable.EndDialogue();
        }
    }
}
