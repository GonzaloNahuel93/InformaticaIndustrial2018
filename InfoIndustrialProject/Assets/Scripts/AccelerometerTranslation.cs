using UnityEngine;
using UnityEngine.UI;

public class AccelerometerTranslation : MonoBehaviour
{
    Vector3 startPoint;
    public float ajuste ;
    float meters;
    public Text _Text;
	//System.DateTime actual ;
	float timer = 0;
	float timerMax = 5;

    void Start()
    {
        startPoint = transform.position;
		//actual = System.DateTime.Now.AddSeconds(1);
		//while(( actual.CompareTo(System.DateTime.Now )) != 0)
		//{
		//}
		ajuste = 0.1f;
    }

	private bool Wait5Seconds()
	{
		timer += Time.deltaTime;
		if (timer >= timerMax)
			return true;
		else
			return false;
	}

    void Update()
	{		
		if (!Wait5Seconds ())
			return;
		else {
			ajuste = 0.4f;
		}
			updateDistanceTraveled ();
			transform.Translate (Input.acceleration.x * ajuste, Input.acceleration.y * 0, -Input.acceleration.z * ajuste,Space.World);
    }

    private void updateDistanceTraveled()
    {
        if (startPoint != transform.position)
        {
            float metersX = transform.position.x - startPoint.x;
            float metersY = transform.position.y - startPoint.y;
            float metersZ = transform.position.z - startPoint.z;
            meters = meters + Mathf.Abs(metersX) + Mathf.Abs(metersY) + Mathf.Abs(metersZ);
            startPoint = transform.position;
            _Text.text = "Distancia recorrida: " + meters.ToString("0.00") + " Metros";
            startPoint = transform.position;
        }
    }
}