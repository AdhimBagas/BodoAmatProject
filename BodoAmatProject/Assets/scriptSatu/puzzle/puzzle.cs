using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour {
	private void OnMouseDown()
	{
		if (!controlpuzzle.youWin)
			transform.Rotate (0f, 0f, 90f);

	}
}
