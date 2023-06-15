using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int count;
    public float moveSpeed = 10.0f;
    public int maxHp = 5;
    public int hp;
    public int dmg;

    public GameManager() { }
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            transform.parent = null;
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        if(count >= 2)
        {
            MoveScene("Play2");
        }
    }
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;  
    }
    public void MoveScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }
}
