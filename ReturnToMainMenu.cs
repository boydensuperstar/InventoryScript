using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    public static int ThisScene;

    private void Start()
    {
        SceneyMana.ThisScene = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
            DestroyAllGameObjects();
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(0);
            DestroyAllGameObjects();
        }
    }

    public void DestroyAllGameObjects()
    {
        GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);

        for (int i = 0; i < GameObjects.Length; i++)
        {
            Destroy(GameObjects[i]);
        }
    }
}
