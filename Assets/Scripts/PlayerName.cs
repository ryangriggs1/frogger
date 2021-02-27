using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text theName;
    private void Start()
    {
        theName.text = Menu.playerName;
    }
}
