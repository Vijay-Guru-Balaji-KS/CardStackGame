using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistributeCardsPanel : MonoBehaviour
{
    public GameObject centerCardsLoad;
    public GameObject TopHalfCardsScriptHolder;
    public GameObject BootomHalfCardsScriptHolder;

    [Header("Before Things(lets go panel)")]
    public GameObject DistributePanel;
    public GameObject AllreadyPresentCards;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void startGame()
    {
        StartCoroutine(startingGame());
    }

    IEnumerator startingGame()
    {
        Destroy(DistributePanel);
        //yield return new WaitForSeconds(0.1f);
        Destroy(AllreadyPresentCards);
        //yield return new WaitForSeconds(0.6f);
        centerCardsLoad.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        TopHalfCardsScriptHolder.SetActive(true);
        BootomHalfCardsScriptHolder .SetActive(true);
    }


}
