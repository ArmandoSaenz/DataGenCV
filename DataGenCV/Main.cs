using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using DirectShowLib;
using DataGenCV.Utities;
using System.Threading;
using System.Text.RegularExpressions;
using DataGenCV.Models;
using DirectShowLib.BDA;
using System.Diagnostics;
using DataGenCV.Views;
using Newtonsoft.Json;
using System.IO;
namespace DataGenCV
{
    public partial class Main : Form
    {
        List<DsDevice> Devices;
        VideoCapture Camera = new VideoCapture();
        List<Models.Resolution> SupportedResolutions;
        CancellationTokenSource CTS = new CancellationTokenSource();
        CancellationToken Token;
        Mat OriginalFrame = new Mat();
        Mat MaskFrame = new Mat();
        Mat FilteredFrame = new Mat();
        Mat CurrentFrame = new Mat();
        Mat Feature1 = new Mat();
        Mat Feature2 = new Mat();
        
        int LostFrames = 0;
        int CapturedFrames = 0;
        int rmin, rmax, gmin, gmax, bmin, bmax;
        Task task;
        bool IsRunning = false;
        Queue<TimeSpan> Delays;
        bool GetFeature1 = false;
        bool GetFeature2 = false;
        bool GettedFeatured1 = false;
        bool GettedFeatured2 = false;
        int Feature1x, Feature1y;
        int Feature2x, Feature2y;
        int Area1, Area2;
        double cx1, cy1, cx2, cy2;
        CarPendulumPostureList DataList = new CarPendulumPostureList();
        SettingsValues settingsValues = new SettingsValues();
        public Main()
        {
            InitializeComponent();
            LoadCameras();
            UpdateFilter();
            carPendulumPostureBindingSource.DataSource = DataList;
            LoadSettings();
        }
        public void LoadSettings()
        {
            settingsValuesBindingSource.DataSource = settingsValues;
            settingsValuesBindingSource.ResetBindings(false);
        }
        public void LoadCameras()
        {
            Devices = Utities.Cameras.GetCameras();
            cbCameras.DataSource = Devices;
            cbCameras.DisplayMember = "Name";
        }

        private void btnUpdateCameras_Click(object sender, EventArgs e)
        {
            LoadCameras();
        }

        private void btnFeature1_Click(object sender, EventArgs e)
        {
            GetFeature1 = true;
            GetFeature2 = false;
            toolTip1.Hide(btnFeature2);
            toolTip1.Show("Dar click sobre la imagen para señalar la primera caracteritica", btnFeature1, 0, -20, 5000);
        }

        private void tbRMin_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void tbRMax_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void tbGMin_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void tbGMax_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void btnTakePoint_Click(object sender, EventArgs e)
        {
            NewRegister();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string filename = $"data{DateTime.Now.ToString("yyMMddHHmmss")}.json";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos JSON | *.json";
            sfd.FileName = filename;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string jsontext = JsonConvert.SerializeObject(DataList, Formatting.Indented);
                File.WriteAllText(sfd.FileName, jsontext );
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string filename = $"settings{DateTime.Now.ToString("yyMMddHHmmss")}.json";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos JSON | *.json";
            sfd.FileName = filename;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string jsontext = JsonConvert.SerializeObject(settingsValues, Formatting.Indented);
                File.WriteAllText(sfd.FileName, jsontext);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo JSON | *.json";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string jsontext = File.ReadAllText(ofd.FileName);
                settingsValues = JsonConvert.DeserializeObject<SettingsValues>(jsontext);
                LoadSettings();
            }
        }

        private void tbRMin_Scroll(object sender, EventArgs e)
        {
            
        }

        private void tbRMin_Validated(object sender, EventArgs e)
        {
            
        }

