using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed;

    public float fpForward;
    public float fpStrafe;

    public Vector3 inputVector;
    public Vector3 outputVector;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float pitch = Input.GetAxis("Mouse X");
        float yaw = Input.GetAxis("Mouse Y");
        rb.transform.Rotate(0, pitch, 0);
        Camera.main.transform.Rotate(-yaw, 0, 0);


        fpForward = Input.GetAxis("Vertical");
        fpStrafe = Input.GetAxis("Horizontal");

        inputVector = transform.forward * fpForward;
        inputVector += transform.right * fpStrafe;
    }
    private void FixedUpdate()
    {
        rb.velocity = inputVector * moveSpeed + (Physics.gravity * 0.69f);

        outputVector = rb.velocity;
    }
}
