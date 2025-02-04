using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float balance;
    private TextMeshProUGUI pointText;
    private GameObject canvas;

    void Start()
    {
        canvas = GameObject.Find("Canvas");
        pointText = canvas.GameObject.Find("Balance").GetComponent<TextMeshProUGUI>();
        pointText.SetText("Guinea Pig");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
