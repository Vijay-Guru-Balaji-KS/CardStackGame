using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DistributePanelChecker : MonoBehaviour
{
    public GameObject[] leftAndRightCards;
    public Vector3 centerPosition;

    public GameObject DistributePanel;

   
    private int n;
    private bool flag = true;
    private bool canOnDistributePanel = false;
    private bool[] checkLeftAndRightCards;

    private void Awake()
    {
        n = leftAndRightCards.Length;
        checkLeftAndRightCards = new bool[n];
        centerPosition = new Vector3(0,0,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag)
        {
            checkIfAllCardsAreCentered();
        }

        if (canOnDistributePanel)
        {
            DistributePanel.SetActive(true);
            Destroy(gameObject);
        }
    }


    public void checkIfAllCardsAreCentered()
    {

        for(int i = 0;i<leftAndRightCards.Length;i++)
        {
            if(leftAndRightCards[i] != null && leftAndRightCards[i].transform.position==centerPosition)
            {
                checkLeftAndRightCards[i] = true;
            }
            else
                checkLeftAndRightCards[i]= false;
        }

        int j;
        for (j = 0; j < leftAndRightCards.Length; j++)
        {
            if (checkLeftAndRightCards[j])
                continue;
            else
                return;
        }

        if (j == n)
        {
            flag = false;
            canOnDistributePanel = true;
        }
    }
}
