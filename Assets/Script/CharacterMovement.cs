using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController controller;
    public float movespeed, rotSpeed;
    public float sensitivity;
    public float gravityforce;
    public float rotSmoothTime;
    public Animator animator;
    public Camera Playercamera;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls();
    }

    public void PlayerControls()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical).normalized;

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * mouseX * sensitivity);

        float verticalRotation = sensitivity * -mouseY;
        float currentRotation = transform.localEulerAngles.x;

        controller.Move(movement * movespeed);

        float movemagnitude = movement.magnitude;
        animator.SetFloat("Speed", movemagnitude);
    }
}
