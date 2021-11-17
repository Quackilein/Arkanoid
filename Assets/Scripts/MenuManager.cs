using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        //Debug.Log("huhu");
        string username = GameObject.Find("Username-Input").GetComponent<TMPro.TextMeshProUGUI>().text;
        StoreValueManager.Instance.currentUser = username;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        //Debug.Log("huhu2");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

}
