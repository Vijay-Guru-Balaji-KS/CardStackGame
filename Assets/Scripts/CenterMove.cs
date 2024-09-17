using PrimeTween;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterMove : MonoBehaviour
{
    
    public Transform[] cards;
    public float moveDuration = 10f;
    public float delayBetweenCards = 4f;
    public Vector3 endPosition = new Vector3(-1920f, 0, 0);

    public GameObject endGameObject;

    float count;

    public Ease ease = Ease.InOutBounce;
    void Start()
    {
        count = 0;
        endPosition = new Vector3(0,endGameObject.transform.position.y,0);
        StartCoroutine(MoveCards());
    }

    private void Update()
    {
        /*foreach (Transform card in cards) 
        if (card.transform == null)
            Debug.Log("Total timetaken = " + count);
        */
        count += Time.deltaTime;
        Debug.Log(count);
    }



    IEnumerator MoveCards()
    {

        foreach (Transform card in cards)
        {
            count += Time.deltaTime;
            if (card == null)
            {
                Debug.LogError("One of the cards is null! Make sure all cards are assigned.");
                continue;
            }

            //Tween.Position(card, endPosition, moveDuration, ease).OnComplete(() =>
            //{
            //    Destroy(card.gameObject);
            //});

            Tween.Position(card, endPosition, delayBetweenCards,ease);

            yield return new WaitForSeconds(delayBetweenCards);
        }
    }

}

