using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



/**************************************

    ����̓x�b�h�ɐG�ꂽ��ԂŃG���^�[�ŃN���A
    �{���͎q���ɐG�ꂽ��ԂŃG���^�[�ŃN���A�ɕύX����K�v������
    �X�N���v�g�̃A�^�b�`���x�b�h����q���ɕύX���邱�ƂőΉ��\

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
