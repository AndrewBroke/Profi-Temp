using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 1;
    public float zoomSpeed = 1;

    public CinemachineVirtualCamera virtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(moveY, 0, -moveX) * moveSpeed;

        float zoom = Input.GetAxis("Mouse ScrollWheel");
        float fov = virtualCamera.m_Lens.FieldOfView;
        fov -= zoom * zoomSpeed;
        fov = Mathf.Clamp(fov, 25, 100);
        virtualCamera.m_Lens.FieldOfView = fov;
    }
}
