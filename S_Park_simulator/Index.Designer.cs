namespace S_Park_simulator
{
    partial class Index
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCarNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCarNum2 = new System.Windows.Forms.TextBox();
            this.dgvCarNum = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txbParkID = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbCarNum);
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进入车库";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(104, 184);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(135, 50);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "确定";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "车牌号：";
            // 
            // txbCarNum
            // 
            this.txbCarNum.Location = new System.Drawing.Point(116, 55);
            this.txbCarNum.Name = "txbCarNum";
            this.txbCarNum.Size = new System.Drawing.Size(188, 25);
            this.txbCarNum.TabIndex = 1;
            this.txbCarNum.TextChanged += new System.EventHandler(this.TxbCarNum_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOut);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbCarNum2);
            this.groupBox2.Location = new System.Drawing.Point(431, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 331);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "离开车库";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(104, 184);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(135, 50);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "确定";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "车牌号：";
            // 
            // txbCarNum2
            // 
            this.txbCarNum2.Location = new System.Drawing.Point(116, 55);
            this.txbCarNum2.Name = "txbCarNum2";
            this.txbCarNum2.Size = new System.Drawing.Size(188, 25);
            this.txbCarNum2.TabIndex = 2;
            // 
            // dgvCarNum
            // 
            this.dgvCarNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarNum.Location = new System.Drawing.Point(133, 420);
            this.dgvCarNum.Name = "dgvCarNum";
            this.dgvCarNum.RowHeadersWidth = 51;
            this.dgvCarNum.RowTemplate.Height = 27;
            this.dgvCarNum.Size = new System.Drawing.Size(537, 204);
            this.dgvCarNum.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "车库ID";
            // 
            // txbParkID
            // 
            this.txbParkID.Location = new System.Drawing.Point(359, 377);
            this.txbParkID.Name = "txbParkID";
            this.txbParkID.Size = new System.Drawing.Size(53, 25);
            this.txbParkID.TabIndex = 3;
            this.txbParkID.Text = "1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(419, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(500, 380);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbParkID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCarNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Index";
            this.Text = "Index";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCarNum;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCarNum2;
        private System.Windows.Forms.DataGridView dgvCarNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbParkID;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}