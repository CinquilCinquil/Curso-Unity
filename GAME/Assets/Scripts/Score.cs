using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI label;

    // Update is called once per frame
    public void UpdateScore(int score)
    {
        label.text = score.ToString();
    }
}
