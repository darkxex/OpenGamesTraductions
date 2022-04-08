// Decompiled with JetBrains decompiler
// Type: TraduccionMain.ConnexionExcel
// Assembly: TraduccionMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3E46C48C-4892-404C-8AE7-6FD2A81F65BF
// Assembly location: C:\Users\darkx\OneDrive\Desktop\Gamestraductions 4.1.1 Only Windows\Gamestraductions 4.1.1\netcoreapp2.0\GamesTraductions.exe

using LinqToExcel;
using System;

namespace TraduccionMain
{
  public class ConnexionExcel
  {
    public string _pathExcelFile;
    public ExcelQueryFactory _urlConnexion;

    public ConnexionExcel(string path)
    {
      Console.WriteLine(path);
      this._pathExcelFile = path;
      this._urlConnexion = new ExcelQueryFactory(this._pathExcelFile);
    }

    public string PathExcelFile => this._pathExcelFile;

    public ExcelQueryFactory UrlConnexion => this._urlConnexion;
  }
}
