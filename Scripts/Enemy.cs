using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int contactDmg;
    [SerializeField] private float speed;
    [SerializeField] private float detectRange = 10f;
    [SerializeField] private Transform player;
    [SerializeField] private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        GameObject p = GameObject.FindWithTag("Player");
        if (p != null) 
        {
            player = p.GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.position;
        Vector2 direction = playerPos - (Vector2)transform.position;
        if (direction.magnitude <= detectRange)
        {
            direction.Normalize();
            rig.velocity = direction * speed;

            transform.localScale = new Vector2(Mathf.Sign(rig.velocity.x), transform.localScale.y);
        }
        else
        {
            rig.velocity = Vector2.zero;
        }
            
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Player>().TakeDamage(contactDmg);
        }
    }

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        if (hp <= 0) Destroy(this.gameObject);
    }

}
