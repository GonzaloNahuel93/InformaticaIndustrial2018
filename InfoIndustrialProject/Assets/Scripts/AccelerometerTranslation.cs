using UnityEngine;
using UnityEngine.UI;

public class AccelerometerTranslation : MonoBehaviour
{
    Vector3 startPoint;
    public float adjustment;
    float meters;
    public Text _Text;
    float timer = 0;

    void Start()
    {
        startPoint = transform.position;
    }

    void Update()
    {
        UpdateDistanceTraveled();
        transform.Translate(Input.acceleration.x * adjustment, Input.acceleration.y * 0, -Input.acceleration.z * adjustment, Space.World);
    }

    private void UpdateDistanceTraveled()
    {
        if (startPoint != transform.position)
        {
            float metersX = transform.position.x - startPoint.x;
            float metersY = transform.position.y - startPoint.y;
            float metersZ = transform.position.z - startPoint.z;
            meters = meters + Mathf.Abs(metersX) + Mathf.Abs(metersY) + Mathf.Abs(metersZ);
            _Text.text = "Distancia recorrida: " + meters.ToString("0.00") + " Metros";
            startPoint = transform.position;
        }
    }
}