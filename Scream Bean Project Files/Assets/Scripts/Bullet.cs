using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosion;

    //Destroys the bullet prefab should it touch a collider in the world

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Destroy(gameObject);
        

    }

}





