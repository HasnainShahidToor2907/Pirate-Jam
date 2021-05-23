using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movableobject : MonoBehaviour
{
    Rigidbody2D shipphysics;

    public float movementspeed = 10f;

    public enum directionlabel { updown,rightleft};
    public directionlabel dl;
    // Start is called before the first frame update
    void Start()
    {
        shipphysics = GetComponent<Rigidbody2D>();
        if (shipphysics == null)
        {
            Debug.Log("rigid body not found");
        }
        
    }
    private void OnMouseDown()
    {
        shipphysics.isKinematic = false;
    }
    private void OnMouseUp()
    {
        shipphysics.isKinematic = true;
        shipphysics.velocity = new Vector2(0, 0);
    }
    // Update is called once per frame
    private void OnMouseDrag()
    {
        Vector2 currentposition = transform.position;
        Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 directiontomove = new Vector2(0, 0);
        shipphysics.velocity = new Vector2(0, 0);
        if (dl == directionlabel.updown)
        {
            if (currentposition.y < mouseposition.y)
            {
                directiontomove.y += mouseposition.y - currentposition.y;

            }
            else if (currentposition.y > mouseposition.y)
            {
                directiontomove.y -= currentposition.y - mouseposition.y;
            }
        }

        if (dl == directionlabel.rightleft)
        {
            if (currentposition.x < mouseposition.x)
            {
                directiontomove.x += mouseposition.x - currentposition.x;

            }
            else if (currentposition.x > mouseposition.x)
            {
                directiontomove.x -= currentposition.x - mouseposition.x;
            }
        }
        shipphysics.AddForce(directiontomove*10,ForceMode2D.Impulse);
    }



}
