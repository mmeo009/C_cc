using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    protected GameManager GameManager => GameManager.Instance;
    public Rigidbody2D rb;
    public GameObject bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bullet = Resources.Load("Bullet") as GameObject;
    }

    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(hori * GameManager.moveSpeed, verti * GameManager.moveSpeed, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        Vector3 pos = this.transform.position;
        Quaternion rot = this.transform.rotation;
        if(GameManager.dmg % 10 == 1 || GameManager.dmg % 10 == 6)
        {
            Instantiate(bullet, pos, rot);
        }
        else if(GameManager.dmg % 10 == 2 || GameManager.dmg % 10 == 7)
        {
            Instantiate(bullet, pos, rot);
            Instantiate(bullet, pos + new Vector3(0.15f, -0.15f, 0), rot);
        }
        else if (GameManager.dmg % 10 == 3 || GameManager.dmg % 10 == 8)
        {
            Instantiate(bullet, pos, rot);
            Instantiate(bullet, pos + new Vector3(0.15f, -0.15f, 0), rot);
            Instantiate(bullet, pos + new Vector3(-0.15f, -0.15f, 0), rot);
        }
        else if(GameManager.dmg % 10 == 4 || GameManager.dmg % 10 == 9)
        {
            Instantiate(bullet, pos, rot);
            Instantiate(bullet, pos + new Vector3(0.15f, -0.15f, 0), rot);
            Instantiate(bullet, pos + new Vector3(-0.15f, -0.15f, 0), rot);
            Instantiate(bullet, pos + new Vector3(0.3f, -0.3f, 0), rot);
        }
        else if(GameManager.dmg % 5 == 0)
        {
            Instantiate(bullet, pos, rot);
            Instantiate(bullet, pos + new Vector3(0.15f, -0.15f, 0), rot);
            Instantiate(bullet, pos + new Vector3(-0.15f, -0.15f, 0), rot);
            Instantiate(bullet, pos + new Vector3(0.3f, -0.3f, 0), rot);
            Instantiate(bullet, pos + new Vector3(-0.3f, -0.3f, 0), rot);
        }
    }
    public void GetDmg(int d)
    {
        if (GameManager.hp > 0)
        {
            GameManager.hp -= d;
        }
        else
        {
            PlayerDie();
        }
    }
    void PlayerDie()
    {
        //플레이어가 죽었을때
    }
}
