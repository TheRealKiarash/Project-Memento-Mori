using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failorsuccess : MonoBehaviour
{
    public GameObject winState;
    public GameObject failState;
    public GameObject gamePanel;

    public void WinOrFail() 
    {
        if (gameObject.CompareTag("DadReading"))
        {
            gamePanel.SetActive(false);

            winState.SetActive(true);
        }
        else
        {
            gamePanel.SetActive(false);

            failState.SetActive(true);
        }
            

        
    
    }
    
}
