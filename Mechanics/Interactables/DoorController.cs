using System;
using System.Collections;
using UnityEngine;

public class DoorController : Interactable
{
    [Header("Door Properties")]
    [SerializeField] private bool doorIsLocked;

    [Header("Scene Transition")]
    public string outgoingScene;
    public string outgoingTelepoint;

    [Header("Audio")]
    [SerializeField] private AudioClip doorLockedSound;
    [SerializeField] private AudioClip doorOpenSound;

    protected override void Interact()
    {
        // Check to see if door is locked
        // If so, play doorLockedSound
        if (doorIsLocked)
        {
            AudioSource.PlayClipAtPoint(doorLockedSound, transform.position);
        }
        // If door isnt locked, then
        // TP player to new scene
        else
        {
            SceneController.Instance.incomingTelepoint = outgoingTelepoint;
            SceneController.Instance.LoadScene(outgoingScene);
        }
    }
}