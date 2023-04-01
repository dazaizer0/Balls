using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float speed = 5f;

    public float jump_force = 10f;
    private int jumps_left = 1;

    private Vector3 jump;

    public bool isGrounded;

    private Rigidbody rb;

    public Camera camera;  

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {

        Vector3 cameraDirection = camera.transform.forward;
        Vector3 forwardForce = transform.forward * speed;
        cameraDirection.y = 0;  
        
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded && jumps_left > 0)
        {

            jumps_left -= 1;
            rb.AddForce(jump * jump_force, ForceMode.Impulse);
            rb.AddForce(forwardForce, ForceMode.Acceleration);
        }

        if (cameraDirection.magnitude > 0.1f)
        {
            transform.rotation = Quaternion.LookRotation(cameraDirection);
        }
    }

    void OnCollisionStay()
    {

        jumps_left = 1;
        isGrounded = true;
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "CanGrab")
        {

            // force up
        }
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
