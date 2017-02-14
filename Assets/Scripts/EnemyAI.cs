using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    public Transform sightStart, sightEnd;
    public bool spotted = false;
    public Transform player;
    public float maxSpeed = 5f;

    public Transform gunPos;
    public float attackSpeed;
    float coolDown;
    public float bulletSpeed;
    public Rigidbody2D bulletPrefab;

    // Update is called once per frame
    void Update () {
        Raycasting();
        Behavior();
	}

    void Raycasting()
    {
        Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);
        spotted = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Player") );
    }

    void Behavior()
    {
        if (spotted == false)
            return;
        else if (spotted == true)
        {
            Vector3 dir = player.position - transform.position;
            dir.Normalize();

            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.Euler(0, 0, zAngle);

            Vector3 pos = transform.position;
            Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime);
            pos += transform.rotation * velocity;
            transform.position = pos;

            Fire();
        }
    }

        void Fire() {
            if (Time.time >= coolDown)
            {
                Rigidbody2D bPrefab = Instantiate(bulletPrefab, gunPos.position, Quaternion.identity) as Rigidbody2D;

                bPrefab.AddForce(transform.up * bulletSpeed);

                coolDown = Time.time + attackSpeed;
            }

        }
    }
