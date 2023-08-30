using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRespaw : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject npc;
    private float largura;
    private float altura;

    void Start()
    {
        altura = Camera.main.orthographicSize;
        largura = Camera.main.orthographicSize * Camera.main.aspect;

        InvokeRepeating("respawn", 0, 2);
    }

    void respawn()
    {
        float x = Random.Range(-largura, largura);
        Vector2 pos = new Vector2(x, altura + 2);
        Instantiate(npc, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
