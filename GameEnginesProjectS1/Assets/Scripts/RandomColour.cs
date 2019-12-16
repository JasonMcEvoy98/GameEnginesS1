using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    public Color[] ColorBank;
    public bool mesh;
    public bool sprite;

   
    void Start()
    {
        int Num = Random.Range(0, ColorBank.Length);
        if (mesh)
        {
            MeshRenderer m = GetComponent<MeshRenderer>();
            m.material.color = ColorBank[Num];
        }
        if (sprite)
        {
            SpriteRenderer s = GetComponent<SpriteRenderer>();
            s.material.color = ColorBank[Num];
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            int Num = Random.Range(0, ColorBank.Length);
            if (mesh)
            {
                MeshRenderer m = GetComponent<MeshRenderer>();
                m.material.color = ColorBank[Num];
            }
            if (sprite)
            {
                SpriteRenderer s = GetComponent<SpriteRenderer>();
                s.material.color = ColorBank[Num];
            }
        }
    }
}
