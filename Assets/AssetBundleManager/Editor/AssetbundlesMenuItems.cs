﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace AssetBundles
{
	public class AssetBundlesMenuItems
	{
		const string kSimulationMode = "AssetBundles/Simulation Mode";
	
		[MenuItem(kSimulationMode)]
		public static void ToggleSimulationMode ()
		{
			AssetBundleManager.SimulateAssetBundleInEditor = !AssetBundleManager.SimulateAssetBundleInEditor;
		}
	
		[MenuItem(kSimulationMode, true)]
		public static bool ToggleSimulationModeValidate ()
		{
			Menu.SetChecked(kSimulationMode, AssetBundleManager.SimulateAssetBundleInEditor);
			return true;
		}
		
		[MenuItem ("AssetBundles/Build AssetBundles")]
		static public void BuildAssetBundles ()
		{
			BuildScript.BuildAssetBundles();
		}
	}
}