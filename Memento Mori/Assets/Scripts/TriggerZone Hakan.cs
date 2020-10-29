using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{

    public GameObject mTarget;

    public GameObject[] mGameObjectToEnabel;
    public GameObject[] mGameObjectToDisabel;

    // Start is called before the first frame update



    void OnTriggerEnter2D(Collider2D col)
    {
        if(mTarget != null)
        {
            if (col.gameObject == mTarget)
            {
                for (int i = 0; i < mGameObjectToEnabel.Length; i++)
                {
                    mGameObjectToEnabel[i].SetActive(true);
                }

                for (int i = 0; i < mGameObjectToDisabel.Length; i++)
                {
                    mGameObjectToDisabel[i].SetActive(false);
                }
            }
        }

    }
}
