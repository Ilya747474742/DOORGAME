using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public UnityEngine.UI.Text GoldDisplay;
    public float goldPerClick = 1;
    public float Gold = 0;



    void Update()
    {
        GoldDisplay.text = "Gold: " + Gold + "$";
    }
}
