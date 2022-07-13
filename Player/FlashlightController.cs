using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlashlightController : MonoBehaviour
{
    [SerializeField] private AudioClip flashlightClip;
    [SerializeField] private AudioSource playerAudioSource;
    [SerializeField] private Light playerLightSource;

    public void OnFlashlightToggle(InputValue value)
    {
        if (InventoryController.Instance.HasFlashlight)
        {
            playerAudioSource.PlayOneShot(flashlightClip);
            playerLightSource.enabled = !playerLightSource.enabled;
        }
    }
}