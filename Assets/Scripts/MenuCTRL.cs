using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuCTRL : MonoBehaviour {
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
