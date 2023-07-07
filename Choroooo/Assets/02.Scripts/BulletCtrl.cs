using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    protected GameManager GameManager => GameManager.Instance;
    public int bulletType = 0;
    private void Awake()
    {
        if(GameManager.dmg < 6)
        {
            bulletType = 1;
        }
        else if(GameManager.dmg < 11)
        {
            bulletType = 2;
        }
    }
    void FixedUpdate()
    {
        float moveAmount = 10 * Time.fixedDeltaTime;
        transform.Translate(Vector2.up * moveAmount);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.layer == 3)
        {
            other.gameObject.GetComponent<MonsterCtrl>().GetDmg(bulletType);
            Destroy(this.gameObject);
        }
    }
}
