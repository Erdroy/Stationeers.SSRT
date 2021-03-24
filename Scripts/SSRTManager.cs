using UnityEngine;

namespace SSRTPlugin.Scripts
{
    public class SSRTManager : MonoBehaviour
    {
        private bool _enabled;
        
        private void Awake()
        {
        }

        private void Update()
        {
            var component = Camera.main.gameObject.GetComponent<SSRT>();

            if (!component)
            {
                Camera.main.gameObject.AddComponent<SSRT>();
                component = Camera.main.gameObject.GetComponent<SSRT>();
                
                component.lightBufferResolution = SSRT.ResolutionDownscale.Full;
                component.resolutionDownscale = SSRT.ResolutionDownscale.Full;
            }

            if (Input.GetKeyDown(KeyCode.F10))
                _enabled = !_enabled;
        }
        
        private void OnGUI()
        {
            if (!_enabled) return;
            
            var component = Camera.main.gameObject.GetComponent<SSRT>();

            if (component)
            {
            
                GUILayout.Label("rotationCount = " + component.rotationCount);
                component.rotationCount = (int)GUILayout.HorizontalSlider(component.rotationCount, 1, 4);
                
                GUILayout.Label("stepCount = " + component.stepCount);
                component.stepCount = (int)GUILayout.HorizontalSlider(component.stepCount, 1, 16);
                
                GUILayout.Label("radius = " + component.radius);
                component.radius = GUILayout.HorizontalSlider(component.radius, 1, 25);
                
                GUILayout.Label("expStart = " + component.expStart);
                component.expStart = GUILayout.HorizontalSlider(component.expStart, 0.1f, 1);
                
                GUILayout.Label("expFactor = " + component.expFactor);
                component.expFactor = GUILayout.HorizontalSlider(component.expFactor, 1, 2);
                
                component.jitterSamples = GUILayout.Toggle(component.jitterSamples, "jitterSamples = " + component.jitterSamples);
                
                GUILayout.Label("GIBoost = " + component.GIBoost);
                component.GIBoost = GUILayout.HorizontalSlider(component.GIBoost, 0, 75);
                
                component.lightBufferHDR = GUILayout.Toggle(component.lightBufferHDR, "lightBufferHDR = " + component.lightBufferHDR);
                
                GUILayout.Label("LnDlOffset = " + component.LnDlOffset);
                component.LnDlOffset = GUILayout.HorizontalSlider(component.LnDlOffset, 0, 1);
                
                GUILayout.Label("nDlOffset = " + component.nDlOffset);
                component.nDlOffset = GUILayout.HorizontalSlider(component.nDlOffset, 0, 1);
                
                GUILayout.Label("power = " + component.power);
                component.power = GUILayout.HorizontalSlider(component.power, 1, 8);
                
                GUILayout.Label("thickness = " + component.thickness);
                component.thickness = GUILayout.HorizontalSlider(component.thickness, 0.1f, 10);
                
                GUILayout.Label("falloff = " + component.falloff);
                component.falloff = GUILayout.HorizontalSlider(component.falloff, 1, 50);
                
                component.multiBounceAO = GUILayout.Toggle(component.multiBounceAO, "multiBounceAO = " + component.multiBounceAO);
                component.directLightingAO = GUILayout.Toggle(component.directLightingAO, "directLightingAO = " + component.directLightingAO);
                
                GUILayout.Label("reuseCount = " + component.reuseCount);
                component.reuseCount = (int)GUILayout.HorizontalSlider(component.reuseCount, 1, 8);
                
                component.temporalEnabled = GUILayout.Toggle(component.temporalEnabled, "temporalEnabled = " + component.temporalEnabled);
                
                GUILayout.Label("temporalResponse = " + component.temporalResponse);
                component.temporalResponse = GUILayout.HorizontalSlider(component.temporalResponse, 0, 1);
                
            }
        }
    }
}