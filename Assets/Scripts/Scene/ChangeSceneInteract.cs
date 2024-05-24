using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneInteract : MonoBehaviour
{
    [SerializeField] string targetScene;
    public void ChangeScene()
    {
        FindObjectOfType<GameSceneManager>().SwitchEnviromentScene(targetScene);
    }
}
