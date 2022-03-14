using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text _score;
    [SerializeField] GameObject _winScreen;

    public static int _goal;

    private void Update()
    {
        _score.text=""+ _goal;
    }

    void Goal()
    {
        if(_goal==20)
        {
            _winScreen.SetActive(true);
        }
    }
        
}
