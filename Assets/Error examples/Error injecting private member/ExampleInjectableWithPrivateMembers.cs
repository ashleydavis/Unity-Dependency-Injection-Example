﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Example that has a dependency injected.
/// </summary>
public class ExampleInjectableWithPrivateMembers : MonoBehaviour
{
    [Inject(InjectFrom.Above)]
    private ExampleDependency ExampleDependencyAsProperty { get; set; }

    [Inject(InjectFrom.Above)]
    private ExampleDependency ExampleDependencyAsField;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
