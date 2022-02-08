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

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
