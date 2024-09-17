using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPanel : MonoBehaviour
{
    public GameObject panel;

    public GameObject cardsdistribute;

    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 7f)
        {
            panel.SetActive(true);
            //startcardDistribution();
            Destroy(gameObject); 
        }
    }

    //public void startcardDistribution()
    //{
    //    if(!cardsdistribute.activeInHierarchy)
    //    {
    //        cardsdistribute.SetActive(true);
    //    }
    //}
}
