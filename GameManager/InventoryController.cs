using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    // INVENTORY
    public bool HasFlashlight { get; set; }
    public bool HasApt103Key { get; set; }

    private static InventoryController _instance;
    public static InventoryController Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("InventoryController is NULL");
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
}