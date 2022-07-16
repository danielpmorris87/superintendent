using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Message to display player
    public string promptMessage;

    // This function will be called from our player
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // No code here in this function
        // Its a template function to be overwritten by our subclasses
    }
}