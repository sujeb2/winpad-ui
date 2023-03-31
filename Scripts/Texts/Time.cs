using UnityEngine;
using System;
using TMPro;

public class Time : MonoBehaviour {

    public TMP_Text time_text;
    
    void Update() {
        DateTime now = DateTime.Now;
        time_text.text = now.ToString("HH:mm");
    }

}