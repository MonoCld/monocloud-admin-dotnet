using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch account protection user unblock options request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserUnblockOptionsRequest>))]
public class PatchAccountProtectionUserUnblockOptionsRequest
{
   /// <summary>
   /// User Unblock Email Options
   /// </summary>
   public Optional<PatchAccountProtectionUserUnblockEmailOptionsRequest> Email { get; set; }
}


