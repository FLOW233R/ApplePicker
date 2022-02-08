/****
 * Created By: Siyu Yang
 * Date Created: 1/31/2022
 * 
 * Last Edited: N/A
 * Last Edited by: N/A
 * 
 * Description: Moving the backets with the Mouse
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;//get the current screen position of the mouse from Input
        mousePos2D.z = -Camera.main.transform.position.z;// The Camera's z position set how far to push the mouse into 3D
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);// Convert the point from 2D screen space into 3D
                                                                        // game world space
        Vector3 pos = this.transform.position;// Move the x position of this Basket to the x position of the Mouse
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
    // find out what hit this basket
    void OnCollisionEnter(Collision coll)
    {
        GameObject collideWith = coll.gameObject;
        if (collideWith.tag == "Apple")
        {
            Destroy(collideWith);
        }
    }
}
