using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody; 
    public float JumpStrength = 5;
    public float MoveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            myRigidBody.velocity = Vector2.up * JumpStrength;
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.position = transform.position + Vector3.left * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.position = transform.position + Vector3.right * MoveSpeed * Time.deltaTime;
        }
    }
}
