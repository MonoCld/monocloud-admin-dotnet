using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Account Protection Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionOptionsRequest>))]
public class PatchAccountProtectionOptionsRequest
{
   /// <summary>
   /// Account Protection&#39;s User Lockout Options
   /// </summary>
   public Optional<PatchAccountProtectionUserLockoutOptionsRequest> UserLockout { get; set; }
}


