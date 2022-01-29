using UnityEngine;

[RequireComponent(typeof(MeshFilter))] 
public class Cube : MonoBehaviour {
    
    private Mesh mesh;
    private Vector3[] verticies;
    private int[] triangles;
    
    // Start is called before the first frame update
    void Start(){
        mesh = new Mesh();
        GetComponent <MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
    }

    void UpdateMesh(){
        mesh.Clear();
        mesh.vertices = verticies;
        mesh.triangles = triangles;
        
        mesh.RecalculateNormals();
    }

    void CreateShape(){
        verticies = new Vector3[]{
            new Vector3 (0, 0, 0),
            new Vector3 (1, 0, 0),
            new Vector3 (1, 1, 0),
            new Vector3 (0, 1, 0),
            new Vector3 (0, 1, 1),
            new Vector3 (1, 1, 1),
            new Vector3 (1, 0, 1),
            new Vector3 (0, 0, 1),
        };

        triangles = new int[]{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
