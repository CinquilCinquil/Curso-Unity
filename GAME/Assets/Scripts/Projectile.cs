using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float velocidade = 1f;
    [SerializeField] public Vector2 direcao = Vector2.right;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = direcao * velocidade;
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject, 0.5f);
        Debug.Log(col.gameObject);
    }
}
