﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VGMToolbox.forms
{
    public partial class Examine_TagViewerForm : TreeViewVgmtForm
    {
        public Examine_TagViewerForm(TreeNode pTreeNode) : base(pTreeNode) 
        {
            InitializeComponent();
        }
    }
}
