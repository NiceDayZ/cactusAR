using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusBehavior : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	//
    void FixedUpdate(){
        float Dist = Vector3.Distance(Camera.main.transform.position,transform.position);
        Debug.Log(Dist);
        Debug.Log(animator.GetBool("cameraIsClose"));
        if(Dist < 5000f){
            animator.SetBool("cameraIsClose", true);
        }else{
            animator.SetBool("cameraIsClose", false);
        }
    }
}
