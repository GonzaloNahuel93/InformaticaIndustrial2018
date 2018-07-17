using UnityEngine;

public class GyroscopeRotation : MonoBehaviour
{
    private Gyroscope gyroscope;

    private void Start()
    {
        gyroscope = Input.gyro;
        gyroscope.enabled = true;
    }

    private void Update()
    {
        var rotation = gyroscope.attitude.eulerAngles;
        var quaternion = Quaternion.Euler(-rotation.x, -rotation.z, -rotation.y);
        transform.rotation = quaternion;
    }
}