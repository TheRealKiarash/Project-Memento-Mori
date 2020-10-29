using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failorsuccess : MonoBehaviour
{
    public GameObject winState;
    public GameObject failState;

    public void WinOrFail() 
    {
        if (gameObject.CompareTag("DadReading"))
        {
            winState.SetActive(true);
        }
        else
            failState.SetActive(true);
    
    }
    
}
