using UnityEngine;

public class ChangeExpression : MonoBehaviour
{
    public Renderer faceRenderer;  // Drag Bro.Face's Renderer here
    public Material[] faceMaterials; // Drag Face_01 to Face_18 here

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) faceRenderer.material = faceMaterials[0];
        if (Input.GetKeyDown(KeyCode.Alpha2)) faceRenderer.material = faceMaterials[1];
        if (Input.GetKeyDown(KeyCode.Alpha3)) faceRenderer.material = faceMaterials[2];
        if (Input.GetKeyDown(KeyCode.Alpha4)) faceRenderer.material = faceMaterials[3];
        if (Input.GetKeyDown(KeyCode.Alpha5)) faceRenderer.material = faceMaterials[4];
    }
}
