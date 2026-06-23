using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class EnableParticleController : BaseParticleController
    {
        protected override void Update(ParticleSystem ps, float percent, int loop)
        {
            // No-op
        }

        protected override void OnEnable(ParticleSystem ps, int loop)
        {
            if(!ps.gameObject.activeInHierarchy)
                ps.gameObject.SetActive(true);
            
            ps.Play();
        }

        protected override void OnDisable(ParticleSystem ps, int loop)
        {
            ps.Stop();
        }
    }
}
