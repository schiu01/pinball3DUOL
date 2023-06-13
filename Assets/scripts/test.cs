using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text text;

    [SerializeField]
    private TextMeshPro tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        tmp.SetText("testing");

        
    }
}
