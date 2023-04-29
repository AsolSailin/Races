using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private GameObject _player;

    void Start()
    {
        _button.onClick.AddListener(Click);
    }

    private void Click()
    {
        _button.gameObject.SetActive(false);
        _player.SetActive(true);
    }
}