        private void tbBMin_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
            
        }

        private void tbBMax_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void btnFeature2_Click(object sender, EventArgs e)
        {
            GetFeature1 = false;
            GetFeature2 = true;
            toolTip1.Hide(btnFeature1);
            toolTip1.Show("Dar click sobre la imagen para señalar la segunda caracteritica", btnFeature2, 0, -20, 5000);
        }

        private void cbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCameras.Items.Count > 0)
            {
                SupportedResolutions = Utities.Cameras.GetSupportedResolutions(Devices[cbCameras.SelectedIndex].Mon);
                cbResolutions.DataSource = SupportedResolutions;
                cbResolutions.DisplayMember = "Caption";
            }
        }

        private void btnConnectCamera_Click(object sender, EventArgs e)
        {
            if(Camera.IsOpened())
            {
                CTS.Cancel();   
            }
            else
            {
                ConnectCamera();
            }
        }
        private void ConnectCamera()
        {
            CTS = new CancellationTokenSource();
            Token = CTS.Token;
            Camera.Open(cbCameras.SelectedIndex);
            btnConnectCamera.BackgroundImage = global::DataGenCV.Properties.Resources.disconnect_icon;
            toolTip1.SetToolTip(btnConnectCamera, "Desconectar Cámara");
            Resolution resolution = SupportedResolutions[cbResolutions.SelectedIndex];
            Camera.Set(VideoCaptureProperties.FrameWidth, resolution.FrameWidth);
            Camera.Set(VideoCaptureProperties.FrameHeight, resolution.FrameHeight);
            Camera.Set(VideoCaptureProperties.FourCC, resolution.Compression);
            GettedFeatured1 = false;
            GettedFeatured2 = false;
            GetFeature1 = false;
            GetFeature2 = false;
            DataList.Clear();
            carPendulumPostureBindingSource.ResetBindings(false);
            task = new Task(() => { VideoProcessing(Token); }, Token);
            task.Start();
        }
        private void DisonnectCamera()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new Action(DisonnectCamera));
                return;
            }
            Cv2.DestroyAllWindows();
            btnConnectCamera.BackgroundImage = global::DataGenCV.Properties.Resources.connect_icon;
            toolTip1.SetToolTip(btnConnectCamera, "Conectar Cámara");
        }
        private void VideoProcessing(CancellationToken token)
        {
            LostFrames = 0;
            CapturedFrames = 0;
            Delays = new Queue<TimeSpan>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (var win = new Window("Imagen"))
            {
                win.SetMouseCallback(onVideoClick);
                while (!token.IsCancellationRequested)
                {
                    
                    if (!Camera.Read(OriginalFrame))
                    {
                        ++LostFrames;
                        continue;
                    }
                    ++CapturedFrames;
                    Area1 = (int)tbArea1.Value;
                    Area2 = (int)tbArea2.Value;
                    OpenCvSharp.Point origin1 = new OpenCvSharp.Point(Feature1x, Feature1y);
                    OpenCvSharp.Point origin2 = new OpenCvSharp.Point(Feature2x, Feature2y);
                    OpenCvSharp.Size size1 = new OpenCvSharp.Size(Area1, Area1);
                    OpenCvSharp.Size size2 = new OpenCvSharp.Size(Area2, Area2);
                    OpenCvSharp.Scalar color1 = cbFilter.Checked ? new Scalar(255,255,255): new Scalar(0, 255, 0);
                    OpenCvSharp.Scalar color2 = cbFilter.Checked ? new Scalar(255, 255, 255) : new Scalar(0, 0, 255);
                    Rect rect1 = new Rect(origin1, size1);
                    Rect rect2 = new Rect(origin2, size2);
                    int MaxX1 = OriginalFrame.Width - Area1;
                    int MaxY1 = OriginalFrame.Height - Area1;
                    int MaxX2 = OriginalFrame.Width - Area2;
                    int MaxY2 = OriginalFrame.Height - Area2;
                    Cv2.InRange(OriginalFrame, new Scalar(bmin, gmin, rmin), new Scalar(bmax, gmax, rmax), MaskFrame);
                    FilteredFrame = new Mat();
                    Cv2.BitwiseAnd(OriginalFrame, OriginalFrame, FilteredFrame, MaskFrame);
                    CurrentFrame = cbFilter.Checked ? FilteredFrame : OriginalFrame;
                    if (GettedFeatured1)
                    {
                        Feature1 = MaskFrame[rect1];
                        Moments moments = Cv2.Moments(Feature1);
                        var cx = (int)(moments.M10 / moments.M00);
                        var cy = (int)(moments.M01 / moments.M00);
                        cx1 = Feature1x + cx;
                        cy1 = Feature1y + cy;
                        Feature1x += cx - Area1 / 2;
                        Feature1y += cy - Area1 / 2;
                        Feature1x = Feature1x < 0 ? 0 : Feature1x;
                        Feature1y = Feature1y < 0 ? 0 : Feature1y;
                        Feature1x = Feature1x > MaxX1 ? MaxX1 : Feature1x;
                        Feature1y = Feature1y > MaxY1 ? MaxY1 : Feature1y;
                        Cv2.Rectangle(CurrentFrame, rect1, color1, 1);
                        Cv2.PutText(CurrentFrame, $"Caracteristica 1 {cx1},{cy1}", origin1, HersheyFonts.HersheyPlain, 1, color1);
                    }
                    if (GettedFeatured2)
                    {
                        Feature2 = MaskFrame[rect2];
                        Moments moments = Cv2.Moments(Feature2);
                        int cx = (int)(moments.M10 / moments.M00);
                        int cy = (int)(moments.M01 / moments.M00);
                        cx2 = Feature2x + cx;
                        cy2 = Feature2y + cy;
                        Feature2x += cx - Area2 / 2;
                        Feature2y += cy - Area2 / 2;
                        Feature2x = Feature2x < 0 ? 0 : Feature2x;
                        Feature2y = Feature2y < 0 ? 0 : Feature2y;
                        Feature2x = Feature2x > MaxX2 ? MaxX2 : Feature2x;
                        Feature2y = Feature2y > MaxY2 ? MaxY2 : Feature2y;
                        Cv2.Rectangle(CurrentFrame, rect2, color2, 1);
                        Cv2.PutText(CurrentFrame, $"Caracteristica 2 {cx2},{cy2}", origin2, HersheyFonts.HersheyPlain, 1, color2);
                    }
                    stopwatch.Stop();
                    Delays.Enqueue(stopwatch.Elapsed);
                    stopwatch.Restart();
                    
                    Cv2.SetWindowTitle("Imagen", $"Delay {Delays.Last().TotalSeconds}");
                    win.ShowImage(CurrentFrame);
                    int key = Cv2.WaitKey(1);
                    if ( key == 27)
                    {
                        break;
                    }
                    else if(key == 13)
                    {
                        NewRegister(); 
                    }
                }
            }
            Camera.Release();
            DisonnectCamera();
        }

        private void onVideoClick(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userData)
        {
            if(@event == MouseEventTypes.LButtonDown)
            {
                if(GetFeature1)
                {
                    Area1 = (int)tbArea1.Value;
                    Feature1x = x - Area1/2; 
                    Feature1y = y - Area1/2;
                    GettedFeatured1 = true;
                    GetFeature1 = false;
                    return;
                }
                if (GetFeature2)
                {
                    Area2 = (int)tbArea2.Value;
                    Feature2x = x-Area2/2;
                    Feature2y = y-Area2/2;
                    GettedFeatured2 = true;
                    GetFeature2 = false;
                    return;
                }
            }
        }
        private void UpdateFilter()
        {
            rmin = (int)tbRMin.Value;
            rmax = (int)tbRMax.Value;
            gmin = (int)tbGMin.Value;
            gmax = (int)tbGMax.Value;
            bmin = (int)tbBMin.Value;
            bmax = (int)tbBMax.Value;
            lRMin.Text = rmin.ToString();
            lRMax.Text = rmax.ToString();
            lGMin.Text = gmin.ToString();
            lGMax.Text = gmax.ToString();
            lBMin.Text = bmin.ToString();
            lBMax.Text = bmax.ToString();
        }

        private void NewRegister()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { NewRegister(); }));
                return;
            }
            FrmPosture frm = new FrmPosture();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                CarPendulumPosture posture = new CarPendulumPosture()
                {
                    U1 = cx1,
                    V1 = cy1,
                    U2 = cx2,
                    V2 = cy2,
                    X = frm.Distance,
                    Angle = frm.Angle
                };
                DataList.Add(posture);
                carPendulumPostureBindingSource.ResetBindings(false);
            }
        }
    }
}
