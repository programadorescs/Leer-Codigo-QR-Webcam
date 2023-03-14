using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace GenerarLeerQrWebcam
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    FilterInfoCollection filterInfoCollection;
    VideoCaptureDevice videoCaptureDevice;

    private void Form1_Load(object sender, EventArgs e)
    {
      filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

      foreach (FilterInfo item in filterInfoCollection)
        cbCamara.Items.Add(item.Name);

      cbCamara.SelectedIndex = 0;
    }

    private void btnIniciar_Click(object sender, EventArgs e)
    {
      videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamara.SelectedIndex].MonikerString);
      videoCaptureDevice.NewFrame += CaptureDevice_NewFrame;
      videoCaptureDevice.Start();

      timer1.Start();
    }

    private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
    {
      pbImagen.Image = (Bitmap)eventArgs.Frame.Clone();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (videoCaptureDevice.IsRunning)
        videoCaptureDevice.Stop();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (pbImagen.Image != null)
      {
        var bc = new BarcodeReader();
        var rs = bc.Decode((Bitmap)pbImagen.Image);

        if (rs != null)
        {
          txtTexto.Text = rs.ToString();
          timer1.Stop();

          if (videoCaptureDevice.IsRunning)
            videoCaptureDevice.Stop();
        }
      }
    }
  }
}
