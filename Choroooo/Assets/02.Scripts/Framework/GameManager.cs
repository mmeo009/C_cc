using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public int count;
    public float moveSpeed = 10.0f;
    public int maxHp = 5;
    public int hp;
    public int dmg;
    public int bulletType = 0;
    public int gold;
    public string SceneName;
    public float r, g, b;
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
    public void Start()
    {
        AddDmg(1);
    }
    private void Update()
    {
        switch(count)
        {
            case 1:
                break;
            case 2:
                break;
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            AddDmg(1);
        }
    }
    public void LoadScene(string nextScene)
    {
        SceneName = nextScene;
        SceneManager.LoadScene("Loading");
    }
    public void AddDmg(int amount)
    {
        dmg += amount;
        int pastBT = bulletType;
        bulletType = dmg / 5 + 1;
        if(pastBT != bulletType)
        {
            BulletColor();
        }
    }
    public void BulletColor()
    {
        if(bulletType != 1)
        {
            r = Random.Range(0.0f, 1.0f);
            g = Random.Range(0.0f, 1.0f);
            b = Random.Range(0.0f, 1.0f);
        }
    }
}
