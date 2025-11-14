using UnityEngine;

public class camera : MonoBehaviour
{

    public float moveSpeed = 10;

    public Rigidbody2D rb;


    void Update()
    {
        Debug.Log(rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal"), rb.linearVelocityY));
    }
}
