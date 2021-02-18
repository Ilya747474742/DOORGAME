using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingGround : MonoBehaviour
{
   void OnTriggerExit2d(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
            gameObject.GetComponentInParent<CharController>().groundCheck = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
            gameObject.GetComponentInParent<CharController>().groundCheck = true;
    }
}
