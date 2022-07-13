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

    // Start is called before the first frame update
    void Start()
    {
        playerCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // Create a ray from the center of the camera
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
        RaycastHit hitInfo;
    }
}
