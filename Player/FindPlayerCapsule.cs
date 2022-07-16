using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayerCapsule : MonoBehaviour
{
    public CharacterController cc;

    void Awake()
    {
        CharacterController cc = gameObject.GetComponent<CharacterController>();
        Debug.Log("CC Found: " + cc);
        SceneController.Instance.playerCapsule = cc;
    }
}