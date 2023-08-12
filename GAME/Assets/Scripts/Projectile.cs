using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float velocidade = 1f;
    [SerializeField] int shotDamage = 1;
    [SerializeField] public Vector2 direcao = Vector2.right;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = direcao * velocidade;
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Enemy>().TakeDamage(shotDamage);
        }

        Destroy(this.gameObject, 0.2f);
    }
}
