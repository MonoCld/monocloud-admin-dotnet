using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Branding Sms Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingSmsOptionsRequest>))]
public class PatchBrandingSmsOptionsRequest
{
   /// <summary>
   /// SignIn Sms Code Branding Options
   /// </summary>
   public Optional<PatchBrandingGenericCustomSmsOptionsRequest> SignIn { get; set; }

   /// <summary>
   /// Verification Sms Code Branding Options
   /// </summary>
   public Optional<PatchBrandingGenericCustomSmsOptionsRequest> Verification { get; set; }

   /// <summary>
   /// Password Reset Sms Code Branding Options
   /// </summary>
   public Optional<PatchBrandingGenericCustomSmsOptionsRequest> PasswordReset { get; set; }
}


