using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MonBulletBasic : MonoBehaviour
{
    public int type;
    public float timer;
    public float hp;
    public float speed;

    void Start()
    {
        if (type == 0)
        {
            Ready(0);
        }
    }
    private void FixedUpdate()
    {
        if (timer != 0)
        {
            timer -= Time.deltaTime;
        }
    }
    void Update()
    {
        switch (type)
        {
            case 0:
                transform.Translate(Vector2.down * 1);
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.layer);

        if (other.gameObject.tag == "Player")
        {
            switch (type)
            {
                case 0:
                other.gameObject.GetComponent<PlayerCtrl>().GetDmg(1);
                break;
            }
            Destroy(this.gameObject);
        }
        if(other.gameObject.layer == 6)
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    public void Ready(int bulletType)
    {
        type = bulletType;
        Reload(0);
    }
    private void Reload(float IDKWII)
    {
        switch (type)
        {
            case 0:
                timer = 5.0f;
                break;
        }
    }
}
