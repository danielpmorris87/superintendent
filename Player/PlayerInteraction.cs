using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactDistance = 1f;
    [SerializeField] private LayerMask interactMask;
    [SerializeField] private PlayerUI playerUI;

    private Camera playerCam;
    public InputAction ButtonInteract;

    void Start()
    {
        playerCam = GetComponent<Camera>();
        ButtonInteract.Enable();
    }

    void Update()
    {
        // Create a ray from the center of the camera
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, interactDistance, interactMask.value))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdatePromptText(interactable.promptMessage);
                if (ButtonInteract.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
