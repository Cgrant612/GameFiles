using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehavior
{
    public float moveSpeed;
    public float rotateSpeed;
    public float rh, rv; //rh and rv are the horizontal and vertical axes of the right stick on the controller
    public Transform Target, Player; //Target is an empty game object that the camera is a child of

    private Vector3 moveInput;
    private Vector3 moveVelocity;
    private RigidBody rb;

    void Start()
    {
        rb = GetComponent<RigidBody>;
    }

    void Update()
    {
        float lh = Input.GetAxis("Horizontal");
        float lv = Input.GetAxis("Vertical");

        moveInput = new Vector3(lh, 0f, lv);
        if (lv < 0)
        {
            moveVelocity = transform.backward * moveSpeed * moveInput.sqrMagnitude;
        }
        else if (lv > 0)
        {
            moveVelocity = transform.forward * moveSpeed * moveInput.sqrMagnitude;
        }
        rh += Input.GetAxis("Mouse X") * rotateSpeed;
        rv -= Input.GetAxis("Mouse Y") * rotateSpeed;
        rv = Mathf.Clamp(rv, -35, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(rv, rh, 0);
        Player.rotation = Quaternion.Euler(0, rh, 0);
    }

    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }

}