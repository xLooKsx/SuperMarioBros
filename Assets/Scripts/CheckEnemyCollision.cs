using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Object"))
        {
            GameObject parentGameObject = this.transform.parent.gameObject;
            parentGameObject.GetComponent<EnemyMovement>().ChangeMovementDirection();
        }
        else if (collision.CompareTag("Player"))
        {
            GameObject.Destroy(collision.gameObject);
        }
    }
}
