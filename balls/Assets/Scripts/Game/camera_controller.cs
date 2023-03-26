using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform player;
    public Transform camera_pos;

    float xRotation = 0f;
    float yRotation = 0f;
    public float camera_smooth;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, camera_pos.position, camera_smooth * Time.deltaTime);
        GetComponent<Rigidbody>().MovePosition(pos);

        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // ograniczenie ruchu w pionie

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        player.Rotate(Vector3.up * mouseX);
        player.Rotate(Vector3.right * mouseY);
    }
}
