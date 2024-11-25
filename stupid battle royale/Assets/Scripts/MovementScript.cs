using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // player compoments
    public Rigidbody rb;
    public Transform playerPos;

    // movement force strength
    public float forwardForce = 2000f;
    public float backwardsForce = 1000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(backwardsForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
