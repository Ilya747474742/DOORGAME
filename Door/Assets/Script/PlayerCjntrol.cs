using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCjntrol : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rb;
    bool FacingRigth = true;
    int DerectionImput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * DerectionImput, speed * rb.velocity.y);
        if (DerectionImput <0 && FacingRigth)
        {
            Flip();
        }
        else if (DerectionImput > 0 && !FacingRigth)
        {
            Flip();
        }
    }

    public void Move(int InputAxis)
    {
        DerectionImput = InputAxis;
    }

    void Flip()
    {
        FacingRigth = !FacingRigth;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
