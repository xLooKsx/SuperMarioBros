using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBlockCollision : MonoBehaviour
{

    public bool GivePoints = false;
    public int AmountOfPoints = 0;

    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GivePoints)
            {
                gameManager.AddPoints(AmountOfPoints);
            }
            
            GameObject parentGameObject = this.transform.parent.gameObject;            
            GameObject.Destroy(parentGameObject);
        }
    }
}
