﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace GameLoop
{
    public partial class Form1 : Form
    {
        FastLoop _fastLoop;
        bool _fullscreen = false;

        public Form1()
        {
            _fastLoop = new FastLoop(GameLoop);
            InitializeComponent();
            _openGLControl.InitializeContexts();
            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GameLoop(double elapsedTime)
        {
            Random r = new Random();
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.3f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glPointSize(5.0f);

            Gl.glRotated(10 * elapsedTime, 0, 1, 0);

            Gl.glBegin(Gl.GL_TRIANGLE_STRIP);
            {
                Gl.glColor3d(1.0, 0.0, 0.0);
                Gl.glVertex3d(-0.5, 0, 0);
                Gl.glColor3d(0.0, 1.0, 0.0);
                Gl.glVertex3d(0.5, 0, 0);
                Gl.glColor3d(0.0, 0.0, 1.0);
                Gl.glVertex3d(0, 0.5, 0);
            }
            Gl.glEnd();

            Gl.glFinish();
            _openGLControl.Refresh();
        }
    }
}
