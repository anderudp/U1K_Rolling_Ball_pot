using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float sideSpeed = 5f;
    public float jumpForce = 300f;
    Rigidbody playerRb;
    bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        PcControls();
    }

    void PcControls()
    {
        transform.Translate(Vector3.right * sideSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        float jumpInput = Input.GetAxis("Jump");
        if(jumpInput > 0.2) Jump(jumpInput);
    }

    void Jump(float jumpInput)
    {
        playerRb.AddForce(Vector3.up * jumpForce * jumpInput);
        canJump = false;
    }
}
