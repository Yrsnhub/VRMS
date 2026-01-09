// UI/Animation/IAnimationHost.cs
using System;

namespace VRMS.UI.Animation
{
    public interface IAnimationHost
    {
        void OnAnimationStart();
        void UpdateAnimationFrame(float easedProgress, float rawProgress);
        void OnAnimationComplete();
    }
}