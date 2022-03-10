using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text _score;

    public static int _goal;

    private void Update()
    {
        _score.text=""+ _goal;
    }

}
