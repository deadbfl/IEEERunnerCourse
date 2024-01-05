using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetect : MonoBehaviour
{
    [SerializeField] private PlayerHealth health;

    private void Awake()
    {
        health = GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
            //can azaltm
            health.ChangeHealth(-1);
            ScoreManager.instance.ChangeScore(-15);
            Destroy(other.gameObject);
        }

        if(other.CompareTag("FinishLine"))
        {
            FinishManager.instance.SetFinishPanel();
            GetComponent<PlayerMovement>().isGameFinish = true;
        }
    }
}
