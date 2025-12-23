using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public WheelCollider[] wheels;
    public GameObject[] wheelModels;
    public float motorTorque=100;
    public bool fourX4;
    public float maxSteerAngle = 25;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            wheels[2].motorTorque = motorTorque*Input.GetAxis("Vertical");  // R -left
            wheels[3].motorTorque = motorTorque*Input.GetAxis("Vertical"); //  R- right
            if (fourX4)
            {
                wheels[0].motorTorque = motorTorque * Input.GetAxis("Vertical"); //  R- right
                wheels[1].motorTorque = motorTorque * Input.GetAxis("Vertical"); //  R- right
            }
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            wheels[0].steerAngle = Input.GetAxis("Horizontal")*maxSteerAngle; // F-Left
            wheels[1].steerAngle = Input.GetAxis("Horizontal")*maxSteerAngle; // F-Right
        }
        UpdateWheelPose();
        
    }
    
    void UpdateWheelPose()
    {
        int count = 0;
        foreach (WheelCollider w in wheels)
        {
            Vector3 pos;
            Quaternion rot;
            w.GetWorldPose(out pos, out rot);
            wheelModels[count].transform.position = pos;
            wheelModels[count].transform.rotation = rot;
            count++;
            // Apply suspension position
           
        }
    }
}
