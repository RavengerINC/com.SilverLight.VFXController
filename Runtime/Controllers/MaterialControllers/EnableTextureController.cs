using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class EnableTextureController : BaseMaterialController
    {
        [SerializeField] private Texture m_Texture;
        [SerializeField] private string m_TargetProperty;

        private Texture m_OriginalTexture;

        protected override void Update(Material material, float percent)
        {
            // No-op
        }

        protected override void OnEnable(Material material)
        {
            m_OriginalTexture = material.GetTexture(m_TargetProperty);
            material.SetTexture(m_TargetProperty, m_Texture);
        }

        protected override void OnDisable(Material material)
        {
            material.SetTexture(m_TargetProperty, m_OriginalTexture);
        }
    }
}