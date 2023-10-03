using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public GameObject Sphere;
    public Text x;
    public float Speed = 10f;
    public int SMTH = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 10 * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 10 * Speed * Time.deltaTime);
        }

    }
    public void Button()
    {
        if (SMTH == 1)
        {
            SMTH = 0;
            var renderer = this.gameObject.GetComponent<Renderer>();
            renderer.material.shader = Shader.Find("Transparent/Diffuse");
            renderer.material.color = Color.white * 0.25f;
            Speed = 0f;
        }
        else if (SMTH == 0)
        {
            SMTH = 1;
            var renderer = this.gameObject.GetComponent<Renderer>();
            renderer.material.shader = Shader.Find("Transparent/Diffuse");
            renderer.material.color = Color.white * 1.0f;
            Speed = 10f;
        }

    }
}
