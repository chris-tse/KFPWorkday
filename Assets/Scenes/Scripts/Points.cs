using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text scoreCounter;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = GetComponent<Text>();
    }

    public void Increment()
    {
        score += 100;
        scoreCounter.text = score.ToString();
    }
}
