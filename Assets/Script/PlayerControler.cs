using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody rBody;

    public float jumpForce = 5f;
    public float jumpInterval = .5f;
    public float jumpCountDown = 0;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        jumpCountDown -= Time.deltaTime;
        var canJump = jumpCountDown <= 0;

        if (jumpCountDown < 0 ) jumpCountDown = 0;
        
        if (canJump)
        {
            var jumpInput = Input.GetKey(KeyCode.Space);
            if (jumpInput)
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        jumpCountDown = jumpInterval;
        rBody.velocity = Vector3.zero;
        rBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
