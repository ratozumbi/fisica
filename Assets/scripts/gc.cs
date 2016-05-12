using UnityEngine;
using System.Collections;

public class gc : MonoBehaviour {

	public GameObject prefab;
	public static float gridX = 10f;
	public static float gridY = 10f;
	public static float gridZ = 10f;
	public float spacing = 2f;

	//Array List Game Objects A.L.G.O!!!!
	private Object[] algo = new Object[(int)gridX * (int)gridY * (int)gridZ]; 

	void Start() {
		botaOsCuboLa ();
	}

	public void botaOsCuboLa(){
		int i = 0;
		for (int z = 0; z < gridZ; z++) {
			for (int y = 0; y < gridY; y++) {
				for (int x = 0; x < gridX; x++) {
					//+0.5 para nao começar dentro do plano
					Vector3 pos = new Vector3 (x, z + 0.5f, y) * spacing;
					algo[i] = Instantiate (prefab, pos, Quaternion.identity);
					i++;
				}
			}
		}	
	}
	
	// Update is called once per frame
	void Update () {
			
		if (Input.GetKeyDown(KeyCode.R)) {
			foreach(Object o in algo){
				Destroy(o);
			}

			botaOsCuboLa ();
		}
	
	}
}
