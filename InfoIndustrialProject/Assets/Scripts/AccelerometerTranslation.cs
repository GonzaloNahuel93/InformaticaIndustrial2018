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
		if (!Wait5Seconds ())
			return;
		else 
			adjustment = 0.4f;
		
        UpdateDistanceTraveled();
        transform.Translate(Input.acceleration.x * adjustment, Input.acceleration.y * 0, -Input.acceleration.z * adjustment, Space.World);
    }

	private bool Wait5Seconds()
	{
		timer += Time.deltaTime;
		if (timer >= 5)
			return true;
		else
			return false;
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