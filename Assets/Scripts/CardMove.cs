using PrimeTween;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CardMove : MonoBehaviour
{
    public Transform[] cards;  
    public float moveDuration = 10f;  
    public float delayBetweenCards = 4f;  
    public Vector3 endPosition = new Vector3(-1920f, 0, 0);

    float count;

    public Ease ease = Ease.InOutBounce;
    void Start()
    {
        count = 0;
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

            Tween.Position(card, endPosition, moveDuration, ease).OnComplete(() =>
            {
                Destroy(card.gameObject);
            });

            yield return new WaitForSeconds(delayBetweenCards);
        }
    }
}
