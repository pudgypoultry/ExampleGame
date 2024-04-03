using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController4 : MonoBehaviour
{

    // We need to add some global variables for this entity
    // Since we were moving and scaling at absurd rates
    public int score = 0;
    public int baseLives = 3;
    public int currentLives;
    [SerializeField] private float baseMovementSpeed = 0.05f;
    public float movementSpeed;
    [SerializeField] private float baseRotationSpeed = 0.5f;
    public float rotationSpeed;
    [SerializeField] private float baseScaleSpeed = 0.05f;
    public float scaleSpeed;
    [SerializeField] private float baseJumpForce = 10f;
    public float jumpForce;
    public float lossHeight = -2f;

    public Rigidbody rb;

    public Vector3 originalPosition;
    public Vector3 originalScale;
    public Vector3 originalRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        originalPosition = transform.position;
        originalScale = transform.localScale;
        originalRotation = transform.eulerAngles;

        movementSpeed = baseMovementSpeed;
        rotationSpeed = baseRotationSpeed;
        scaleSpeed = baseScaleSpeed;
        jumpForce = baseJumpForce;
        currentLives = baseLives;
    }

    void Update()
    {
        Move();
        Jump();
        // Collect();
        Lose();
    }

    void Move()
    {
        // While these keys are pressed, move relative to movement speed
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -movementSpeed);
        }


        // Examples of rotation and scale, since those can also be used in movement!
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }

        // Try using if/else statements to detect combinations of inputs
        if (Input.GetKey(KeyCode.Z))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localScale += new Vector3(-scaleSpeed, 0, 0);
            }
            else
            {
                transform.localScale += new Vector3(scaleSpeed, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.X))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localScale += new Vector3(0, -scaleSpeed, 0);
            }
            else
            {
                transform.localScale += new Vector3(0, scaleSpeed, 0);
            }
        }
        if (Input.GetKey(KeyCode.C))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.localScale += new Vector3(0, 0, -scaleSpeed);
            }
            else
            {
                transform.localScale += new Vector3(0, 0, scaleSpeed);
            }
        }
    }

    void Jump()
    {
        // On the frame space is pressed, apply this force to the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    // This will work to stand in for "Collect", we'll use the built in "OnCollisionEnter(Collision collision)"
    // that comes baked in with this GameObject having a collider attached as a component
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Found a collision: " + collision.gameObject.name);
        if (collision.gameObject.GetComponent<Collectible1>() != null)
        {
            collision.gameObject.GetComponent<Collectible1>().CollectMe(this);
        }
    }

    void Lose()
    {
        // If the player reaches a height below a chosen lossHeight, reset the player to a default position.
        if (transform.position.y < lossHeight)
        {
            transform.position = originalPosition;
            transform.localScale = originalScale;
            transform.eulerAngles = originalRotation;
        }
    }


}

