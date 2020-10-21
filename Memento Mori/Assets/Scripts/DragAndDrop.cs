using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    // Start is called before the first frame update

    private bool mCanMove;
    private bool mDragging;
    public Collider2D mCollider;


    void Start()
    {
        if(mCollider == null)
        mCollider = GetComponent<Collider2D>();

        mCanMove = false;
        mDragging = false;

    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (mCollider == Physics2D.OverlapPoint(mousePos))
            {
                mCanMove = true;
            }
            else
            {
                mCanMove = false;
            }
            if (mCanMove)
            {
                mDragging = true;
            }


        }
        if (mDragging)
        {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mCanMove = false;
            mDragging = false;
        }
    }
}





