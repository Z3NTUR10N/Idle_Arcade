using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float speed = 6;

    private Vector2 _inputvalues;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _inputvalues = InputValues;

    }

    private Vector2 InputValues => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    
    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        rigidbody.velocity = new Vector3(InputValues.x * speed, rigidbody.velocity.y, InputValues.y * speed);
    }
    
}
