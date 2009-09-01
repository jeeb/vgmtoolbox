﻿namespace VGMToolbox.forms.extraction
{
    partial class OffsetFinderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSavePreset = new System.Windows.Forms.Button();
            this.lblPresets = new System.Windows.Forms.Label();
            this.btnLoadPreset = new System.Windows.Forms.Button();
            this.lblDragNDrop = new System.Windows.Forms.Label();
            this.tbSourcePaths = new System.Windows.Forms.TextBox();
            this.comboPresets = new System.Windows.Forms.ComboBox();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.lblStartingOffset = new System.Windows.Forms.Label();
            this.tbStartingOffset = new System.Windows.Forms.TextBox();
            this.cbSearchAsHex = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMinCutSizeBytes = new System.Windows.Forms.Label();
            this.lblMinCutSize = new System.Windows.Forms.Label();
            this.tbMinSizeForCut = new System.Windows.Forms.TextBox();
            this.cbDoCut = new System.Windows.Forms.CheckBox();
            this.lblOutputExtension = new System.Windows.Forms.Label();
            this.tbOutputExtension = new System.Windows.Forms.TextBox();
            this.gbCutSizeOptions = new System.Windows.Forms.GroupBox();
            this.tbExtraCutSizeBytes = new System.Windows.Forms.TextBox();
            this.cbAddExtraBytes = new System.Windows.Forms.CheckBox();
            this.cbIncludeTerminatorInLength = new System.Windows.Forms.CheckBox();
            this.cbTreatTerminatorAsHex = new System.Windows.Forms.CheckBox();
            this.tbTerminatorString = new System.Windows.Forms.TextBox();
            this.rbUseTerminator = new System.Windows.Forms.RadioButton();
            this.cbOffsetSize = new System.Windows.Forms.ComboBox();
            this.lblByteOrder = new System.Windows.Forms.Label();
            this.lblStoredIn = new System.Windows.Forms.Label();
            this.cbByteOrder = new System.Windows.Forms.ComboBox();
            this.lblInBytes = new System.Windows.Forms.Label();
            this.lblInBytes2 = new System.Windows.Forms.Label();
            this.lblFromStart = new System.Windows.Forms.Label();
            this.lblHasSize = new System.Windows.Forms.Label();
            this.tbStaticCutsize = new System.Windows.Forms.TextBox();
            this.tbCutSizeOffset = new System.Windows.Forms.TextBox();
            this.rbOffsetBasedCutSize = new System.Windows.Forms.RadioButton();
            this.rbStaticCutSize = new System.Windows.Forms.RadioButton();
            this.lblStringAtOffset = new System.Windows.Forms.Label();
            this.tbSearchStringOffset = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlLabels.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCutSizeOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabels
            // 
            this.pnlLabels.Location = new System.Drawing.Point(0, 521);
            this.pnlLabels.Size = new System.Drawing.Size(757, 19);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Size = new System.Drawing.Size(757, 20);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(0, 444);
            this.tbOutput.Size = new System.Drawing.Size(757, 77);
            this.toolTip1.SetToolTip(this.tbOutput, "Double-Click to view in your default text editor.");
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(0, 424);
            this.pnlButtons.Size = new System.Drawing.Size(757, 20);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(697, 0);
            // 
            // btnDoTask
            // 
            this.btnDoTask.Location = new System.Drawing.Point(637, 0);
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.btnRefresh);
            this.grpFiles.Controls.Add(this.btnSavePreset);
            this.grpFiles.Controls.Add(this.lblPresets);
            this.grpFiles.Controls.Add(this.btnLoadPreset);
            this.grpFiles.Controls.Add(this.lblDragNDrop);
            this.grpFiles.Controls.Add(this.tbSourcePaths);
            this.grpFiles.Controls.Add(this.comboPresets);
            this.grpFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFiles.Location = new System.Drawing.Point(0, 23);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(757, 64);
            this.grpFiles.TabIndex = 5;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files to Search";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::VGMToolbox.Properties.Resources.Button_Refresh_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(538, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(20, 20);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.Location = new System.Drawing.Point(497, 42);
            this.btnSavePreset.Name = "btnSavePreset";
            this.btnSavePreset.Size = new System.Drawing.Size(40, 20);
            this.btnSavePreset.TabIndex = 5;
            this.btnSavePreset.Text = "Save";
            this.btnSavePreset.UseVisualStyleBackColor = true;
            this.btnSavePreset.Click += new System.EventHandler(this.btnSavePreset_Click);
            // 
            // lblPresets
            // 
            this.lblPresets.AutoSize = true;
            this.lblPresets.Location = new System.Drawing.Point(291, 46);
            this.lblPresets.Name = "lblPresets";
            this.lblPresets.Size = new System.Drawing.Size(42, 13);
            this.lblPresets.TabIndex = 4;
            this.lblPresets.Text = "Presets";
            // 
            // btnLoadPreset
            // 
            this.btnLoadPreset.Location = new System.Drawing.Point(456, 42);
            this.btnLoadPreset.Name = "btnLoadPreset";
            this.btnLoadPreset.Size = new System.Drawing.Size(40, 20);
            this.btnLoadPreset.TabIndex = 3;
            this.btnLoadPreset.Text = "Load";
            this.btnLoadPreset.UseVisualStyleBackColor = true;
            this.btnLoadPreset.Click += new System.EventHandler(this.btnLoadPreset_Click);
            // 
            // lblDragNDrop
            // 
            this.lblDragNDrop.AutoSize = true;
            this.lblDragNDrop.Location = new System.Drawing.Point(3, 42);
            this.lblDragNDrop.Name = "lblDragNDrop";
            this.lblDragNDrop.Size = new System.Drawing.Size(172, 13);
            this.lblDragNDrop.TabIndex = 1;
            this.lblDragNDrop.Text = "Drag and Drop files to search here.";
            // 
            // tbSourcePaths
            // 
            this.tbSourcePaths.AllowDrop = true;
            this.tbSourcePaths.Location = new System.Drawing.Point(6, 19);
            this.tbSourcePaths.Name = "tbSourcePaths";
            this.tbSourcePaths.Size = new System.Drawing.Size(282, 20);
            this.tbSourcePaths.TabIndex = 0;
            this.tbSourcePaths.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSourcePaths_DragDrop);
            this.tbSourcePaths.DragEnter += new System.Windows.Forms.DragEventHandler(this.doDragEnter);
            // 
            // comboPresets
            // 
            this.comboPresets.FormattingEnabled = true;
            this.comboPresets.Location = new System.Drawing.Point(294, 19);
            this.comboPresets.Name = "comboPresets";
            this.comboPresets.Size = new System.Drawing.Size(264, 21);
            this.comboPresets.TabIndex = 2;
            this.comboPresets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboPresets_KeyPress);
            this.comboPresets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboPresets_KeyDown);
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.lblStartingOffset);
            this.grpCriteria.Controls.Add(this.tbStartingOffset);
            this.grpCriteria.Controls.Add(this.cbSearchAsHex);
            this.grpCriteria.Controls.Add(this.label2);
            this.grpCriteria.Controls.Add(this.tbSearchString);
            this.grpCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCriteria.Location = new System.Drawing.Point(0, 87);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(757, 55);
            this.grpCriteria.TabIndex = 6;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Criteria";
            // 
            // lblStartingOffset
            // 
            this.lblStartingOffset.AutoSize = true;
            this.lblStartingOffset.Location = new System.Drawing.Point(315, 15);
            this.lblStartingOffset.Name = "lblStartingOffset";
            this.lblStartingOffset.Size = new System.Drawing.Size(74, 13);
            this.lblStartingOffset.TabIndex = 16;
            this.lblStartingOffset.Text = "Starting Offset";
            // 
            // tbStartingOffset
            // 
            this.tbStartingOffset.Location = new System.Drawing.Point(395, 12);
            this.tbStartingOffset.Name = "tbStartingOffset";
            this.tbStartingOffset.Size = new System.Drawing.Size(129, 20);
            this.tbStartingOffset.TabIndex = 3;
            // 
            // cbSearchAsHex
            // 
            this.cbSearchAsHex.AutoSize = true;
            this.cbSearchAsHex.Location = new System.Drawing.Point(9, 34);
            this.cbSearchAsHex.Name = "cbSearchAsHex";
            this.cbSearchAsHex.Size = new System.Drawing.Size(87, 17);
            this.cbSearchAsHex.TabIndex = 2;
            this.cbSearchAsHex.Text = "Treat as Hex";
            this.cbSearchAsHex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search String";
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(83, 12);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(205, 20);
            this.tbSearchString.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.gbCutSizeOptions);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 252);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cut Options (all values are relative to the location of the file to be cut)";
            // 
            // lblMinCutSizeBytes
            // 
            this.lblMinCutSizeBytes.AutoSize = true;
            this.lblMinCutSizeBytes.Location = new System.Drawing.Point(444, 27);
            this.lblMinCutSizeBytes.Name = "lblMinCutSizeBytes";
            this.lblMinCutSizeBytes.Size = new System.Drawing.Size(32, 13);
            this.lblMinCutSizeBytes.TabIndex = 18;
            this.lblMinCutSizeBytes.Text = "bytes";
            // 
            // lblMinCutSize
            // 
            this.lblMinCutSize.AutoSize = true;
            this.lblMinCutSize.Location = new System.Drawing.Point(233, 27);
            this.lblMinCutSize.Name = "lblMinCutSize";
            this.lblMinCutSize.Size = new System.Drawing.Size(101, 13);
            this.lblMinCutSize.TabIndex = 17;
            this.lblMinCutSize.Text = "Min. Size for Cutting";
            // 
            // tbMinSizeForCut
            // 
            this.tbMinSizeForCut.Location = new System.Drawing.Point(346, 24);
            this.tbMinSizeForCut.Name = "tbMinSizeForCut";
            this.tbMinSizeForCut.Size = new System.Drawing.Size(92, 20);
            this.tbMinSizeForCut.TabIndex = 16;
            this.tbMinSizeForCut.Text = "0";
            // 
            // cbDoCut
            // 
            this.cbDoCut.AutoSize = true;
            this.cbDoCut.Location = new System.Drawing.Point(6, 3);
            this.cbDoCut.Name = "cbDoCut";
            this.cbDoCut.Size = new System.Drawing.Size(83, 17);
            this.cbDoCut.TabIndex = 15;
            this.cbDoCut.Text = "Extract Files";
            this.cbDoCut.UseVisualStyleBackColor = true;
            this.cbDoCut.CheckedChanged += new System.EventHandler(this.cbDoCut_CheckedChanged);
            // 
            // lblOutputExtension
            // 
            this.lblOutputExtension.AutoSize = true;
            this.lblOutputExtension.Location = new System.Drawing.Point(233, 4);
            this.lblOutputExtension.Name = "lblOutputExtension";
            this.lblOutputExtension.Size = new System.Drawing.Size(107, 13);
            this.lblOutputExtension.TabIndex = 14;
            this.lblOutputExtension.Text = "Output File Extension";
            // 
            // tbOutputExtension
            // 
            this.tbOutputExtension.Location = new System.Drawing.Point(346, 1);
            this.tbOutputExtension.Name = "tbOutputExtension";
            this.tbOutputExtension.Size = new System.Drawing.Size(92, 20);
            this.tbOutputExtension.TabIndex = 13;
            // 
            // gbCutSizeOptions
            // 
            this.gbCutSizeOptions.Controls.Add(this.tbExtraCutSizeBytes);
            this.gbCutSizeOptions.Controls.Add(this.cbAddExtraBytes);
            this.gbCutSizeOptions.Controls.Add(this.cbIncludeTerminatorInLength);
            this.gbCutSizeOptions.Controls.Add(this.cbTreatTerminatorAsHex);
            this.gbCutSizeOptions.Controls.Add(this.tbTerminatorString);
            this.gbCutSizeOptions.Controls.Add(this.rbUseTerminator);
            this.gbCutSizeOptions.Controls.Add(this.cbOffsetSize);
            this.gbCutSizeOptions.Controls.Add(this.lblByteOrder);
            this.gbCutSizeOptions.Controls.Add(this.lblStoredIn);
            this.gbCutSizeOptions.Controls.Add(this.cbByteOrder);
            this.gbCutSizeOptions.Controls.Add(this.lblInBytes);
            this.gbCutSizeOptions.Controls.Add(this.lblInBytes2);
            this.gbCutSizeOptions.Controls.Add(this.lblFromStart);
            this.gbCutSizeOptions.Controls.Add(this.lblHasSize);
            this.gbCutSizeOptions.Controls.Add(this.tbStaticCutsize);
            this.gbCutSizeOptions.Controls.Add(this.tbCutSizeOffset);
            this.gbCutSizeOptions.Controls.Add(this.rbOffsetBasedCutSize);
            this.gbCutSizeOptions.Controls.Add(this.rbStaticCutSize);
            this.gbCutSizeOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCutSizeOptions.Location = new System.Drawing.Point(3, 65);
            this.gbCutSizeOptions.Name = "gbCutSizeOptions";
            this.gbCutSizeOptions.Size = new System.Drawing.Size(751, 184);
            this.gbCutSizeOptions.TabIndex = 2;
            this.gbCutSizeOptions.TabStop = false;
            this.gbCutSizeOptions.Text = "Cut Size Options";
            // 
            // tbExtraCutSizeBytes
            // 
            this.tbExtraCutSizeBytes.Location = new System.Drawing.Point(162, 158);
            this.tbExtraCutSizeBytes.Name = "tbExtraCutSizeBytes";
            this.tbExtraCutSizeBytes.ReadOnly = true;
            this.tbExtraCutSizeBytes.Size = new System.Drawing.Size(57, 20);
            this.tbExtraCutSizeBytes.TabIndex = 18;
            // 
            // cbAddExtraBytes
            // 
            this.cbAddExtraBytes.AutoSize = true;
            this.cbAddExtraBytes.Location = new System.Drawing.Point(6, 161);
            this.cbAddExtraBytes.Name = "cbAddExtraBytes";
            this.cbAddExtraBytes.Size = new System.Drawing.Size(150, 17);
            this.cbAddExtraBytes.TabIndex = 17;
            this.cbAddExtraBytes.Text = "Add extra bytes to cut size";
            this.cbAddExtraBytes.UseVisualStyleBackColor = true;
            this.cbAddExtraBytes.CheckedChanged += new System.EventHandler(this.cbAddExtraBytes_CheckedChanged);
            // 
            // cbIncludeTerminatorInLength
            // 
            this.cbIncludeTerminatorInLength.AutoSize = true;
            this.cbIncludeTerminatorInLength.Location = new System.Drawing.Point(112, 139);
            this.cbIncludeTerminatorInLength.Name = "cbIncludeTerminatorInLength";
            this.cbIncludeTerminatorInLength.Size = new System.Drawing.Size(222, 17);
            this.cbIncludeTerminatorInLength.TabIndex = 16;
            this.cbIncludeTerminatorInLength.Text = "Include Terminator in Cut Size Calculation";
            this.cbIncludeTerminatorInLength.UseVisualStyleBackColor = true;
            // 
            // cbTreatTerminatorAsHex
            // 
            this.cbTreatTerminatorAsHex.AutoSize = true;
            this.cbTreatTerminatorAsHex.Location = new System.Drawing.Point(247, 116);
            this.cbTreatTerminatorAsHex.Name = "cbTreatTerminatorAsHex";
            this.cbTreatTerminatorAsHex.Size = new System.Drawing.Size(87, 17);
            this.cbTreatTerminatorAsHex.TabIndex = 15;
            this.cbTreatTerminatorAsHex.Text = "Treat as Hex";
            this.cbTreatTerminatorAsHex.UseVisualStyleBackColor = true;
            // 
            // tbTerminatorString
            // 
            this.tbTerminatorString.Location = new System.Drawing.Point(138, 113);
            this.tbTerminatorString.Name = "tbTerminatorString";
            this.tbTerminatorString.Size = new System.Drawing.Size(100, 20);
            this.tbTerminatorString.TabIndex = 14;
            // 
            // rbUseTerminator
            // 
            this.rbUseTerminator.AutoSize = true;
            this.rbUseTerminator.Location = new System.Drawing.Point(6, 115);
            this.rbUseTerminator.Name = "rbUseTerminator";
            this.rbUseTerminator.Size = new System.Drawing.Size(127, 17);
            this.rbUseTerminator.TabIndex = 13;
            this.rbUseTerminator.TabStop = true;
            this.rbUseTerminator.Text = "Use Terminator String";
            this.rbUseTerminator.UseVisualStyleBackColor = true;
            this.rbUseTerminator.CheckedChanged += new System.EventHandler(this.doRadioCheckedChanged);
            // 
            // cbOffsetSize
            // 
            this.cbOffsetSize.FormattingEnabled = true;
            this.cbOffsetSize.Location = new System.Drawing.Point(138, 63);
            this.cbOffsetSize.Name = "cbOffsetSize";
            this.cbOffsetSize.Size = new System.Drawing.Size(100, 21);
            this.cbOffsetSize.TabIndex = 12;
            this.cbOffsetSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOffsetSize_KeyPress);
            this.cbOffsetSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbOffsetSize_KeyDown);
            // 
            // lblByteOrder
            // 
            this.lblByteOrder.AutoSize = true;
            this.lblByteOrder.Location = new System.Drawing.Point(244, 89);
            this.lblByteOrder.Name = "lblByteOrder";
            this.lblByteOrder.Size = new System.Drawing.Size(57, 13);
            this.lblByteOrder.TabIndex = 11;
            this.lblByteOrder.Text = "byte order.";
            // 
            // lblStoredIn
            // 
            this.lblStoredIn.AutoSize = true;
            this.lblStoredIn.Location = new System.Drawing.Point(64, 89);
            this.lblStoredIn.Name = "lblStoredIn";
            this.lblStoredIn.Size = new System.Drawing.Size(68, 13);
            this.lblStoredIn.TabIndex = 10;
            this.lblStoredIn.Text = "and stored in";
            // 
            // cbByteOrder
            // 
            this.cbByteOrder.FormattingEnabled = true;
            this.cbByteOrder.Location = new System.Drawing.Point(138, 86);
            this.cbByteOrder.Name = "cbByteOrder";
            this.cbByteOrder.Size = new System.Drawing.Size(100, 21);
            this.cbByteOrder.TabIndex = 9;
            // 
            // lblInBytes
            // 
            this.lblInBytes.AutoSize = true;
            this.lblInBytes.Location = new System.Drawing.Point(244, 21);
            this.lblInBytes.Name = "lblInBytes";
            this.lblInBytes.Size = new System.Drawing.Size(46, 13);
            this.lblInBytes.TabIndex = 8;
            this.lblInBytes.Text = "in bytes.";
            // 
            // lblInBytes2
            // 
            this.lblInBytes2.AutoSize = true;
            this.lblInBytes2.Location = new System.Drawing.Point(244, 66);
            this.lblInBytes2.Name = "lblInBytes2";
            this.lblInBytes2.Size = new System.Drawing.Size(46, 13);
            this.lblInBytes2.TabIndex = 7;
            this.lblInBytes2.Text = "in bytes.";
            // 
            // lblFromStart
            // 
            this.lblFromStart.AutoSize = true;
            this.lblFromStart.Location = new System.Drawing.Point(244, 44);
            this.lblFromStart.Name = "lblFromStart";
            this.lblFromStart.Size = new System.Drawing.Size(147, 13);
            this.lblFromStart.TabIndex = 6;
            this.lblFromStart.Text = "from the start of the file to cut.";
            // 
            // lblHasSize
            // 
            this.lblHasSize.AutoSize = true;
            this.lblHasSize.Location = new System.Drawing.Point(66, 66);
            this.lblHasSize.Name = "lblHasSize";
            this.lblHasSize.Size = new System.Drawing.Size(66, 13);
            this.lblHasSize.TabIndex = 5;
            this.lblHasSize.Text = "and has size";
            // 
            // tbStaticCutsize
            // 
            this.tbStaticCutsize.Location = new System.Drawing.Point(138, 18);
            this.tbStaticCutsize.Name = "tbStaticCutsize";
            this.tbStaticCutsize.Size = new System.Drawing.Size(100, 20);
            this.tbStaticCutsize.TabIndex = 3;
            // 
            // tbCutSizeOffset
            // 
            this.tbCutSizeOffset.Location = new System.Drawing.Point(138, 41);
            this.tbCutSizeOffset.Name = "tbCutSizeOffset";
            this.tbCutSizeOffset.Size = new System.Drawing.Size(100, 20);
            this.tbCutSizeOffset.TabIndex = 2;
            // 
            // rbOffsetBasedCutSize
            // 
            this.rbOffsetBasedCutSize.AutoSize = true;
            this.rbOffsetBasedCutSize.Location = new System.Drawing.Point(6, 42);
            this.rbOffsetBasedCutSize.Name = "rbOffsetBasedCutSize";
            this.rbOffsetBasedCutSize.Size = new System.Drawing.Size(117, 17);
            this.rbOffsetBasedCutSize.TabIndex = 1;
            this.rbOffsetBasedCutSize.TabStop = true;
            this.rbOffsetBasedCutSize.Text = "Cut Size is at Offset";
            this.rbOffsetBasedCutSize.UseVisualStyleBackColor = true;
            this.rbOffsetBasedCutSize.CheckedChanged += new System.EventHandler(this.doRadioCheckedChanged);
            // 
            // rbStaticCutSize
            // 
            this.rbStaticCutSize.AutoSize = true;
            this.rbStaticCutSize.Location = new System.Drawing.Point(6, 19);
            this.rbStaticCutSize.Name = "rbStaticCutSize";
            this.rbStaticCutSize.Size = new System.Drawing.Size(111, 17);
            this.rbStaticCutSize.TabIndex = 0;
            this.rbStaticCutSize.TabStop = true;
            this.rbStaticCutSize.Text = "Use Static Cutsize";
            this.rbStaticCutSize.UseVisualStyleBackColor = true;
            this.rbStaticCutSize.CheckedChanged += new System.EventHandler(this.doRadioCheckedChanged);
            // 
            // lblStringAtOffset
            // 
            this.lblStringAtOffset.AutoSize = true;
            this.lblStringAtOffset.Location = new System.Drawing.Point(3, 27);
            this.lblStringAtOffset.Name = "lblStringAtOffset";
            this.lblStringAtOffset.Size = new System.Drawing.Size(124, 13);
            this.lblStringAtOffset.TabIndex = 1;
            this.lblStringAtOffset.Text = "Search String is at Offset";
            // 
            // tbSearchStringOffset
            // 
            this.tbSearchStringOffset.Location = new System.Drawing.Point(133, 24);
            this.tbSearchStringOffset.Name = "tbSearchStringOffset";
            this.tbSearchStringOffset.Size = new System.Drawing.Size(92, 20);
            this.tbSearchStringOffset.TabIndex = 0;
            this.tbSearchStringOffset.Text = "0x00";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 282);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDoCut);
            this.panel2.Controls.Add(this.lblMinCutSizeBytes);
            this.panel2.Controls.Add(this.tbSearchStringOffset);
            this.panel2.Controls.Add(this.lblMinCutSize);
            this.panel2.Controls.Add(this.lblStringAtOffset);
            this.panel2.Controls.Add(this.tbMinSizeForCut);
            this.panel2.Controls.Add(this.tbOutputExtension);
            this.panel2.Controls.Add(this.lblOutputExtension);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 49);
            this.panel2.TabIndex = 19;
            // 
            // OffsetFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpCriteria);
            this.Controls.Add(this.grpFiles);
            this.Name = "OffsetFinderForm";
            this.Text = "OffsetFinderForm";
            this.Controls.SetChildIndex(this.pnlLabels, 0);
            this.Controls.SetChildIndex(this.tbOutput, 0);
            this.Controls.SetChildIndex(this.pnlTitle, 0);
            this.Controls.SetChildIndex(this.pnlButtons, 0);
            this.Controls.SetChildIndex(this.grpFiles, 0);
            this.Controls.SetChildIndex(this.grpCriteria, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbCutSizeOptions.ResumeLayout(false);
            this.gbCutSizeOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.TextBox tbSourcePaths;
        private System.Windows.Forms.Label lblDragNDrop;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchString;
        private System.Windows.Forms.CheckBox cbSearchAsHex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSearchStringOffset;
        private System.Windows.Forms.Label lblStringAtOffset;
        private System.Windows.Forms.GroupBox gbCutSizeOptions;
        private System.Windows.Forms.RadioButton rbOffsetBasedCutSize;
        private System.Windows.Forms.RadioButton rbStaticCutSize;
        private System.Windows.Forms.TextBox tbStaticCutsize;
        private System.Windows.Forms.TextBox tbCutSizeOffset;
        private System.Windows.Forms.Label lblHasSize;
        private System.Windows.Forms.Label lblByteOrder;
        private System.Windows.Forms.Label lblStoredIn;
        private System.Windows.Forms.ComboBox cbByteOrder;
        private System.Windows.Forms.Label lblInBytes;
        private System.Windows.Forms.Label lblInBytes2;
        private System.Windows.Forms.Label lblFromStart;
        private System.Windows.Forms.Label lblOutputExtension;
        private System.Windows.Forms.TextBox tbOutputExtension;
        private System.Windows.Forms.ComboBox cbOffsetSize;
        private System.Windows.Forms.CheckBox cbDoCut;
        private System.Windows.Forms.RadioButton rbUseTerminator;
        private System.Windows.Forms.TextBox tbTerminatorString;
        private System.Windows.Forms.CheckBox cbTreatTerminatorAsHex;
        private System.Windows.Forms.CheckBox cbIncludeTerminatorInLength;
        private System.Windows.Forms.CheckBox cbAddExtraBytes;
        private System.Windows.Forms.TextBox tbExtraCutSizeBytes;
        private System.Windows.Forms.ComboBox comboPresets;
        private System.Windows.Forms.Button btnLoadPreset;
        private System.Windows.Forms.Label lblPresets;
        private System.Windows.Forms.TextBox tbStartingOffset;
        private System.Windows.Forms.Label lblStartingOffset;
        private System.Windows.Forms.Button btnSavePreset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbMinSizeForCut;
        private System.Windows.Forms.Label lblMinCutSize;
        private System.Windows.Forms.Label lblMinCutSizeBytes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}