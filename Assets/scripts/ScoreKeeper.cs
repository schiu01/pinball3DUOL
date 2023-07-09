using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int score = 0;
    [SerializeField]
    TextMeshProUGUI tmp;

    [SerializeField]
    TextMeshProUGUI gravity;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gravity.text = "Gravity Value: " + Physics.gravity.ToString();

        
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = score.ToString();
    }

    public void scoreAdd()
    {
        score++;
    }
        
}
