using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    private int totalSceneCount;
    private int currentSceneIndex;


    void Start()
    {
        totalSceneCount = SceneManager.sceneCountInBuildSettings;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }


    void Update()
    {
        if (Input.GetButtonDown("Switch Scene"))
        {
            if (currentSceneIndex != totalSceneCount - 1) {
                SceneManager.LoadScene(currentSceneIndex + 1);
            } else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}