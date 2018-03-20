using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowHeritage : MonoBehaviour {

	Button b;

	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener(() => clicked());
	}
	
	void Update () {
		
	}

	void clicked(){
		SceneManager.LoadScene("second", LoadSceneMode.Single);
	}
}
