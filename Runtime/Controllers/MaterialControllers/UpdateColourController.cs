using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class UpdateColourController : BaseMaterialController
    {
        [SerializeField] private Gradient m_Gradient;
        [SerializeField] private string m_TargetProperty;
        
        private Color m_OriginalColour;
        
        protected override void Update(Material material, float percent)
        {
            material.SetColor(m_TargetProperty, m_Gradient.Evaluate(percent));
        }

        protected override void OnEnable(Material material)
        {
            m_OriginalColour = material.GetColor(m_TargetProperty);
            material.SetColor(m_TargetProperty, m_Gradient.Evaluate(0));
        }

        protected override void OnDisable(Material material)
        {
            material.SetColor(m_TargetProperty, m_OriginalColour);
        }
    }
}
