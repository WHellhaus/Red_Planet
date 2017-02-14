using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {
    void Update()
    {
        Quit1();
    }
    void Quit1()
    {
        Application.Quit();
    }
}
