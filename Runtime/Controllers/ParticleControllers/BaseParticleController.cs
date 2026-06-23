using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public abstract class BaseParticleController : BaseController
    {
        protected abstract void Update(ParticleSystem ps, float percent, int loop);
        protected abstract void OnEnable(ParticleSystem ps, int loop);
        protected abstract void OnDisable(ParticleSystem ps, int loop);

        public ParticleSystem[] ParticleSystems;
        
        public override void SetUpdate(float percent)
        {
            for (int i = 0; i < ParticleSystems.Length; i++)
            {
                Update(ParticleSystems[i], percent, i);
            }
        }

        public override void SetOnEnable()
        {
            for (int i = 0; i < ParticleSystems.Length; i++)
            {
                OnEnable(ParticleSystems[i], i);
            }
        }

        public override void SetOnDisable()
        {
            for (int i = 0; i < ParticleSystems.Length; i++)
            {
                OnDisable(ParticleSystems[i], i);
            }
        }
    }
}
