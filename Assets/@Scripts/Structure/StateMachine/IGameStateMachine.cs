﻿using Helix.Service;

namespace Helix.State
{
    public interface IGameStateMachine : IService
    {
        void Enter<TState, TPayLoad>(TPayLoad payLoad) where TState : class, IPayLoadState<TPayLoad>;
        void Enter<TState>() where TState : class, IState;
    }
}