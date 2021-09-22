
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.processvisibility = new Guna.UI2.WinForms.Guna2ComboBox();
            this.processname = new Guna.UI2.WinForms.Guna2TextBox();
            this.launchprocess = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshprocesses = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
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
            this.processvisibility.Items.AddRange(new object[] {
            "Visible",
            "Hidden"});
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
            // refreshprocesses
            // 
            this.refreshprocesses.Animated = true;
            this.refreshprocesses.AnimatedGIF = true;
            this.refreshprocesses.BorderRadius = 5;
            this.refreshprocesses.CheckedState.Parent = this.refreshprocesses;
            this.refreshprocesses.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.refreshprocesses.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refreshprocesses.CustomImages.Parent = this.refreshprocesses;
            this.refreshprocesses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshprocesses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshprocesses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshprocesses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshprocesses.DisabledState.Parent = this.refreshprocesses;
            this.refreshprocesses.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.refreshprocesses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshprocesses.ForeColor = System.Drawing.Color.White;
            this.refreshprocesses.HoverState.Parent = this.refreshprocesses;
            this.refreshprocesses.Location = new System.Drawing.Point(14, 58);
            this.refreshprocesses.Name = "refreshprocesses";
            this.refreshprocesses.PressedDepth = 0;
            this.refreshprocesses.ShadowDecoration.Parent = this.refreshprocesses;
            this.refreshprocesses.Size = new System.Drawing.Size(30, 30);
            this.refreshprocesses.TabIndex = 46;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pname,
            this.pid,
            this.responding,
            this.priority,
            this.cpu,
            this.memory,
            this.path});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.Location = new System.Drawing.Point(52, 58);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(930, 350);
            this.guna2DataGridView1.TabIndex = 47;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pname
            // 
            this.pname.HeaderText = "Process Name";
            this.pname.Name = "pname";
            // 
            // pid
            // 
            this.pid.HeaderText = "PID";
            this.pid.Name = "pid";
            // 
            // responding
            // 
            this.responding.HeaderText = "Responding";
            this.responding.Name = "responding";
            // 
            // priority
            // 
            this.priority.HeaderText = "Priority";
            this.priority.Name = "priority";
            // 
            // cpu
            // 
            this.cpu.HeaderText = "CPU";
            this.cpu.Name = "cpu";
            // 
            // memory
            // 
            this.memory.HeaderText = "Memory";
            this.memory.Name = "memory";
            // 
            // path
            // 
            this.path.HeaderText = "Path";
            this.path.Name = "path";
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.refreshprocesses);
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button refreshprocesses;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn responding;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
    }
}
