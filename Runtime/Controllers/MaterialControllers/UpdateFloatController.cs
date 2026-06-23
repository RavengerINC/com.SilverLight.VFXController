using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class UpdateFloatController : BaseMaterialController
    {
        [SerializeField] private AnimationCurve m_Curve = AnimationCurve.Linear(0, 0, 1, 1);
        [SerializeField] private string m_TargetProperty;

        private float m_OriginalValue;

        protected override void Update(Material material, float percent)
        {
            material.SetFloat(m_TargetProperty, m_Curve.Evaluate(percent));
        }

        protected override void OnEnable(Material material)
        {
            m_OriginalValue = material.GetFloat(m_TargetProperty);
        }

        protected override void OnDisable(Material material)
        {
            material.SetFloat(m_TargetProperty, m_OriginalValue);
        }
    }
}