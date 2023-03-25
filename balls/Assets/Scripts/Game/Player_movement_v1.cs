using UnityEngine;

public class Player_movement_v1 : MonoBehaviour
{

    public float speed = 5f;
    public float jump_force = 10f;
    public bool isGrounded;

    private Rigidbody rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        Vector2 axis = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * speed;
        Vector3 forward = new Vector3(-Camera.main.transform.right.z, 0, Camera.main.transform.right.x);
        Vector3 wishDirection = (forward * axis.x + Camera.main.transform.right * axis.y + Vector3.up * rb.velocity.y);
        
        rb.velocity = wishDirection;
    }
    
    void OnCollisionStay()
    {
    
        isGrounded = true;
    }


    /*Rigidbody rb;
    public float jump_delta_v;
    public float accel;s

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        rb.AddForce(((Input.GetKey(KeyCode.W) ? 1 : 0) - (Input.GetKey(KeyCode.S) ? 1 : 0)) * accel * transform.forward, ForceMode.Acceleration);
        rb.AddForce(((Input.GetKey(KeyCode.D) ? 1 : 0) - (Input.GetKey(KeyCode.A) ? 1 : 0)) * accel * transform.right , ForceMode.Acceleration);
        rb.AddForce(((Input.GetKey(KeyCode.Space) ? 1 : 0) - (Input.GetKey(KeyCode.LeftShift) ? 1 : 0)) * jump_delta_v * transform.up , ForceMode.Acceleration);
    }*/
}
