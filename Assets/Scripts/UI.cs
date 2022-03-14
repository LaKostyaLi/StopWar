using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _panel;
    
    public void OnButtonClick()
    {
        _button.SetActive(false);
        _panel.SetActive(false);
    }

    
    
}
