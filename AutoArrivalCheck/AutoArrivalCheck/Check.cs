using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//カメラいんぽーと
using OpenCvSharp;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Windows.Devices.PointOfService;
using Windows.Media.Capture;

namespace AutoArrivalCheck
{
    public partial class Check : Form
    {
        VideoCapture VideoCapture;
        Graphics Graphics;
        Mat Mat;
        public Check()
        {
            InitializeComponent();
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            exitmenu exitmenu = new exitmenu();
            exitmenu.Show();
        }

        private void Check_Load(object sender, EventArgs e)
        {
            VideoCapture = new VideoCapture(0);
            if (VideoCapture != null)
            {
                MessageBox.Show("カメラがありません！！");
                Close();
            }
            else
            {
                Graphics = cameraPic.CreateGraphics();
            }
        }

        private void Check_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoCapture.Dispose();
            Graphics.Dispose();
        }

        private void shutterBt_Click(object sender, EventArgs e)
        {

        }
        private void Read_Camera()
        {
            using (Mat = new Mat(0, 0, MatType.CV_8UC3))
            {
                VideoCapture.Read(Mat);
                VideoCapture.Read(Mat);
                using (Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(Mat))
                {
                    Graphics.DrawImage(bitmap, 0, 0, Mat.Cols, Mat.Rows);
                }
            }

        }
        private void timer1_Camera_Tick(object sender, EventArgs e)
        {
            Read_Camera();
        }
    }
}
