using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Branding Generic Page Background Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingGenericPageBackgroundOptionsRequest>))]
public class PatchBrandingGenericPageBackgroundOptionsRequest
{
   /// <summary>
   /// Specifies the background colour (in Hex)
   /// </summary>
   public Optional<string?> Color { get; set; }

   /// <summary>
   /// Specifies the background image
   /// </summary>
   public Optional<string?> Image { get; set; }
}


