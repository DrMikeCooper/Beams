using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamTester : MonoBehaviour {

    public BeamRenderer beamRenderer;
    public Transform target;
    public Material material;
    public Color color = Color.white;
    public BeamParticles particles;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            beamRenderer.Activate(transform, target, 2.0f, material, 0.5f, color, particles);
            beamRenderer.uvSpeed = 20;
        }

	}
}
