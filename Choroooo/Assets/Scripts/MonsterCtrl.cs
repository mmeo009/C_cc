using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    public int hp = 5;
    Rigidbody2D rb;
    [SerializeField]
    GameManager manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, -1);

        if(this.transform.position.y < - 8 )
        {
            Destroy(this.gameObject);
        }
    }
    public void GetDmg(int d)
    {
        hp -= d;
        if(hp <= 0) 
        {
            manager.count ++;
            Destroy(this.gameObject);
        }
    }
}
