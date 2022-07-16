using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string incomingTelepoint { get; set; }
    public Transform foundTelepoint { get; set; }
    public CharacterController playerCapsule { get; set; }

    private static SceneController _instance;
    public static SceneController Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("SceneController is NULL");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
        DontDestroyOnLoad(this);
    }

    public void LoadScene(string sceneName)
    {
        Debug.Log("Outgoing Scene: " + sceneName);
        SceneManager.LoadSceneAsync(sceneName);
        TPPlayer();
    }

    public void TPPlayer()
    {
        playerCapsule.enabled = false;
        playerCapsule.transform.position = foundTelepoint.transform.position;
        playerCapsule.transform.rotation = foundTelepoint.transform.rotation;
        playerCapsule.enabled = true;
    }
}