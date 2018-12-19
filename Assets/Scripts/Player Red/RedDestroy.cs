using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedDestroy : MonoBehaviour {

    public TMP_Text matterEatenScore;   // Show the score in game overlay
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
        matterEaten = PlayerPrefs.GetInt("matterEatenRed");
        matterEatenScore.text = "Matter " + matterEaten.ToString();

        // Record the size of player so that we know what matter it can eat. 
        playerSize = GetComponent<Collider>().bounds.size;
    }

    /*IEnumerator WaitToPlaySound()
    {
        print("In");
        yield return new WaitForSeconds(5);
        print("Out");
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (playerSize.x >= 1)
        {
            if (other.gameObject.tag == "stone")
            {
                //print("You hit stone");
                matterEaten = PlayerPrefs.GetInt("matterEatenRed");
                PlayerPrefs.SetInt("matterEatenRed", matterEaten + 1);
                Instantiate(smoke, transform.position, transform.rotation);     // Smoke particle effect

                AudioSource.PlayClipAtPoint(rockCrunch, transform.position);
                //AudioSource rockCrunch = GetComponent<AudioSource>();
                //rockCrunch.Play();


                //AudioSource.PlayClipAtPoint(rockCrunch, transform.position);
                //StartCoroutine(WaitToPlaySound());

                Destroy(other.gameObject,1.1f);
            }

            if (other.gameObject.tag == "tree1")
            {
                //print("You hit tree1");
                matterEaten = PlayerPrefs.GetInt("matterEatenRed");
                PlayerPrefs.SetInt("matterEatenRed", matterEaten + 2);

                AudioSource.PlayClipAtPoint(treeSound, transform.position);
                Destroy(other.gameObject);
            }
        }

        if (playerSize.x >= 1.6)
        {
            

            if (other.gameObject.tag == "fence")
            {
                //print("You hit fance");
                matterEaten = PlayerPrefs.GetInt("matterEatenRed");
                PlayerPrefs.SetInt("matterEatenRed", matterEaten + 1);
                AudioSource.PlayClipAtPoint(treeSound, transform.position);
                Destroy(other.gameObject);
            }
        }

        if (playerSize.x >= 3)
        {
            if (other.gameObject.tag == "tree2")
            {
                //print("You hit tree2");
                matterEaten = PlayerPrefs.GetInt("matterEatenRed");
                PlayerPrefs.SetInt("matterEatenRed", matterEaten + 8);
                Destroy(other.gameObject);
            }
        }    
    }
}
