using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Talk();
    }
    
    public virtual void Talk()
    {
        Debug.Log("Hola mundo");
    }
    
    
    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A is pressed");
            moveX = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        Debug.Log(moveX);
        
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        Debug.Log(moveY);
        float speedCalculation = (moveSpeed * Time.deltaTime);
        Vector3 movement = new Vector3(moveX, moveY, 0f) * speedCalculation ;
        Debug.Log(Time.deltaTime);
        Debug.Log(moveSpeed);
        Debug.Log(speedCalculation);
        Debug.Log(movement);
        transform.position += movement;


    }
}
