using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float velocidade = 10;
    [SerializeField] Transform FloorCheck;
    [SerializeField] Transform Gun;
    [SerializeField] LayerMask Floor;

    [SerializeField] GameObject pellet;

    [SerializeField] Score sc;
    [SerializeField] Hearts hb;
    [SerializeField] Animator anim;

    [SerializeField] AudioSource aud;
    [SerializeField] AudioClip jumpClip;

    int score = 0;
    float Hp = 100f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("alguma coisa");
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(hAxis*velocidade, rb.velocity.y);

        if (hAxis != 0)
        {
            anim.SetBool("isMoving", true);
            Flip(hAxis);
        }
        else anim.SetBool("isMoving", false);

        anim.SetBool("isGround", IsOnGround());

        if (Input.GetButtonDown("Jump") && IsOnGround())
        {
            aud.PlayOneShot(jumpClip);
            rb.velocity = new Vector2(rb.velocity.x, 20);

            score += 100;
            sc.UpdateScore(score);

            Hp -= 10;
            hb.UpdateHearts(Hp);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(pellet, Gun.position, new Quaternion());
            Projectile p = projectile.GetComponent<Projectile>();
            p.direcao = p.direcao * transform.localScale.x;
        }

    }

    bool IsOnGround()
    {
        return Physics2D.OverlapCircle(FloorCheck.position, 0.2f, Floor);
    }
    void Flip(float hAxis)
    {
        transform.localScale = new Vector2(Mathf.Sign(hAxis), transform.localScale.y);
    }
}
