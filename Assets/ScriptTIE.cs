using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTIE : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public float speed;

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0;
        float y = -1;

        rbd.velocity = new Vector2(x, y) * speed;

        if (transform.position.y < - Camera.main.orthographicSize - 1)
        {
            Destroy(this.gameObject);
        }

        
    }
}
