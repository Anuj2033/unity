using UnityEngine;

public class CandleLit : MonoBehaviour
{
    public ParticleSystem litCandle;
    private bool isLit = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isLit)
            {
                litCandle.Stop();
            }
            else
            {
                litCandle.Play();
            }
            isLit = !isLit;
        }
    }
}
