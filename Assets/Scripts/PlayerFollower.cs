using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {

        if (!target.IsDestroyed())
        {
            this.transform.position = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);    
        }
        
    }
}
