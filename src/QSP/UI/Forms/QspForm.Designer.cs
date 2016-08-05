﻿namespace QSP.UI.Forms
{
    partial class QspForm
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
            this.navDataStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.trackStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.windDataStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new QSP.UI.Controls.PanelSilentScrollbar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fuelBtn = new System.Windows.Forms.Button();
            this.acConfigBtn = new System.Windows.Forms.Button();
            this.airportBtn = new System.Windows.Forms.Button();
            this.ldgBtn = new System.Windows.Forms.Button();
            this.toBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navDataStatusLabel
            // 
            this.navDataStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.navDataStatusLabel.Image = global::QSP.Properties.Resources.GreenLight;
            this.navDataStatusLabel.Name = "navDataStatusLabel";
            this.navDataStatusLabel.Size = new System.Drawing.Size(148, 20);
            this.navDataStatusLabel.Text = "Nav Data: Loaded";
            this.navDataStatusLabel.ToolTipText = "Click to view options";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(45, 20);
            this.ToolStripStatusLabel3.Text = "         ";
            // 
            // trackStatusLabel
            // 
            this.trackStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.trackStatusLabel.Image = global::QSP.Properties.Resources.YellowLight;
            this.trackStatusLabel.Name = "trackStatusLabel";
            this.trackStatusLabel.Size = new System.Drawing.Size(166, 20);
            this.trackStatusLabel.Text = "Tracks: Patially ready";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(49, 20);
            this.ToolStripStatusLabel2.Text = "          ";
            // 
            // windDataStatusLabel
            // 
            this.windDataStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.windDataStatusLabel.Image = global::QSP.Properties.Resources.GreenLight;
            this.windDataStatusLabel.Name = "windDataStatusLabel";
            this.windDataStatusLabel.Size = new System.Drawing.Size(153, 20);
            this.windDataStatusLabel.Text = "Wind Aloft : Ready";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navDataStatusLabel,
            this.ToolStripStatusLabel3,
            this.trackStatusLabel,
            this.ToolStripStatusLabel2,
            this.windDataStatusLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 830);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1182, 25);
            this.StatusStrip1.TabIndex = 40;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 830);
            this.panel1.TabIndex = 41;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(886, 50);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(876, 40);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.fuelBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.acConfigBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.airportBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ldgBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.toBtn, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 40);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // fuelBtn
            // 
            this.fuelBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.fuelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fuelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fuelBtn.Location = new System.Drawing.Point(152, 1);
            this.fuelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.fuelBtn.Name = "fuelBtn";
            this.fuelBtn.Size = new System.Drawing.Size(150, 38);
            this.fuelBtn.TabIndex = 7;
            this.fuelBtn.Text = "Fuel Planning";
            this.fuelBtn.UseVisualStyleBackColor = false;
            // 
            // acConfigBtn
            // 
            this.acConfigBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.acConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acConfigBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acConfigBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acConfigBtn.Location = new System.Drawing.Point(1, 1);
            this.acConfigBtn.Margin = new System.Windows.Forms.Padding(0);
            this.acConfigBtn.Name = "acConfigBtn";
            this.acConfigBtn.Size = new System.Drawing.Size(150, 38);
            this.acConfigBtn.TabIndex = 0;
            this.acConfigBtn.Text = "Aircraft Config";
            this.acConfigBtn.UseVisualStyleBackColor = false;
            // 
            // airportBtn
            // 
            this.airportBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.airportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.airportBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.airportBtn.Location = new System.Drawing.Point(605, 1);
            this.airportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.airportBtn.Name = "airportBtn";
            this.airportBtn.Size = new System.Drawing.Size(150, 38);
            this.airportBtn.TabIndex = 3;
            this.airportBtn.Text = "Misc Info";
            this.airportBtn.UseVisualStyleBackColor = false;
            // 
            // ldgBtn
            // 
            this.ldgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ldgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ldgBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldgBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ldgBtn.Location = new System.Drawing.Point(454, 1);
            this.ldgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ldgBtn.Name = "ldgBtn";
            this.ldgBtn.Size = new System.Drawing.Size(150, 38);
            this.ldgBtn.TabIndex = 2;
            this.ldgBtn.Text = "Landing";
            this.ldgBtn.UseVisualStyleBackColor = false;
            // 
            // toBtn
            // 
            this.toBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.toBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toBtn.Location = new System.Drawing.Point(303, 1);
            this.toBtn.Margin = new System.Windows.Forms.Padding(0);
            this.toBtn.Name = "toBtn";
            this.toBtn.Size = new System.Drawing.Size(150, 38);
            this.toBtn.TabIndex = 1;
            this.toBtn.Text = "Take off";
            this.toBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.aboutBtn, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(836, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(40, 40);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutBtn.BackColor = System.Drawing.Color.Turquoise;
            this.aboutBtn.BackgroundImage = global::QSP.Properties.Resources.info;
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutBtn.Location = new System.Drawing.Point(5, 5);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(30, 30);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.optionsBtn, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(796, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(40, 40);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionsBtn.BackColor = System.Drawing.Color.Black;
            this.optionsBtn.BackgroundImage = global::QSP.Properties.Resources.noun_1329;
            this.optionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.optionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsBtn.ForeColor = System.Drawing.Color.White;
            this.optionsBtn.Location = new System.Drawing.Point(5, 5);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(30, 30);
            this.optionsBtn.TabIndex = 0;
            this.optionsBtn.UseVisualStyleBackColor = false;
            this.optionsBtn.MouseEnter += new System.EventHandler(this.optionsBtn_MouseEnter);
            this.optionsBtn.MouseLeave += new System.EventHandler(this.optionsBtn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(5, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 8;
            // 
            // QspForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1182, 855);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip1);
            this.DoubleBuffered = true;
            this.Name = "QspForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QSimPlanner";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button airportBtn;
        private System.Windows.Forms.Button ldgBtn;
        private System.Windows.Forms.Button acConfigBtn;
        private System.Windows.Forms.Button toBtn;
        private System.Windows.Forms.Button fuelBtn;
        internal System.Windows.Forms.ToolStripStatusLabel navDataStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel trackStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel windDataStatusLabel;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private Controls.PanelSilentScrollbar panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
    }
}