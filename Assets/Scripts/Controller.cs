using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Range(0,1f)]
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        transform.position += (new Vector3(xInput, yInput, 0))*movementSpeed;
        //transform.position = transform.position + new 

        //print("x Input: "+xInput);
        //print("y Input");
    }
}
