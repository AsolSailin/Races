using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartBtn : MonoBehaviour
{
    [SerializeField]
    private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(Click);
    }

    private void Click()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
