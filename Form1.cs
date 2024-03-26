using System;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.Camera;

namespace VideoCameraViewer02
{
    public partial class Form1 : Form
    {
        private IIPCamera _camera;
        private DrawingImageProvider _imageProvider = new DrawingImageProvider();
        private MediaConnector _connector = new MediaConnector();
        private VideoViewerWF _videoViewerWF1;

        public Form1()
        {
            InitializeComponent();

            // Create video viewer UI control
            _videoViewerWF1 = new VideoViewerWF();
            _videoViewerWF1.Name = "videoViewerWF1";
            _videoViewerWF1.Size = panel1.Size;
            panel1.Controls.Add(_videoViewerWF1);

            // Bind the camera image to the UI control
            _videoViewerWF1.SetImageProvider(_imageProvider);
        }

        // Connect camera video channel to image provider and start
        private void connectBtn_Click(object sender, EventArgs e)
        {
            //_camera = IPCameraFactory.GetCamera("rtsp://127.0.0.2:14550/9999/Payload", "root", "pass");
            _camera = IPCameraFactory.GetCamera("rtsp://192.168.2.119", "root", "pass");
            _connector.Connect(_camera.VideoChannel, _imageProvider);
            _camera.Start();
            _videoViewerWF1.Start();
        }
    }
}
