using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights; // Sahnedeki ���klar�n listesi
    public float interval = 3f; // I��klar�n a��k/kapal� olaca�� s�re

    private bool lightsOn = true;
    private float timer;

    void Start()
    {
        // I��klar� al
        lights = FindObjectsOfType<Light>();

        // Timer'� ba�lat
        timer = interval;
    }

    void Update()
    {
        // Zamanlay�c�y� g�ncelle
        timer -= Time.deltaTime;

        // Zamanlay�c� s�f�rlan�rsa
        if (timer <= 0f)
        {
            // I��klar�n durumunu de�i�tir
            lightsOn = !lightsOn;

            // T�m ���klar� a� veya kapat
            foreach (Light light in lights)
            {
                light.enabled = lightsOn;
            }

            // Zamanlay�c�y� yeniden ayarla
            timer = interval;
        }
    }
}