using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickMe : MonoBehaviour
{
    public Click gm;
    public void Clickk()
    {
        gm.Gold += gm.goldPerClick;
    }

}
