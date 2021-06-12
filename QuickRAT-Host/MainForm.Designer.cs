
namespace QuickRAT_Host
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dragpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.title = new System.Windows.Forms.Label();
            this.minimizebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.closebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.servermanagementbtn = new Guna.UI2.WinForms.Guna2Button();
            this.terminalbtn = new Guna.UI2.WinForms.Guna2Button();
            this.processesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.screenviewbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ddosbtn = new Guna.UI2.WinForms.Guna2Button();
            this.funbtn = new Guna.UI2.WinForms.Guna2Button();
            this.systemcontrolbtn = new Guna.UI2.WinForms.Guna2Button();
            this.dragpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragpanel
            // 
            this.dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dragpanel.Controls.Add(this.title);
            this.dragpanel.Controls.Add(this.minimizebtn);
            this.dragpanel.Controls.Add(this.closebtn);
            this.dragpanel.Location = new System.Drawing.Point(0, 0);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.ShadowDecoration.Parent = this.dragpanel;
            this.dragpanel.Size = new System.Drawing.Size(1000, 40);
            this.dragpanel.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(392, -2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(208, 37);
            this.title.TabIndex = 6;
            this.title.Text = "QuickRAT Host";
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.CheckedState.Parent = this.minimizebtn;
            this.minimizebtn.CustomImages.Parent = this.minimizebtn;
            this.minimizebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizebtn.DisabledState.Parent = this.minimizebtn;
            this.minimizebtn.FillColor = System.Drawing.Color.Yellow;
            this.minimizebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizebtn.ForeColor = System.Drawing.Color.White;
            this.minimizebtn.HoverState.Parent = this.minimizebtn;
            this.minimizebtn.Location = new System.Drawing.Point(948, 12);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizebtn.ShadowDecoration.Parent = this.minimizebtn;
            this.minimizebtn.Size = new System.Drawing.Size(15, 15);
            this.minimizebtn.TabIndex = 7;
            this.minimizebtn.UseTransparentBackground = true;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.CheckedState.Parent = this.closebtn;
            this.closebtn.CustomImages.Parent = this.closebtn;
            this.closebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closebtn.DisabledState.Parent = this.closebtn;
            this.closebtn.FillColor = System.Drawing.Color.Red;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.HoverState.Parent = this.closebtn;
            this.closebtn.Location = new System.Drawing.Point(969, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closebtn.ShadowDecoration.Parent = this.closebtn;
            this.closebtn.Size = new System.Drawing.Size(15, 15);
            this.closebtn.TabIndex = 6;
            this.closebtn.UseTransparentBackground = true;
            // 
            // servermanagementbtn
            // 
            this.servermanagementbtn.Animated = true;
            this.servermanagementbtn.AnimatedGIF = true;
            this.servermanagementbtn.BorderRadius = 5;
            this.servermanagementbtn.CheckedState.Parent = this.servermanagementbtn;
            this.servermanagementbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.servermanagementbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servermanagementbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.servermanagementbtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.servermanagementbtn.CustomImages.Parent = this.servermanagementbtn;
            this.servermanagementbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.servermanagementbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.servermanagementbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.servermanagementbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.servermanagementbtn.DisabledState.Parent = this.servermanagementbtn;
            this.servermanagementbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.servermanagementbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.servermanagementbtn.ForeColor = System.Drawing.Color.White;
            this.servermanagementbtn.HoverState.Parent = this.servermanagementbtn;
            this.servermanagementbtn.Location = new System.Drawing.Point(41, 50);
            this.servermanagementbtn.Name = "servermanagementbtn";
            this.servermanagementbtn.PressedDepth = 0;
            this.servermanagementbtn.ShadowDecoration.Parent = this.servermanagementbtn;
            this.servermanagementbtn.Size = new System.Drawing.Size(120, 45);
            this.servermanagementbtn.TabIndex = 1;
            // 
            // terminalbtn
            // 
            this.terminalbtn.Animated = true;
            this.terminalbtn.AnimatedGIF = true;
            this.terminalbtn.BorderRadius = 5;
            this.terminalbtn.CheckedState.Parent = this.terminalbtn;
            this.terminalbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.terminalbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.terminalbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.terminalbtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.terminalbtn.CustomImages.Parent = this.terminalbtn;
            this.terminalbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.terminalbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.terminalbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.terminalbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.terminalbtn.DisabledState.Parent = this.terminalbtn;
            this.terminalbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.terminalbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.terminalbtn.ForeColor = System.Drawing.Color.White;
            this.terminalbtn.HoverState.Parent = this.terminalbtn;
            this.terminalbtn.ImageOffset = new System.Drawing.Point(0, 5);
            this.terminalbtn.Location = new System.Drawing.Point(307, 50);
            this.terminalbtn.Name = "terminalbtn";
            this.terminalbtn.PressedDepth = 0;
            this.terminalbtn.ShadowDecoration.Parent = this.terminalbtn;
            this.terminalbtn.Size = new System.Drawing.Size(120, 45);
            this.terminalbtn.TabIndex = 2;
            // 
            // processesbtn
            // 
            this.processesbtn.Animated = true;
            this.processesbtn.AnimatedGIF = true;
            this.processesbtn.BorderRadius = 5;
            this.processesbtn.CheckedState.Parent = this.processesbtn;
            this.processesbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.processesbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.processesbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.processesbtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.processesbtn.CustomImages.Parent = this.processesbtn;
            this.processesbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.processesbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.processesbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.processesbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.processesbtn.DisabledState.Parent = this.processesbtn;
            this.processesbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.processesbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.processesbtn.ForeColor = System.Drawing.Color.White;
            this.processesbtn.HoverState.Parent = this.processesbtn;
            this.processesbtn.Location = new System.Drawing.Point(440, 50);
            this.processesbtn.Name = "processesbtn";
            this.processesbtn.PressedDepth = 0;
            this.processesbtn.ShadowDecoration.Parent = this.processesbtn;
            this.processesbtn.Size = new System.Drawing.Size(120, 45);
            this.processesbtn.TabIndex = 3;
            // 
            // screenviewbtn
            // 
            this.screenviewbtn.Animated = true;
            this.screenviewbtn.AnimatedGIF = true;
            this.screenviewbtn.BorderRadius = 5;
            this.screenviewbtn.CheckedState.Parent = this.screenviewbtn;
            this.screenviewbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.screenviewbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.screenviewbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.screenviewbtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.screenviewbtn.CustomImages.Parent = this.screenviewbtn;
            this.screenviewbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.screenviewbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.screenviewbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.screenviewbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.screenviewbtn.DisabledState.Parent = this.screenviewbtn;
            this.screenviewbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.screenviewbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.screenviewbtn.ForeColor = System.Drawing.Color.White;
            this.screenviewbtn.HoverState.Parent = this.screenviewbtn;
            this.screenviewbtn.Location = new System.Drawing.Point(573, 50);
            this.screenviewbtn.Name = "screenviewbtn";
            this.screenviewbtn.PressedDepth = 0;
            this.screenviewbtn.ShadowDecoration.Parent = this.screenviewbtn;
            this.screenviewbtn.Size = new System.Drawing.Size(120, 45);
            this.screenviewbtn.TabIndex = 4;
            // 
            // ddosbtn
            // 
            this.ddosbtn.Animated = true;
            this.ddosbtn.AnimatedGIF = true;
            this.ddosbtn.BorderRadius = 5;
            this.ddosbtn.CheckedState.Parent = this.ddosbtn;
            this.ddosbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.ddosbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ddosbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.ddosbtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.ddosbtn.CustomImages.Parent = this.ddosbtn;
            this.ddosbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ddosbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ddosbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ddosbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ddosbtn.DisabledState.Parent = this.ddosbtn;
            this.ddosbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ddosbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddosbtn.ForeColor = System.Drawing.Color.White;
            this.ddosbtn.HoverState.Parent = this.ddosbtn;
            this.ddosbtn.Location = new System.Drawing.Point(706, 50);
            this.ddosbtn.Name = "ddosbtn";
            this.ddosbtn.PressedDepth = 0;
            this.ddosbtn.ShadowDecoration.Parent = this.ddosbtn;
            this.ddosbtn.Size = new System.Drawing.Size(120, 45);
            this.ddosbtn.TabIndex = 5;
            // 
            // funbtn
            // 
            this.funbtn.Animated = true;
            this.funbtn.AnimatedGIF = true;
            this.funbtn.BorderRadius = 5;
            this.funbtn.CheckedState.Parent = this.funbtn;
            this.funbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.funbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.funbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.funbtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.funbtn.CustomImages.Parent = this.funbtn;
            this.funbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.funbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.funbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.funbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.funbtn.DisabledState.Parent = this.funbtn;
            this.funbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.funbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.funbtn.ForeColor = System.Drawing.Color.White;
            this.funbtn.HoverState.Parent = this.funbtn;
            this.funbtn.Location = new System.Drawing.Point(839, 50);
            this.funbtn.Name = "funbtn";
            this.funbtn.PressedDepth = 0;
            this.funbtn.ShadowDecoration.Parent = this.funbtn;
            this.funbtn.Size = new System.Drawing.Size(120, 45);
            this.funbtn.TabIndex = 6;
            // 
            // systemcontrolbtn
            // 
            this.systemcontrolbtn.Animated = true;
            this.systemcontrolbtn.AnimatedGIF = true;
            this.systemcontrolbtn.BorderRadius = 5;
            this.systemcontrolbtn.CheckedState.Parent = this.systemcontrolbtn;
            this.systemcontrolbtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.systemcontrolbtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.systemcontrolbtn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.systemcontrolbtn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.systemcontrolbtn.CustomImages.Parent = this.systemcontrolbtn;
            this.systemcontrolbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.systemcontrolbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.systemcontrolbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.systemcontrolbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.systemcontrolbtn.DisabledState.Parent = this.systemcontrolbtn;
            this.systemcontrolbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.systemcontrolbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.systemcontrolbtn.ForeColor = System.Drawing.Color.White;
            this.systemcontrolbtn.HoverState.Parent = this.systemcontrolbtn;
            this.systemcontrolbtn.Location = new System.Drawing.Point(174, 50);
            this.systemcontrolbtn.Name = "systemcontrolbtn";
            this.systemcontrolbtn.PressedDepth = 0;
            this.systemcontrolbtn.ShadowDecoration.Parent = this.systemcontrolbtn;
            this.systemcontrolbtn.Size = new System.Drawing.Size(120, 45);
            this.systemcontrolbtn.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.systemcontrolbtn);
            this.Controls.Add(this.funbtn);
            this.Controls.Add(this.ddosbtn);
            this.Controls.Add(this.screenviewbtn);
            this.Controls.Add(this.processesbtn);
            this.Controls.Add(this.terminalbtn);
            this.Controls.Add(this.servermanagementbtn);
            this.Controls.Add(this.dragpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.dragpanel.ResumeLayout(false);
            this.dragpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel dragpanel;
        private Guna.UI2.WinForms.Guna2CircleButton minimizebtn;
        private Guna.UI2.WinForms.Guna2CircleButton closebtn;
        private Guna.UI2.WinForms.Guna2Button servermanagementbtn;
        private Guna.UI2.WinForms.Guna2Button terminalbtn;
        private Guna.UI2.WinForms.Guna2Button processesbtn;
        private Guna.UI2.WinForms.Guna2Button screenviewbtn;
        private Guna.UI2.WinForms.Guna2Button ddosbtn;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2Button funbtn;
        private Guna.UI2.WinForms.Guna2Button systemcontrolbtn;
    }
}

