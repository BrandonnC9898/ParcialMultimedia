using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ControlAnimaciones : MonoBehaviour
{
	public float velocidadDesplazamiento = 3.0f;
	public float velocidadRotacion = 200.0f;
	public float x;
	public float y;
	private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		x = Input.GetAxis("Horizontal");
		y = Input.GetAxis("Vertical");
		
		transform.Rotate(0, x*Time.deltaTime*velocidadRotacion, 0);
		transform.Translate(0, 0, y*Time.deltaTime*velocidadDesplazamiento);
		
		animator.SetFloat("VelX", x);
		animator.SetFloat("VelY", y);
		
		if(Input.GetKey(KeyCode.Space)){
			animator.SetTrigger("Saltar");
		}else if(Input.GetKey(KeyCode.K)){
			animator.SetTrigger("Patear");
		}else if(Input.GetKey(KeyCode.J)){
			animator.SetTrigger("Golpear");
		}
    }
}
