using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSW : MonoBehaviour
{

    private Rigidbody2D rbd;
    public float speed;
    public float verticalSpeed;

    private float altura;
    private float largura;
    private float altXW;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent <Rigidbody2D>();
        speed = 20;
        verticalSpeed = 20;
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        altXW = sr.bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x,y) * speed;

        if(this.transform.position.x > largura){
            transform.position = new Vector2(-largura, this.transform.position.y);
        }else if(this.transform.position.x < -largura){
            transform.position = new Vector2(largura, this.transform.position.y);
        }

        if (this.transform.position.y > 0)
        {
            transform.position = new Vector2(this.transform.position.x, 0);
        }
        else if (this.transform.position.y < -altura + altXW)
        {
            transform.position = new Vector2(this.transform.position.x, -altura + altXW);
        }
    }
}
