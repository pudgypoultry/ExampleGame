using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LOOK HERE FIRST
    void Update()
    {
        // This is my process, you'll develop your own as you work on game development :)
        // First, define your verbs
        Move();
        Jump();
        Collect();
        Lose();
    }

    // Second, expand on each verb
    // Think about what the actual problem is and what the computer needs to do to achieve this verb's action
    void Move()
    {
        // Move: "I need to move the player character when Input is given"
        // Problem: How do I detect input? How do I move?
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
