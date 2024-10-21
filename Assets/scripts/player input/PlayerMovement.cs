using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

<<<<<<< Updated upstream
[RequireComponent(typeof(Rigidbody))] 
=======
>>>>>>> Stashed changes
public class PlayerMovement : MonoBehaviour
{
    PlayerInput input;
    InputAction move;
<<<<<<< Updated upstream
    [SerializeField] float speed = 7;

    Vector3 jump;
    float jumpSpeed = 2f;

    bool grounded;
    Rigidbody rb;
=======
    InputAction jump;
    [SerializeField] float speed = 7;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        move = input.actions.FindAction("move");
<<<<<<< Updated upstream
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 3f, 0f);
    }

    void OnCollisionStay()
    {
        grounded = true;
=======
        jump = input.actions.FindAction("jump");
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        movement();

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {

            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            grounded = false;
        }
    }

    void movement() { 
        Vector2 direction = move.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * Time.deltaTime * speed;
=======
        playerMovement();
    }

    void playerMovement() {
        Debug.Log(jump.ReadValue<Vector2>());
        Vector2 direction = move.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;
>>>>>>> Stashed changes
    }
}
