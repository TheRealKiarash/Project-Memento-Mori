using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggelGameObject : MonoBehaviour
{


    public GameObject[] mNeedToBeEnabeleGameObject;
    public GameObject[] mNeedToBeDisabelGameObject;



    public GameObject[] mGameObjectToEnabel;
    public GameObject[] mGameObjectToDisabel;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        bool flip = true;


        for (int i = 0; i < mNeedToBeEnabeleGameObject.Length; i++)
        {
            if (mNeedToBeEnabeleGameObject[i].activeSelf == false)
                flip = false;
        }

        for (int i = 0; i < mNeedToBeDisabelGameObject.Length; i++)
        {
            if (mNeedToBeDisabelGameObject[i].activeSelf == true)
                flip = false;
        }

        if (flip)
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
