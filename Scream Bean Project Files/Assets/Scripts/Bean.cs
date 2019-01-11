using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bean : MonoBehaviour {

    public Transform target;

    private Rigidbody2D rb;

    public float speed = 5f;

    public float rotateSpeed = 200f;

    public Transform Spawn;

	//This is one of the two scripts integral to making the game work, it controls the speed of the beans and detects wether they're hitting the bullet collider or the fort collider. This script links back to the lives script 
    //as it requires the integer


	void Start () {
        target = GameObject.FindGameObjectWithTag("Fort").transform;
        rb = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, -transform.right).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = -transform.right * speed;

    }

    void OnTriggerEnter2D (Collider2D collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("LOL");
            Userinterfacescore.scoreAmount += 1;
            Destroy(gameObject);
        }


            if (collision.gameObject.tag == "Fort")
            {

            Debug.Log("Fort");
            Userinterfacelives.liveAmount += -1;
            Destroy(gameObject);

            }


        Destroy(gameObject);
    } 

    }
