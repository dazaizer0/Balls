using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurnMarc : MonoBehaviour
{
    public float vert_sens, hori_sens;

    Vector3 current_euler;
    Quaternion current_rotation;

    void Update()
    {
        Cursor.lockState = Input.GetMouseButtonDown(0) ? CursorLockMode.Locked : (Input.GetKeyDown(KeyCode.Escape) ? CursorLockMode.None : Cursor.lockState);
        if (Cursor.lockState == CursorLockMode.None) return;

        // pitch
        transform.rotation *= Quaternion.AngleAxis(-Input.GetAxis("Mouse Y") * vert_sens, Vector3.right);

        /*
        if (transform.rotation.eulerAngles.x > 90)
        {
            current_euler = transform.eulerAngles;
            current_euler.x = 90;
            current_rotation.eulerAngles = current_euler;
            transform.rotation = current_rotation;
        }
        */

        // yaw or paw whatever

        transform.rotation = Quaternion.Euler(
                transform.eulerAngles.x,
                transform.eulerAngles.y + Input.GetAxis("Mouse X") * hori_sens,
                transform.eulerAngles.z);

        Debug.Log(transform.rotation);
    }
}
