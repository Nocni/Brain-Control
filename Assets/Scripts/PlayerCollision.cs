using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GameObject scoreText;
    public int score;
    public Player_Movement movement;

    void Start() {
        score = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
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
