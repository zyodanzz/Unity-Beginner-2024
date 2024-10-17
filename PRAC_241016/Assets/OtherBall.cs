using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    /*
    private void OnCollisionEnter(Collision collision)  // collision Ãæµ¹Á¤º¸ Å¬·¡½º
    {
        mat.color = new Color(0, 0, 0);  //¹Ù´Ú°ú ´ê¾Æµµ ¹Ù²ñ
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "MyBall")
        mat.color = new Color(0, 0, 0);  //¹Ù´Ú°ú ´ê¾Æµµ ¹Ù²ñ
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
            mat.color = new Color(1, 1, 1);  //¹Ù´Ú°ú ´ê¾Æµµ ¹Ù²ñ
    }

    

}
