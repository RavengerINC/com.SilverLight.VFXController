using System;
using UnityEngine;

namespace VisualEffects.Controller
{
    [Serializable]
    public class PlayOneShotParticleController : BaseParticleController
    {
        public float[] TriggerTime;
        private bool[] m_HasTriggered;
        
        protected override void Update(ParticleSystem ps, float percent, int loop)
        {
            if (!m_HasTriggered[loop] && percent >= TriggerTime[loop])
            {
                if(!ps.gameObject.activeInHierarchy)
                    ps.gameObject.SetActive(true);
                
                ps.Play();
                m_HasTriggered[loop] = true;
            }
        }

        protected override void OnEnable(ParticleSystem ps, int loop)
        {
            m_HasTriggered = new bool[ParticleSystems.Length];
            
            for (int i = 0; i < m_HasTriggered.Length; i++)
            {
                m_HasTriggered[i] = false;
            }
        }

        protected override void OnDisable(ParticleSystem ps, int loop)
        {
            ps.Stop();
        }
    }
}
