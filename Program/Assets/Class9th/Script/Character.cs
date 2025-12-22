using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
    Vector3 moveDir;
    float moveSpeed;
    void Start()
    {
        moveSpeed = 50;
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        moveDir = new Vector3(x,0,z);
    }


    private void FixedUpdate()
    {
        if(moveDir.magnitude > 0.01f)
        {
            transform.position = transform.position + moveDir * Time.fixedDeltaTime * moveSpeed;
            //transform.Translate(moveDir * Time.fixedDeltaTime * moveSpeed, Space.World);
            Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.fixedDeltaTime * 5);
        }
    }

    private IEnumerator Start_MoveFireballProjectile()
    {
        yield return new WaitForSeconds(0.2f);
    }
}
