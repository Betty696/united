using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSenes : MonoBehaviour {

    public SceneObject m_nextScene;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SceneManager.LoadScene(m_nextScene);
    }
}
