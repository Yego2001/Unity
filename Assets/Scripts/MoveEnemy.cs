using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float maxRight;
    public float maxLeft;
    public float enemySpeed = 5;
    public int chaingeDirection = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * chaingeDirection * enemySpeed * Time.deltaTime);
        if (transform.position.x > maxRight)
        {
            chaingeDirection = -1;

        }
        else if (transform.position.x < maxLeft)
        {
            chaingeDirection = 1;
        }
        transform.localScale = new Vector3(-chaingeDirection, 1, 1);

    }

}
