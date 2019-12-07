using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneyMana : MonoBehaviour
{
    // Start is called before the first frame update
    public static int ThisScene;
    public static string SceneNames;
    public static int ItemsCollected;

    void Awake()
    {
        ThisScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("The current scene is " + ThisScene);
    }

    private void Start()
    {
        GameObject check = GameObject.Find("__app");
        if (check == null)
        {
            SceneManager.LoadScene("_Preload");
        }

    }

    private void Update()
    {
        ThisScene = SceneManager.GetActiveScene().buildIndex;
        if (ThisScene == 0)
        {
            Cursor.visible = true;
        }
    }

    public void UnlockCursor()
    {
        if (SceneNames == "MainMenu")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (SceneNames == "FinalScene")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
