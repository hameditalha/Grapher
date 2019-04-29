namespace Final_Project
{
    partial class WorkingWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingWindow));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonClearGraphPanel = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonAxies = new System.Windows.Forms.Button();
            this.toolTipWorkingWindowButton = new System.Windows.Forms.ToolTip(this.components);
            this.buttonPlotCircle = new System.Windows.Forms.Button();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.buttonPlotLine1 = new System.Windows.Forms.Button();
            this.buttonPlotLine = new System.Windows.Forms.Button();
            this.toolTipWorkingWindowImage = new System.Windows.Forms.ToolTip(this.components);
            this.panelGraph = new System.Windows.Forms.Panel();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelCenter = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.label2Intercept = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxSlope = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelSlope = new System.Windows.Forms.Label();
            this.labelIntercept = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelSide.SuspendLayout();
            this.panelCircle.SuspendLayout();
            this.panelLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelTop.Controls.Add(this.buttonClearGraphPanel);
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Controls.Add(this.pictureBoxIcon);
            this.panelTop.Controls.Add(this.buttonBack);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(750, 40);
            this.panelTop.TabIndex = 0;
            // 
            // buttonClearGraphPanel
            // 
            this.buttonClearGraphPanel.FlatAppearance.BorderSize = 0;
            this.buttonClearGraphPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonClearGraphPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearGraphPanel.Image = global::Final_Project.Properties.Resources.clearGraphPanelImage;
            this.buttonClearGraphPanel.Location = new System.Drawing.Point(651, 7);
            this.buttonClearGraphPanel.Name = "buttonClearGraphPanel";
            this.buttonClearGraphPanel.Size = new System.Drawing.Size(25, 25);
            this.buttonClearGraphPanel.TabIndex = 6;
            this.buttonClearGraphPanel.UseVisualStyleBackColor = true;
            this.buttonClearGraphPanel.Click += new System.EventHandler(this.buttonClearGraphPanel_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(682, 7);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(25, 25);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImage = global::Final_Project.Properties.Resources.robotImage;
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIcon.Location = new System.Drawing.Point(14, 5);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(25, 30);
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Click += new System.EventHandler(this.pictureBoxIcon_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(713, 7);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(25, 25);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(112)))), ((int)(((byte)(120)))));
            this.panelSide.Controls.Add(this.buttonCalculator);
            this.panelSide.Controls.Add(this.buttonLine);
            this.panelSide.Controls.Add(this.buttonCircle);
            this.panelSide.Controls.Add(this.buttonAxies);
            this.panelSide.Location = new System.Drawing.Point(0, 40);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(145, 460);
            this.panelSide.TabIndex = 1;
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.FlatAppearance.BorderSize = 0;
            this.buttonCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(146)))));
            this.buttonCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculator.Image = global::Final_Project.Properties.Resources.calculatorImage;
            this.buttonCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalculator.Location = new System.Drawing.Point(1, 195);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(143, 80);
            this.buttonCalculator.TabIndex = 2;
            this.buttonCalculator.Text = "COUNT";
            this.buttonCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.FlatAppearance.BorderSize = 0;
            this.buttonLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(146)))));
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLine.Image = global::Final_Project.Properties.Resources.lineGraphImage;
            this.buttonLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLine.Location = new System.Drawing.Point(1, 101);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(143, 80);
            this.buttonLine.TabIndex = 0;
            this.buttonLine.Text = "LINES";
            this.buttonLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.FlatAppearance.BorderSize = 0;
            this.buttonCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(146)))));
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle.Image")));
            this.buttonCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCircle.Location = new System.Drawing.Point(1, 7);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(143, 80);
            this.buttonCircle.TabIndex = 0;
            this.buttonCircle.Text = "CIRCLE";
            this.buttonCircle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonAxies
            // 
            this.buttonAxies.FlatAppearance.BorderSize = 0;
            this.buttonAxies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(146)))));
            this.buttonAxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAxies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAxies.Image = global::Final_Project.Properties.Resources.axisImage;
            this.buttonAxies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAxies.Location = new System.Drawing.Point(1, 289);
            this.buttonAxies.Name = "buttonAxies";
            this.buttonAxies.Size = new System.Drawing.Size(143, 80);
            this.buttonAxies.TabIndex = 0;
            this.buttonAxies.Text = "AXIS";
            this.buttonAxies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAxies.UseVisualStyleBackColor = true;
            this.buttonAxies.Click += new System.EventHandler(this.buttonAxies_Click);
            // 
            // toolTipWorkingWindowButton
            // 
            this.toolTipWorkingWindowButton.ShowAlways = true;
            this.toolTipWorkingWindowButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonPlotCircle
            // 
            this.buttonPlotCircle.AutoEllipsis = true;
            this.buttonPlotCircle.FlatAppearance.BorderSize = 0;
            this.buttonPlotCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonPlotCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlotCircle.Location = new System.Drawing.Point(26, 110);
            this.buttonPlotCircle.Name = "buttonPlotCircle";
            this.buttonPlotCircle.Size = new System.Drawing.Size(79, 38);
            this.buttonPlotCircle.TabIndex = 7;
            this.buttonPlotCircle.Text = "PLOT";
            this.buttonPlotCircle.UseVisualStyleBackColor = true;
            this.buttonPlotCircle.Click += new System.EventHandler(this.buttonPlotCircle_Click);
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRadius.Location = new System.Drawing.Point(56, 84);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(52, 13);
            this.textBoxRadius.TabIndex = 6;
            this.textBoxRadius.Text = "0";
            this.toolTipWorkingWindowButton.SetToolTip(this.textBoxRadius, "Radius of circle");
            // 
            // textBoxH
            // 
            this.textBoxH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxH.Location = new System.Drawing.Point(56, 53);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(52, 13);
            this.textBoxH.TabIndex = 4;
            this.textBoxH.Text = "0";
            this.toolTipWorkingWindowButton.SetToolTip(this.textBoxH, "Y coordinate of center of circle");
            // 
            // textBoxG
            // 
            this.textBoxG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxG.Location = new System.Drawing.Point(56, 28);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(52, 13);
            this.textBoxG.TabIndex = 3;
            this.textBoxG.Text = "0";
            this.toolTipWorkingWindowButton.SetToolTip(this.textBoxG, "X coordinate of the center of circle");
            // 
            // buttonPlotLine1
            // 
            this.buttonPlotLine1.FlatAppearance.BorderSize = 0;
            this.buttonPlotLine1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonPlotLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlotLine1.Location = new System.Drawing.Point(29, 218);
            this.buttonPlotLine1.Name = "buttonPlotLine1";
            this.buttonPlotLine1.Size = new System.Drawing.Size(76, 32);
            this.buttonPlotLine1.TabIndex = 9;
            this.buttonPlotLine1.Text = "PLOT";
            this.buttonPlotLine1.UseVisualStyleBackColor = true;
            this.buttonPlotLine1.Click += new System.EventHandler(this.buttonPlotLine1_Click);
            // 
            // buttonPlotLine
            // 
            this.buttonPlotLine.FlatAppearance.BorderSize = 0;
            this.buttonPlotLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonPlotLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlotLine.Location = new System.Drawing.Point(29, 73);
            this.buttonPlotLine.Name = "buttonPlotLine";
            this.buttonPlotLine.Size = new System.Drawing.Size(76, 32);
            this.buttonPlotLine.TabIndex = 4;
            this.buttonPlotLine.Text = "PLOT";
            this.buttonPlotLine.UseVisualStyleBackColor = true;
            this.buttonPlotLine.Click += new System.EventHandler(this.buttonPlotLine_Click);
            // 
            // toolTipWorkingWindowImage
            // 
            this.toolTipWorkingWindowImage.IsBalloon = true;
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.Transparent;
            this.panelGraph.Location = new System.Drawing.Point(288, 45);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(450, 450);
            this.panelGraph.TabIndex = 2;
            // 
            // panelCircle
            // 
            this.panelCircle.Controls.Add(this.buttonPlotCircle);
            this.panelCircle.Controls.Add(this.textBoxRadius);
            this.panelCircle.Controls.Add(this.labelRadius);
            this.panelCircle.Controls.Add(this.textBoxH);
            this.panelCircle.Controls.Add(this.textBoxG);
            this.panelCircle.Controls.Add(this.labelH);
            this.panelCircle.Controls.Add(this.labelG);
            this.panelCircle.Controls.Add(this.labelCenter);
            this.panelCircle.Location = new System.Drawing.Point(153, 82);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(131, 155);
            this.panelCircle.TabIndex = 3;
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(3, 87);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(48, 13);
            this.labelRadius.TabIndex = 5;
            this.labelRadius.Text = "RADIUS";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(22, 56);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(13, 13);
            this.labelH.TabIndex = 2;
            this.labelH.Text = "h";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(23, 31);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(13, 13);
            this.labelG.TabIndex = 1;
            this.labelG.Text = "g";
            // 
            // labelCenter
            // 
            this.labelCenter.AutoSize = true;
            this.labelCenter.Location = new System.Drawing.Point(3, 8);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(51, 13);
            this.labelCenter.TabIndex = 0;
            this.labelCenter.Text = "CENTER";
            // 
            // panelLine
            // 
            this.panelLine.Controls.Add(this.buttonPlotLine1);
            this.panelLine.Controls.Add(this.textBoxX2);
            this.panelLine.Controls.Add(this.textBoxY2);
            this.panelLine.Controls.Add(this.textBoxY1);
            this.panelLine.Controls.Add(this.textBoxX1);
            this.panelLine.Controls.Add(this.labelY2);
            this.panelLine.Controls.Add(this.labelY1);
            this.panelLine.Controls.Add(this.labelX2);
            this.panelLine.Controls.Add(this.labelX1);
            this.panelLine.Controls.Add(this.label2Intercept);
            this.panelLine.Controls.Add(this.buttonPlotLine);
            this.panelLine.Controls.Add(this.textBoxC);
            this.panelLine.Controls.Add(this.textBoxSlope);
            this.panelLine.Controls.Add(this.labelC);
            this.panelLine.Controls.Add(this.labelSlope);
            this.panelLine.Controls.Add(this.labelIntercept);
            this.panelLine.Location = new System.Drawing.Point(153, 170);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(131, 259);
            this.panelLine.TabIndex = 4;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(77, 146);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(51, 20);
            this.textBoxX2.TabIndex = 8;
            this.textBoxX2.Text = "0";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(77, 192);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(51, 20);
            this.textBoxY2.TabIndex = 7;
            this.textBoxY2.Text = "0";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(77, 169);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(51, 20);
            this.textBoxY1.TabIndex = 7;
            this.textBoxY1.Text = "0";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(77, 123);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(51, 20);
            this.textBoxX1.TabIndex = 7;
            this.textBoxX1.Text = "0";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(9, 195);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(20, 13);
            this.labelY2.TabIndex = 6;
            this.labelY2.Text = "Y2";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(9, 172);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(20, 13);
            this.labelY1.TabIndex = 6;
            this.labelY1.Text = "Y1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(9, 149);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(20, 13);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "X2";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(9, 126);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(20, 13);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "X1";
            // 
            // label2Intercept
            // 
            this.label2Intercept.AutoSize = true;
            this.label2Intercept.Location = new System.Drawing.Point(3, 108);
            this.label2Intercept.Name = "label2Intercept";
            this.label2Intercept.Size = new System.Drawing.Size(104, 13);
            this.label2Intercept.TabIndex = 5;
            this.label2Intercept.Text = "(y2 - y1) = m (x2 - x1)";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(88, 46);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(40, 20);
            this.textBoxC.TabIndex = 3;
            this.textBoxC.Text = "0";
            // 
            // textBoxSlope
            // 
            this.textBoxSlope.Location = new System.Drawing.Point(88, 21);
            this.textBoxSlope.Name = "textBoxSlope";
            this.textBoxSlope.Size = new System.Drawing.Size(40, 20);
            this.textBoxSlope.TabIndex = 3;
            this.textBoxSlope.Text = "0";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(9, 49);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(70, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "Intercept ie C";
            // 
            // labelSlope
            // 
            this.labelSlope.AutoSize = true;
            this.labelSlope.Location = new System.Drawing.Point(9, 28);
            this.labelSlope.Name = "labelSlope";
            this.labelSlope.Size = new System.Drawing.Size(78, 13);
            this.labelSlope.TabIndex = 1;
            this.labelSlope.Text = "Slope ie m * 10\r\n";
            // 
            // labelIntercept
            // 
            this.labelIntercept.AutoSize = true;
            this.labelIntercept.Location = new System.Drawing.Point(3, 5);
            this.labelIntercept.Name = "labelIntercept";
            this.labelIntercept.Size = new System.Drawing.Size(55, 13);
            this.labelIntercept.TabIndex = 0;
            this.labelIntercept.Text = "y = mx + c";
            // 
            // WorkingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.panelCircle);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkingWindow";
            this.Load += new System.EventHandler(this.WorkingWindow_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.panelCircle.ResumeLayout(false);
            this.panelCircle.PerformLayout();
            this.panelLine.ResumeLayout(false);
            this.panelLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.ToolTip toolTipWorkingWindowButton;
        private System.Windows.Forms.ToolTip toolTipWorkingWindowImage;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Button buttonAxies;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Panel panelCircle;
        private System.Windows.Forms.Label labelCenter;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Button buttonPlotCircle;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label labelIntercept;
        private System.Windows.Forms.Button buttonPlotLine;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxSlope;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelSlope;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label label2Intercept;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Button buttonPlotLine1;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClearGraphPanel;
    }
}