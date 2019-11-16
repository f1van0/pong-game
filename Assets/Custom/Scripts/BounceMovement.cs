﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceMovement : MonoBehaviour
{
    Rigidbody rb;
    public GameObject Hit;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //сообщаем шару начальную скорость
        rb.AddForce(new Vector3(Random.Range(0f,1f), 0, Random.Range(0f, 1f)) *0.4f);
        
    }

    //
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bar"))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = collision.gameObject.GetComponent<MeshRenderer>().material.color;

            Instantiate(Hit,new Vector3(collision.contacts[0].point.x,
                                        collision.contacts[0].point.y,
                                        collision.contacts[0].point.z),Quaternion.identity);    //спавн хита

        }
    }
}
