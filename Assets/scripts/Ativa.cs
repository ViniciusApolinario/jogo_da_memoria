using UnityEngine;
using System.Collections;

public class Ativa : MonoBehaviour {

	public bool ativada = false;

	public void lol(){
		ativada = true;
		if(ativada){
			ativada = false;
		}
	}
}
