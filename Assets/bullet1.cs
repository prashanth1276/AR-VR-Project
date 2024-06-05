using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    public float life = 2f;
    void Awake()
    {
        Destroy(gameObject, life);
    }
}
