using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class EnableKeywordController : BaseMaterialController
    {
        [SerializeField] private string m_Keyword;

        protected override void Update(Material material, float percent)
        {
            // No-op
        }

        protected override void OnEnable(Material material)
        {
            material.EnableKeyword(m_Keyword);
        }

        protected override void OnDisable(Material material)
        {
            material.DisableKeyword(m_Keyword);
        }
    }
}