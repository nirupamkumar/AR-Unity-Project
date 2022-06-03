using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovementController : MonoBehaviour
{
    public WheelCollider frontRight;
    public WheelCollider frontLeft;
    public WheelCollider backRight;
    public WheelCollider backLeft;

    public Transform frTransform;
    public Transform flTransform;
    public Transform brTransform;
    public Transform blTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    public Joystick joystick;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    private void FixedUpdate()
    {
        // foreward/reverce acceleration from vertical axis (w & s keys) @Keyboard
        //currentAcceleration = acceleration * Input.GetAxis("Vertical");

        // foreward/rever using @Joystick
        currentAcceleration = acceleration * joystick.Vertical;

        //pressing space, gives currentBreakingForce a value
        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else
            currentBreakForce = 0f;

        //Apply acceleration to the wheels
        frontRight.motorTorque = currentAcceleration;
        frontRight.motorTorque = currentAcceleration;

        //Applying breaking force to all wheels
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;

        //Take care of the steering
        //currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        currentTurnAngle = maxTurnAngle * joystick.Horizontal;
        frontRight.steerAngle = currentTurnAngle;
        frontLeft.steerAngle = currentTurnAngle;

        //Update wheels meshes
        UpdateWheelPosition(frontRight, frTransform);
        UpdateWheelPosition(frontLeft, flTransform);
        UpdateWheelPosition(backRight, brTransform);
        UpdateWheelPosition(backLeft, blTransform);
    }

    private void UpdateWheelPosition(WheelCollider collider, Transform transform)
    {
        //Get wheel collider state
        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);

        //Set wheel transform state
        transform.position = position;
        transform.rotation = rotation;
    }
}
