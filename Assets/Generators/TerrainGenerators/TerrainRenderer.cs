using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PHDGame;

public class TerrainRenderer : MonoBehaviour {

	//mesh info
	public Vector3[] newVertices = new Vector3[3];
	public Vector2[] newUV = new Vector2[3];
	public int[] newTriangles = {0,1,2};
	private int textureHeight = 32;
	private int textureWidth = 32;

	public TerrainUnit t = new TerrainUnit();

	void Start() {
		Vector3 v1 = new Vector3 (0, 0, 0);
		Vector3 v2 = new Vector3 (0, 1, 0);
		Vector3 v3 = new Vector3 (1, 1, 0);
		newVertices [0] = v1;
		newVertices [1] = v2;
		newVertices [2] = v3;
		Vector2 u1 = new Vector2 (0, 0);
		Vector2 u2 = new Vector2 (0, 1);
		Vector2 u3 = new Vector2 (1, 1);
		newUV [0] = u1;
		newUV [1] = u1;
		newUV [2] = u1;	

		Mesh mesh = new Mesh ();
		GetComponent<MeshFilter> ().mesh = mesh;
		mesh.vertices = newVertices;
		mesh.uv = newUV;
		mesh.triangles = newTriangles;
		Texture2D t = new Texture2D (32, 32, TextureFormat.ARGB32, false);

		for (int i = 0; i < textureWidth; i++) {
			for (int j = 0; j < textureHeight / 2; j += 2) {
				if (i % 2 == 0) {
					t.SetPixel (i, j, Color.red);
					t.SetPixel (i, j + 1, Color.black);
				} else {
					t.SetPixel (i, j, Color.black);
					t.SetPixel (i, j + 1, Color.red);
				}
			}
		}

		t.filterMode = FilterMode.Point;
		t.Apply ();
		GetComponent<Renderer> ().material.mainTexture = t;
	}       
	// Update is called once per frame
	void Update () {
		
	}
}
