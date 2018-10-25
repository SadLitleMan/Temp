using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoroler : MonoBehaviour {

    public float speed = 30f;
    private Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void Update () {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical")*speed*Time.deltaTime);
	}
}
