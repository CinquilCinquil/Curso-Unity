using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    float t = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 1f)
        {

            transform.position = new Vector2(transform.position.x + 0.2f, transform.position.y);

            t = 0f;
        }

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Transform tr = col.gameObject.transform;
        tr.position = new Vector2(0, 2);
    }
}