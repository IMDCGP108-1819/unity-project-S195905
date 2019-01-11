using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireRate = 0.2f;
    private float nextFire = 0.0f;
    Animator animator;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public GameObject explosion;

    //A much more complex script than I could've figured out myself. This script tracks the players mouse position at all times and points the cannon towards that position in the world.
    //Some of the components like minRotation I decided not to use as it snapped the players position back to the default, making aiming close to those angles fustrating.

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }


    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        var pos = Camera.main.WorldToScreenPoint(transform.position);
        var dir = Input.mousePosition - pos;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        float minRotation = 0;
        float maxRotation = 360;
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.z = Mathf.Clamp(currentRotation.z, minRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(currentRotation);

        bool fire = Input.GetButtonDown("Fire1");

        animator.SetBool("Fire", fire);

        if (Userinterfacelives.liveAmount <= 0)
        {

            currentRotation = new Vector3(currentRotation.x, currentRotation.z);
            ((FireScript)gameObject.GetComponent<FireScript>()).enabled = false;


        }


            if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            FireBullet();
        }
    }

    void FireBullet()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * 13;

        bool fire = Input.GetButtonDown("Fire1");

        animator.SetBool("Fire", fire);


        Destroy(bullet, 1.6f);


    }

    



}






