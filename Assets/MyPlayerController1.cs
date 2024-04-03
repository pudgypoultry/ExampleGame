using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController1 : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        Move();
        Jump();
        Collect();
        Lose();
    }

    void Move()
    {
        // Move: "I need to move the player character when Input is given"
        // Problem: How do I detect input? How do I move?
        // Answer, by using the Input class that lives within UnityEngine namespace
        //      "Input.GetKey()" returns true as long as the key is held down
        //      "Input.GetKeyDown()" returns true only on the frame that the key is pressed after being in the up state
        //      "Input.GetKeyUp()" returns true only on the frame that the key is let up after being in the down state
        // To be clear, "GetKey" and "KeyCode./key/" is the naive way of accomplishing this, we can tie it into Unity better
        //  by using GetAxis and manipulating that, and I'll post an example of doing so, but this is the most basic, quick
        //  way of understanding this concept and works just find for our purposes!
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1);
        }


        // Examples of rotation and scale, since those can also be used in movement!
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.localScale += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.localScale += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.localScale += new Vector3(0, 0, 1);
        }
    }

    void Jump()
    {
        // Jump: "I need to move the player upward when input is given, and I need to fall after a certain point back to the ground
        // Note: Rigidbody component in Unity takes care of physics for us! So one half of this job is done
        //      All we need to do now is make sure the play moves upward, then allow the Rigidbody to do its job for us
        // Problem: How do I move upward? How do I *want* to move upward? Do I want to launch the player like a catapult or do I want
        //      to move the player a set amount? Classic versions of Super Mario vs Castlevania
    }

    void Collect()
    {
        // Collect: "When the player comes into contact with something they can collect, I need to collect it and get rid of the object
        //      or put it in its correct place, such as the player's inventory
        // Problem: How do I detect that I've come into contact with something?
    }

    void Lose()
    {
        // Lose:  "When the player reaches a loss state, I need to reset the player back to the start and subtract 1 from the player's lives
        // Problem: How do I know the player has reached the loss state?
    }
}
