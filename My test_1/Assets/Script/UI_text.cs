using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UI_text : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public string nextText = "¹Ù²î³ª¿ä?";

    OnButtonClick OnButtonClick;

    
    public void OnClickButton()
    {
        Debug.Log("gg");
        txt.text = nextText;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
