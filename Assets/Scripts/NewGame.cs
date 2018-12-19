using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewGame : MonoBehaviour {

    public TMP_Text matterEatenScore;   // Show the score in game overlay
    private int matterEaten;            // This is taken from the playerpref

    // Use this for initialization
    void Start () {

        print("This is the first thing to come up.");

        // New game so matter score is set to 0
        PlayerPrefs.DeleteAll();

        PlayerPrefs.SetInt("matterEaten", 0);
        matterEaten = PlayerPrefs.GetInt("matterEaten");
        matterEatenScore.text = "Matter " + matterEaten.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
