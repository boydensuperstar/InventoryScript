using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneReturn : MonoBehaviour
{
    // on hitting play game it will load the next scene in the build.  If the lobby is not the next scene, it will load whatever scene is after the main menu
    public static int ThisScene;
    public static GameObject AllGameObjects;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void Start()
    {
            SceneyMana.ThisScene = 0;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
        DestroyAllGameObjects();
    }

    // on hitting quit, it will quit the game
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void DestroyAllGameObjects()
    {
        GameObject[] AllGameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);

        for (int i = 0; i < AllGameObjects.Length; i++)
        {
            Destroy(AllGameObjects[i]);
        }
    }

}
