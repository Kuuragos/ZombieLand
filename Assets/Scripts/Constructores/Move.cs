using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 5;
    float eje_X;
    private Rigidbody mover;
    private bool canJump;

    void Start()
    {
        int n= Random.Range(4, 10);
        mover = GetComponent<Rigidbody>();
        for (int i = 0; i < n; i++)
        {
            int s = Random.Range(0, 2);
            if (s==0)
            {
                Zombie zom = new Zombie(0, 10);
            }
            else
            {
                Citizen ciu = new Citizen();
            }
            
        }
        
    }

    private void FixedUpdate()
    {
        if (canJump)
        {
            canJump = false;
            mover.AddForce(0, 5, 0, ForceMode.Impulse);
        }

    }

    void Update()
    {
        eje_X += Input.GetAxis("Mouse X");

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            canJump = true;
        }
        transform.eulerAngles = new Vector3(0, eje_X, 0);

    }
    public class Zombie
    {
         string nombre;
         int cerebros;
         int golpe;
        int color = Random.Range(1, 4);

        public Zombie(int cerebros, int golpe)
        {
            GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Mobs.transform.position = v;

            
            this.golpe = golpe;
            this.cerebros = cerebros;
            string colorFinal="";
            switch (color)
            {
                case 1:
                    Mobs.GetComponent<Renderer>().material.color = Color.cyan;
                    colorFinal = "cyan";
                    break;
                case 2:
                    Mobs.GetComponent<Renderer>().material.color = Color.green;
                    colorFinal = "green";
                    break;
                case 3:
                    Mobs.GetComponent<Renderer>().material.color = Color.magenta;
                    colorFinal = "magenta";
                    break;
            }
            Debug.Log(soyZ(colorFinal));

        }
        string soyZ(string color)
        {
            return "Soy un zombie de color " + color;
        }
    }
    public class Citizen
    {
        public Citizen()
        {
            GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Mobs.transform.position = v;
            
            Debug.Log(Nombre());
        }
        string Nombre()
        {
            string[] names = new string[20];
            int nom = Random.Range(0, 20);
            int age = Random.Range(15, 101);
            names[0] = "Aydan";
            names[1] = "Chindler";
            names[2] = "Tann";
            names[3] = "Erock";
            names[4] = "Aerav";
            names[5] = "Daviron";
            names[6] = "Leviye";
            names[7] = "Tobis";
            names[8] = "Patrock";
            names[9] = "Abbrahan";
            names[10] = "Alaysia";
            names[11] = "Reegan";
            names[12] = "Catlea";
            names[13] = "Emiliye";
            names[14] = "Emilyse";
            names[15] = "Charleagh";
            names[16] = "Claissa";
            names[17] = "Belenne";
            names[18] = "Aebby";
            names[19] = "Allany";
            return "hola soy " + names[nom] + " y tengo " + age + " años";
        }
    }
}
