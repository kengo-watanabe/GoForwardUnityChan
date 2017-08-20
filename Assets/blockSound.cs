using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSound : MonoBehaviour {
    //アニメーションするためのコンポーネントを入れる
    Animator animator;

    //地面の位置
    private float groundLevel = -3.0f;

	// Use this for initialization
	void Start () {

       
		
	}
	
	// Update is called once per frame
	void Update () {
        //着地しているかどうか調べる
        bool isGround = (transform.position.y < this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        //設置しているときに、ボリュームを出す
        GetComponent<AudioSource>().volume = (isGround) ? 0 : 1;

    }
}
