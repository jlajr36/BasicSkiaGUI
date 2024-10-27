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
        int lineCount = 0;

        private void skglCanvas_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            surface.Canvas.Clear(SKColor.Parse("#003366"));
            int minWidth = 1;
            int maxWidth = 10;
            for (int i = 0; i < lineCount; i++)
            {
                SKPaint paint = new SKPaint
                {
                    Color = new SKColor(
                        red: (byte)rand.Next(255),
                        green: (byte)rand.Next(255),
                        blue: (byte)rand.Next(255),
                        alpha: (byte)rand.Next(255)),
                    StrokeWidth = rand.Next(minWidth, maxWidth),
                    IsAntialias = true
                };
                surface.Canvas.DrawLine(
                    x0: rand.Next(skglCanvas.Width),
                    y0: rand.Next(skglCanvas.Height),
                    x1: rand.Next(skglCanvas.Width),
                    y1: rand.Next(skglCanvas.Height),
                    paint: paint
                );
            }
        }

        private void doDraw(int lineCounts)
        {
            this.lineCount = lineCounts;
            skglCanvas.Invalidate();
            Application.DoEvents();
        }

        private void btn10Lines_Click(object sender, EventArgs e)
        {
            doDraw(10);
        }

        private void btn1kLines_Click(object sender, EventArgs e)
        {
            doDraw(1000);
        }

        private void btn10kLines_Click(object sender, EventArgs e)
        {
            doDraw(10000);
        }

        private void btn100kLines_Click(object sender, EventArgs e)
        {
            doDraw(100000);
        }

    }
}
