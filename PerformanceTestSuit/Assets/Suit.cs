using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class Suit : MonoBehaviour
{
	CustomSampler _samplerTC1 = CustomSampler.Create("TC1");
	CustomSampler _samplerTC2 = CustomSampler.Create("TC2");

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		_samplerTC1.Begin();
		for (var i = 0; i < 10000; ++i)
		{
			var s = string.Empty;
		}
		_samplerTC1.End();

		_samplerTC2.Begin();
		for (var i = 0; i < 10000; ++i)
		{
			var s = string.Empty;
		}
		_samplerTC2.End();
	}
}
