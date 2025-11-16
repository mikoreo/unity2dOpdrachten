using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float moveSpeed = 3.5f;
    [SerializeField] private float jumpForce = 8;
    private float xInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");

        Debug.Log(rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y)); 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}
