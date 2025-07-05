﻿using Fluxor;

namespace coderzxcBlazor.FluxState
{
    [FeatureState]
    public class AuthState
    {
        public string JwtToken { get; init; }
        public bool IsAuthenticated { get; }

        public AuthState(string jwtToken, bool isAuthenticated)
        {
            JwtToken = jwtToken;
            IsAuthenticated = isAuthenticated;
        }

        public AuthState() : this(null, false) { }
    }
}
