using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    public float speed = 2.0f;
    public float bouceSpeed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)){
            transform.Translate(Vector3.up * bouceSpeed * Time.deltaTime);
        }
    }
}
