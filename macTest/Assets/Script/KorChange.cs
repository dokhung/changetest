using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KorChange : MonoBehaviour
{
    public Button btn;

    public Text KorChangefun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KorChangeText()
    {
        KorChangefun.text = "한글이다 시발";
    }
}
