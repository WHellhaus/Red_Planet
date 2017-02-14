using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    public Rigidbody2D bulletPrefab;
    public GameObject gunPos;
    public float attackSpeed = 0.5f;
    public float coolDown;
    public float bulletSpeed = 10000;
    public float yValue = 0.0f; // Used to make it look like it's shot from the gun itself (offset)
    public float xValue = 0.0f; // Same as above


    // Update is called once per frame
    void Update()
    {

        if (Time.time >= coolDown)
        {
            if (Input.GetMouseButton(0))
            {
                Fire();
            }
        }
    }

    void Fire()
    {
        //Rigidbody2D bPrefab = Instantiate(bulletPrefab,transform.position,Quaternion.identity) as Rigidbody2D;

        Rigidbody2D bPrefab = Instantiate(bulletPrefab, gunPos.transform.position, Quaternion.identity) as Rigidbody2D;

        bPrefab.AddForce(transform.up * bulletSpeed);

        coolDown = Time.time + attackSpeed;
    }

}
