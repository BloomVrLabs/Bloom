using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsScript : MonoBehaviour {

    bool IsOpen = false;
    private Animator _animator;
	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}
    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Player") && (IsOpen == false))
        {
            _animator.SetBool("open", true);
            IsOpen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((other.tag == "Player") && (IsOpen == true))
        {
            _animator.SetBool("open", false);
            IsOpen = false;
        }
    }

}
