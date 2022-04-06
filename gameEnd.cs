using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameEnd : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI scoreText;
    public int score;
    public string scoreString;
    public Transform goal;
    public bool signal;
    void Start()
    {
        signal = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, goal.position) < 15){
            signal = true;
        }
        if(signal == false){
            score += 1;
        }
        else{
            GameObject[] alld;
            alld = GameObject.FindGameObjectsWithTag("dragon");
            for(int i = 0; i < alld.Length; i++)
            {
                Destroy(alld[i].gameObject);
            }
            GameObject[] alls;
            alls = GameObject.FindGameObjectsWithTag("spawner");
            for(int i = 0; i < alls.Length; i++)
            {
                Destroy(alls[i].gameObject);
            }
            score = score/5;
            scoreText.text = (score).ToString();
            canvas.transform.position = new Vector3(4.73f,4.5f,2.45f);
            int highScore = PlayerPrefs.GetInt("highscore");
            if (score > highScore){
                PlayerPrefs.SetInt("highscore", score);
            }


            }

        }
        
} 
