using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    protected GameManager GameManager => GameManager.Instance;
    public int bulletType = 0;
    private void Awake()
    {
        int dmg = GameManager.dmg;
        bulletType = dmg / 5 + 1;
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
