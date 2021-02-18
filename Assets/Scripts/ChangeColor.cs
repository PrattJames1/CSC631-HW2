using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update

    public Material material1;
    void Start()
    {
        material1.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (material1.color == Color.red)
            {
                material1.color = Color.blue;
            }
            else
            {
                material1.color = Color.red;
            }
        }
    }
}