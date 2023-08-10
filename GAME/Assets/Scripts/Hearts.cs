using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    // Update is called once per frame
    public void UpdateHearts(float hp)
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i*20 < hp);
        }
    }
}
