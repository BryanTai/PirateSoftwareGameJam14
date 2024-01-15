using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyleftmove = this.transform.position;
        enemyleftmove.x -= speed;
        this.transform.position = enemyleftmove;

    }
}
