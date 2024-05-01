using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBirdTracker : MonoBehaviour
{
    public GameObject bird;
    private float xOffsets = -1;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bird.transform.position.x - xOffsets, transform.position.y, transform.position.z);
    }




}
