using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class Destroer : MonoBehaviour
{
    private Transform mainCamera;


    // public Transform pipes;
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();



    }

    // Update is called once per frame
    void Update(
    )
    {
        Transform pipe = this.gameObject.GetComponent<Transform>();

        if ((mainCamera.position.x - pipe.position.x) > 10)
        {
            Destroy(this.gameObject);
        }



    }
}
