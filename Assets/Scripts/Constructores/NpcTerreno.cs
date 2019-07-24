using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTerreno : MonoBehaviour
{
    public GameObject[] cubos;
    void Start()
    {
        cubos = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            go.transform.position = v;
            go.name = i.ToString();
            
            cubos[i] = go;
        }

        void Update()
        {

        }
    }
}
