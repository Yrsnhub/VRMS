// UI/Animation/IAnimationManager.cs
using System;

namespace VRMS.UI.Animation
{
    public interface IAnimationManager : IDisposable
    {
        event EventHandler AnimationStarted;
        event EventHandler AnimationCompleted;

        bool IsAnimating { get; }
        void StartSlideAnimation();
        void StopAnimation();
    }
}