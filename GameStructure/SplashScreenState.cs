﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GameStructure
{
    public class SplashScreenState:IGameObject
    {
        StateSystem _system;
        double _delayInSeconds = 3;
        public SplashScreenState(StateSystem system)
        {
            _system = system;
        }
        #region IGameObject
        public void Update(double elapsedTime)
        {
            _delayInSeconds -= elapsedTime;
            if (_delayInSeconds <= 0)
            {
                _delayInSeconds = 3;
                _system.ChangeState("title_menu");
            }

        }

        public void Render()
        {
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glFinish();
        }
        #endregion
    
    }
}
