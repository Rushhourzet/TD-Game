using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMeshGenerator : MonoBehaviour
{
    [SerializeField] private MeshFilter fieldMeshFilter;
    public FieldData fieldData;
    private int x;
    private int y;
    private int z;

    public void GenerateMesh() {
        x = fieldData.width;
        y = fieldData.thickness;
        z = fieldData.height;
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[]{
            new Vector3 (0, 0, 0),
            new Vector3 (x, 0, 0),
            new Vector3 (x, y, 0),
            new Vector3 (0, y, 0),
            new Vector3 (0, y, z),
            new Vector3 (x, y, z),
            new Vector3 (x, 0, z),
            new Vector3 (0, 0, z),
        };

        int[] triangles = {
            0, 2, 1, //face front
	        0, 3, 2,
            2, 3, 4, //face top
	        2, 4, 5,
            1, 2, 5, //face right
	        1, 5, 6,
            0, 7, 4, //face left
	        0, 4, 3,
            5, 4, 7, //face back
	        5, 7, 6,
            0, 6, 7, //face bottom
	        0, 1, 6
        };

        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();

        fieldMeshFilter.mesh = mesh;
    }

    public static Mesh GenerateMesh(int x, int y, int z) {
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[]{
            new Vector3 (0, 0, 0),
            new Vector3 (x, 0, 0),
            new Vector3 (x, y, 0),
            new Vector3 (0, y, 0),
            new Vector3 (0, y, z),
            new Vector3 (x, y, z),
            new Vector3 (x, 0, z),
            new Vector3 (0, 0, z),
        };

        int[] triangles = {
            0, 2, 1, //face front
	        0, 3, 2,
            2, 3, 4, //face top
	        2, 4, 5,
            1, 2, 5, //face right
	        1, 5, 6,
            0, 7, 4, //face left
	        0, 4, 3,
            5, 4, 7, //face back
	        5, 7, 6,
            0, 6, 7, //face bottom
	        0, 1, 6
        };

        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();

        return mesh;
    }
}
