using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tip : MonoBehaviour
{
    public string[] tipText;
    public TMP_Text textGUI;
    public int nowNum = 999;
    public bool isTipRunning = false;

    private void Start()
    {
        textGUI = GetComponent<TextMeshProUGUI>();
        StartCoroutine(ToolTips());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isTipRunning)
        {
            StartCoroutine(ToolTips());
        }
    }
    IEnumerator ToolTips()
    {
        isTipRunning = true;
        int lastNum = nowNum;
        while (true)
        {
            yield return null;
            nowNum = Random.Range(0, tipText.Length);
            if(nowNum != lastNum)
            {
                TextChange();
                yield break;
            }
        }
    }
    void TextChange()
    {
        textGUI.text = "�˰��̳���?" + tipText[nowNum] + "\n" + "�����̽� �ٸ� ���� ������ �����ϼ���.";
        isTipRunning = false;
    }
}
