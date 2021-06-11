using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : MonoBehaviour
{
    // Setting Variables
    float m_moveSpeed = 5.0f;
    float m_reverseSpeed = 1.0f;
    float m_jumpForce = 5.0f;
    readonly float rotationSpeed = 100.0f;

    Rigidbody rb;

    // Setting properties and introducing certain limits (Encapsulation)

    public float MoveSpeed 
    {
        get { return m_moveSpeed; }
        set 
        { 
            if(value > 20.0f)
            {
                m_moveSpeed = 20.0f;
                Debug.Log("Movespeed can't exceed 20!");
            } else
                if (value < 0.0f)
            {
                m_moveSpeed = 5.0f;
                Debug.Log("Movespeed can't be negative. Set reverseSpeed for reverse speed. Movespeed set to 5.");
            } else
            {
                m_moveSpeed = value;
                Debug.Log("Movespeed set to:" + value);
            }

        } 
    }
    
    public float ReverseSpeed
    {
        get { return m_reverseSpeed; }
        set
        {
            if (value > 2.0f)
            {
                m_reverseSpeed = 2.0f;
                Debug.Log("Movespeed can't exceed 2!");
            }
            else
                if (value < 0.0f)
            {
                m_reverseSpeed = 1.0f;
                Debug.Log("Reversespeed can't be negative. Reversespeed set to 1.");
            }
            else
            {
                m_reverseSpeed = value;
                Debug.Log("Reversespeed set to:" + value);
            }

        }
    }
    
    public float JumpForce
    {
        get { return m_jumpForce; }
        set
        {
            if (value > 20.0f)
            {
                m_jumpForce = 20.0f;
                Debug.Log("Jumpforce can't exceed 20!");
            }
            else
                if (value < 0.0f)
            {
                m_jumpForce = 5.0f;
                Debug.Log("Jumpforce can't be negative. Jumpforce set to 5.");
            }
            else
            {
                m_jumpForce = value;
                Debug.Log("Jumpforce set to:" + value);
            }

        }
    }


    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Using Abstraction
    private void Update()
    {
        Jump();
        Move();
    }

    // Simple script to detect input and then add an upwards force (Abstraction)
    protected void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
        }
    }

    // Script to detect input and move forwards/backwards or rotate, based on speed variables (Abstraction)
    protected void Move()
    {
        if (Input.GetAxis("Vertical") > 0.0f)
        {
            float move = Input.GetAxis("Vertical") * m_moveSpeed * Time.deltaTime;
            transform.Translate(0, 0, move);
        }
        else if (Input.GetAxis("Vertical") < 0.0f)
        {
            float move = Input.GetAxis("Vertical") * m_reverseSpeed * Time.deltaTime;
            transform.Translate(0, 0, move);
        }

        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
    }
}
