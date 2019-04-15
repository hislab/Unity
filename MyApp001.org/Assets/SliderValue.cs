using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour {

	public GameObject uiText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetSliderValue() {
		Slider s = GameObject.Find ("Slider").GetComponent<Slider> ();
		Text t = GameObject.Find ("SliderValue").GetComponent<Text> ();
		t.text = "" + s.value;
	}
}
