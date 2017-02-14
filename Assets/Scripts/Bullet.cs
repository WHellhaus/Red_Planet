using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerEnter2D()
    {
        Destroy(this.gameObject);
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
