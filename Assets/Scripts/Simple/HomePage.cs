using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    // Start is called before the first frame update

    SceneManager SceneManager;
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
        SceneManager.LoadScene("Options Page");
    }
}
