using UnityEngine;

public class SpacecraftMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float enginePower = 10f;
    public float rotationSpeed = 40f;
    public float friction = 0.5f;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.linearDamping= friction;
        rb.angularDamping = friction*4;
    }
    public void FixedUpdate()
    {
        Move(); 
    }
    public void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            rb.AddForce(transform.up * enginePower);
        }
        if (horizontalInput != 0)
        {
            rb.AddTorque(-horizontalInput * rotationSpeed);
        }

    }
}
