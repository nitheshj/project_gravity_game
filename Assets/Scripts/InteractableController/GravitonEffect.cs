﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitonEffect : MonoBehaviour {

    private Rigidbody rb;
    public float gravitonForce = 1.0f;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void OnTriggerStay(Collider coll)
    {
        
        if (coll.gameObject.tag == "Graviton")
        {
            if (this.gameObject.tag != "JadeCube")
            {
                Vector3 velo;
                velo = rb.velocity;
                velo.x = 0;
                rb.velocity = velo;
            }
           
            rb.AddForce(Vector3.up * (gravitonForce + 9.8f) * rb.mass);
        }
    }

}
