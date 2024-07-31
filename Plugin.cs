using BepInEx;
using System;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace Kuromi
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {

        AssetBundle bundle;

        void Start()
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Kuromi.Resources.kuromi");
            bundle = AssetBundle.LoadFromStream(stream);
            if (stream == null)
            {
                Debug.LogError("STREAM IS NULL. NOT LOADING ASSETS");
            }
            stream.Close();

            GameObject kruP = bundle.LoadAsset<GameObject>("kurP");

            GameObject kurp = Instantiate(kruP);
        }
    }
}
