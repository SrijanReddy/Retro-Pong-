﻿using UnityEngine;
using System.Collections;

public class HelpScript : MonoBehaviour
{
	void OnMouseDown()
	{
		transform.localScale *= 0.9F;
	}

	void OnMouseUp()
	{
		Application.LoadLevel(3);
	}
}