using UnityEngine;
using UnityEngine.UI;

public class AccelerometerTranslation : MonoBehaviour
{
    Vector3 startPoint;
    float ajuste = 0.4f;
    float meters;
    public Text _Text;

    void Start()
    {
        startPoint = transform.position;
    }

    void Update()
    {
        if (startPoint != transform.position)
        {
            float metersX = transform.position.x - startPoint.x;
            float metersY = transform.position.y - startPoint.y;
            float metersZ = transform.position.z - startPoint.z;
            meters = meters + Mathf.Abs(metersX) + Mathf.Abs(metersY) + Mathf.Abs(metersZ);
            startPoint = transform.position;
            _Text.text = "Distancia recorrida: " + meters.ToString("C") + " Metros";
            transform.Translate(Input.acceleration.x * ajuste, Input.acceleration.y * 0, -Input.acceleration.z * ajuste,
                Space.World);
            startPoint = transform.position;
        }
    }
}