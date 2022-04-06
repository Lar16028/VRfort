using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Showhighscore : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    
    void updateScore(){
        scoretext.text = PlayerPrefs.GetInt("highscore").ToString();

    }
    void Start() {
        updateScore();
    }
}
