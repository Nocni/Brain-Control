using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LSL4Unity.Samples.SimpleInlet;

public class PlayerCollision : MonoBehaviour
{
    public GameObject scoreText;
    public int score;
    public SimpleInletScaleObject movement;


    void Start() {
        score = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            score++;
            scoreText.GetComponent<Text>().text = score.ToString();
            other.gameObject.SetActive(false);
        }
    }
}
