using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeed : MonoBehaviour
{
    public static float additionalSpeed = 0.01f;

    public void Start()
    {

    }
    public void UpdatePlayerSpeed(float value)
    {
        additionalSpeed = Mathf.RoundToInt(value * 10);
    }
}
