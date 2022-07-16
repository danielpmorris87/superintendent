using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTelepoints : MonoBehaviour
{
    private string playerTelepoint;
    public List<Transform> telepointsInScene;

    void Awake()
    {
        playerTelepoint = SceneController.Instance.incomingTelepoint;
        Debug.Log("Incoming telepoint: " + playerTelepoint);
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("TeleportPoint"))
        {
            telepointsInScene.Add(go.GetComponent<Transform>());
        }

        // Select telepoint from list
        // and send to the Scene Controller
        Transform telepointFound = telepointsInScene.Find((x) => x.name == playerTelepoint);
        SceneController.Instance.foundTelepoint = telepointFound;
        Debug.Log("Telepoint found: " + telepointFound);
    }

    void Start()
    {
        CharacterController cc = SceneController.Instance.playerCapsule;
        Transform telepointFound = SceneController.Instance.foundTelepoint;
        cc.enabled = false;
        cc.transform.position = telepointFound.transform.position;
        cc.transform.rotation = telepointFound.transform.rotation;
        cc.enabled = true;
    }
}