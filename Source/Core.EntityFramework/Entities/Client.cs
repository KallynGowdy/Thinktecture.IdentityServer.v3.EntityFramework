﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Thinktecture.IdentityServer.Core.Models;

namespace Thinktecture.IdentityServer.Core.EntityFramework.Entities
{
    public class Client
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual bool Enabled { get; set; }

        [Required]
        public virtual string ClientId { get; set; }
        public virtual string ClientSecret { get; set; }
        [Required]
        public virtual string ClientName { get; set; }
        public virtual string ClientUri { get; set; }
        public virtual string LogoUri { get; set; }

        public virtual bool RequireConsent { get; set; }
        public virtual bool AllowRememberConsent { get; set; }

        public virtual Flows Flow { get; set; }

        // in seconds
        [Range(0, Int32.MaxValue)]
        public virtual int IdentityTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public virtual int AccessTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public virtual int AuthorizationCodeLifetime { get; set; }
        
        [Range(0, Int32.MaxValue)]
        public virtual int AbsoluteRefreshTokenLifetime { get; set; }
        [Range(0, Int32.MaxValue)]
        public virtual int SlidingRefreshTokenLifetime { get; set; }
        public virtual TokenUsage RefreshTokenUsage { get; set; }
        public virtual TokenExpiration RefreshTokenExpiration { get; set; }
        
        public virtual SigningKeyTypes IdentityTokenSigningKeyType { get; set; }
        public virtual AccessTokenType AccessTokenType { get; set; }

        // not implemented yet
        public virtual bool RequireSignedAuthorizeRequest { get; set; }
        public virtual SubjectTypes SubjectType { get; set; }
        public virtual string SectorIdentifierUri { get; set; }
        public virtual ApplicationTypes ApplicationType { get; set; }

        public virtual ICollection<ClientRedirectUri> RedirectUris { get; set; }
        public virtual ICollection<ClientScopeRestriction> ScopeRestrictions { get; set; }
    }
}
