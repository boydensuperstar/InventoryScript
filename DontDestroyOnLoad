using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static int SameScene;
    public static string SceneNames;
    public static Inventory instance; 
  
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't Destroy on Load " + gameObject.name);
    }

    public void Start()
    {

        SameScene = SceneManager.GetActiveScene().buildIndex;

        int ThisScene = SceneyMana.ThisScene;

        Debug.Log("ThisScene is " + ThisScene);
        Debug.Log("SameScene is " + SameScene);

        if (ThisScene == SameScene)
        {
            SceneManager.LoadScene("MainMenu");

        }
        else
        {
            SceneManager.LoadScene(ThisScene);
        }
    }

    public void Update()
    {
        SceneNames = SceneManager.GetActiveScene().name;

        if (SceneNames == "FinalScene")
        {
            Destroy(gameObject);
            instance = null; 
        }
    }

}
