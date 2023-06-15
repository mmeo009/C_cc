using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    protected GameManager GameManager => GameManager.Instance;
    public Rigidbody2D rb;
    public GameObject bullet;

    public float moveSpeed = 10.0f;
    public int hp = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bullet = Resources.Load("Bullet") as GameObject;
        //리소스 파일에서 총알을 불러옴
    }

    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(hori * moveSpeed, verti * moveSpeed, 0);

        // 캐릭터 움직이는 코드
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        switch(GameManager.dmg)
        {
            case 0:
                break; 
            case 1:
                Instantiate(bullet, this.gameObject.transform.position, this.transform.rotation);
                break;
                case 2:
                Instantiate(bullet, this.gameObject.transform.position, this.transform.rotation);
                Instantiate(bullet, this.gameObject.transform.position + new Vector3(0.3f,-0.2f,0), this.transform.rotation);
                break;
            case 3:
                Instantiate(bullet, this.gameObject.transform.position, this.transform.rotation);
                Instantiate(bullet, this.gameObject.transform.position + new Vector3(0.3f, -0.2f, 0), this.transform.rotation);
                Instantiate(bullet, this.gameObject.transform.position + new Vector3(-0.3f, -0.2f, 0), this.transform.rotation);
                break;

        }

    }
    public void GetDmg(int d)
    {
        if (hp > 0)
        {
            hp -= d;
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
