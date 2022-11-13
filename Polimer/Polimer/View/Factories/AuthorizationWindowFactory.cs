﻿using System;
using Polimer.App.ViewModel.Authorization;

namespace Polimer.App.View.Factories
{
    public class AuthorizationWindowFactory : IWindowFactory<AuthorizationWindow>
    {
        private readonly AuthorizationViewModel _authViewModel;
        public AuthorizationWindowFactory(AuthorizationViewModel authViewModel)
        {
            _authViewModel = authViewModel ?? throw new ArgumentNullException(nameof(authViewModel));
        }
        public AuthorizationWindow CreateWindow()
        {
            return new AuthorizationWindow() {DataContext = _authViewModel};
        }
    }
}
