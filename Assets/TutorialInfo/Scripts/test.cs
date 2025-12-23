using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public WheelCollider[] wheels;
    public float steerAngle = 35;
    public float MotorTorque;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            wheels[2].motorTorque = Input.GetAxis("Vertical")* MotorTorque;
            wheels[3].motorTorque = Input.GetAxis("Vertical")* MotorTorque;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            wheels[0].steerAngle = Input.GetAxis("Horizontal")* steerAngle;
            wheels[1].steerAngle =  Input.GetAxis("Horizontal")*  steerAngle;
        }
    }
}
