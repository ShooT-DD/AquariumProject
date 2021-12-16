using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFish : MonoBehaviour
{
    public float fishSpeed = 1.0f;
    public float radius = 2.5f;
    public float angle = 0;
    public Transform player;

    void Start()
    {
        
    }

    void Update()
    {
        angle += Time.deltaTime;

        var x = Mathf.Cos(angle * fishSpeed) * radius;
        var z = Mathf.Sin(angle * fishSpeed) * radius;
        transform.position = new Vector3(x, 1, z) + player.position;

        Vector3 relativePos = player.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;
    }
}
