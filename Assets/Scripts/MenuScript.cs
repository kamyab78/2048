using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[DefaultExecutionOrder(-1)]

public class MenuScript : MonoBehaviour
{   
    public static MenuScript Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI hiscoreText;

    // Start is called before the first frame update
    void Start()
    {
        hiscoreText.text = LoadHiscore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int LoadHiscore()
    {
        return PlayerPrefs.GetInt("hiscore", 0);
    }
}
