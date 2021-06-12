
namespace QuickRAT_Host
{
    partial class Processes
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
            this.processvisibility = new Guna.UI2.WinForms.Guna2ComboBox();
            this.processname = new Guna.UI2.WinForms.Guna2TextBox();
            this.launchprocess = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Processes";
            // 
            // processvisibility
            // 
            this.processvisibility.BackColor = System.Drawing.Color.Transparent;
            this.processvisibility.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.processvisibility.BorderRadius = 5;
            this.processvisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.processvisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processvisibility.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.processvisibility.FocusedColor = System.Drawing.Color.Aqua;
            this.processvisibility.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.processvisibility.FocusedState.Parent = this.processvisibility;
            this.processvisibility.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.processvisibility.ForeColor = System.Drawing.Color.White;
            this.processvisibility.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.processvisibility.HoverState.Parent = this.processvisibility;
            this.processvisibility.ItemHeight = 30;
            this.processvisibility.ItemsAppearance.Parent = this.processvisibility;
            this.processvisibility.Location = new System.Drawing.Point(216, 437);
            this.processvisibility.Name = "processvisibility";
            this.processvisibility.ShadowDecoration.Parent = this.processvisibility;
            this.processvisibility.Size = new System.Drawing.Size(150, 36);
            this.processvisibility.TabIndex = 34;
            // 
            // processname
            // 
            this.processname.Animated = true;
            this.processname.BackColor = System.Drawing.Color.Transparent;
            this.processname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.processname.BorderRadius = 5;
            this.processname.Cursor = System.Windows.Forms.Cursors.Default;
            this.processname.DefaultText = "";
            this.processname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.processname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.processname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.processname.DisabledState.Parent = this.processname;
            this.processname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.processname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.processname.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.processname.FocusedState.Parent = this.processname;
            this.processname.Font = new System.Drawing.Font("Segoe UI", 8.6F);
            this.processname.ForeColor = System.Drawing.Color.White;
            this.processname.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.processname.HoverState.Parent = this.processname;
            this.processname.Location = new System.Drawing.Point(50, 437);
            this.processname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processname.Multiline = true;
            this.processname.Name = "processname";
            this.processname.PasswordChar = '\0';
            this.processname.PlaceholderForeColor = System.Drawing.Color.White;
            this.processname.PlaceholderText = "";
            this.processname.SelectedText = "";
            this.processname.ShadowDecoration.Parent = this.processname;
            this.processname.Size = new System.Drawing.Size(160, 36);
            this.processname.TabIndex = 35;
            this.processname.TabStop = false;
            // 
            // launchprocess
            // 
            this.launchprocess.Animated = true;
            this.launchprocess.AnimatedGIF = true;
            this.launchprocess.BorderRadius = 5;
            this.launchprocess.CheckedState.Parent = this.launchprocess;
            this.launchprocess.CustomImages.Parent = this.launchprocess;
            this.launchprocess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.launchprocess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.launchprocess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.launchprocess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.launchprocess.DisabledState.Parent = this.launchprocess;
            this.launchprocess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.launchprocess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.launchprocess.ForeColor = System.Drawing.Color.White;
            this.launchprocess.HoverState.Parent = this.launchprocess;
            this.launchprocess.Location = new System.Drawing.Point(863, 437);
            this.launchprocess.Name = "launchprocess";
            this.launchprocess.PressedDepth = 0;
            this.launchprocess.ShadowDecoration.Parent = this.launchprocess;
            this.launchprocess.Size = new System.Drawing.Size(120, 36);
            this.launchprocess.TabIndex = 42;
            this.launchprocess.Text = "Launch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Process name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(214, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Visibility";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(50, 58);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(900, 335);
            this.listView2.TabIndex = 45;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Process Name";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Respoding";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Title";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Priority";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Path";
            this.columnHeader11.Width = 450;
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.launchprocess);
            this.Controls.Add(this.processname);
            this.Controls.Add(this.processvisibility);
            this.Controls.Add(this.panel1);
            this.Name = "Processes";
            this.Size = new System.Drawing.Size(1000, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox processvisibility;
        internal Guna.UI2.WinForms.Guna2TextBox processname;
        private Guna.UI2.WinForms.Guna2Button launchprocess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}
