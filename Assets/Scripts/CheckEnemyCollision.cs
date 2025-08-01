using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Destroy(collision.gameObject);
            Debug.Log("Chamando o gameOver");
            gameManager.GameOver();
        }
        else
        {
            GameObject parentGameObject = this.transform.parent.gameObject;
            parentGameObject.GetComponent<EnemyMovement>().ChangeMovementDirection();
        }
        
    }
}
