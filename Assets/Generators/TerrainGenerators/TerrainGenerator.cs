using UnityEngine;
using System.Collections;
using PHDGame;

public class TerrainGenerator : MonoBehaviour {

	private TerrainUnit[,,] map;
	private TerrainRenderer[,,] mapMesh;
	public int MAP_X;
	public int MAP_Y;
	public int MAP_Z;
	public int SEA_LEVEL;
	public TerrainRenderer tr;

	void Start() {
		map = new TerrainUnit[MAP_X, MAP_Y, MAP_Z];
		for (int x = 0; x < MAP_X; x++) {
			for (int y = 0; y < MAP_Y; y++) {
				for (int z = 0; z < MAP_Z; z++) {
					TerrainUnit t = new TerrainUnit ();
					t.ID = x.ToString () + y.ToString () + z.ToString ();
					if (z <= SEA_LEVEL) {
						string[] tempC = { "Si", "Fe", "C-", "Au" };
						t.Composition = tempC;
						float[] tempCP = { 91.00f, 3.00f, 3.00f, 3.00f };
						t.CompositionPercentages = tempCP;
					}
					map [x, y, z] = t;

					Instantiate(tr, new Vector3(x, y, z), Quaternion.identity);
				}
			}
		}


		Debug.Log ("Generated: " + Time.realtimeSinceStartup);
    }       

	// Update is called once per frame
	void Update () {
	
	}
}
