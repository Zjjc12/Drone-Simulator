using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed = 1.0f;

    [SerializeField]
    private float verticalSpeed = 1.0f;

    [SerializeField]
    private float rotationSpeed = 1.0f;

    [SerializeField]
    private GameObject gimbalCamera;
    [SerializeField]
    private float cameraSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("VerticalLeft") * movementSpeed * Time.deltaTime;
        float depth = Input.GetAxis("VerticalRight") * verticalSpeed * Time.deltaTime;
        float horizontal = Input.GetAxis("HorizontalRight") * movementSpeed * Time.deltaTime;
        float yaw = Input.GetAxis("HorizontalLeft") * rotationSpeed * Time.deltaTime;
        float gimbal = Input.GetAxis("Camera") * cameraSpeed * Time.deltaTime;


        transform.Translate(0, vertical, 0);
        transform.Translate(depth, 0, 0);
        transform.Translate(0, 0, horizontal);

        transform.Rotate(0, yaw, 0);
        gimbalCamera.transform.Rotate(gimbal, 0, 0);

    }
}
