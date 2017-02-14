using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {
    public Transform player;
    public float maxSpeed = 5f;
    public float rotSpeed = 180f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GoTowardsPlayer();
	
	}

    void GoTowardsPlayer()
    {
        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAngle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90);
        transform.rotation = Quaternion.Euler(0, 0, zAngle);

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime);
        pos += transform.rotation * velocity;
        transform.position = pos;
    }
}
