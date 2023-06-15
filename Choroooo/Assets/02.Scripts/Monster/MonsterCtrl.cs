using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonsterStats
{
    Rigidbody2D rb;
    [SerializeField]
    GameManager manager;
    private void Awake()
    {
        switch (this.gameObject.tag)
        {
            case "Mon_1_1":
                MonsterStatSetting(1, 1, 1, 3, 1, 1);
                break;
        }
    }
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (this.transform.position.y < -8)
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        if (Mon.MonT == 1) 
        {
            rb.velocity = new Vector2(rb.velocity.x, -1);
        }
    }
    public void GetDmg(int dmg)
    {
        Mon.HP -= dmg;
        if(Mon.HP <= 0) 
        {
            manager.count ++;
            Destroy(this.gameObject);
        }
    }

    public void Attack_1()
    {

    }
}
