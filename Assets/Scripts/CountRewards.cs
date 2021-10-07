using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountRewards : MonoBehaviour
{
    private string v ;
    public GameObject popUp;
    private int count_0;
    private int count_1;
    private int count_2;
    private int count_3;
    public Text message;
    
    
    void start()
    {
        popUp.active = false;
    }

    [System.Obsolete]
    void Update()
    {
        if (count_0 == 3 || count_1 == 3 || count_2 == 3 || count_3 == 3)
        {
            
            if (count_0 == 3)
            {
                v = "mini reward";
                showPopup();
            }
            else if (count_1 == 3)
            {
                v = "minor reward";
                showPopup();
            }
            else if (count_2 == 3)
            {
                v = "major reward";
                showPopup();
            }
            else if (count_3 == 3)
            {
                v = "Grand reward";
                showPopup();
            }
            
        }
        message.text = v;
        

    }

    public void showPopup()
    {
        popUp.active = true;
    }
    public void increasecount(int index)
    {
        if (index == 0)
        {
            count_0 += 1;
            Debug.Log("count_0 :" + count_0);
        }
        else if (index == 1)
        {
            count_1 += 1;
            Debug.Log("count_1 :" + count_1);
        }
        else if (index == 2)
        {
            count_2 += 1;
            Debug.Log("count_2 : " + count_2);
        }
        else if (index == 3)
        {
            count_3 += 1;
            Debug.Log("count_3 :" + count_3);
        }
        
    }
}
