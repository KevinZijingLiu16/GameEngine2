using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceReceiver : MonoBehaviour
{
    [SerializeField] private CharacterController controller;

    private float verticalVelocity;
    private Vector3 impact;
    private Vector3 dampingVelocity;

    [SerializeField] private float drag = 0.3f;

    public Vector3 Movement => impact + Vector3.up * verticalVelocity; //=> is return


   

    private void Update()
    {
        if (verticalVelocity < 0f && controller.isGrounded)
        {
            verticalVelocity = Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            verticalVelocity += Physics.gravity.y * Time.deltaTime; //using + is because gravity is negative
        }

        impact = Vector3.SmoothDamp(impact, Vector3.zero, ref dampingVelocity, drag );
    }

    public void AddForce(Vector3 force)
    {
        impact += force;

    }

}
