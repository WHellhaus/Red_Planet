using UnityEngine;
using System.Collections;

public class HealthShower : MonoBehaviour {
    public int health = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D()
    {
        health -= 10;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 50), "Health: " + health);
    }
}
