using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onGUI()
    {
        GUI.contentColor = Color.black;
        if(GUI.Button(new Rect(Screen.width/5-50, Screen.height/2 + 150, 100, 40), "Retry"))
        {
            print("Hi");
        }
        if (GUI.Button(new Rect(0,0, 100, 40), "Retry"))
        {
            print("Bye");
        }
    }
}
