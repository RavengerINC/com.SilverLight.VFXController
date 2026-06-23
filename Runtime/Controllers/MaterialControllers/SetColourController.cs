using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class SetColourController : BaseMaterialController
    {
        [SerializeField] private Color m_Colour;
        [SerializeField] private string m_TargetProperty;
        
        private Color m_OriginalColour;
        
        protected override void Update(Material material, float percent)
        {
            // No-op
        }

        protected override void OnEnable(Material material)
        {
            m_OriginalColour = material.GetColor(m_TargetProperty);
            material.SetColor(m_TargetProperty, m_Colour);
        }

        protected override void OnDisable(Material material)
        {
            material.SetColor(m_TargetProperty, m_OriginalColour);
        }
    }
}
