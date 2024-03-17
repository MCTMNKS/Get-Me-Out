using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights; // Sahnedeki ýþýklarýn listesi
    public float interval = 3f; // Iþýklarýn açýk/kapalý olacaðý süre

    private bool lightsOn = true;
    private float timer;

    void Start()
    {
        // Iþýklarý al
        lights = FindObjectsOfType<Light>();

        // Timer'ý baþlat
        timer = interval;
    }

    void Update()
    {
        // Zamanlayýcýyý güncelle
        timer -= Time.deltaTime;

        // Zamanlayýcý sýfýrlanýrsa
        if (timer <= 0f)
        {
            // Iþýklarýn durumunu deðiþtir
            lightsOn = !lightsOn;

            // Tüm ýþýklarý aç veya kapat
            foreach (Light light in lights)
            {
                light.enabled = lightsOn;
            }

            // Zamanlayýcýyý yeniden ayarla
            timer = interval;
        }
    }
}