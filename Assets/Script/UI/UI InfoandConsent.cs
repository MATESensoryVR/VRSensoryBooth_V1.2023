using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInfoandConsent : MonoBehaviour
{
    [SerializeField] Button _Button;

    void Start()
    {
        _Button.onClick.AddListener(StartButton);
    }

    private void StartButton()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Booth1);
    }
}