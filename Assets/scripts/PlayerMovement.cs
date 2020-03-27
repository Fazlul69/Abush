using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController character_Controller;

    private Vector3 move_Direction;

    public float speed = 10f;
    [SerializeField] private float gravity = 20f;
    public float jump_Force = 10f;
    [SerializeField] private float vertical_Velocity;
    // Start is called before the first frame update
    void Awake()
    {
        character_Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer()
    {

        move_Direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        ApplyGravity();

        character_Controller.Move(move_Direction);
    }

    //player walk gravity
    void ApplyGravity()
    {

        vertical_Velocity -= gravity * Time.deltaTime;
        //jump
        //PlayerJump();

        move_Direction.y = vertical_Velocity * Time.deltaTime;

    }//apply gravity
}
