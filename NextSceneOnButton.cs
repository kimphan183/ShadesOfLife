
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneOnButton : MonoBehaviour
{
    [SerializeField] private string sceneName; //[SerializeField] allows you to see private variables in the editor without making them public

    private void Start()
    {
        
    }

    public void nextScene() {
        Debug.Log("Loading Scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
