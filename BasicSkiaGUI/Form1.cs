using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicSkiaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        private void Render(int lineCount)
        {
            SKImageInfo imageInfo = new SKImageInfo(
                width: imageCanvas.Width, 
                height: imageCanvas.Height,
                colorType: SKColorType.Rgba8888,
                alphaType: SKAlphaType.Premul
            );

            SKSurface surface = SKSurface.Create( imageInfo );
            SKCanvas canvas = surface.Canvas;

            canvas.Clear(SKColor.Parse("#003366"));

            for (int i = 0; i < lineCount; i++) 
            {
                int minWidth = 1;
                int maxWidth = 10;
                float lineWidth = rand.Next(minWidth, maxWidth);
                SKColor lineColor = new SKColor(
                    red: (byte)rand.Next(255),
                    green: (byte)rand.Next(255),
                    blue: (byte)rand.Next(255),
                    alpha: (byte)rand.Next(255)
                );
                SKPaint linePaint = new SKPaint
                {
                    Color = lineColor,
                    StrokeWidth = lineWidth,
                    IsAntialias = true,
                    Style = SKPaintStyle.Stroke
                };
                int x1 = rand.Next(imageInfo.Width);
                int y1 = rand.Next(imageInfo.Height);
                int x2 = rand.Next(imageInfo.Width);
                int y2 = rand.Next( imageInfo.Height);
                canvas.DrawLine(x1, y1, x2, y2, linePaint);
            }

            using (SKImage image = surface.Snapshot()) {
                using (SKData data = image.Encode()) {
                    using (System.IO.MemoryStream mStream = new System.IO.MemoryStream(data.ToArray()))
                    {
                        imageCanvas.Image?.Dispose();
                        imageCanvas.Image = new Bitmap(mStream, false);
                    }
                }
            }

            Application.DoEvents();
            
        }

        private void btn10Lines_Click(object sender, EventArgs e)
        {
            Render(10);
        }

        private void btn1kLines_Click(object sender, EventArgs e)
        {
            Render(1000);
        }

        private void btn10kLines_Click(object sender, EventArgs e)
        {
            Render(10000);
        }

        private void btn100kLines_Click(object sender, EventArgs e)
        {
            Render(100000);
        }
    }
}
