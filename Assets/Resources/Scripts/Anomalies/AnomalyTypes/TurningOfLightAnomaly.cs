using UnityEngine;

public class TurningOfLightAnomaly : MonoBehaviour, IAnomaly
{
    private Light bulbLight;

    private void Awake()
    {
        bulbLight = GetComponent<Light>();
    }

    public void Occur()
    {
        bulbLight.enabled = false;
    }

    public void Fix()
    {
        bulbLight.enabled = true;
    }
}