﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform objectToFollow;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.position + offset;
        //transform.position = Vector3.Lerp(transform.position, objectToFollow.position + offset, Time.deltaTime);
    }
}
