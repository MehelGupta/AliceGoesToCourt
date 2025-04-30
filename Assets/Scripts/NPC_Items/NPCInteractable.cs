using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface NPCInteractable
{
    public void Interact();
    
    bool CanInteract();
}
