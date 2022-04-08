// Decompiled with JetBrains decompiler
// Type: TraduccionMain.Program
// Assembly: TraduccionMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3E46C48C-4892-404C-8AE7-6FD2A81F65BF
// Assembly location: C:\Users\darkx\OneDrive\Desktop\Gamestraductions 4.1.1 Only Windows\Gamestraductions 4.1.1\netcoreapp2.0\GamesTraductions.exe

using System;
using System.Windows.Forms;

namespace TraduccionMain
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
