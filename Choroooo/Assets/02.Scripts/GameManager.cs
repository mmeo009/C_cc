using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int count;
    private void Update()
    {
        if(count >= 2)
        {
            MoveScene("Play2");
        }
    }
    public void MoveScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
