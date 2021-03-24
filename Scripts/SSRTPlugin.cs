// Stationeers.Addons (c) 2018-2020 Damian 'Erdroy' Korczowski & Contributors

using Stationeers.Addons;
using UnityEngine;

namespace SSRTPlugin.Scripts
{
    public class SSRTPlugin : IPlugin
    {
        public void OnLoad()
        {
            Debug.Log("SSRT: Hello, World!");
            var gameObject = new GameObject("SSRT");
            Object.DontDestroyOnLoad(gameObject);
            gameObject.AddComponent<SSRTManager>();
        }

        public void OnUnload()
        {
        }
    }
}