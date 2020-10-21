using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    // don´t do it like this... dont 
    public Sprite mImage1;
    public Sprite mImage2;

    public float mAnimationSpeed = 0.5f;

    private SpriteRenderer mSpriteRenderer;
    private float mNextFrameFlip;
    // Start is called before the first frame update
    private void Start()
    {
        mSpriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(mSpriteRenderer!= null && Time.time > mNextFrameFlip)
        {
            if (mSpriteRenderer.sprite != mImage1)
                mSpriteRenderer.sprite = mImage1;
            else
                mSpriteRenderer.sprite = mImage2;

            mNextFrameFlip = Time.time + mAnimationSpeed;

        }


    }
}
