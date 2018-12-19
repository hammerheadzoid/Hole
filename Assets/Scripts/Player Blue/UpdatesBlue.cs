using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdatesBlue : MonoBehaviour {

    public GameObject sphere;           // Player
    public TMP_Text matterEatenScore;   // Show the score in game overlay
    private int matterEaten;            // This is taken from the playerpref that is updated in destroy.cs
    private Vector3 temp;               // temp is used to enable scaling up of sphere
    private int checkonce=0;            // This will be set to true every time score increases

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print("Updates loop");

        // This is used to update the score on the screen
        matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
        matterEatenScore.text = "Matter " + matterEaten.ToString();
             
        if (matterEaten > 0 && matterEaten < 7)
        {
            if (checkonce == 0)
            {
                temp = transform.localScale;
                    
                temp.x += .5f;
                temp.y += .5f;
                temp.z += .5f;

                transform.localScale = temp;

                checkonce = 1;
                print("0 to 7 range");
            }

        }

        if (matterEaten >= 7 && matterEaten < 14)
        {
            if (checkonce == 1)
            {
                temp = transform.localScale;
                    
                temp.x += .5f;
                temp.y += .5f;
                temp.z += .5f;

                transform.localScale = temp;

                checkonce = 2;
                print("7 to 14 range");
            }
        }

        if (matterEaten >= 14 && matterEaten < 30)
        {
            if (checkonce == 2)
            {
                temp = transform.localScale;

                temp.x += .5f;
                temp.y += .5f;
                temp.z += .5f;

                transform.localScale = temp;

                checkonce = 3;
                print("14 to 30 range");
            }
        }

        if (matterEaten >= 30 && matterEaten < 50)
        {
            if (checkonce == 3)
            {
                temp = transform.localScale;

                temp.x += .5f;
                temp.y += .5f;
                temp.z += .5f;

                transform.localScale = temp;

                checkonce = 4;
                print("30 to 50 range");
            }
        }

        if (matterEaten >= 50 && matterEaten < 100)
        {
            if (checkonce == 4)
            {
                temp = transform.localScale;

                temp.x += 1.5f;
                temp.y += 1.5f;
                temp.z += 1.5f;

                transform.localScale = temp;

                checkonce = 5;
                print("50 to 100 range");
            }
        }

        if (matterEaten >= 100 && matterEaten < 150)
        {
            if (checkonce == 5)
            {
                temp = transform.localScale;

                temp.x += 1.5f;
                temp.y += 1.5f;
                temp.z += 1.5f;

                transform.localScale = temp;

                checkonce = 6;
                print("100 to 150 range");
            }
        }
    }  
}


/*

How to Find Size of Game Object in Unity 3D
https://www.youtube.com/watch?v=W-p0LFqJY_0

19. Unity Scaling GameObjects and Changing Size - Unity C# Scripting Tutorial
    https://www.youtube.com/watch?v=e7I315b74HY
    */

