using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class MeteorCollisionDetector : MonoBehaviour
{
    
    public Score scoreData;
    public int scoreValue = 10;
    public int dmg = 10;
    public GameObject explosionPrefab;
    private HandController handController;
    public AudioSource audioSource; 
    
    
    
    private void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.CompareTag("Hand"))
        {
            audioSource.Play();
            handController = col.gameObject.GetComponent<HandController>();
        }
        else if (col.gameObject.CompareTag("Wall"))
        {
            Debug.Log("wall collider");
            PlayerHealth playerHealth = col.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(dmg);
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider col)
    {
        
        if (col.gameObject.CompareTag("Hand") && handController != null && handController.fistValue == 1)
        {
            Debug.Log("hand kill");
            Debug.Log(gameObject.name);
            scoreData.AddScore(scoreValue);
            Debug.Log("Meteor Zerstört: " + scoreData.score);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Hand"))
        {
            handController = null;
        }
    }
}