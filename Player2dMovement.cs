using UnityEngine;

public class Player2dMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX;
    private float speedY;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxis("Horizontal") * moveSpeed;
        speedY = Input.GetAxis("Vertical") * moveSpeed;

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
