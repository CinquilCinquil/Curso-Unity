using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI label;

    // Update is called once per frame

    public void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        label.text = PlayerPrefs.GetInt("Pontos", 0).ToString();
    }
}
