// Decompiled with JetBrains decompiler
// Type: TraduccionMain.Form1
// Assembly: TraduccionMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3E46C48C-4892-404C-8AE7-6FD2A81F65BF
// Assembly location: C:\Users\darkx\OneDrive\Desktop\Gamestraductions 4.1.1 Only Windows\Gamestraductions 4.1.1\netcoreapp2.0\GamesTraductions.exe

using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraduccionMain
{
  public class Form1 : Form
  {
    private Form topMostForm = new Form();
    private int xMouse = 0;
    private int yMouse = 0;
    private int yMouseRectangle;
    private int xMouseRectangle;
    private string res = (string) null;
    private string resulTraduc = (string) null;
    private static string resultIp = (string) null;
    private int port = 0;
    private int cont;
    private bool almacenCoordenadadas = false;
    private Joystick joystick;
    private JoystickState stato;
    private bool[] buttons;
    private string inLeng = (string) null;
    private string outLeng = (string) null;
    private string path;
    private string pathDelete;
    private Bitmap bitmap;
    private bool pulsoboton = false;
    private string textExcel;
    public bool game_port_booted = false;
    private bool entryBucleGamepad = true;
    private int iniX;
    private int iniY;
    private int finX;
    private int finY;
    private int auxIniX;
    private int auxIniY;
    private int auxFinX;
    private int auxFinY;
    private string idioma;
    private bool conexionAcepted = true;
    private int reduccionX;
    private int reduccionY;
    private int perf1AuxReducX;
    private int perf1AuxReducY;
    private int perf1AuxMouseRectX;
    private int perf1AuxMouseRectY;
    private string contraPass = "";
    private int cuentapass = 0;
    private bool conexionAndroid = true;
    private Thread hiloExcel;
    private RetornoVarsPerfiles rvp = new RetornoVarsPerfiles();
    private IContainer components = (IContainer) null;
    private Button button1;
    private Label labAncho;
    private Label labAlto;
    private Label lblInix;
    private Label lblFinX;
    private NumericUpDown numIniX;
    private NumericUpDown numFinX;
    private NumericUpDown numFinY;
    private NumericUpDown numIniY;
    private Label label1;
    private Label label2;
    public PictureBox pictureBox1;
    private Panel panel1;
    private Label labOpaci;
    public NumericUpDown numOpaci;
    private ComboBox comboBox1;
    private Label label4;
    private Label label3;
    private ComboBox comboBox2;
    private Label label5;
    private Label lab_ip;
    private Label labelY;
    private Label labelX;
    private Label label7;
    private Label label6;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private CheckBox checkBox2;
    private CheckBox checkBox1;
    private CheckBox checkBox3;
    private Label label9;
    private LinkLabel linkLabel1;
    private NumericUpDown numericDownYfin;
    private NumericUpDown numericDownYpri;
    private NumericUpDown numericCenterYfin;
    private NumericUpDown numericCenterYpri;
    private NumericUpDown numericTopYfin;
    private RadioButton radioButton3;
    private CheckBox cbViewTraductor;
    private ComboBox comboBox3;
    private Label label12;
    private Label label11;
    private TextBox textBoxFs;
    private Label label8;
    private ComboBox comboBoxSeg;
    private CheckBox checkBoxAuto;
    private ComboBox comboBox4;
    private NumericUpDown numericTopYpri;
    private NumericUpDown numericUpBinario;
    private Label label13;
    private Label label14;
    private RadioButton radioButAnime;
    private Label label10;
    private Label label15;
    private CheckBox checkBoxExcelTranslate;
    private TextBox textBoxExcelName;
    private NumericUpDown numPort;
    private TextBox text_ip;
    private Label lbError;
    private Label indicador;
    private CheckBox checkOnlyTradu;
    private TextBox textBoxTextoTraducidoExcel;
    private Panel panel2;
    protected WebBrowser webBrowser1;
    private Label label16;
    private LinkLabel linkLabel2;

    public Form1()
    {
      this.topMostForm.TopMost = true;
      this.InitializeComponent();
      this.textBoxTextoTraducidoExcel.Visible = false;
      this.Opacity = 0.9;
      this.checkOnlyTradu.Checked = false;
      this.AcceptButton = (IButtonControl) this.button1;
      this.path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\samples\\img1.png";
      this.labAncho.Text = "ResoluciónHorizontalX: " + Convert.ToString(Screen.PrimaryScreen.Bounds.Width);
      this.labAlto.Text = "ResoluciónVerticalY: " + Convert.ToString(Screen.PrimaryScreen.Bounds.Height);
      this.numFinX.Value = 0M;
      this.numFinY.Value = 0M;
      this.comboBox1.Items.Add((object) "Ingles");
      this.comboBox1.Items.Add((object) "Frances");
      this.comboBox1.Items.Add((object) "Español");
      this.comboBox1.Items.Add((object) "Portugues");
      this.comboBox1.Items.Add((object) "Italiano");
      this.comboBox1.Items.Add((object) "Aleman");
      this.comboBox1.Items.Add((object) "Japonés");
      this.comboBox1.Items.Add((object) "Català");
      this.comboBox1.Items.Add((object) "Euskera");
      this.comboBox1.Items.Add((object) "Gallego");
      this.comboBox1.Items.Add((object) "Árabe");
      this.comboBox1.Items.Add((object) "Chino");
      this.comboBox1.Items.Add((object) "Ruso");
      this.comboBox1.Items.Add((object) "Koreano");
      this.comboBox2.Items.Add((object) "Español");
      this.comboBox2.Items.Add((object) "Frances");
      this.comboBox2.Items.Add((object) "Ingles");
      this.comboBox2.Items.Add((object) "Portugues");
      this.comboBox2.Items.Add((object) "Italiano");
      this.comboBox2.Items.Add((object) "Aleman");
      this.comboBox2.Items.Add((object) "Català");
      this.comboBox2.Items.Add((object) "Euskera");
      this.comboBox2.Items.Add((object) "Árabe");
      this.comboBox2.Items.Add((object) "Gallego");
      this.comboBox2.Items.Add((object) "Bielorruso");
      this.comboBox2.Items.Add((object) "Japonés");
      this.comboBox2.Items.Add((object) "Ruso");
      this.comboBox2.Items.Add((object) "Chino");
      this.comboBox2.Items.Add((object) "Holandés");
      this.comboBox2.Items.Add((object) "Koreano");
      this.comboBox2.Items.Add((object) "Thailandes");
      this.comboBox2.Items.Add((object) "Hindi");
      this.comboBox3.Items.Add((object) "Select Ps4");
      this.comboBox3.Items.Add((object) "Touchpad Ps4");
      this.comboBox3.Items.Add((object) "Home Ps4");
      this.comboBox3.Items.Add((object) "X Ps4");
      this.comboBox3.Items.Add((object) "Select Xbox360");
      this.comboBox4.Items.Add((object) "L3 Ps4");
      this.comboBox4.Items.Add((object) "R3 Ps4");
      this.comboBox4.Items.Add((object) "D-Pad Up Ps4");
      this.comboBox4.Items.Add((object) "TouchPad Ps4");
      this.comboBox4.Items.Add((object) "D-Pad Up 360");
      this.comboBoxSeg.Items.Add((object) "0,8");
      this.comboBoxSeg.Items.Add((object) "1");
      this.comboBoxSeg.Items.Add((object) "1,5");
      this.comboBoxSeg.Items.Add((object) "2");
      this.comboBoxSeg.Items.Add((object) "2,5");
      this.comboBoxSeg.Items.Add((object) "3");
      this.comboBoxSeg.Items.Add((object) "3,5");
      this.comboBoxSeg.Items.Add((object) "4");
      this.comboBoxSeg.Items.Add((object) "4,5");
      this.comboBoxSeg.Items.Add((object) "5");
      Decimal.ToInt32(this.numIniX.Value);
      Decimal.ToInt32(this.numIniY.Value);
      Decimal.ToInt32(this.numFinX.Value);
      Decimal.ToInt32(this.numFinY.Value);
      this.radioButton1.Checked = true;
      //Thread thread = new Thread(new ThreadStart(this.Joystick2));
      //thread.Start();
      //thread.IsBackground = true;
      if (WBEmulator.IsBrowserEmulationSet())
        return;
      WBEmulator.SetBrowserEmulationVersion();
    }

    private void button1_Click(object sender, EventArgs e) => this.Empezamos();

    private void CapturedKeys(object sender, KeyPressEventArgs e)
    {
      this.topMostForm.TopMost = true;
      if ((int) e.KeyChar != (int) Convert.ToChar((object) Keys.D0) && (int) e.KeyChar != (int) Convert.ToChar((object) Keys.Space))
        return;
      Console.WriteLine("click space");
      this.Empezamos();
    }

    public void Empezamos()
    {
      Control.CheckForIllegalCrossThreadCalls = false;
      if (!this.checkBoxAuto.Checked)
        this.Hide();
      this.lbError.Text = "";
      this.AcceptButton = (IButtonControl) this.button1;
      Form1.resultIp = this.text_ip.Text;
      this.port = Convert.ToInt32(this.numPort.Value);
      try
      {
        Decimal num1 = this.numIniX.Value;
        Rectangle bounds = Screen.PrimaryScreen.Bounds;
        Decimal width1 = (Decimal) bounds.Width;
        if (num1 >= width1)
        {
          NumericUpDown numIniX = this.numIniX;
          bounds = Screen.PrimaryScreen.Bounds;
          Decimal num2 = (Decimal) (bounds.Width - 1);
          numIniX.Value = num2;
        }
        Decimal num3 = this.numIniY.Value;
        bounds = Screen.PrimaryScreen.Bounds;
        Decimal height1 = (Decimal) bounds.Height;
        if (num3 >= height1)
        {
          NumericUpDown numIniY = this.numIniY;
          bounds = Screen.PrimaryScreen.Bounds;
          Decimal num4 = (Decimal) (bounds.Height - 1);
          numIniY.Value = num4;
        }
        Decimal num5 = this.numFinX.Value;
        bounds = Screen.PrimaryScreen.Bounds;
        Decimal width2 = (Decimal) bounds.Width;
        if (num5 >= width2)
        {
          NumericUpDown numFinX = this.numFinX;
          bounds = Screen.PrimaryScreen.Bounds;
          Decimal num6 = (Decimal) (bounds.Width - 1);
          numFinX.Value = num6;
        }
        Decimal num7 = this.numFinY.Value;
        bounds = Screen.PrimaryScreen.Bounds;
        Decimal height2 = (Decimal) bounds.Height;
        if (num7 >= height2)
        {
          NumericUpDown numFinY = this.numFinY;
          bounds = Screen.PrimaryScreen.Bounds;
          Decimal num8 = (Decimal) (bounds.Height - 1);
          numFinY.Value = num8;
        }
        int num9 = Decimal.ToInt32(this.numIniY.Value) + Decimal.ToInt32(this.numFinY.Value);
      }
      catch (Exception ex)
      {
        this.lbError.Text = "Out Range ";
      }
      this.res = (string) null;
      this.resulTraduc = "";
      try
      {
        Rectangle bounds = Screen.PrimaryScreen.Bounds;
        int width = bounds.Width - Decimal.ToInt32(this.numIniX.Value + this.numFinX.Value);
        bounds = Screen.PrimaryScreen.Bounds;
        int height = bounds.Height - Decimal.ToInt32(this.numIniY.Value + this.numFinY.Value);
        this.bitmap = new Bitmap(width, height);
        Graphics graphics = Graphics.FromImage((Image) this.bitmap);
        this.iniX = Decimal.ToInt32(this.numIniX.Value);
        this.iniY = Decimal.ToInt32(this.numIniY.Value);
        graphics.CopyFromScreen(this.iniX, this.iniY + 23, 0, 0, this.bitmap.Size);
      }
      catch (Exception ex)
      {
        this.lbError.Text = "Error coordenadas";
      }
      if (this.radioButton2.Checked)
      {
        Bitmap bitmap1 = this.bitmap;
        Bitmap bitmap2 = this.bitmap;
        float num10 = 1f;
        float gamma = 1f;
        float num11 = num10 - 1f;
        float[][] newColorMatrix = new float[5][]
        {
          new float[5]{ 0.3f, 0.3f, 0.3f, 0.0f, 0.0f },
          new float[5]{ 0.59f, 0.59f, 0.59f, 0.0f, 0.0f },
          new float[5]{ 0.11f, 0.11f, 0.11f, 0.0f, 0.0f },
          new float[5]{ 0.0f, 0.0f, 0.0f, 1f, 0.0f },
          new float[5]{ 0.0f, 0.0f, 0.0f, 0.0f, 1f }
        };
        ImageAttributes imageAttr = new ImageAttributes();
        imageAttr.ClearColorMatrix();
        imageAttr.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        imageAttr.SetGamma(gamma, ColorAdjustType.Bitmap);
        Graphics.FromImage((Image) this.bitmap).DrawImage((Image) bitmap1, new Rectangle(0, 0, this.bitmap.Width, this.bitmap.Height), 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel, imageAttr);
      }
      if (this.radioButton3.Checked)
      {
        Bitmap bitmap3 = this.bitmap;
        Bitmap bitmap4 = this.bitmap;
        float num12 = 1f;
        float gamma = 1f;
        float num13 = num12 - 1f;
        float[][] newColorMatrix = new float[5][]
        {
          new float[5]{ -5f, -5f, -5f, 0.0f, 0.0f },
          new float[5]{ -5f, -5f, -5f, 0.0f, 0.0f },
          new float[5]{ -5f, -5f, -5f, 0.0f, 0.0f },
          new float[5]{ 5f, 5f, 5f, 2f, 0.0f },
          new float[5]{ -1f, -1f, -1f, 1f, 0.0f }
        };
        ImageAttributes imageAttr = new ImageAttributes();
        imageAttr.ClearColorMatrix();
        imageAttr.SetColorMatrix(new ColorMatrix(newColorMatrix), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        imageAttr.SetGamma(gamma, ColorAdjustType.Bitmap);
        Graphics.FromImage((Image) this.bitmap).DrawImage((Image) bitmap3, new Rectangle(0, 0, this.bitmap.Width, this.bitmap.Height), 0, 0, bitmap3.Width, bitmap3.Height, GraphicsUnit.Pixel, imageAttr);
      }
      try
      {
        if (!this.checkBox1.Checked && !this.checkBox2.Checked && !this.checkBox3.Checked)
        {
          Console.WriteLine("Sin Perfil");
          if (this.radioButAnime.Checked)
            this.imagenAbinario();
          else
            this.bitmap = (Bitmap) this.CambiarTamanoImagen((Image) this.bitmap, this.bitmap.Width * 2, this.bitmap.Height * 2);
        }
        else if (this.checkBox1.Checked)
        {
          Console.WriteLine("perfil 1");
          if (this.radioButAnime.Checked)
          {
            this.imagenAbinario();
          }
          else
          {
            this.bitmap = (Bitmap) this.CambiarTamanoImagen((Image) this.bitmap, this.bitmap.Width * 2, this.bitmap.Height * 2);
            Console.WriteLine("REDUCCION X:" + (object) this.reduccionX + "    REDUCCION Y:" + (object) this.reduccionY);
          }
        }
        else if (this.checkBox2.Checked)
        {
          Console.WriteLine("perfil 2");
          if (this.radioButAnime.Checked)
            this.imagenAbinario();
          else
            this.bitmap = (Bitmap) this.CambiarTamanoImagen((Image) this.bitmap, this.bitmap.Width * 2, this.bitmap.Height * 2);
        }
        else if (this.checkBox3.Checked)
        {
          Console.WriteLine("perfil 3");
          if (this.radioButAnime.Checked)
            this.imagenAbinario();
          else
            this.bitmap = (Bitmap) this.CambiarTamanoImagen((Image) this.bitmap, this.bitmap.Width * 2, this.bitmap.Height * 2);
        }
        this.bitmap.Save(this.path);
        this.pictureBox1.Image = (Image) this.bitmap;
      }
      catch
      {
        this.lbError.Text = "Error Image ";
      }
      string fullName = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
      string tesseractPath = fullName + "\\master";
      IEnumerable<string> strings = Directory.EnumerateFiles(fullName + "\\samples");
      int processorCount = Environment.ProcessorCount;
      IEnumerable<string> source = strings;
      ParallelOptions parallelOptions = new ParallelOptions();
      parallelOptions.MaxDegreeOfParallelism = processorCount;
      System.Action<string> body = (System.Action<string>) (fileName =>
      {
        Control.CheckForIllegalCrossThreadCalls = false;
        this.idioma = this.DimeIdioma(this.comboBox1.Text);
        byte[] imageFile = File.ReadAllBytes(fileName);
        string str = this.ParseText(tesseractPath, imageFile, this.idioma);
        this.textExcel = str;
        if (this.comboBox1.Text == "Japonés")
          str = str.Replace(" ", "").Replace("  ", " ");
        else if (this.comboBox1.Text == "Chino")
          str = str.Replace("  ", " ");
        this.resulTraduc = str.Replace("%", "*").Trim();
      });
      Parallel.ForEach<string>(source, parallelOptions, body);
      this.Show();
      if (this.checkBoxExcelTranslate.Checked)
      {
       /* this.hiloExcel = new Thread(new ThreadStart(this.leeExcel));
        this.hiloExcel.Start();
        this.hiloExcel.IsBackground = true;*/
      }
      this.openWeb();
    }

    public void imagenAbinario()
    {
      Bitmap original = new Bitmap((Image) this.bitmap);
      Bitmap bitmap = new Bitmap((Image) original);
      for (int y = 0; y < original.Height; ++y)
      {
        for (int x = 0; x < original.Width; ++x)
        {
          Color pixel = original.GetPixel(x, y);
          if ((double) pixel.R * 0.3 + (double) pixel.G * 0.59 + (double) pixel.B * 0.11 > (double) Decimal.ToInt32(this.numericUpBinario.Value))
            bitmap.SetPixel(x, y, Color.White);
          else
            bitmap.SetPixel(x, y, Color.Black);
        }
      }
      this.bitmap = bitmap;
    }

    public string codificaText(string result)
    {
      foreach (char ch in result)
      {
        switch (ch)
        {
          case '\n':
            this.res += "%20".Trim();
            goto case ' ';
          case ' ':
            this.res += ch.ToString();
            continue;
          case ';':
            this.res += "%20".Trim();
            goto case ' ';
          default:
            if (ch.Equals((object) "’"))
            {
              this.res += "%20";
              goto case ' ';
            }
            else if (ch.Equals('/'))
            {
              this.res += "%2F";
              goto case ' ';
            }
            else
              goto case ' ';
        }
      }
      return this.res.Trim();
    }

    public void openWeb()
    {
      if (this.comboBox1.Text == "Ingles")
        this.inLeng = "en";
      else if (this.comboBox1.Text == "Frances")
        this.inLeng = "fr";
      else if (this.comboBox1.Text == "Español")
        this.inLeng = "es";
      else if (this.comboBox1.Text == "Portugues")
        this.inLeng = "pt";
      else if (this.comboBox1.Text == "Italiano")
        this.inLeng = "it";
      else if (this.comboBox1.Text == "Aleman")
        this.inLeng = "de";
      else if (this.comboBox1.Text == "Català")
        this.inLeng = "ca";
      else if (this.comboBox1.Text == "Euskera")
        this.inLeng = "eu";
      else if (this.comboBox1.Text == "Gallego")
        this.inLeng = "gl";
      else if (this.comboBox1.Text == "Japonés")
        this.inLeng = "ja";
      else if (this.comboBox1.Text == "Árabe")
        this.inLeng = "ar";
      else if (this.comboBox1.Text == "Chino")
        this.inLeng = "zh-CN";
      else if (this.comboBox1.Text == "Ruso")
        this.inLeng = "ru";
      else if (this.comboBox1.Text == "Koreano")
        this.inLeng = "ko";
      if (this.comboBox2.Text == "Ingles")
        this.outLeng = "en";
      else if (this.comboBox2.Text == "Frances")
        this.outLeng = "fr";
      else if (this.comboBox2.Text == "Español")
        this.outLeng = "es";
      else if (this.comboBox2.Text == "Portugues")
        this.outLeng = "pt";
      else if (this.comboBox2.Text == "Italiano")
        this.outLeng = "it";
      else if (this.comboBox2.Text == "Aleman")
        this.outLeng = "de";
      else if (this.comboBox2.Text == "Català")
        this.outLeng = "ca";
      else if (this.comboBox2.Text == "Euskera")
        this.outLeng = "eu";
      else if (this.comboBox2.Text == "Árabe")
        this.outLeng = "ar";
      else if (this.comboBox2.Text == "Gallego")
        this.outLeng = "gl";
      else if (this.comboBox2.Text == "Bielorruso")
        this.outLeng = "be";
      else if (this.comboBox2.Text == "Japonés")
        this.outLeng = "ja";
      else if (this.comboBox2.Text == "Chino")
        this.outLeng = "zh-TW";
      else if (this.comboBox2.Text == "Holandés")
        this.outLeng = "nl";
      else if (this.comboBox2.Text == "Koreano")
        this.outLeng = "ko";
      else if (this.comboBox2.Text == "Thailandes")
        this.outLeng = "th";
      else if (this.comboBox2.Text == "Hindi")
        this.outLeng = "hi";
      else if (this.comboBox2.Text == "Ruso")
        this.outLeng = "ru";
      this.excelFansub();
      string str1 = "";
      try
      {
        if (this.resulTraduc != null)
        {
          string str2 = this.codificaText(this.resulTraduc).Replace('"', '_').Trim().Replace('/', '_').Trim().Replace("|", "I").Trim().Replace("  ", "").Replace("   ", "");
          this.webBrowser1.ScriptErrorsSuppressed = true;
          string urlString = "https://translate.google.es/?hl=ca#view=home&op=translate&sl=" + this.inLeng + "&tl=" + this.outLeng + "&text=" + str2.Trim();
          this.textBoxTextoTraducidoExcel.Focus();
          if (this.cbViewTraductor.Checked)
          {
            this.webBrowser1.Navigate(urlString);
            this.webBrowser1.Visible = true;
            this.textBoxTextoTraducidoExcel.Focus();
          }
          if (this.checkBoxAuto.Checked)
          {
            str1 = " ";
            this.textBoxTextoTraducidoExcel.Focus();
          }
          this.textBoxTextoTraducidoExcel.Focus();
        }
      }
      catch (Exception ex)
      {
        this.lbError.Text = "No hay texto ";
      }
      this.textBoxTextoTraducidoExcel.Focus();
      if (!this.checkBoxAuto.Checked)
        return;
      Console.WriteLine("Esperando... {0} segundos", (object) Convert.ToDouble(this.comboBoxSeg.Text));
      DateTime now1 = DateTime.Now;
      Form1.WaitSeconds(Convert.ToDouble(this.comboBoxSeg.Text));
      DateTime now2 = DateTime.Now;
      Console.WriteLine("Inicio: {0}", (object) now1.ToString("HH:mm:ss.ff"));
      Console.WriteLine("final : {0}", (object) now2.ToString("HH:mm:ss.ff"));
      Console.WriteLine("{0}", (object) (now2 - now1).TotalSeconds.ToString("0.00"));
      this.Empezamos();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData == Keys.Down || keyData == Keys.NumPad0)
        this.Empezamos();
      return base.ProcessCmdKey(ref msg, keyData);
    }
        /*
    public void leeExcel()
    {
      Thread.Sleep(200);
      try
      {
        ConnexionExcel connexionExcel = new ConnexionExcel("C:\\Fansub GamesTraductions\\" + this.textBoxExcelName.Text + ".xlsx");
        int length1 = this.resulTraduc.Length;
        int length2 = this.resulTraduc.Length;
        Console.WriteLine("resultado longitud:" + (object) length1);
        if (length1 > 42)
          length1 = 42;
        string char3last;
        if (length1 > 3)
        {
          char3last = this.resulTraduc.Substring(length2 - 4, 4);
          Console.WriteLine("Ultima letra: " + char3last);
        }
        else
        {
          char3last = this.resulTraduc.Substring(length2 - 2, 2);
          Console.WriteLine("Ultima letra: " + char3last);
        }
        Console.WriteLine("Longitud Texto = " + (object) length1);
        Console.WriteLine("Texto Inicial= " + this.resulTraduc.Substring(0, length1));
        string textoInicial = this.resulTraduc.Substring(0, length1).Replace("\n", " ");
        Console.WriteLine("Texto Modificado = " + textoInicial);
        Console.WriteLine("Texto Final= " + char3last);
        string str = "";
        if (length1 == 42)
        {
          IQueryable<\u003C\u003Ef__AnonymousType0<string>> queryable = connexionExcel.UrlConnexion.Worksheet<TraduccionExcel>().Where<TraduccionExcel>((Expression<Func<TraduccionExcel, bool>>) (p => p.TextoOriginal.StartsWith(textoInicial))).Select(p => new
          {
            TextoTraducido = p.TextoTraducido
          });
          try
          {
            foreach (var data in queryable)
            {
              str = "TextoTraducido : {0}";
              Console.WriteLine(string.Format(str, (object) data.TextoTraducido));
              str = data.TextoTraducido;
            }
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show(ex.Message, "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.lbError.Text = ex.Message;
          }
        }
        else
        {
          IQueryable<\u003C\u003Ef__AnonymousType0<string>> queryable = connexionExcel.UrlConnexion.Worksheet<TraduccionExcel>().Where<TraduccionExcel>((Expression<Func<TraduccionExcel, bool>>) (p => p.TextoOriginal.StartsWith(textoInicial) && p.TextoOriginal.EndsWith(char3last))).Select(p => new
          {
            TextoTraducido = p.TextoTraducido
          });
          try
          {
            foreach (var data in queryable)
            {
              str = "TextoTraducido : {0}";
              Console.WriteLine(string.Format(str, (object) data.TextoTraducido));
              str = data.TextoTraducido;
            }
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show(ex.Message, "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.lbError.Text = ex.Message;
          }
        }
        this.textBoxTextoTraducidoExcel.ResetText();
        this.textBoxTextoTraducidoExcel.AppendText(str);
        Console.WriteLine(str);
        if (!this.conexionAndroid)
          this.textBoxTextoTraducidoExcel.ResetText();
        Console.ReadLine();
        this.textBoxTextoTraducidoExcel.Focus();
      }
      catch (Exception ex)
      {
        this.lbError.Text = ex.Message;
      }
    }
        */
    private string DimeIdioma(string idioma)
    {
      if (idioma == "Ingles")
        idioma = "eng";
      else if (idioma == "Frances")
        idioma = "fra";
      else if (idioma == "Español")
        idioma = "spa";
      else if (idioma == "Aleman")
        idioma = "deu";
      else if (idioma == "Árabe")
        idioma = "ara";
      else if (idioma == "Japonés")
        idioma = "jpn";
      else if (idioma == "Italiano")
        idioma = "ita";
      else if (idioma == "Català")
        idioma = "cat";
      else if (idioma == "Portugues")
        idioma = "por";
      else if (idioma == "Euskera")
        idioma = "eus";
      else if (idioma == "Chino")
        idioma = "chi_tra";
      else if (idioma == "Ruso")
        idioma = "rus";
      else if (idioma == "Gallego")
        idioma = "spa";
      else if (idioma == "Koreano")
        idioma = "kor";
      return idioma;
    }

    private void closeFormTranslate(object sender, FormClosingEventArgs e) => e.Cancel = true;

    private void OpacityChange(object sender, EventArgs e)
    {
      if (this.numOpaci.Value == 10M)
        this.Opacity = 0.99;
      if (this.numOpaci.Value == 9M)
        this.Opacity = 0.9;
      else if (this.numOpaci.Value == 8M)
        this.Opacity = 0.8;
      else if (this.numOpaci.Value == 7M)
        this.Opacity = 0.7;
      else if (this.numOpaci.Value == 6M)
      {
        this.Opacity = 0.6;
      }
      else
      {
        if (!(this.numOpaci.Value == 5M))
          return;
        this.Opacity = 0.5;
      }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);
      this.CreateGraphics();
      this.xMouse = e.X;
      this.yMouse = e.Y;
      this.labelX.Text = this.xMouse.ToString();
      this.labelY.Text = this.yMouse.ToString();
    }

    public static bool IsKeyPressed(ConsoleKey key) => Console.KeyAvailable && Console.ReadKey(true).Key == key;

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.linkLabel1.LinkVisited = true;
      Process.Start("http://www.gamestraductions.com");
    }

    private void FormExit(object sender, FormClosedEventArgs e)
    {
      if (Application.OpenForms.Count != 0)
        return;
      Application.ExitThread();
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
      this.yMouseRectangle = this.yMouse;
      this.xMouseRectangle = this.xMouse;
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
      this.lbError.Text = "";
      Graphics graphics = Graphics.FromHwnd(this.Handle);
      graphics.Clear(Color.Beige);
      Point point = new Point(this.xMouseRectangle, this.yMouseRectangle);
      this.reduccionX = this.xMouse - this.xMouseRectangle;
      this.reduccionY = this.yMouse - this.yMouseRectangle;
      graphics.DrawRectangle(new Pen(Color.Red), point.X, point.Y, this.reduccionX, this.reduccionY);
      this.numIniX.Value = (Decimal) this.xMouseRectangle;
      this.numIniY.Value = (Decimal) this.yMouseRectangle;
      try
      {
        this.numFinX.Value = (Decimal) Screen.PrimaryScreen.Bounds.Width - (this.numIniX.Value + (Decimal) this.reduccionX);
        this.numFinY.Value = (Decimal) Screen.PrimaryScreen.Bounds.Height - (this.numIniY.Value + (Decimal) this.reduccionY);
        if (!this.checkBox1.Checked && !this.checkBox2.Checked && !this.checkBox3.Checked)
        {
          this.rvp.AuxNumIniX = Decimal.ToInt32(this.numIniX.Value);
          this.rvp.AuxNumFinX = Decimal.ToInt32(this.numFinX.Value);
          this.rvp.AuxNumIniY = Decimal.ToInt32(this.numIniY.Value);
          this.rvp.AuxNumFinY = Decimal.ToInt32(this.numFinY.Value);
        }
        if (this.checkBox1.Checked && !this.checkBox2.Checked && !this.checkBox3.Checked)
        {
          this.rvp.AuxTopNumIniX = Decimal.ToInt32(this.numIniX.Value);
          this.rvp.AuxTopNumFinX = Decimal.ToInt32(this.numFinX.Value);
          this.rvp.AuxTopNumIniY = Decimal.ToInt32(this.numIniY.Value);
          this.rvp.AuxTopNumFinY = Decimal.ToInt32(this.numFinY.Value);
        }
        if (!this.checkBox1.Checked && this.checkBox2.Checked && !this.checkBox3.Checked)
        {
          this.rvp.AuxCenNumIniX = Decimal.ToInt32(this.numIniX.Value);
          this.rvp.AuxCenNumFinX = Decimal.ToInt32(this.numFinX.Value);
          this.rvp.AuxCenNumIniY = Decimal.ToInt32(this.numIniY.Value);
          this.rvp.AuxCenNumFinY = Decimal.ToInt32(this.numFinY.Value);
        }
        if (this.checkBox1.Checked || this.checkBox2.Checked || !this.checkBox3.Checked)
          return;
        this.rvp.AuxDowNumIniX = Decimal.ToInt32(this.numIniX.Value);
        this.rvp.AuxDowNumFinX = Decimal.ToInt32(this.numFinX.Value);
        this.rvp.AuxDowNumIniY = Decimal.ToInt32(this.numIniY.Value);
        this.rvp.AuxDowNumFinY = Decimal.ToInt32(this.numFinY.Value);
      }
      catch (Exception ex)
      {
        this.lbError.Text = "Error  LEFT ---> to RIGHT GOOD  , RIGHT <----- to LEFT BAD ";
      }
    }

    private void checkOnlyTradu_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkOnlyTradu.Checked)
      {
        this.panel1.Visible = false;
        this.ClientSize = new Size(600, 307);
        Console.WriteLine("Casilla pequeña");
        Console.WriteLine("Dime tamaño panel 1: " + (object) this.panel1.Location);
        Console.WriteLine("Dime tamaño panel 2: " + (object) this.panel2.Location);
        Panel panel2 = this.panel2;
        Point location = this.panel1.Location;
        Point point1 = new Point(location.X, 0);
        panel2.Location = point1;
        this.AutoScroll = false;
        this.webBrowser1.Location = new Point(-450, -70);
        CheckBox checkOnlyTradu1 = this.checkOnlyTradu;
        location = this.webBrowser1.Location;
        Point point2 = new Point(location.X + 350);
        checkOnlyTradu1.Location = point2;
        CheckBox checkOnlyTradu2 = this.checkOnlyTradu;
        location = this.webBrowser1.Location;
        Point point3 = new Point(location.Y + 280);
        checkOnlyTradu2.Location = point3;
        Label indicador = this.indicador;
        location = this.checkOnlyTradu.Location;
        Point point4 = new Point(location.X + 300);
        indicador.Location = point4;
        this.textBoxTextoTraducidoExcel.Focus();
      }
      if (this.checkOnlyTradu.Checked)
        return;
      Console.WriteLine("Casilla normal");
      Console.WriteLine("Dime tamaño panel 1: " + (object) this.panel1.Location);
      Console.WriteLine("Dime tamaño panel 2: " + (object) this.panel2.Location);
      this.ClientSize = new Size(1800, 307);
      this.panel1.Visible = true;
      this.panel2.Location = new Point(600, 0);
      this.webBrowser1.Location = new Point(0, 0);
      this.textBoxTextoTraducidoExcel.Focus();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e) => this.ActiveControl = (Control) this.textBoxTextoTraducidoExcel;

    private void label11_Click(object sender, EventArgs e)
    {
    }

    private void linkDonate(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://paypal.me/ReidloGames?locale.x=es_ES");

    private void checkBoxExcelTranslate_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBoxExcelTranslate.Checked)
        this.textBoxTextoTraducidoExcel.Visible = true;
      else
        this.textBoxTextoTraducidoExcel.Visible = false;
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
    }

    private void EntraPanel(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Maximized)
      {
        this.panel1.Visible = false;
        this.panel2.Visible = false;
        this.textBoxTextoTraducidoExcel.Focus();
      }
      else
      {
        if (!this.checkOnlyTradu.Checked)
          this.panel1.Visible = true;
        this.panel2.Visible = true;
        this.textBoxTextoTraducidoExcel.Focus();
      }
    }
        /*
    public void Joystick2()
    {
      Guid deviceGuid = Guid.Empty;
      SharpDX.DirectInput.DirectInput directInput = new SharpDX.DirectInput.DirectInput();
      foreach (DeviceInstance device in (IEnumerable<DeviceInstance>) directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
        deviceGuid = device.InstanceGuid;
      if (deviceGuid == Guid.Empty)
      {
        foreach (DeviceInstance device in (IEnumerable<DeviceInstance>) directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
        {
          Guid instanceGuid = device.InstanceGuid;
        }
        try
        {
        }
        catch (Exception ex)
        {
          Control.CheckForIllegalCrossThreadCalls = false;
          this.lbError.Text = "Gamepad disconnected";
        }
      }
      else
      {
        if (!(deviceGuid != Guid.Empty))
          return;
        this.joystick = new Joystick(directInput, deviceGuid);
        foreach (EffectInfo effect in (IEnumerable<EffectInfo>) this.joystick.GetEffects())
          Console.WriteLine("Effect available {0}", (object) effect.Name);
        this.joystick.Properties.BufferSize = 128;
        this.joystick.Acquire();
        this.cont = 0;
        if (deviceGuid != Guid.Empty)
        {
          while (this.entryBucleGamepad && deviceGuid != Guid.Empty)
          {
            try
            {
              Thread.Sleep(200);
              this.joystick.Poll();
              foreach (JoystickUpdate joystickUpdate in this.joystick.GetBufferedData())
              {
                Control.CheckForIllegalCrossThreadCalls = false;
                if (this.comboBox3.Text == "Select Ps4")
                {
                  if (joystickUpdate.Offset == JoystickOffset.Buttons8)
                  {
                    if (joystickUpdate.Value == 0)
                    {
                      Console.WriteLine("Valor " + (object) joystickUpdate.Value);
                      Control.CheckForIllegalCrossThreadCalls = true;
                      this.pulsoboton = true;
                      this.Empezamos();
                      this.entryBucleGamepad = false;
                    }
                    this.pulsoboton = false;
                  }
                }
                else if (this.comboBox3.Text == "Touchpad Ps4")
                {
                  if (joystickUpdate.Offset == JoystickOffset.Buttons13)
                  {
                    if (joystickUpdate.Value == 0)
                    {
                      Console.WriteLine("Valor " + (object) joystickUpdate.Value);
                      Control.CheckForIllegalCrossThreadCalls = true;
                      this.pulsoboton = true;
                      this.Empezamos();
                      this.entryBucleGamepad = false;
                    }
                    this.pulsoboton = false;
                  }
                }
                else if (this.comboBox3.Text == "Home Ps4")
                {
                  if (joystickUpdate.Offset == JoystickOffset.Buttons1)
                  {
                    if (joystickUpdate.Value == 0)
                    {
                      Console.WriteLine("Valor " + (object) joystickUpdate.Value);
                      Control.CheckForIllegalCrossThreadCalls = true;
                      this.pulsoboton = true;
                      this.Empezamos();
                      this.entryBucleGamepad = false;
                    }
                    this.pulsoboton = false;
                  }
                }
                else if (this.comboBox3.Text == "X Ps4")
                {
                  IList<DeviceInstance> deviceInstanceList = (IList<DeviceInstance>) new List<DeviceInstance>();
                  foreach (DeviceInstance device in (IEnumerable<DeviceInstance>) directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                    deviceInstanceList.Add(device);
                  if (joystickUpdate.Offset == JoystickOffset.Buttons1)
                  {
                    if (joystickUpdate.Value == 0)
                    {
                      Console.WriteLine("Valor " + (object) joystickUpdate.Value);
                      Control.CheckForIllegalCrossThreadCalls = true;
                      this.pulsoboton = true;
                      this.Empezamos();
                      this.entryBucleGamepad = false;
                    }
                    this.pulsoboton = false;
                  }
                }
                else if (this.comboBox3.Text == "Select Xbox360")
                {
                  IList<DeviceInstance> deviceInstanceList = (IList<DeviceInstance>) new List<DeviceInstance>();
                  foreach (DeviceInstance device in (IEnumerable<DeviceInstance>) directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                    deviceInstanceList.Add(device);
                  if (joystickUpdate.Offset == JoystickOffset.Buttons6)
                  {
                    if (joystickUpdate.Value == 0)
                    {
                      Console.WriteLine("Valor " + (object) joystickUpdate.Value);
                      Control.CheckForIllegalCrossThreadCalls = true;
                      this.pulsoboton = true;
                      this.Empezamos();
                      this.entryBucleGamepad = false;
                    }
                    this.pulsoboton = false;
                  }
                }
                if (joystickUpdate.Value == 0)
                  Console.WriteLine((object) joystickUpdate);
                if (this.comboBox4.Text == "L3 Ps4")
                {
                  if (joystickUpdate.Offset == JoystickOffset.Buttons10)
                  {
                    Control.CheckForIllegalCrossThreadCalls = true;
                    if (joystickUpdate.Value == 0)
                    {
                      ++this.cont;
                      if (this.cont == 1)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 2)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 3)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 4)
                      {
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                        this.cont = 0;
                      }
                    }
                  }
                }
                else if (this.comboBox4.Text == "R3 Ps4")
                {
                  if (joystickUpdate.Offset == JoystickOffset.Buttons11)
                  {
                    Control.CheckForIllegalCrossThreadCalls = true;
                    if (joystickUpdate.Value == 0)
                    {
                      ++this.cont;
                      if (this.cont == 1)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 2)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 3)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 4)
                      {
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                        this.cont = 0;
                      }
                    }
                  }
                }
                else if (this.comboBox4.Text == "D-Pad Up Ps4")
                {
                  if (joystickUpdate.Offset == JoystickOffset.PointOfViewControllers0)
                  {
                    Control.CheckForIllegalCrossThreadCalls = true;
                    if (joystickUpdate.Value == 0)
                    {
                      ++this.cont;
                      if (this.cont == 1)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 2)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 3)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 4)
                      {
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                        this.cont = 0;
                      }
                    }
                  }
                }
                else if (this.comboBox4.Text == "TouchPad Ps4")
                {
                  if (joystickUpdate.Offset == JoystickOffset.Buttons13)
                  {
                    Control.CheckForIllegalCrossThreadCalls = true;
                    if (joystickUpdate.Value == 0)
                    {
                      ++this.cont;
                      if (this.cont == 1)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 2)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 3)
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      else if (this.cont == 4)
                      {
                        this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                        this.cont = 0;
                      }
                    }
                  }
                }
                else if (this.comboBox4.Text == "D-Pad Up 360" && joystickUpdate.Offset == JoystickOffset.PointOfViewControllers0)
                {
                  Control.CheckForIllegalCrossThreadCalls = true;
                  if (joystickUpdate.Value == 0)
                  {
                    ++this.cont;
                    if (this.cont == 1)
                      this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                    else if (this.cont == 2)
                      this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                    else if (this.cont == 3)
                      this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                    else if (this.cont == 4)
                    {
                      this.checkBoxTodos_CheckStateChanged((object) this.cont, (EventArgs) null);
                      this.cont = 0;
                    }
                  }
                }
                this.entryBucleGamepad = true;
              }
            }
            catch (Exception ex)
            {
              this.lbError.Text = "GAMEPAD OFF ";
              this.Joystick2();
            }
          }
        }
        else
        {
          this.lbError.Text = "GAMEPAD OFF ";
          this.Joystick2();
        }
      }
    }
        */
    public static TripleDES CrearDES(string clave)
    {
      MD5 md5 = (MD5) new MD5CryptoServiceProvider();
      TripleDES tripleDes = (TripleDES) new TripleDESCryptoServiceProvider();
      tripleDes.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(clave));
      tripleDes.IV = new byte[tripleDes.BlockSize / 8];
      return tripleDes;
    }

    private void checkBoxTodos_CheckStateChanged(object sender, EventArgs e)
    {
      Control.CheckForIllegalCrossThreadCalls = false;
      if (sender.Equals((object) 1))
      {
        this.checkBox1.Checked = true;
        this.checkBox2.Checked = false;
        this.checkBox3.Checked = false;
        this.almacenCoordenadadas = false;
      }
      else if (sender.Equals((object) 2))
      {
        this.checkBox1.Checked = false;
        this.checkBox2.Checked = true;
        this.checkBox3.Checked = false;
        this.almacenCoordenadadas = false;
      }
      else if (sender.Equals((object) 3))
      {
        this.checkBox1.Checked = false;
        this.checkBox2.Checked = false;
        this.checkBox3.Checked = true;
        this.almacenCoordenadadas = false;
      }
      else if (sender.Equals((object) 4))
      {
        this.checkBox1.Checked = false;
        this.checkBox2.Checked = false;
        this.checkBox3.Checked = false;
        this.almacenCoordenadadas = true;
      }
      if (this.checkBox1.Checked)
      {
        Console.WriteLine("chek 1 seleccionado");
        Console.WriteLine("chek 1 :" + (object) this.rvp.AuxTopNumIniX);
        this.indicador.Text = "Top";
        this.numIniX.Value = (Decimal) this.rvp.AuxTopNumIniX;
        this.numFinX.Value = (Decimal) this.rvp.AuxTopNumFinX;
        this.numIniY.Value = (Decimal) this.rvp.AuxTopNumIniY;
        this.numFinY.Value = (Decimal) this.rvp.AuxTopNumFinY;
        Console.WriteLine("PRUEBA getter: " + (object) this.rvp.AuxTopNumFinX);
      }
      if (this.checkBox2.Checked)
      {
        Console.WriteLine("chek 2 seleccionado");
        this.indicador.Text = "Center";
        this.numIniX.Value = (Decimal) this.rvp.AuxCenNumIniX;
        this.numFinX.Value = (Decimal) this.rvp.AuxCenNumFinX;
        this.numIniY.Value = (Decimal) this.rvp.AuxCenNumIniY;
        this.numFinY.Value = (Decimal) this.rvp.AuxCenNumFinY;
      }
      if (this.checkBox3.Checked)
      {
        Console.WriteLine("chek 3 seleccionado");
        this.indicador.Text = "Down";
        this.numIniX.Value = (Decimal) this.rvp.AuxDowNumIniX;
        this.numFinX.Value = (Decimal) this.rvp.AuxDowNumFinX;
        this.numIniY.Value = (Decimal) this.rvp.AuxDowNumIniY;
        this.numFinY.Value = (Decimal) this.rvp.AuxDowNumFinY;
      }
      if (this.checkBox1.Checked || this.checkBox2.Checked || this.checkBox3.Checked)
        return;
      Console.WriteLine("chek 0 seleccionados");
      this.indicador.Text = "null";
      this.numIniX.Value = (Decimal) this.rvp.AuxNumIniX;
      this.numFinX.Value = (Decimal) this.rvp.AuxNumFinX;
      this.numIniY.Value = (Decimal) this.rvp.AuxNumIniY;
      this.numFinY.Value = (Decimal) this.rvp.AuxNumFinY;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.checkBox1.Checked)
        return;
      this.checkBox2.Checked = false;
      this.checkBox3.Checked = false;
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.checkBox2.Checked)
        return;
      this.checkBox1.Checked = false;
      this.checkBox3.Checked = false;
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.checkBox3.Checked)
        return;
      this.checkBox1.Checked = false;
      this.checkBox2.Checked = false;
    }

    private string ParseText(string tesseractPath, byte[] imageFile, params string[] lang)
    {
      string text = string.Empty;
      string str = Path.GetTempPath() + (object) Guid.NewGuid();
      string tempFileName = Path.GetTempFileName();
      try
      {
        File.WriteAllBytes(tempFileName, imageFile);
        Process process = Process.Start(new ProcessStartInfo()
        {
          WorkingDirectory = tesseractPath,
          WindowStyle = ProcessWindowStyle.Hidden,
          UseShellExecute = true,
          FileName = "cmd.exe",
          Arguments = "/c tesseract.exe " + tempFileName + " " + str + " -l " + string.Join("+", lang)
        });
        process.WaitForExit();
        if (process.ExitCode == 0)
          text = File.ReadAllText(str + ".txt");
      }
      catch (Exception ex)
      {
        this.lbError.Text = "Error reconocimento de imagen ";
      }
      finally
      {
        File.Delete(str + ".txt");
      }
      return text;
    }

    public void excelFansub()
    {
      string str1 = this.textBoxFs.Text;
      if (str1.Equals(""))
        str1 = "excel";
      try
      {
        if (!Directory.Exists("C:\\Fansub GamesTraductions"))
          Directory.CreateDirectory("C:\\Fansub GamesTraductions");
      }
      catch (IOException ex)
      {
        this.lbError.Text = ex.Message;
      }
      DateTime now = DateTime.Now;
      string contents = "";
      string path = "C:\\Fansub GamesTraductions\\" + str1 + "_" + this.inLeng + ".txt";
      if (!File.Exists(path))
        File.WriteAllText(path, contents);
      if (File.Exists(path))
      {
        this.textExcel = this.textExcel.Replace("\n", " ");
        string str2 = this.textExcel.Trim();
        bool flag = false;
        using (StreamReader streamReader = File.OpenText(path))
        {
          string str3;
          while ((str3 = streamReader.ReadLine()) != null)
          {
            if (str3.Equals(str2))
            {
              Console.WriteLine("\nEL TEXTO EXISTE no se copia");
              flag = true;
            }
          }
        }
        if (!flag)
        {
          using (StreamWriter streamWriter = new StreamWriter(path, true))
          {
            string str4 = str2;
            Console.WriteLine("Linea en blanco");
            Console.WriteLine(str4);
            if (!str4.Equals(""))
            {
              streamWriter.WriteLine(str4);
              this.textBoxTextoTraducidoExcel.Focus();
            }
            streamWriter.Close();
            this.textBoxTextoTraducidoExcel.Focus();
          }
        }
      }
      this.textBoxTextoTraducidoExcel.Focus();
    }

    public Image CambiarTamanoImagen(Image pImagen, int pAncho, int pAlto)
    {
      Bitmap bitmap = new Bitmap(pAncho, pAlto);
      using (Graphics graphics = Graphics.FromImage((Image) bitmap))
      {
        graphics.SmoothingMode = SmoothingMode.HighQuality;
        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.DrawImage(pImagen, 0, 0, pAncho, pAlto);
      }
      return (Image) bitmap;
    }

    private static void WaitSeconds(double nSecs)
    {
      DateTime dateTime = DateTime.Now.Add(TimeSpan.Parse("0.00:00:" + nSecs.ToString().Replace(",", ".")));
      for (DateTime now = DateTime.Now; now < dateTime; now = DateTime.Now)
        Application.DoEvents();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.button1 = new System.Windows.Forms.Button();
            this.labAncho = new System.Windows.Forms.Label();
            this.labAlto = new System.Windows.Forms.Label();
            this.lblInix = new System.Windows.Forms.Label();
            this.lblFinX = new System.Windows.Forms.Label();
            this.numIniX = new System.Windows.Forms.NumericUpDown();
            this.numFinX = new System.Windows.Forms.NumericUpDown();
            this.numFinY = new System.Windows.Forms.NumericUpDown();
            this.numIniY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxExcelTranslate = new System.Windows.Forms.CheckBox();
            this.textBoxExcelName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButAnime = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpBinario = new System.Windows.Forms.NumericUpDown();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBoxSeg = new System.Windows.Forms.ComboBox();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.textBoxFs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cbViewTraductor = new System.Windows.Forms.CheckBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.numericDownYfin = new System.Windows.Forms.NumericUpDown();
            this.numericDownYpri = new System.Windows.Forms.NumericUpDown();
            this.numericCenterYfin = new System.Windows.Forms.NumericUpDown();
            this.numericCenterYpri = new System.Windows.Forms.NumericUpDown();
            this.numericTopYfin = new System.Windows.Forms.NumericUpDown();
            this.numericTopYpri = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_ip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numOpaci = new System.Windows.Forms.NumericUpDown();
            this.labOpaci = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.indicador = new System.Windows.Forms.Label();
            this.checkOnlyTradu = new System.Windows.Forms.CheckBox();
            this.textBoxTextoTraducidoExcel = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numIniX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIniY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDownYfin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDownYpri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCenterYfin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCenterYpri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTopYfin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTopYpri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpaci)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Captured Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapturedKeys);
            // 
            // labAncho
            // 
            this.labAncho.AutoSize = true;
            this.labAncho.Location = new System.Drawing.Point(161, 50);
            this.labAncho.Name = "labAncho";
            this.labAncho.Size = new System.Drawing.Size(41, 13);
            this.labAncho.TabIndex = 4;
            this.labAncho.Text = "Ancho:";
            // 
            // labAlto
            // 
            this.labAlto.AutoSize = true;
            this.labAlto.Location = new System.Drawing.Point(161, 64);
            this.labAlto.Name = "labAlto";
            this.labAlto.Size = new System.Drawing.Size(35, 13);
            this.labAlto.TabIndex = 5;
            this.labAlto.Text = "label1";
            // 
            // lblInix
            // 
            this.lblInix.AutoSize = true;
            this.lblInix.Location = new System.Drawing.Point(12, 50);
            this.lblInix.Name = "lblInix";
            this.lblInix.Size = new System.Drawing.Size(90, 13);
            this.lblInix.TabIndex = 6;
            this.lblInix.Text = "Posicion Inicial X:";
            this.lblInix.Visible = false;
            // 
            // lblFinX
            // 
            this.lblFinX.AutoSize = true;
            this.lblFinX.Location = new System.Drawing.Point(12, 78);
            this.lblFinX.Name = "lblFinX";
            this.lblFinX.Size = new System.Drawing.Size(85, 13);
            this.lblFinX.TabIndex = 7;
            this.lblFinX.Text = "Posicion Final X:";
            this.lblFinX.Visible = false;
            // 
            // numIniX
            // 
            this.numIniX.Location = new System.Drawing.Point(108, 48);
            this.numIniX.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numIniX.Name = "numIniX";
            this.numIniX.Size = new System.Drawing.Size(62, 20);
            this.numIniX.TabIndex = 8;
            this.numIniX.Visible = false;
            // 
            // numFinX
            // 
            this.numFinX.Location = new System.Drawing.Point(108, 76);
            this.numFinX.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numFinX.Name = "numFinX";
            this.numFinX.Size = new System.Drawing.Size(62, 20);
            this.numFinX.TabIndex = 9;
            this.numFinX.Visible = false;
            // 
            // numFinY
            // 
            this.numFinY.Location = new System.Drawing.Point(108, 134);
            this.numFinY.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numFinY.Name = "numFinY";
            this.numFinY.Size = new System.Drawing.Size(62, 20);
            this.numFinY.TabIndex = 13;
            this.numFinY.Visible = false;
            // 
            // numIniY
            // 
            this.numIniY.Location = new System.Drawing.Point(108, 107);
            this.numIniY.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numIniY.Name = "numIniY";
            this.numIniY.Size = new System.Drawing.Size(62, 20);
            this.numIniY.TabIndex = 12;
            this.numIniY.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Posicion Final Y:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Posicion Inicial Y:";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(401, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.checkBoxExcelTranslate);
            this.panel1.Controls.Add(this.textBoxExcelName);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.radioButAnime);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.numericUpBinario);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBoxSeg);
            this.panel1.Controls.Add(this.checkBoxAuto);
            this.panel1.Controls.Add(this.textBoxFs);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.cbViewTraductor);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.numericDownYfin);
            this.panel1.Controls.Add(this.numericDownYpri);
            this.panel1.Controls.Add(this.numericCenterYfin);
            this.panel1.Controls.Add(this.numericCenterYpri);
            this.panel1.Controls.Add(this.numericTopYfin);
            this.panel1.Controls.Add(this.numericTopYpri);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Controls.Add(this.numPort);
            this.panel1.Controls.Add(this.text_ip);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lab_ip);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numOpaci);
            this.panel1.Controls.Add(this.labOpaci);
            this.panel1.Controls.Add(this.numIniX);
            this.panel1.Controls.Add(this.labAncho);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labAlto);
            this.panel1.Controls.Add(this.numFinY);
            this.panel1.Controls.Add(this.lblInix);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numIniY);
            this.panel1.Controls.Add(this.lblFinX);
            this.panel1.Controls.Add(this.numFinX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-153, 2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(601, 311);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.EntraPanel);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(161, 275);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(125, 17);
            this.linkLabel2.TabIndex = 70;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Donate , thanks  :)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonate);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(201, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Key Down y number 0 ";
            // 
            // checkBoxExcelTranslate
            // 
            this.checkBoxExcelTranslate.AutoSize = true;
            this.checkBoxExcelTranslate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxExcelTranslate.Location = new System.Drawing.Point(270, 209);
            this.checkBoxExcelTranslate.Name = "checkBoxExcelTranslate";
            this.checkBoxExcelTranslate.Size = new System.Drawing.Size(99, 17);
            this.checkBoxExcelTranslate.TabIndex = 68;
            this.checkBoxExcelTranslate.Text = "Excel Translate";
            this.checkBoxExcelTranslate.UseVisualStyleBackColor = false;
            this.checkBoxExcelTranslate.Visible = false;
            this.checkBoxExcelTranslate.CheckedChanged += new System.EventHandler(this.checkBoxExcelTranslate_CheckedChanged);
            // 
            // textBoxExcelName
            // 
            this.textBoxExcelName.AccessibleDescription = "Name File";
            this.textBoxExcelName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxExcelName.Location = new System.Drawing.Point(164, 202);
            this.textBoxExcelName.MaxLength = 20;
            this.textBoxExcelName.Name = "textBoxExcelName";
            this.textBoxExcelName.Size = new System.Drawing.Size(100, 20);
            this.textBoxExcelName.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(181, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "File Excel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "(Only Anime, Films)";
            // 
            // radioButAnime
            // 
            this.radioButAnime.AutoSize = true;
            this.radioButAnime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.radioButAnime.Location = new System.Drawing.Point(288, 2);
            this.radioButAnime.Name = "radioButAnime";
            this.radioButAnime.Size = new System.Drawing.Size(123, 17);
            this.radioButAnime.TabIndex = 64;
            this.radioButAnime.TabStop = true;
            this.radioButAnime.Text = "Anime/Films/Games:";
            this.radioButAnime.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label14.Location = new System.Drawing.Point(430, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "Games: 130 -180";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label13.Location = new System.Drawing.Point(430, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Anime/Films: 240 - 247";
            // 
            // numericUpBinario
            // 
            this.numericUpBinario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numericUpBinario.Location = new System.Drawing.Point(412, 1);
            this.numericUpBinario.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.numericUpBinario.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpBinario.Name = "numericUpBinario";
            this.numericUpBinario.Size = new System.Drawing.Size(55, 20);
            this.numericUpBinario.TabIndex = 61;
            this.numericUpBinario.Value = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numericUpBinario.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownWidth = 62;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.ItemHeight = 12;
            this.comboBox4.Location = new System.Drawing.Point(498, 93);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(75, 20);
            this.comboBox4.TabIndex = 58;
            this.comboBox4.Text = "L3 Ps4";
            // 
            // comboBoxSeg
            // 
            this.comboBoxSeg.DropDownWidth = 62;
            this.comboBoxSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeg.FormattingEnabled = true;
            this.comboBoxSeg.IntegralHeight = false;
            this.comboBoxSeg.ItemHeight = 12;
            this.comboBoxSeg.Location = new System.Drawing.Point(363, 228);
            this.comboBoxSeg.Name = "comboBoxSeg";
            this.comboBoxSeg.Size = new System.Drawing.Size(39, 20);
            this.comboBoxSeg.TabIndex = 57;
            this.comboBoxSeg.Text = "0,8";
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(270, 233);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(95, 17);
            this.checkBoxAuto.TabIndex = 56;
            this.checkBoxAuto.Text = "Auto Translate";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            // 
            // textBoxFs
            // 
            this.textBoxFs.Location = new System.Drawing.Point(164, 161);
            this.textBoxFs.MaxLength = 20;
            this.textBoxFs.Name = "textBoxFs";
            this.textBoxFs.Size = new System.Drawing.Size(100, 20);
            this.textBoxFs.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(185, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "FanSub:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Button Profiles:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(207, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Button Translate:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownWidth = 62;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.ItemHeight = 12;
            this.comboBox3.Location = new System.Drawing.Point(316, 96);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(75, 20);
            this.comboBox3.TabIndex = 51;
            this.comboBox3.Text = "Select Ps4";
            // 
            // cbViewTraductor
            // 
            this.cbViewTraductor.AutoSize = true;
            this.cbViewTraductor.Checked = true;
            this.cbViewTraductor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbViewTraductor.Location = new System.Drawing.Point(305, 185);
            this.cbViewTraductor.Name = "cbViewTraductor";
            this.cbViewTraductor.Size = new System.Drawing.Size(95, 17);
            this.cbViewTraductor.TabIndex = 50;
            this.cbViewTraductor.Text = "TraductorView";
            this.cbViewTraductor.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(350, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 17);
            this.radioButton3.TabIndex = 49;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "White-Black";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericDownYfin
            // 
            this.numericDownYfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDownYfin.Location = new System.Drawing.Point(528, 104);
            this.numericDownYfin.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericDownYfin.Name = "numericDownYfin";
            this.numericDownYfin.Size = new System.Drawing.Size(47, 18);
            this.numericDownYfin.TabIndex = 48;
            this.numericDownYfin.Value = new decimal(new int[] {
            324,
            0,
            0,
            0});
            this.numericDownYfin.Visible = false;
            // 
            // numericDownYpri
            // 
            this.numericDownYpri.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDownYpri.Location = new System.Drawing.Point(528, 85);
            this.numericDownYpri.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericDownYpri.Name = "numericDownYpri";
            this.numericDownYpri.Size = new System.Drawing.Size(47, 18);
            this.numericDownYpri.TabIndex = 47;
            this.numericDownYpri.Value = new decimal(new int[] {
            464,
            0,
            0,
            0});
            this.numericDownYpri.Visible = false;
            // 
            // numericCenterYfin
            // 
            this.numericCenterYfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCenterYfin.Location = new System.Drawing.Point(528, 64);
            this.numericCenterYfin.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericCenterYfin.Name = "numericCenterYfin";
            this.numericCenterYfin.Size = new System.Drawing.Size(47, 18);
            this.numericCenterYfin.TabIndex = 46;
            this.numericCenterYfin.Value = new decimal(new int[] {
            223,
            0,
            0,
            0});
            this.numericCenterYfin.Visible = false;
            // 
            // numericCenterYpri
            // 
            this.numericCenterYpri.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCenterYpri.Location = new System.Drawing.Point(528, 46);
            this.numericCenterYpri.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericCenterYpri.Name = "numericCenterYpri";
            this.numericCenterYpri.Size = new System.Drawing.Size(47, 18);
            this.numericCenterYpri.TabIndex = 45;
            this.numericCenterYpri.Value = new decimal(new int[] {
            244,
            0,
            0,
            0});
            this.numericCenterYpri.Visible = false;
            // 
            // numericTopYfin
            // 
            this.numericTopYfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTopYfin.Location = new System.Drawing.Point(528, 24);
            this.numericTopYfin.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericTopYfin.Name = "numericTopYfin";
            this.numericTopYfin.Size = new System.Drawing.Size(47, 18);
            this.numericTopYfin.TabIndex = 44;
            this.numericTopYfin.Value = new decimal(new int[] {
            616,
            0,
            0,
            0});
            this.numericTopYfin.Visible = false;
            // 
            // numericTopYpri
            // 
            this.numericTopYpri.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTopYpri.Location = new System.Drawing.Point(528, 7);
            this.numericTopYpri.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericTopYpri.Name = "numericTopYpri";
            this.numericTopYpri.Size = new System.Drawing.Size(47, 18);
            this.numericTopYpri.TabIndex = 43;
            this.numericTopYpri.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericTopYpri.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(418, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 13);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.GamesTraductions.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(477, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Profiles:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(475, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 37;
            this.checkBox3.Text = "Down";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBoxTodos_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(475, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "Center";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBoxTodos_CheckStateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(475, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Click += new System.EventHandler(this.checkBoxTodos_CheckStateChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(350, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "GrayScale";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(350, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "PosY:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "PosX:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(202, 22);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(13, 13);
            this.labelY.TabIndex = 29;
            this.labelY.Text = "0";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(202, 8);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(13, 13);
            this.labelX.TabIndex = 28;
            this.labelX.Text = "0";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(70, 263);
            this.numPort.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(62, 20);
            this.numPort.TabIndex = 27;
            this.numPort.Visible = false;
            // 
            // text_ip
            // 
            this.text_ip.Location = new System.Drawing.Point(70, 240);
            this.text_ip.MaxLength = 16;
            this.text_ip.Name = "text_ip";
            this.text_ip.Size = new System.Drawing.Size(100, 20);
            this.text_ip.TabIndex = 26;
            this.text_ip.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Puerto:";
            this.label5.Visible = false;
            // 
            // lab_ip
            // 
            this.lab_ip.AutoSize = true;
            this.lab_ip.Location = new System.Drawing.Point(22, 237);
            this.lab_ip.Name = "lab_ip";
            this.lab_ip.Size = new System.Drawing.Size(20, 13);
            this.lab_ip.TabIndex = 24;
            this.lab_ip.Text = "IP:";
            this.lab_ip.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(277, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Out:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "In:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(304, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.Text = "Español";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Ingles";
            // 
            // numOpaci
            // 
            this.numOpaci.Location = new System.Drawing.Point(224, 240);
            this.numOpaci.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOpaci.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOpaci.Name = "numOpaci";
            this.numOpaci.Size = new System.Drawing.Size(40, 20);
            this.numOpaci.TabIndex = 18;
            this.numOpaci.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numOpaci.Click += new System.EventHandler(this.OpacityChange);
            // 
            // labOpaci
            // 
            this.labOpaci.AutoSize = true;
            this.labOpaci.Location = new System.Drawing.Point(172, 243);
            this.labOpaci.Name = "labOpaci";
            this.labOpaci.Size = new System.Drawing.Size(46, 13);
            this.labOpaci.TabIndex = 17;
            this.labOpaci.Text = "Opacity:";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Crimson;
            this.lbError.Location = new System.Drawing.Point(234, 1);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 42;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(12, -18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1252, 328);
            this.webBrowser1.TabIndex = 19456;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // indicador
            // 
            this.indicador.AutoSize = true;
            this.indicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicador.Location = new System.Drawing.Point(1105, 62);
            this.indicador.Name = "indicador";
            this.indicador.Size = new System.Drawing.Size(30, 17);
            this.indicador.TabIndex = 59;
            this.indicador.Text = "null";
            // 
            // checkOnlyTradu
            // 
            this.checkOnlyTradu.AutoSize = true;
            this.checkOnlyTradu.BackColor = System.Drawing.Color.Transparent;
            this.checkOnlyTradu.Location = new System.Drawing.Point(978, 63);
            this.checkOnlyTradu.Name = "checkOnlyTradu";
            this.checkOnlyTradu.Size = new System.Drawing.Size(121, 17);
            this.checkOnlyTradu.TabIndex = 59;
            this.checkOnlyTradu.Text = "View only traduction";
            this.checkOnlyTradu.UseVisualStyleBackColor = false;
            this.checkOnlyTradu.CheckedChanged += new System.EventHandler(this.checkOnlyTradu_CheckedChanged);
            // 
            // textBoxTextoTraducidoExcel
            // 
            this.textBoxTextoTraducidoExcel.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTextoTraducidoExcel.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.textBoxTextoTraducidoExcel.Location = new System.Drawing.Point(12, 17);
            this.textBoxTextoTraducidoExcel.Multiline = true;
            this.textBoxTextoTraducidoExcel.Name = "textBoxTextoTraducidoExcel";
            this.textBoxTextoTraducidoExcel.Size = new System.Drawing.Size(584, 91);
            this.textBoxTextoTraducidoExcel.TabIndex = 60;
            this.textBoxTextoTraducidoExcel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxTextoTraducidoExcel);
            this.panel2.Controls.Add(this.checkOnlyTradu);
            this.panel2.Controls.Add(this.indicador);
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.lbError);
            this.panel2.Location = new System.Drawing.Point(454, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1269, 310);
            this.panel2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1762, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 39);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "GamesTraductions 4.1";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormExit);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.EntraPanel);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapturedKeys);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numIniX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIniY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDownYfin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDownYpri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCenterYfin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCenterYpri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTopYfin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTopYpri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpaci)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }
  }
}
