using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletLogic : MonoBehaviour {

    public float speed = 40;
    public Rigidbody rb;
    public float dmg=24;
    private int hasState;

	void LateUpdate () {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)&&hasState==0)
        {
            rb.velocity = transform.right * (-1) * speed;
            hasState++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && hasState == 0)
        {
            rb.velocity = transform.right * speed;
            hasState++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && hasState == 0)
        {
            rb.velocity = transform.forward * speed;
            hasState++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && hasState == 0)
        {
            rb.velocity = transform.forward * (-1) * speed;
            hasState++;
        }

    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        //Debug.Log(hitInfo.name);
        if (hitInfo.tag != "Player")
        {
            Destroy(gameObject);
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.takeDamage(dmg);
            }
        }

       
    }
}
