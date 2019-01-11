using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotation : MonoBehaviour {

    public Transform hitPoint;
    public bool direction;
    public Camera cam;
    public int posOffset;

    // Use this for initialization
    void Start() {

        direction = true;

    }

    // Rotates the players cannon in relation to where the cursor is
    void Update() {
            var pos = Camera.main.WorldToScreenPoint(transform.position);
            var dir = Input.mousePosition - pos;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            float minRotation =  10;
            float maxRotation =  100;
            Vector3 currentRotation = transform.localRotation.eulerAngles;
            currentRotation.z = Mathf.Clamp(currentRotation.z, minRotation, maxRotation);
            transform.localRotation = Quaternion.Euler(currentRotation);
             }
    }


