using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Button;
    public void Pause007()
    {
        Button.SetActive(!Button.activeSelf);
    }
}
