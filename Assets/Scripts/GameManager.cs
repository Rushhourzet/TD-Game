using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Object mainMenuScene;
    [SerializeField] private Object gameScene;

    private const int INFORMATION = 1;

    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }
    public void Play() {
        SceneManager.LoadScene(gameScene.name);
    }
}
