using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour
{
    string playerName = "";
    // Start is called before the first frame update
    void Start()
    {
        playerName = PlayerPrefs.GetString("name");
    }

    void OnGUI(){
        GUI.Label(new Rect(5, 220, 50, 30), playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
