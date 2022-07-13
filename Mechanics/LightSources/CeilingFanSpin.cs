using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingFanSpin : MonoBehaviour
{
    public float fanSpeed;

    void Update()
    {
        transform.Rotate(0, fanSpeed * Time.deltaTime, 0);
    }
}