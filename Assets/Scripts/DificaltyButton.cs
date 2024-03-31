using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DificaltyButton : MonoBehaviour
{
    private Button button;
    void Start()
    {
        Debug.Log("Hello, I'm a button");
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDificalty);

    }

    // Update is called once per frame
    void Update()
    {

    }


    void SetDificalty()
    {
        Debug.Log(gameObject.name + "Была нажата");

    }
}
