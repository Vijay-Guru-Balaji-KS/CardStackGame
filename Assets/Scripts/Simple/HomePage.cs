using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject testing;

    SceneManager SceneManager;

    private int screenheight;
    private int screenwidth;
    private void Awake()
    {
        screenheight = Screen.currentResolution.height;
        screenwidth = Screen.currentResolution.width;
    }
    void Start()
    {
        Debug.Log(screenheight);
        testing.transform.position = new Vector2(screenwidth / 2, screenheight / 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPressed(string loadSceneName)
    {
        Debug.Log("button Pressed");
        SceneManager.LoadScene(loadSceneName);
    }
}
