using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Will give you a "Generate" Button to generate the CubeMesh from the Cubemesh-Editor in the Editor
/// </summary>
[CustomEditor (typeof(CubeMeshGenerator))]
public class CubeMeshGeneratorEditor : Editor
{
    public override void OnInspectorGUI() {
        CubeMeshGenerator cubeMGen = (CubeMeshGenerator)target;

        DrawDefaultInspector();
        if(GUILayout.Button("Generate")) {
            cubeMGen.GenerateMesh();
        }
    }
}
