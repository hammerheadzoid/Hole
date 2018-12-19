using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlueDestroy : MonoBehaviour {

    public TMP_Text matterEatenScore;   // Show the score in game overlay
    public TMP_Text score;              // Show the size of the sphere 
    public int matterEaten = 0;
    Vector3 playerSize;                 // Record the size of player so that we know what matter it can eat. 
    public GameObject smoke;            // Smoke dropped in the inspector
    public AudioClip rockCrunch;        // Sound dropped in in the inspector
    public AudioClip treeSound;        // Sound dropped in in the inspector

    private void Start()
    {
       // AudioSource.PlayClipAtPoint(rockCrunch, transform.position);
    }

    void Update()
    {
        print("You are in the Destrpy loop");
        // This is used to update the score on the screen
        matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
        matterEatenScore.text = "Matter " + matterEaten.ToString();

        // Record the size of player so that we know what matter it can eat. 
        playerSize = GetComponent<Collider>().bounds.size;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerSize.x >= 1)
        {
            if (other.gameObject.tag == "stone")
            {
                //print("You hit stone");
                matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
                PlayerPrefs.SetInt("matterEatenBlue", matterEaten + 1);
                Instantiate(smoke, transform.position, transform.rotation);     // Smoke particle effect

                AudioSource.PlayClipAtPoint(rockCrunch, transform.position);
                Destroy(other.gameObject,1.1f);
            }

            if (other.gameObject.tag == "lvl01")
            {
                //print("You hit tree1");
                matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
                PlayerPrefs.SetInt("matterEatenBlue", matterEaten + 1);

                AudioSource.PlayClipAtPoint(treeSound, transform.position);
                Destroy(other.gameObject);
            }

            if (other.gameObject.tag == "lvl01")
            {
                //print("You hit tree1");
                matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
                PlayerPrefs.SetInt("matterEatenBlue", matterEaten + 2);

                AudioSource.PlayClipAtPoint(treeSound, transform.position);
                Destroy(other.gameObject);
            }

            if (other.gameObject.tag == "tree1")
            {
                //print("You hit tree1");
                matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
                PlayerPrefs.SetInt("matterEatenBlue", matterEaten + 2);

                AudioSource.PlayClipAtPoint(treeSound, transform.position);
                Destroy(other.gameObject);
            }
        }

        if (playerSize.x >= 1.6)
        {
            

            if (other.gameObject.tag == "fence")
            {
                //print("You hit fance");
                matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
                PlayerPrefs.SetInt("matterEatenBlue", matterEaten + 1);
                AudioSource.PlayClipAtPoint(treeSound, transform.position);
                Destroy(other.gameObject);
            }
        }

        if (playerSize.x >= 3)
        {
            if (other.gameObject.tag == "tree2")
            {
                //print("You hit tree2");
                matterEaten = PlayerPrefs.GetInt("matterEatenBlue");
                PlayerPrefs.SetInt("matterEatenBlue", matterEaten + 8);
                Destroy(other.gameObject);
            }
        }    
    }
}
