using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDesolver : MonoBehaviour
{
    public GameObject cardAnimationGO;

    public GameObject panel;
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
}
