using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManController : MonoBehaviour
{
    
    public float speed = 10f;
    private Vector3 up = Vector3.zero,
                    down = new Vector3(0, 180, 0),
                    left = new Vector3(0, 270, 0),
                    right = new Vector3(0, 90, 0),
                    currentDirection = Vector3.zero;
    private Vector3 resetPosition = Vector3.zero;

    Rigidbody rb;

    public void Reset()
    {
        transform.position = resetPosition;
        currentDirection = down;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        QualitySettings.vSyncCount = 0;
        resetPosition = transform.position;

        Reset();
    }

    void FixedUpdate()
    {
        //rb.MovePosition(Vector3.up);
        bool isMoving = true;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            currentDirection = up;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            currentDirection = down;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            currentDirection = left;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            currentDirection = right;
        }
        else{
            isMoving = false;           //disable for automatic movement
        }

        transform.localEulerAngles = currentDirection;

        if (isMoving){
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            //rb.MovePosition((transform.position + transform.forward) * Time.fixedDeltaTime * speed);
        }
    }
}
