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
        switch(GameManager.dmg)
        {
            case 0:
                break; 
            case 1:
                Instantiate(bullet, pos, rot);
                break;
                case 2:
                Instantiate(bullet, pos, rot);
                Instantiate(bullet, pos + new Vector3(0.15f,-0.15f,0), rot);
                break;
            case 3:
                Instantiate(bullet, pos, rot);
                Instantiate(bullet, pos + new Vector3(0.15f, -0.15f, 0), rot);
                Instantiate(bullet, pos + new Vector3(-0.15f, -0.15f, 0), rot);
                break;
            case 4:
                Instantiate(bullet, pos, rot);
                Instantiate(bullet, pos + new Vector3(0.15f, -0.15f, 0), rot);
                Instantiate(bullet, pos + new Vector3(-0.15f, -0.15f, 0), rot);
                Instantiate(bullet, pos + new Vector3(0.3f, -0.3f, 0), rot);
                break;
            case 5:
                Instantiate(bullet, pos, rot);
                Instantiate(bullet, pos + new Vector3(0.15f, -0.15f, 0), rot);
                Instantiate(bullet, pos + new Vector3(-0.15f, -0.15f, 0), rot);
                Instantiate(bullet, pos + new Vector3(0.3f, -0.3f, 0), rot);
                Instantiate(bullet, pos + new Vector3(-0.3f, -0.3f, 0), rot);
                break;

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
