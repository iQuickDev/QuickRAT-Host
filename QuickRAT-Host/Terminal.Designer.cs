
namespace QuickRAT_Host
{
    partial class Terminal
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
            this.terminaloutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.terminalcommandfield = new Guna.UI2.WinForms.Guna2TextBox();
            this.terminalsendbtn = new Guna.UI2.WinForms.Guna2Button();
            this.toggleterminal = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Terminal";
            // 
            // terminaloutput
            // 
            this.terminaloutput.Animated = true;
            this.terminaloutput.BackColor = System.Drawing.Color.Transparent;
            this.terminaloutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.terminaloutput.BorderRadius = 10;
            this.terminaloutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.terminaloutput.DefaultText = "Couldn\'t launch the terminal\r\n";
            this.terminaloutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.terminaloutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.terminaloutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.terminaloutput.DisabledState.Parent = this.terminaloutput;
            this.terminaloutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.terminaloutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.terminaloutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.terminaloutput.FocusedState.Parent = this.terminaloutput;
            this.terminaloutput.Font = new System.Drawing.Font("Segoe UI", 8.6F);
            this.terminaloutput.ForeColor = System.Drawing.Color.White;
            this.terminaloutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.terminaloutput.HoverState.Parent = this.terminaloutput;
            this.terminaloutput.Location = new System.Drawing.Point(27, 100);
            this.terminaloutput.Multiline = true;
            this.terminaloutput.Name = "terminaloutput";
            this.terminaloutput.PasswordChar = '\0';
            this.terminaloutput.PlaceholderForeColor = System.Drawing.Color.White;
            this.terminaloutput.PlaceholderText = "";
            this.terminaloutput.ReadOnly = true;
            this.terminaloutput.SelectedText = "";
            this.terminaloutput.SelectionStart = 30;
            this.terminaloutput.ShadowDecoration.Parent = this.terminaloutput;
            this.terminaloutput.Size = new System.Drawing.Size(947, 329);
            this.terminaloutput.TabIndex = 30;
            this.terminaloutput.TabStop = false;
            // 
            // terminalcommandfield
            // 
            this.terminalcommandfield.Animated = true;
            this.terminalcommandfield.BackColor = System.Drawing.Color.Transparent;
            this.terminalcommandfield.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.terminalcommandfield.BorderRadius = 5;
            this.terminalcommandfield.Cursor = System.Windows.Forms.Cursors.Default;
            this.terminalcommandfield.DefaultText = "";
            this.terminalcommandfield.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.terminalcommandfield.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.terminalcommandfield.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.terminalcommandfield.DisabledState.Parent = this.terminalcommandfield;
            this.terminalcommandfield.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.terminalcommandfield.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.terminalcommandfield.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.terminalcommandfield.FocusedState.Parent = this.terminalcommandfield;
            this.terminalcommandfield.Font = new System.Drawing.Font("Segoe UI", 8.6F);
            this.terminalcommandfield.ForeColor = System.Drawing.Color.White;
            this.terminalcommandfield.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.terminalcommandfield.HoverState.Parent = this.terminalcommandfield;
            this.terminalcommandfield.Location = new System.Drawing.Point(27, 435);
            this.terminalcommandfield.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.terminalcommandfield.Multiline = true;
            this.terminalcommandfield.Name = "terminalcommandfield";
            this.terminalcommandfield.PasswordChar = '\0';
            this.terminalcommandfield.PlaceholderForeColor = System.Drawing.Color.White;
            this.terminalcommandfield.PlaceholderText = "Enter a command";
            this.terminalcommandfield.SelectedText = "";
            this.terminalcommandfield.ShadowDecoration.Parent = this.terminalcommandfield;
            this.terminalcommandfield.Size = new System.Drawing.Size(857, 30);
            this.terminalcommandfield.TabIndex = 31;
            this.terminalcommandfield.TabStop = false;
            // 
            // terminalsendbtn
            // 
            this.terminalsendbtn.Animated = true;
            this.terminalsendbtn.AnimatedGIF = true;
            this.terminalsendbtn.BorderRadius = 5;
            this.terminalsendbtn.CheckedState.Parent = this.terminalsendbtn;
            this.terminalsendbtn.CustomImages.Parent = this.terminalsendbtn;
            this.terminalsendbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.terminalsendbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.terminalsendbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.terminalsendbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.terminalsendbtn.DisabledState.Parent = this.terminalsendbtn;
            this.terminalsendbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.terminalsendbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.terminalsendbtn.ForeColor = System.Drawing.Color.White;
            this.terminalsendbtn.HoverState.Parent = this.terminalsendbtn;
            this.terminalsendbtn.Location = new System.Drawing.Point(890, 435);
            this.terminalsendbtn.Name = "terminalsendbtn";
            this.terminalsendbtn.PressedDepth = 0;
            this.terminalsendbtn.ShadowDecoration.Parent = this.terminalsendbtn;
            this.terminalsendbtn.Size = new System.Drawing.Size(75, 30);
            this.terminalsendbtn.TabIndex = 32;
            this.terminalsendbtn.Text = "Send";
            // 
            // toggleterminal
            // 
            this.toggleterminal.Animated = true;
            this.toggleterminal.BackColor = System.Drawing.Color.Transparent;
            this.toggleterminal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleterminal.CheckedState.BorderRadius = 8;
            this.toggleterminal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleterminal.CheckedState.InnerBorderColor = System.Drawing.Color.Lime;
            this.toggleterminal.CheckedState.InnerColor = System.Drawing.Color.Lime;
            this.toggleterminal.CheckedState.Parent = this.toggleterminal;
            this.toggleterminal.Location = new System.Drawing.Point(475, 57);
            this.toggleterminal.Margin = new System.Windows.Forms.Padding(0);
            this.toggleterminal.Name = "toggleterminal";
            this.toggleterminal.ShadowDecoration.Parent = this.toggleterminal;
            this.toggleterminal.Size = new System.Drawing.Size(50, 25);
            this.toggleterminal.TabIndex = 33;
            this.toggleterminal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleterminal.UncheckedState.BorderRadius = 8;
            this.toggleterminal.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleterminal.UncheckedState.InnerBorderColor = System.Drawing.Color.Red;
            this.toggleterminal.UncheckedState.InnerColor = System.Drawing.Color.Red;
            this.toggleterminal.UncheckedState.Parent = this.toggleterminal;
            this.toggleterminal.UseTransparentBackground = true;
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.toggleterminal);
            this.Controls.Add(this.terminalsendbtn);
            this.Controls.Add(this.terminalcommandfield);
            this.Controls.Add(this.terminaloutput);
            this.Controls.Add(this.panel1);
            this.Name = "Terminal";
            this.Size = new System.Drawing.Size(1000, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal Guna.UI2.WinForms.Guna2TextBox terminaloutput;
        internal Guna.UI2.WinForms.Guna2TextBox terminalcommandfield;
        private Guna.UI2.WinForms.Guna2Button terminalsendbtn;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleterminal;
    }
}
