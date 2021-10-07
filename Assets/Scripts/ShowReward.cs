using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ShowReward : MonoBehaviour
{
    [SerializeField] public Sprite[] spritearr;
    public SpriteRenderer image;
    private int index;
    public CountRewards countRewards;
    private int count = 0;
    void start()
    {

        image = GetComponent<SpriteRenderer>();
        Debug.Log(image);
    }

    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if(count == 0)
        {
            index = Random.Range(0, spritearr.Length);
            image.sprite = spritearr[index];
            countRewards.increasecount(index);
        }

        count++;
    }
    
   





}
