using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public static bool IsPlayerDead = false;
    private Text Gameover;

	// Use this for initialization
	void Start () {
        Gameover = GetComponent<Text>();
        Gameover.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (IsPlayerDead)
        {
            Time.timeScale = 0;
            Gameover.enabled = true;
        }
		
	}
}
