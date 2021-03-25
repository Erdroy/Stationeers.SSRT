// Stationeers.Addons (c) 2018-2020 Damian 'Erdroy' Korczowski & Contributors

using Stationeers.Addons;
using UnityEngine;

namespace SSRTPlugin.Scripts
{
    public class SSRTPlugin : IPlugin
    {
        private GameObject _root;
        
        public void OnLoad()
        {
            Debug.Log("SSRT: Hello, World!");
            _root = new GameObject("SSRT");
            Object.DontDestroyOnLoad(_root);
            _root.AddComponent<SSRTManager>();
        }

        public void OnUnload()
        {
            Object.Destroy(_root);
        }
    }
}