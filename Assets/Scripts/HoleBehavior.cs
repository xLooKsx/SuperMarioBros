using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Destroy(collision.gameObject);
    }
}
