using UnityEngine;
public class LightSource : MonoBehaviour
{
    public Light lampLight;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lampLight.enabled = !lampLight.enabled;
        }
    }
}