using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ragdoll : MonoBehaviour {


    private Rigidbody2D _rb;

    private ParticleSystem _boost;
    private bool _boosting;
    private float _moving;

    public float Speed = 500;
    public float JetpackForce = 650;

    private AudioSource source;


    // Use this for initialization
    void Start () {
        _rb = GetComponent<Rigidbody2D>();
        _boost = transform.Find("Boost").gameObject.GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {

	        _boost.Play();
	        source.PlayOneShot(source.clip, 1);

	}

    private void FixedUpdate()
    {
        _rb.AddForce(new Vector2(1,1) * Speed);
    }
}
