using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Rigidbody projectile;
    public float timer = 0;
    Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            spawn = Camera.main.transform.TransformPoint(Vector3.forward*2);




            timer++;
            if (timer > 10)
            {
                Rigidbody clone;

                clone = Instantiate(projectile, spawn, transform.rotation);
                clone.velocity = Camera.main.transform.TransformDirection(Vector3.forward * 20);
                timer = 0;
            }


        }
    }

 
    
} 
