using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    protected GameManager GameManager => GameManager.Instance;
    private SpriteRenderer sp;
    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        sp.color = new Color(GameManager.r, GameManager.g, GameManager.b);
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
            other.gameObject.GetComponent<MonsterCtrl>().GetDmg(GameManager.bulletType);
            Destroy(this.gameObject);
        }
    }
}
