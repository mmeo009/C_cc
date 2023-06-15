using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{

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
            other.gameObject.GetComponent<MonsterCtrl>().GetDmg(1);
            Destroy(this.gameObject);
        }
    }
}
