using PrimeTween;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMove : MonoBehaviour
{
    public Transform[] cards;  
    public float moveDuration = 10f;  
    public float delayBetweenCards = 4f;  
    public Vector3 endPosition = new Vector3(-1920f, 0, 0);

    public Ease ease = Ease.InOutBounce;
    void Start()
    {
        StartCoroutine(MoveCards());
    }

    IEnumerator MoveCards()
    {
        foreach (Transform card in cards)
        {
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
