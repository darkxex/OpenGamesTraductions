// Decompiled with JetBrains decompiler
// Type: TraduccionMain.Properties.Resources
// Assembly: TraduccionMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3E46C48C-4892-404C-8AE7-6FD2A81F65BF
// Assembly location: C:\Users\darkx\OneDrive\Desktop\Gamestraductions 4.1.1 Only Windows\Gamestraductions 4.1.1\netcoreapp2.0\GamesTraductions.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TraduccionMain.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (TraduccionMain.Properties.Resources.resourceMan == null)
          TraduccionMain.Properties.Resources.resourceMan = new ResourceManager("TraduccionMain.Properties.Resources", typeof (TraduccionMain.Properties.Resources).Assembly);
        return TraduccionMain.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => TraduccionMain.Properties.Resources.resourceCulture;
      set => TraduccionMain.Properties.Resources.resourceCulture = value;
    }
  }
}
