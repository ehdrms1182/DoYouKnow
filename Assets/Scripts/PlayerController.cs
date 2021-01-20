﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed = 1.5f;
    float x;
    float z;
    private Vector3 moving;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        moving = new Vector3(x, 0, z).normalized;
        transform.position += moving * playerSpeed * Time.deltaTime;
    }

    private void Jump()
    {
        //if (Input.GetKey = "SpaceBar")
        //{
        //return;
        //}
    }
    private void Rotate()
    {
        float rotateSpeed = 300f;
        //마우스 입력받기
        float mouseX = Input.GetAxis("Mouse X");
        //회전 방향 결정
        Vector3 dir = new Vector3(0, -mouseX, 0);

        //r=ro+vt
        transform.eulerAngles += dir * rotateSpeed * Time.deltaTime;
    }

}
