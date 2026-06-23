using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class UpdateTextureController : BaseMaterialController
    {
        [SerializeField] private Texture[] m_TextureSequence;
        [SerializeField] private AnimationCurve m_Curve = AnimationCurve.Linear(0, 0, 1, 1);
        [SerializeField] private string m_TargetProperty;

        private Texture m_OriginalTexture;
        private int m_TextureCount;

        protected override void Update(Material material, float percent)
        {
            material.SetTexture(m_TargetProperty, m_TextureSequence[Mathf.RoundToInt(m_Curve.Evaluate(percent) * (m_TextureCount - 1))]);
        }

        protected override void OnEnable(Material material)
        {
            m_OriginalTexture = material.GetTexture(m_TargetProperty);

            material.SetTexture(m_TargetProperty, m_TextureSequence[0]);
            m_TextureCount = m_TextureSequence.Length;
        }

        protected override void OnDisable(Material material)
        {
            material.SetTexture(m_TargetProperty, m_OriginalTexture);
        }
    }
}