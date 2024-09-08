using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    public Button button;
    public string nextSceneName;
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    private void OnButtonClick()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
