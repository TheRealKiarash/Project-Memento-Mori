using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timers : MonoBehaviour
{

    public GameObject[] mGameObjectToEnabel;
    public GameObject[] mGameObjectToDisabel;

    public UnityEngine.UI.Text mTextOutput;

    public string mTextOutputFormat = "m:s";


    public float mCountdownTime = 5;


    private float mTimeToStop;
    private bool mFlip = true;


    // Start is called before the first frame update
   

    private void OnEnable()
    {
        mFlip = true;
        mTimeToStop = Time.time + mCountdownTime;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(mFlip && Time.time >  mTimeToStop)
        {
            mFlip = false;

            for(int i = 0; i < mGameObjectToEnabel.Length;i++)
            {
                mGameObjectToEnabel[i].SetActive(true);
            }

            for (int i = 0; i < mGameObjectToDisabel.Length; i++)
            {
                mGameObjectToDisabel[i].SetActive(false);              
            }
        }

        if(mTextOutput != null)
        {


            //System.DateTime date;// System.DateTime;
            System.DateTime date;


            if(mFlip)
                date = new System.DateTime((long)(mTimeToStop-Time.time) * System.TimeSpan.TicksPerSecond);
            else
                date = new System.DateTime((long)(0) * System.TimeSpan.TicksPerSecond);


            mTextOutput.text = date.ToString(mTextOutputFormat);

        }

    }
}
