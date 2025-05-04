using UnityEngine;

public class SimpleBounce : MonoBehaviour
{
    public float stopAfterSeconds = 5f; // User-defined stop time
    private float timer = 0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= stopAfterSeconds)
        {
            rb.linearVelocity = Vector3.zero; // Stop the ball's movement
            Vector3 pos = transform.position;
            pos.y = 0.5f;
            transform.position = pos;
        }
    }
}
