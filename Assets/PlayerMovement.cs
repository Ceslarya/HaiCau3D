using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpForce = 2000f;
    public float SidewaysForce = 1000f;

    void Update()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, SidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -SidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, JumpForce * Time.deltaTime, 0);
        }
    }
}
