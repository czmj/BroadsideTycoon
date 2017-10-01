using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textureScrollController : MonoBehaviour {

    public float speed = 0.5f;
    private Vector2 offset = new Vector2(0.0f, 0.0f);
    private Renderer renderer;

	// Use this for initialization
	void Start ()
    {
        renderer = this.GetComponent<Renderer>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        offset.Set(Time.time * speed, 0.0f);
        renderer.material.mainTextureOffset = offset;
    }
}
