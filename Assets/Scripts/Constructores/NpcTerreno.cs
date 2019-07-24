using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTerreno : MonoBehaviour
{
    public GameObject[] cubos;
    void Start()
    {
        int Mob=Random.Range(2,6);
        int Zombie = Random.Range(3, 6);
        for (int i = 0; i < Mob; i++)
        {
            GameObject Npc = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Npc.transform.position = v;
            Npc.name = i.ToString();
        }

        for (int i = 0; i < Zombie; i++)
        {
            int color = Random.Range(1, 4);
            GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Mobs.transform.position = v;

            switch(color)
            {
                case 1:
                    Mobs.GetComponent<Renderer>().material.color = Color.cyan;
                    break;
                case 2:
                    Mobs.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 3:
                    Mobs.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
            }
        }
    }
    void Update()
    {

    }
}
