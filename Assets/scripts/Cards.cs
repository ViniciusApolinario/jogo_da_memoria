using UnityEngine;
using System.Collections;

public class Cards : MonoBehaviour {

	public GameObject cartas, canvas;
	public Transform posiçao;
	public static GameObject[] linha;
	public static GameObject[] par;
	public static int[] teams;

	private int numbercards = 0;
	private int t;
	//public static int ue;
	// Use this for initialization
	void Start () {
		linha = new GameObject[6];

		for (numbercards = 0; numbercards < 6; numbercards++) {
			linha[numbercards] = Instantiate (cartas) as GameObject;
			posiçao.transform.position = new Vector3(posiçao.transform.position.x + numbercards + 100 , posiçao.transform.position.y , transform.position.z); 
			linha[numbercards].transform.SetParent (canvas.transform);
			linha[numbercards].transform.localPosition = posiçao.transform.position;
			linha[numbercards].transform.rotation = Quaternion.identity;
			linha[numbercards].name = numbercards.ToString();
		}

		teams = new int[3];
		teams[0] = Random.Range (0, 6);
		teams[1] = Random.Range (0, 6);
		teams[2] = Random.Range (0, 6);
		if (teams[0] == teams[1] || teams[1] == teams[2] || teams[0] == teams[2]) {
			teams[0] = Random.Range (0, 6);
			teams[1] = Random.Range (0, 6);
			teams[2] = Random.Range (0, 6);
		}
		Debug.Log (teams[0]);
		Debug.Log (teams[1]);
		Debug.Log (teams[2]);

	}

	// Update is called once per frame
	void Update () {

	}
}
