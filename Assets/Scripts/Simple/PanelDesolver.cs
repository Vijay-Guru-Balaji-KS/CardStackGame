using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDesolver : MonoBehaviour
{
    public GameObject cardAnimationGO;

    public GameObject panel;

    public GameObject cardsdistribute;
    public GameObject topHalfLoader;
    public GameObject bottomHalfLoader;
    public GameObject p1Holder;
    public GameObject p2Holder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed()
    {
        Debug.Log("button Pressed");
        Destroy(cardAnimationGO);
        panel.SetActive(false);
    }

    public void oncardsDistribute()
    {
        cardsdistribute.SetActive(true);
        p1Holder.SetActive(true);
        p2Holder.SetActive(true);
        topHalfLoader.SetActive(true);
        bottomHalfLoader.SetActive(true);
    }

    
}
