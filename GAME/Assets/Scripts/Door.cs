using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] LevelManager manager;
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") manager.LoadNextLevel();
    }
}
