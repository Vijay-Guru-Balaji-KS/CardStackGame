using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDesolver : MonoBehaviour
{
    public GameObject cardAnimationGO;

    public GameObject panel;

    public GameObject cardsdistribute;

    [Header("Distribution references")]
    public GameObject topHalfLoader;
    public GameObject bottomHalfLoader;
    public GameObject p1Holder;
    public GameObject p2Holder;


    [Header("Cards Shuffling references")]
    public GameObject CardShufflerHolder;
    public GameObject leftHalfHolder;
    public GameObject rightHalfHolder;

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
        //panel.SetActive(false);
        cardsdistribute.SetActive(true);
        p1Holder.SetActive(true);
        p2Holder.SetActive(true);
        topHalfLoader.SetActive(true);
        bottomHalfLoader.SetActive(true);

    }

    /*public void leftAndRightDistributer()
    {
        StartCoroutine(StartShuffling());
    }*/

    public void shuffle()
    {
        CardShufflerHolder.SetActive(true);
        leftHalfHolder.SetActive(true);
        rightHalfHolder.SetActive(true);
    }


    /*IEnumerator StartShuffling()
    {
        CardShufflerHolder.SetActive(true);
        leftHalfHolder.SetActive(true);
        rightHalfHolder.SetActive(true);
        yield return new WaitForSeconds(4);
        Destroy(CardShufflerHolder);
        yield return new WaitForSeconds(2);
        oncardsDistribute();
    }*/




}
