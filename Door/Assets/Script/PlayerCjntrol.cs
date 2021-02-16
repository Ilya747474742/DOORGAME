using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCjntrol : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int jump;
    private bool Ground;

    private Rigidbody2D rb;
    [SerializeField] private int direction;

    private void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(3, -1);
    }
    private void Update()
    {
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
        
        Flip();
    }
    public void Jump()
    {
        if (Ground == true)
        {
            rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
            
        }
    }
    public void ChangeDirection(int buttonDirection)
    {
        direction = buttonDirection;
    }
    private void Flip()
    {
        if (direction < 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        else if (direction > 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ground")
            Ground = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground")
            Ground = false;
    }
}
