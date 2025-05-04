using UnityEngine;

public class SimpleBallKick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 5, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 15, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 20, ForceMode.Impulse);
        }
    }
}