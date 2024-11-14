using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class ThirdPersonPlayerRB : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float rotationSpeed;

    private Rigidbody body;

    private Vector2 inputValue;

    private Vector3 moveDirection;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {   
        body = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputValue = context.ReadValue<Vector2>();
        moveDirection = new Vector3(inputValue.x, 0, inputValue.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (inputValue.magnitude != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
            anim.SetBool("isWalking", false);

        if (inputValue.magnitude != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection.normalized, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        body.velocity = moveDirection.normalized * moveSpeed;
    }
}
