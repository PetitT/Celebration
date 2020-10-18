using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Vector2 direction;

    private void Update()
    {
        gameObject.transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
