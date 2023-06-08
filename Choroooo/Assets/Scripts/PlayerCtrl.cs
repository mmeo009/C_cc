using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody2D rb;

    public GameObject bullet;

    public float moveSpeed = 20.0f;
    public int hp = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bullet = Resources.Load("Bullet") as GameObject;
        //리소스 파일에서 총알을 불러옴
    }

    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, 0);
        // 캐릭터 움직이는 코드
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject temp = (GameObject)Instantiate(bullet);
            temp.transform.position = this.gameObject.transform.position;
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
