﻿using UnityEngine;
using System.Collections;

public class RemoveBuildings : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "destroy")
        {
            Destroy(this.gameObject);
        }
    }
}
