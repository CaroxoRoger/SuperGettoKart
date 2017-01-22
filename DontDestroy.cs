using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	// vai ser chamado antes do start
	void awake () {
        DontDestroyOnLoad (transform.gameObject);
	}
}
