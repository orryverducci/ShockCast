﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockCast
{
    public partial class InputHeader : UserControl
    {
        private Input input;

        /// <summary>
        /// Create an input header
        /// </summary>
        /// <param name="input">The input to display on the header</param>
        public InputHeader(Input inputDevice)
        {
            // Set input to given input
            input = inputDevice;
            // Create components
            InitializeComponent();
        }
    }
}