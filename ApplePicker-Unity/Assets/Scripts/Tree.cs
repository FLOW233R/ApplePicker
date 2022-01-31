/****
 * Created By: Logan Patrick
 * Date Created: 1/31/2022
 * 
 * Last Edited: N/A
 * Last Edited by: N/A
 * 
 * Description: Controls tree movement and apple movement
 */




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChanceDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;// Move 
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        // Move every frame
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);//Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);//Move left
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChanceDirections)
        {
            speed *= -1;//Change direction
        }
    }
}



