using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{

    #region Singleton

    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public static int ItemsCollected;
    public int TotalItemCount;
    public static GameObject AllGameObjects;


    public int space = 20;

    public List<Item> items = new List<Item>();

    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not Enough Room.");
                return false;
            }
            items.Add(item);
            ItemsCollected = ItemsCollected + 1;
            Debug.Log("Items Collected = " + ItemsCollected);

            if (ItemsCollected >= TotalItemCount)
            {
                SceneManager.LoadScene("FinalScene");
                Debug.Log("Loading Final Scene");
                AllGameObjects.GetComponent<WinSceneReturn>().DestroyAllGameObjects();
                
            }

            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }

        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }


}
