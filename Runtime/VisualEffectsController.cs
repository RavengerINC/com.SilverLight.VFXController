using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace VisualEffects.Controller
{
    public class VisualEffectsController : MonoBehaviour
    {
        private Dictionary<string, VisualEffect> M_VisualEffects;

        private void Awake()
        {
            VisualEffect[] effects = GetComponents<VisualEffect>();
            M_VisualEffects = effects.ToDictionary(a => a.Name);
            
            DefaultEffectsOff();
        }

        public VisualEffect GetAssembly(string label)
        {
            return M_VisualEffects.GetValueOrDefault(label);
        }

        private void DefaultEffectsOff()
        {
            foreach (var assembly in M_VisualEffects.Values)
            {
                assembly.enabled = false;
            }
        }
    }
}