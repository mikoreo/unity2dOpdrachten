using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;


    [SerializeField] private string _coinTag = "Coin";
    [SerializeField] private float moveSpeed = 3.5f;
    private float jumpForce = 5;
    private float xInput;

    private bool facingRight = true;

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

    private void handleFlip()
    {
        if (rb.linearVelocity.x > 0 && facingRight == false)
            Flip();
        else if (rb.linearVelocity.x < 0 && facingRight == true)
            Flip(); 
    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        facingRight = !facingRight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("door"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(_coinTag))
        {
            Destroy(collision.gameObject);
        }
    }


}
