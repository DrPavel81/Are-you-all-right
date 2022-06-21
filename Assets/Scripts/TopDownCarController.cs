using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCarController : MonoBehaviour
{
    public float driftFactor = 0.05f;
    public float turnFactor = 0.4f;
    public float maxSpeed = 4;


    float rotationAngle = 0;

    float velocity = 0;
    int i=1;

    Rigidbody2D carRigidbody2D;

    void Awake()
    {
        carRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            i++;
        }
        if(i%2==0)
        {
            ApplySteering();
        }
    }

    void FixedUpdate()
    {
        KillOrthogonalVelocity();
        
        ApplyEngineForce();
    }

    void KillOrthogonalVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(carRigidbody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody2D.velocity, transform.right);

        carRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;
    }
    void ApplyEngineForce()
    {

        velocity = Vector2.Dot(transform.up, carRigidbody2D.velocity);
        if (velocity > maxSpeed)
        {
            return;
        }
        Vector2 engineForceVector = transform.up * 2;

        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }

    void ApplySteering()
    {
  
        rotationAngle -= turnFactor;

        carRigidbody2D.MoveRotation(rotationAngle);
    }




 
}
