using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTerreno : MonoBehaviour
{

    public GameObject[] cubos;
    void Start()
    {
        int Mob = Random.Range(2, 6);
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

            switch (color)
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

    void Nombre()
    {
        string[] names = new string[20];

        names[0] = ("Aydan");
        names[1] = ("Chindler");
        names[2] = ("Tann");
        names[3] = ("Erock");
        names[4] = ("Aerav");
        names[5] = ("Daviron");
        names[6] = ("Leviye");
        names[7] = ("Tobis");
        names[8] = ("Patrock");
        names[9] = ("Abbrahan");
        names[10] = ("Alaysia");
        names[11] = ("Reegan");
        names[12] = ("Catlea");
        names[13] = ("Emiliye");
        names[14] = ("Emilyse");
        names[15] = ("Charleagh");
        names[16] = ("Claissa");
        names[17] = ("Belenne");
        names[18] = ("Aebby");
        names[19] = ("Allany");
    }
}

