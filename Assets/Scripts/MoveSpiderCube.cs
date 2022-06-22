using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpiderCube : MonoBehaviour
{
    private float rotation = 0f;
    [SerializeField] private float movingSpeed = .1f;

    private void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * movingSpeed;

        if (Input.GetMouseButtonDown(0))
            transform.position += new Vector3(0, 1, 0);
        if (Input.GetMouseButtonDown(1))
            transform.position -= new Vector3(0, 1, 0);

        //if (Input.GetMouseButtonDown(0))
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 90), movingSpeed);
        //if (Input.GetMouseButtonDown(1))
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -90), movingSpeed);


    }
}
