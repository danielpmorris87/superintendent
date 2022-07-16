using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightPickup : Interactable
{
    [SerializeField] private AudioClip _clip;

    protected override void Interact()
    {
        InventoryController.Instance.HasFlashlight = true;
        AudioSource.PlayClipAtPoint(_clip, transform.position);
        Destroy(gameObject);
    }
}