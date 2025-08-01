using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject parentGameObject = this.transform.parent.gameObject;
            GameObject.Destroy(parentGameObject);
        }
    }
}
