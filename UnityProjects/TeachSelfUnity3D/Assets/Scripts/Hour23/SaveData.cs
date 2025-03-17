using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public string playerName= "";

    void OnGUI(){
        playerName = GUI.TextField(new Rect(5,120,100,30),playerName);

        if(GUI.Button(new Rect(5,180,50,50), "Save")){
            PlayerPrefs.SetString("name", playerName);
        }
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
