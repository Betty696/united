using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



/**************************************

    現状はベッドに触れた状態でエンターでクリア
    本当は子供に触れた状態でエンターでクリアに変更する必要がある
    スクリプトのアタッチをベッドから子供に変更することで対応可能

*/

public class gameClear : MonoBehaviour {

    [SerializeField]
    SceneObject nextScene;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			SceneManager.LoadScene(nextScene);
	}
	
}
