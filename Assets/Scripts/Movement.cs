using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float enginePower = 5f;
    public float rotationSpeed = 10f;
    public float friction = 0.5f;
    public Transform cSprite;
    public float groundBoost = 3f;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.12f;
        rb.linearDamping = friction;
        rb.angularDamping = friction * 4;
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
            rb.AddTorque(verticalInput * rotationSpeed);
        }
        if (horizontalInput != 0)
        {
            if (horizontalInput > 0)
            {
                cSprite.localScale = new Vector3(1, 1, 1);
                rb.AddForce(transform.right * enginePower);
            }
            else
            {
                cSprite.localScale = new Vector3(-1, 1, 1);
                rb.AddForce(-transform.right * enginePower);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput != 0)
        {
            rb.AddTorque(verticalInput * rotationSpeed * groundBoost);
            rb.AddForce(Vector2.up * enginePower * 0.2f);
        }
    }
}