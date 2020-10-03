using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gradient : MonoBehaviour
{
    public Color colorTop = Color.white;
    public Color colorBottom = Color.black;
    void Update() {
        MeshFilter thisMeshFilter = GetComponent<MeshFilter>();
        thisMeshFilter.mesh.colors = new Color[] { colorTop, colorTop, colorBottom, colorBottom };
    }

}
