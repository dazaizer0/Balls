using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float speed = 5f;

    public float jump_force = 10f;
    private int jumps_left = 1;

    private Vector3 jump;

    public bool isGrounded;

    private Rigidbody rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {

        
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded && jumps_left > 0)
        {

            jumps_left -= 1;
            rb.AddForce(jump * jump_force, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {

        Vector2 axis = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * speed;
        rb.velocity = (Vector3.forward * axis.x + Camera.main.transform.right * axis.y + Vector3.up * rb.velocity.y);;
    }
    
    void OnCollisionStay()
    {

        jumps_left = 1;
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
