using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class Destroer : MonoBehaviour
{
    private Transform mainCamera;


    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();



    }

    // Update is called once per frame
    void Update(
    )
    {
        Transform objectPosition = this.gameObject.GetComponent<Transform>();

        if ((mainCamera.position.x - objectPosition.position.x) > 10)
        {
            Destroy(this.gameObject);
        }



    }
}
