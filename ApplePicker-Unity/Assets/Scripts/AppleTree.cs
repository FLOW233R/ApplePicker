/****
 * Created By: Siyu Yang
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

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject applePrefab;// Prefab for instantiating apples

    public float speed = 1f;// Speed at which the AppleTree moves

    public float leftAndRightEdge = 10f;//Distance where AppleTree turns around 

    public float chanceToChanceDirections = 0.1f;//Chance that the AppleTree will be instanianted

    public float secondsBetweenAppleDrops = 1f;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }// end Start

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
    void FixedUpdate()
    {
        if (Random.value < chanceToChanceDirections)
        {
            speed *= -1;//Change direction
        }
    }// end FixedUpdate
}



