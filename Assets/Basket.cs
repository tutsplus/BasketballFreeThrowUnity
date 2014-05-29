using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour
{
    public GameObject score;
    public AudioClip basket;

    void OnCollisionEnter()
    {
        audio.Play();
    }

    void OnTriggerEnter()
    {
        int currentScore = int.Parse(score.GetComponent<GUIText>().text) + 1;
        score.GetComponent<GUIText>().text = currentScore.ToString();
        AudioSource.PlayClipAtPoint(basket, transform.position);
    }
}