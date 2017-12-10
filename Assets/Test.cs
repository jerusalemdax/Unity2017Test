using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssetBundles;

public class Test : MonoBehaviour {

	// Use this for initialization
    IEnumerator Start () {
        AssetBundleManager.SetSourceAssetBundleURL(Application.dataPath + "/../AssetBundles/");
        var request = AssetBundleManager.Initialize();

        if (request != null)
            yield return StartCoroutine(request);

        var scenerequest = AssetBundleManager.LoadLevelAsync("test.unity.unity3d", "Test", false);
        if (scenerequest == null)
            yield break;
        yield return StartCoroutine(scenerequest);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
