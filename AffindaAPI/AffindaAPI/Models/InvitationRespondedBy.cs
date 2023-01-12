// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The InvitationRespondedBy. </summary>
    public partial class InvitationRespondedBy : User
    {
        /// <summary> Initializes a new instance of InvitationRespondedBy. </summary>
        internal InvitationRespondedBy()
        {
        }

        /// <summary> Initializes a new instance of InvitationRespondedBy. </summary>
        /// <param name="id"> Uniquely identify a user. </param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="avatar"> URL of the user&apos;s avatar. </param>
        internal InvitationRespondedBy(string id, string name, string username, string email, string avatar) : base(id, name, username, email, avatar)
        {
        }
    }
}
