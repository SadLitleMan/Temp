using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {


    public Transform FirePoint;
    public GameObject bullet;
    
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        Instantiate(bullet, FirePoint.position-new Vector3(0f,1f,0f), FirePoint.rotation);
    }
  
}
