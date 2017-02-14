using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    GameObject go;
    public GameObject go1;
    public int nextLev = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        go = GameObject.FindGameObjectWithTag("enemy");
        if (go == null)
        {
            UWin();
        }
        
        if (go1 == null)
        {
            ULose();
        }

    }
    
    void UWin()
    {
        SceneManager.LoadScene(nextLev);
    }
    void ULose()
    {
        SceneManager.LoadScene("Game Over");
    }
}
