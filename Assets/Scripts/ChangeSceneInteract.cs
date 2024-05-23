using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneInteract : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.UnloadSceneAsync("Town");
        SceneManager.LoadSceneAsync("House", LoadSceneMode.Additive);
    }
}
