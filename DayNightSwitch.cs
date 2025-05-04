using UnityEngine;

public class DayNightSwitch : MonoBehaviour
{
    public Material dayMaterial;
    public Material nightMaterial;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse click
        {
            if (RenderSettings.skybox == dayMaterial)
                RenderSettings.skybox = nightMaterial;
            else
                RenderSettings.skybox = dayMaterial;
        }
    }
}