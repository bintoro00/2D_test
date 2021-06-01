using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public PlayerController pctrl;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = new Vector2(-speed,rb.velocity.y);
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            pctrl.PlayerDead();
        }
    }
}
