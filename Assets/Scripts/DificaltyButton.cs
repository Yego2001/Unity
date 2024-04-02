using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DificaltyButton : MonoBehaviour
{
    private Button button;
    private SpawnManager spawnManagerScript;
    public float dificalty;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDificalty);
        spawnManagerScript = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();


    }

    // Update is called once per frame
    void Update()
    {

    }


    void SetDificalty()
    {
        Debug.Log(gameObject.name + "Была нажата");
        spawnManagerScript.spawnRate = this.dificalty;
        spawnManagerScript.StartGame();



    }
}
