using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SiteHandler : MonoBehaviour, IVirtualButtonEventHandler {


	void IVirtualButtonEventHandler.OnButtonPressed (VirtualButtonBehaviour vb)
	{
	}

	void IVirtualButtonEventHandler.OnButtonReleased (VirtualButtonBehaviour vb)
	{
		Debug.Log ("Pressed");
	}

	VirtualButtonBehaviour[] virtualButtonBehaviours;

	void Start()
	{
		virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < virtualButtonBehaviours.Length; ++i)
		{
			virtualButtonBehaviours[i].RegisterEventHandler(this);
		}
	}

	void Update () {

	}
}
